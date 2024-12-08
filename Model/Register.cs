using Emgu.CV.CvEnum;
using Emgu.CV;
using facial_recognition.Dto;
using facial_recognition.Enums;
using facial_recognition.Repository;
using facial_recognition.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace facial_recognition.Model
{
	public class Register
	{

		private readonly RegisterRepository _repo = new RegisterRepository();

		public Register(string fullname, string address, string email, string phone, string age, string gender, string guardian, string civilStatus, string workStatus, string dateOfBirth, byte[] profileImage)
		{
			Fullname = fullname;
			Address = address;
			Email = email;
			Phone = phone;
			Age = age;
			Gender = gender;
			Guardian = guardian;
			CivilStatus = civilStatus;
			WorkStatus = workStatus;
			DateOfBirth = dateOfBirth;
			ProfileImage = profileImage;
		}

		public string Fullname { get; private set; }
		public string Address { get; private set; }
		public string Email { get; private set; }
		public string Phone { get; private set; }
		public string Age { get; private set; }
		public string Gender { get; private set; }
		public string Guardian { get; private set; }
		public string CivilStatus { get; private set; }
		public string WorkStatus { get; private set; }
		public string DateOfBirth { get; private set; }
		public string ReferenceNumber { get; private set; }
		public byte[] ProfileImage { get; private set; }

		public string AddUser()
		{
			Validate();
			var dto = new RegisterDto
				(
					fullname: Fullname,
					address: Address,
					email: Email,
					phone: Phone,
					age: Convert.ToInt32(Age),
					gender: Gender,
					guardian: Guardian,
					civilStatus: CivilStatus,
					workStatus: WorkStatus,
					dateOfBirth: DateTime.Parse(DateOfBirth).Date,
					referenceNumber: GenerateReferenceNumber(),
					profileImage: ProfileImage
				);
			return _repo.AddUser(dto);
		}

		public string GenerateReferenceNumber()
		{
			return Guid.NewGuid().ToString();
		}

		private void Validate()
		{
			if (string.IsNullOrEmpty(Fullname))
				throw new Exception("Fullname is required.");

			if (string.IsNullOrEmpty(Address))
				throw new Exception("Address is required.");
			
			ValidateEmail();

			ValidatePhoneNumber();

			ValidateAge();

			ValidateGender();

			if (string.IsNullOrEmpty(Guardian))
				throw new Exception("Guardian is required.");
			
			ValidateCivilStatus();
			ValidateWorkStatus();
			ValidateDateOfBirth();
			ValidateImage();
		}

		private void ValidateGender()
		{
			if (string.IsNullOrEmpty(Gender))
				throw new Exception("Gender is required");

			if (!Enum.IsDefined(typeof(GenderEnum), Gender))
			{
				if (Gender == "Prefer Not to Say") return;

				throw new Exception($"Invalid Gender {Gender}");
			}
		}

		private void ValidatePhoneNumber()
		{
			if (string.IsNullOrEmpty(Phone))
				throw new Exception("Phone is required.");

			if (Phone.Length < 11 || Phone.Length > 11)
				throw new Exception("Phone number must be 11 digits.");
		}


		private void ValidateAge()
		{
			if (string.IsNullOrEmpty(Age))
				throw new Exception("Age is required.");

			if (!int.TryParse(Age, out int age))
				throw new Exception("Age must be a number.");
		}

		private void ValidateEmail()
		{
			if (!Email.Contains("@"))
				throw new Exception("Invalid Email.");

			if (!Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
				throw new Exception("Invalid Email.");
		}

		private void ValidateCivilStatus()
		{
			if (string.IsNullOrEmpty(CivilStatus))
				throw new Exception("Civil Status is required.");

			if (!Enum.IsDefined(typeof(CivilStatusEnum), CivilStatus))
				throw new Exception("Invalid Civil Status.");
		}

		private void ValidateWorkStatus()
		{
			if (string.IsNullOrEmpty(WorkStatus))
				throw new Exception("Work Status is required.");
		
			if (!Enum.TryParse(WorkStatus, out WorkStatusEnum workStatus))
			{
				if (WorkStatus == "Working Student") return;

				throw new Exception("Invalid Work Status.");
			}
		}

		private void ValidateDateOfBirth()
		{
			if (string.IsNullOrEmpty(DateOfBirth))
				throw new Exception("Date of Birth is required.");

			if (!DateTime.TryParse(DateOfBirth, out DateTime dob))
				throw new Exception("Invalid Date of Birth.");

			if (dob > DateTime.Now)
				throw new Exception("Invalid Date of Birth.");

			if (DateTime.Now.Year - dob.Year < 18)
				throw new Exception("User must be at least 18 years old.");

			// check date of birth and age calculation if both matches
			// example: today is December of 2024, the users age and date of birth should be 23 should be April 17, 2001
			// if the date and year is April 17, 2025 then the age should be 24 if he/she is born in April 17, 2001.
			if (DateTime.Now.Year - dob.Year != Convert.ToInt32(Age))
				throw new Exception("Invalid Date of Birth.");
		}

		private void ValidateImage()
		{
			if (ProfileImage == null)
				throw new Exception("Profile Image is required.");

			if (ProfileImage.Length == 0)
				throw new Exception("Profile Image is required.");

			if (ProfileImage.Length > 1000000)
				throw new Exception("Profile Image is too large.");

			if (ProfileImage.Length < 1000)
				throw new Exception("Profile Image is too small.");
			try
			{
				var facesInsideDatabase = GetUserImage();

				// Convert the uploaded profile image to a Mat
				Mat uploadedFaceMat = RecognizerUtility.ByteArrayToMat(ProfileImage);

				// Check for duplicates
				foreach (var storedImage in facesInsideDatabase)
				{
					// Convert the stored image byte array to Mat
					Mat storedFaceMat = RecognizerUtility.ByteArrayToMat(storedImage.ByteImage);

					// Compare the two faces
					double similarity = RecognizerUtility.CompareFaces(uploadedFaceMat, storedFaceMat);

					// If similarity exceeds threshold, it's a duplicate
					if (similarity >= 0.6)  // Threshold for face comparison (adjust as necessary)
					{
						throw new Exception("This face already exists in the database.");
					}
				}
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

		private IEnumerable<ImageCacheDto> GetUserImage() => _repo.GetImage();

		public static void SaveImage(byte[] imageBytes, string filePath)
		{
			using (var ms = new MemoryStream(imageBytes))
			{
				var image = Image.FromStream(ms);
				image.Save(filePath, ImageFormat.Bmp);
			}
		}

	}
}
