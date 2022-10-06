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
                new Student(1, "pp1.png", "Murad", "Shafizada", "Dursun", new DateTime(2022, 04, 26), Abscence.Unknown, null, null, null, null),
                new Student(2, "pp2.png", "Leyla", "Shafiyeva", "Dursun", new DateTime(2022, 04, 29), Abscence.Unknown, null, null, null, null),
                new Student(3, "pp3.png", "Rahman", "Karimli", "Rizvan", new DateTime(2022, 04, 22), Abscence.Unknown, null, null, null, null),
                new Student(4, "pp4.png", "Adil", "Nasirli", "Namin", new DateTime(2022, 04, 23), Abscence.Unknown, null, null, null, null),
               
            };

        }
    
}
