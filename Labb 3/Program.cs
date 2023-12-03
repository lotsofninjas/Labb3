using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3
{
    class Program
    {
        private static void Main(string[] args)
        {
            DateTime dateOfBirth = new DateTime(1986, 06, 19);
            string eyeColor = "Blueish";
            Gender gender = Gender.Male;
            Hair hair = new Hair
            {
                HairColor = "Brown",
                HairLength = 0.5
            };
            
            Person person = new Person(dateOfBirth, eyeColor, gender, hair);

            Console.WriteLine(person);
            Console.ReadLine();
        }
    }

}
