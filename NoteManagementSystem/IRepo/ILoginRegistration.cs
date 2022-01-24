using NoteManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteManagementSystem.IRepo
{
   public interface ILoginRegistration
    {
        public CreateUserDTO CreateUser(CreateUserDTO obj);

        public bool UserLogin(Guid UserId);
    }
}
