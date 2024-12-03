using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facial_recognition.Dto
{
	public class UpdateUserDto
	{
		public UpdateUserDto(int id, string fullname, string address, string email, string phone, int age, string gender, string guardian, string civilStatus, string workStatus, DateTime dateOfBirth)
		{
			Id = id;
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
		}

		public int Id { get; set; }
		public string Fullname { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public int Age { get; set; }
		public string Gender { get; set; }
		public string Guardian { get; set; }
		public string CivilStatus { get; set; }
		public string WorkStatus { get; set; }
		public DateTime DateOfBirth { get; set; }
	}
}
