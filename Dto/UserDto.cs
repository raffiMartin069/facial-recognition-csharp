using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facial_recognition.Dto
{
	public class UserDto
	{
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
		public string ReferenceNumber { get; set; }
		public Bitmap ProfileImage { get; set; }
	}
}
