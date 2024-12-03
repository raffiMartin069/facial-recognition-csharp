using facial_recognition.Dto;
using facial_recognition.Persistent.Data;
using facial_recognition.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facial_recognition.Repository
{
	public class DashboardRepository
	{
		private readonly FacialDataContext _context = new FacialDataContext();

		private static byte[] HexStringToByteArray(string hex)
		{
			int numberChars = hex.Length;
			byte[] bytes = new byte[numberChars / 2];
			for (int i = 0; i < numberChars; i += 2)
			{
				bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
			}
			return bytes;
		}


		public IEnumerable<UserDto> GetUser(int id)
		{
			return _context.USERs
				.Where(i => i.ID == id)
				.Select(i => new UserDto()
				{
					Id = i.ID,
					Fullname = i.FULLNAME,
					Address = i.ADDRESS,
					Email = i.EMAILADDRESS,
					Phone = i.PHONENUMBER,
					Age = i.AGE,
					Gender = i.GENDER,
					Guardian = i.GUARDIAN,
					CivilStatus = i.CIVILSTATUS,
					WorkStatus = i.WORKSTATUS,
					DateOfBirth = i.DATEOFBIRTH,
					ReferenceNumber = i.REFERENCENUMBER,
					ProfileImage = ImageUtility.ByteToBitmap(i.PROFILE.ToArray())
				});
		}

		public bool UpdateUser(UpdateUserDto dto)
		{
			var user = _context.USERs.SingleOrDefault(u => u.ID == dto.Id);
			if (user != null)
			{
				user.FULLNAME = dto.Fullname;
				user.ADDRESS = dto.Address;
				user.EMAILADDRESS = dto.Email;
				user.PHONENUMBER = dto.Phone;
				user.AGE = dto.Age;
				user.GENDER = dto.Gender;
				user.GUARDIAN = dto.Guardian;
				user.CIVILSTATUS = dto.CivilStatus;
				user.WORKSTATUS = dto.WorkStatus;
				user.DATEOFBIRTH = dto.DateOfBirth;
				_context.SubmitChanges();

				// get the result of this transaction and return it to identify wether transaction is successful or not
				var updated = _context.USERs.SingleOrDefault(u => u.ID == dto.Id);
				return updated != null;

			}
			else
			{
				throw new Exception("User not found.");
			}
		}


	}
}
