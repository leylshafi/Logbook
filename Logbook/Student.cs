using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logbook
{
    internal class Student
    {
        public int Number { get; set; }
        public string? PictureUrl { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FatherName { get; set; }
        public DateTime? LastIn { get; set; }
        public Abscence Status { get; set; }
        public byte? LaboratoryWork { get; set; }
        public byte? ClassWork { get; set; }
        public byte? ActivityCrystal { get; set; }
        public string? Comment { get; set; }



        public Student(int number, string? pictureUrl, string? firstName, string? lastName, string? fatherName, DateTime? lastIn, Abscence status, byte? laboratoryWork, byte? classWork, byte? activityCrystal, string? comment)
        {
            Number = number;
            PictureUrl = pictureUrl;
            FirstName = firstName;
            LastName = lastName;
            FatherName = fatherName;
            LastIn = lastIn;
            Status = status;
            LaboratoryWork = laboratoryWork;
            ClassWork = classWork;
            ActivityCrystal = activityCrystal;
            Comment = comment;
        }


        public string? FullName() => $"{FirstName} {LastName} {FatherName}";

        public override string ToString() => $@"
No: {Number},
Full name: {FullName()}";
    }


    public enum Abscence
    {
        Unknown,
        Present,
        Absent,
        Late
    }

}


