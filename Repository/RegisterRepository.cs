using facial_recognition.Dto;
using facial_recognition.Persistent.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace facial_recognition.Repository
{
	public class RegisterRepository
	{
		FacialDataContext _context = new FacialDataContext();

		public string AddUser(RegisterDto dto)
		{
			using (var transaction = new TransactionScope())
			{
				try
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
						REFERENCENUMBER = dto.ReferenceNumber,
						PROFILE = dto.ProfileImage
					};
					_context.USERs.InsertOnSubmit(user);
					_context.SubmitChanges();
					transaction.Complete();
					return user.REFERENCENUMBER.ToString();
				}
				catch (SqlException sqlEx)
				{
					throw new Exception(sqlEx.GetBaseException().Message);
				}
			}
		}

		public IEnumerable<ImageCacheDto> GetImage()
		{
			return _context.USERs.Select(i => new ImageCacheDto { ByteImage = i.PROFILE.ToArray() });
		}
	}
}
