using facial_recognition.Dto;
using facial_recognition.Persistent.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facial_recognition.Repository
{
	public class RegisterRepository
	{
		FacialDataContext _context = new FacialDataContext();

		public void AddUser(RegisterDto dto)
		{
			var user = new USER
			{
				FULLNAME = dto.Fullname,
				ADDRESS = dto.Address,
				EMAILADDRESS = dto.Email,
				PHONENUMBER = dto.Phone,
				AGE = dto.Age,
				GENDER = dto.Gender,
				CIVILSTATUS = dto.CivilStatus,
				GUARDIAN = dto.Guardian,
				DATEOFBIRTH = dto.DateOfBirth,
				WORKSTATUS = dto.WorkStatus,
				REFERENCENUMBER = dto.ReferenceNumber
			};
			_context.USERs.InsertOnSubmit(user);
			_context.SubmitChanges();
		}
	}
}
