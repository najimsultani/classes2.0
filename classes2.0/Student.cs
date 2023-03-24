using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes2._0
{
    // internal 
    //public
    // private
    //protected
    public class Student
    {
        string _firstName;
        string _lastName;
        double _csiGrade;
        double _GenEdGrade;
        // Constructor
        //public Student(string firstName)
        //{
        //    this._firstName = firstName;
        //}
        public Student(string firstName, string lastName, double csiGrade, double genEdGrade)
        {
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = csiGrade;
            _GenEdGrade = genEdGrade;
        }

        //Review: What’s the name for any field, constructor, property or method that is part of a class?
        // Members
        public string FirstName
        {
            // get and set
            //allows the user to read the value
            //set allows the user to change the value

            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }


        }

        public string LastName { get => _lastName; set => _lastName = value; }
        public double CsiGrade { get => _csiGrade; set => _csiGrade = value; }
        public double GenEdGrade { get => _GenEdGrade; set => _GenEdGrade = value; }



        // Method

        // What is a method?
        // A block of code that is given a name, and runs when it is called

        //What is the purpose of a method?
        // Easy to code easy to read easy to refactor and easy to resuse

        public double StudentAverage()
        {
            //csi grade and genedgrade is / BY 2
            return (_csiGrade + _GenEdGrade) / 2;
        }

        //public double studentAverage (double csigrade, double genedgrade)
        //Review: What are the 4 parts of declaring a method?
        // Access Modifier, return type, Name, Paremeters
        //What keyword allows you to access members related to the specific instance?


        //FirstName + " " + s.LastName + " " + s.CsiGrade + " " + s.GenEdGrade;

        //what does override .ToString() allow us to do
        //what's a class 
        //how to override to string
        //first name last name ----

        // How to override to string
        // First Name Last Name CSI Grade Gen Grade
        public override string ToString()
        {
            //display output 
            return $"{this._firstName} {this._lastName} - Gen Ed Grade: {this._GenEdGrade}" +
                $" - CSI Grade {this._csiGrade} - Average {StudentAverage()}";
        }//ToString 
    }
}
