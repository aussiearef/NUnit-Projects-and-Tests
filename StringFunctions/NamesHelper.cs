using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    public static class NamesHelper
    {
        public static string MakeFullName(string firstName, string lastName, Genders gender = Genders.UnIdentified) 
        {
            var title = gender == Genders.Male ? "Mr." : (gender == Genders.Female ? "Ms." : string.Empty);
            var fullName = $"{firstName} {lastName}";

            if (!string.IsNullOrEmpty(title))
            {
                fullName = $"{title} {fullName}";
            }

            return fullName;
        }
    }

    public enum Genders
    {
        Male,
        Female,
        UnIdentified
    }
}
