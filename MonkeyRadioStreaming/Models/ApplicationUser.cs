using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Identity;

namespace MonkeyRadioStreaming.Models
{
    public class ApplicationUser : IdentityUser
    {

        public string Name { get; set; }

        public string Surname { get; set; }

        private bool Admin { get; set; }

        public bool IsAdmin()
        {
            return Admin;
        }

        public bool SetAdmin(bool admin)
        {
            return Admin = admin;
        }
    }
}