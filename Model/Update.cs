using Emgu.CV;
using facial_recognition.Dto;
using facial_recognition.Enums;
using facial_recognition.Repository;
using facial_recognition.Utility;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace facial_recognition.Model
{
	public class Update
	{
		private readonly DashboardRepository _repo = new DashboardRepository();

		public Update(string fullname, string address, string email, string phone, string age, string gender, string guardian, string civilStatus, string workStatus, string dateOfBirth, int id)
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
			Id = id;
		}

		public int Id { get; private set; }
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

		public bool UpdateUser()
		{
			Validate();
			var dto = new UpdateUserDto
				(
					id: Id,
					fullname: Fullname,
					address: Address,
					email: Email,
					phone: Phone,
					age: Convert.ToInt32(Age),
					gender: Gender,
					guardian: Guardian,
					civilStatus: CivilStatus,
					workStatus: WorkStatus,
					dateOfBirth: DateTime.Parse(DateOfBirth).Date
				);
			return _repo.UpdateUser(dto);
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
			if(DateTime.Now.Year - dob.Year != Convert.ToInt32(Age))
				throw new Exception("Invalid Date of Birth.");
		}
	}
}
