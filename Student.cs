// Written By Shashank
// 1/15/2025

using System;
using System.Collections.Generic;

namespace ProjectSpring2025B
{
    public class Student
    {
        // class variables and they are in camel case
        private int studentId = -1;
        private string firstName = "n/a";
        private string middleName = "n/a";
        private string lastName = "n/a";
        private string major = "n/a";
        // GPA is a calculated field so later in the semester
        //private double gpa = 0.0;

        // get and sets Accessor Methods = gets and Mutator Methods = sets

        public int StudentId
        {
            // I am making this read only just for fun, just for now
            get { return this.studentId; }
            //set { this.middleName = value; }
        }
        public string FirstName
        {
            // This is a very bare bones get and set
            // there could be a lot of code here
            // but this is week 0 so there isn't a lot of code here yet
            // the code would be for checking ranges and such

            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {

            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string MiddleName
        {

            get { return this.middleName; }
            set { this.middleName = value; }
        }
        public string Major
        {

            get { return this.major; }
            set { this.major = value; }


        }

        //Constructor

        //When you have two methods with the same name but different parameters
        //It is called overloading
        public Student():this(-1, "n/a", "n/a", "n/a", "n/a")
        {
            //This is an empty constructor
            //It is empty because it has no parameters
            //It may have significant amount of code
            //overriding vs overloading 
        }
        //Constructors

        public Student(int aStudentId, string aFirstName, string aLastName, string aMiddleName, "n/a"):
            this(aStudentId, aFirstName, aLastName, aMiddleName, "undecided")
        {
            //This is a constructor with 4 parameters
            //Rule of Thumb, use the sets -- that is the capitalized version that will call the set
            //Try not to ever use the private variables unless you need to 
            
            //We no longer need this code because it has no parameters
            //this.StudentID = aStudentId;
            //this.FirstName = aFirstName;
            //this.LastName = aLastName;
            //this.MiddleName = aMiddleName;
            //this.Major = "undecided";


        //Constructors

        public Student(int aStudentId, string aFirstName, string aLastName, string aMiddleName, string aMajor);
        {
            //This is called the full constructor , it has all of the properties
            //this is not quite industry standard 
            //that is, not everyone would know the term full constructor
            this.StudentID = aStudentId;
            this.FirstName = aFirstName;
            this.LastName = aLastName;
            this.MiddleName = aMiddleName;
            this.Major = aMajor;

        // methods

        public override string ToString()
        {
            string message = "";
            message = message + "Student Id: "      + this.StudentId    + "\n";
            message = message + "First Name: "      + this.FirstName    + "\n";
            message = message + "Last Name: "       + this.LastName     + "\n";
            message = message + "Middle Name: "     + this.MiddleName   + "\n";
            message = message + "Major: "           + this.Major        + "\n";
            return message;
        }



    }
}
