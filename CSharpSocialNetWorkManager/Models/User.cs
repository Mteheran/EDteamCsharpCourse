using CSharpSocialNetWorkManager.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSocialNetWorkManager.Models
{
    class User
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public short Age { get; set; }

        public bool IsValid(bool validateAge = true)
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email) || !HelperValidator.IsValidEmail(Email))
                return false;

            if ((Age < 0 || Age > 250) && validateAge)
                return false;

            return true;
        }


    }
}
