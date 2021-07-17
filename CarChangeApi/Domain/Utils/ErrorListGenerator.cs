using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CarChangeApi.Domain.Utils
{
    public static class ErrorListGenerator
    {
        public static IEnumerable<IdentityError> CreateError(string msg, string code = default)
        {
            return new List<IdentityError>()
            {
                new(){Code = code, Description = msg}
            };
        }

        public static IEnumerable<IdentityError> CreateFromList((string, string)[] msgs)
        {
            List<IdentityError> errors = new();

            for(int i = 0; i < msgs.Length; i++)
            {
                var error = new IdentityError() { Description = msgs[i].Item1, Code = msgs[i].Item2 };
                errors.Add(error);
            }

            return errors;
        }

        public static IEnumerable<IdentityError> CreateEmpty()
        {
            return new List<IdentityError>();
        }
    }
}
