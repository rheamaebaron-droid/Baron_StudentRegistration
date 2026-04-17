using System;
using System.Collections.Generic;
using System.Text;

namespace baron_student2
{
    public class StudentObjects
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string MiddleInitial { get; set; } = "";
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; } = "";
        public string Address { get; set; } = "";
        public string Course { get; set; } = "";
        public string Year { get; set; } = "";

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - Birthdate.Year;
                if (Birthdate > DateTime.Now.AddYears(-age)) age--;
                return age;
            }
        }
    }
}
    

