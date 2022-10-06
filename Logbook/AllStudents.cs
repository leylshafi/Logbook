using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logbook
{
   class FakeRepository
        {
            public static List<Student> Students { get; set; } = new()
            {
                new Student(1, "1.jpg", "Ceyhun", "Abdullayev", "Aqil", new DateTime(2022, 05, 24), Abscence.Unknown, null, null, null, null),
                new Student(2, null, "Ağamətləb", "Akbarzade", "Metleb", new DateTime(2022, 05, 26), Abscence.Unknown, null, null, null, null),
                new Student(3, "3.jpg", "Fərman", "Asadov", "Suleyman", new DateTime(2022, 05, 23), Abscence.Unknown, null, null, null, null),
               
            };

        }
    
}
