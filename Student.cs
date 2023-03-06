using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExample
{
    internal class Student
    {
        private string _address;
        private string _dob;
        private string _firstName;
        private char _gender;
        private string _lastName;
        private string _id;

        public Student()
        {
            Console.WriteLine("Create a new instance of Student class without student id");
        }

        public Student(string studentId)
        {
            _id = studentId;
            Console.WriteLine($"Create a new instance of Student class with student id {_id}");
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Dob
        {
            get { return _dob; }
            set { _dob = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public void RegisterPaper(string paperId)
        {
            Console.WriteLine($"The student {FirstName} {LastName} register the papaer {paperId}");
        }

        public void RegisterPaper(int paperCode)
        {
            Console.WriteLine($"The student {FirstName} {LastName} register the papaer {paperCode}");
        }

        public bool AttendClass()
        {
            Console.Write($"The student {FirstName} {LastName} attends a class");
            return true;
        }
    }
}
