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
            Person person = new Person(
                new DateTime(1986, 06, 19),
                "Blueish",
                GenderInfo.Gender.Male,
                new HairInfo.Hair
                {
                    HairColor = "Brown",
                    HairLength = 1
                });



            Console.WriteLine(person.ToString());
            Console.ReadLine();
        }
    }

}
