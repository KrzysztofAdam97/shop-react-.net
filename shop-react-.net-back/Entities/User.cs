using System;
using Microsoft.AspNetCore.Identity;

namespace shop_react_.net_back.Entities
{
    public class User   /* : IdentityUser
                         możemy pobrać wszystkie dane z IdentityUser, ale zrobimy to ręcznie*/
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; } // data urodzenia, moze byc null
        public string Email { get; set; }
        public string PasswordHash { get; set; }    // hash hasła
        
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }  // RoleId - klucz obcy, Role - referencja do Role
        

    }
}
