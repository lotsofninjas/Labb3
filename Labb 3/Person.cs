using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3
{
    public class Person
    {
        private DateTime DateOfBirth { get; }
        private string EyeColor { get; }
        private Gender Gender { get; }
        private Hair Hair { get; }

        public Person(DateTime dateOfBirth, string eyeColor, Gender gender, Hair hair) 
        { 
            DateOfBirth = dateOfBirth;
            EyeColor = eyeColor;
            Gender = gender;
            Hair = hair;
        }

        public override string ToString() 
        {
            return $"Date of birth: {DateOfBirth.ToString("yy/MM/dd", CultureInfo.InvariantCulture)}" + 
                $"\nEyecolor: {EyeColor}" +
                $"\nGender: {Gender}" +
                $"\nHaircolor: {Hair.HairColor}" +
                $"\nHairlength: {Hair.HairLength} cm";
        }
    }
}
