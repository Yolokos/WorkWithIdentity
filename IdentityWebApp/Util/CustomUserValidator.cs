using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityWebApp.Models;
using Microsoft.AspNetCore.Identity;

namespace IdentityWebApp.Util
{
    public class CustomUserValidator : IUserValidator<User>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user)
        {
            List<IdentityError> errors = new List<IdentityError>();

            if (user.Email.Contains("admin"))
            {
                errors.Add(new IdentityError
                {
                    Description = "You can't have admin name"
                });
            }

            if (!user.Email.ToLower().EndsWith("@gmail.com"))
            {
                errors.Add(new IdentityError {
                    Description = "Ends with gmail.com only beatch"
                });
            }

            return Task.FromResult(errors.Count == 0 ? IdentityResult.Success : IdentityResult.Failed(errors.ToArray()));
        }
    }
}
