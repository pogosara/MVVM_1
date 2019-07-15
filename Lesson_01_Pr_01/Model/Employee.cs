using Lesson_01_Pr_01.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_01_Pr_01.Models
{
    public class Employee : ObservableObject
    {
       
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; OnPropertyChanged("FirstName"); }
        }


        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged("LastName"); }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; OnPropertyChanged("Age"); }
        }

    }
}
