using System;
using System.Collections.Generic;
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
        
    }
}
