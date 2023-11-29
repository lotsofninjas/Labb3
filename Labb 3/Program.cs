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
            Person person = new Person();

            person.DateOfBirth = new DateTime(1986, 06, 19);
            person.EyeColor = "Blueish";
            person.Gender = GenderInfo.Gender.Male;
            person.Hair = new HairInfo.Hair
            {
                HairColor = "Brown",
                HairLength = 1
            };

            Console.WriteLine(person.ToString());
            Console.ReadLine();
        }
    }

}
