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
	public class LoginRepository
	{
		private readonly FacialDataContext _context = new FacialDataContext();

		public IEnumerable<ImageCacheDto> GetFaces() => _context.USERs.Select(i => new ImageCacheDto { ByteImage = i.PROFILE.ToArray(), Id = i.ID }); 
		public IEnumerable<UserDto> GetUser() => _context.USERs.Select(i => new UserDto()
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
}
