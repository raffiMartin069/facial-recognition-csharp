using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facial_recognition.Dto
{
	public class RegisterDto
	{
		public RegisterDto(string fullname, string address, string email, string phone, int age, string gender, string guardian, string civilStatus, string workStatus, DateTime dateOfBirth, string referenceNumber, byte[] profileImage)
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
			ReferenceNumber = referenceNumber;
			ProfileImage = profileImage;
		}

		public string Fullname { get; private set; }
		public string Address { get; private set; }
		public string Email { get; private set; }
		public string Phone { get; private set; }
		public int Age { get; private set; }
		public string Gender { get; private set; }
		public string Guardian { get; private set; }
		public string CivilStatus { get; private set; }
		public string WorkStatus { get; private set; }
		public DateTime DateOfBirth { get; private set; }
		public string ReferenceNumber { get; private set; }
		public byte[] ProfileImage { get; private set; }
	}
}
