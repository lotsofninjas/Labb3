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
        public DateTime DateOfBirth { get; set; }
        public string EyeColor { get; set; }
        public GenderInfo.Gender Gender { get; set; }
        public HairInfo.Hair Hair { get; set; }

        public Person(DateTime dateOfBirth, string eyeColor, GenderInfo.Gender genderInfo, HairInfo .Hair hair) 
        { 
            DateOfBirth = dateOfBirth;
            EyeColor = eyeColor;
            Gender = genderInfo;
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
