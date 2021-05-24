using System;
namespace Lession33
{
    public class Student
    {
        #region fields
        // fields
        private int age;
        private string email;
        private string pin;
        public string Fullname {get;set;}

        #endregion
        // Contructors
        #region  contructors
        public Student()
        {

        }

        ~Student(){

        }
        public Student(string fullname, string email)
        {
            Fullname = fullname;
            this.email = email;
        }

        public Student(string fullname, int age, string email, string pin)
        {
            this.Fullname = fullname;
            this.age = age;
            this.email = email;
            this.pin = pin;
        }
        #endregion

        #region  methods
        //Methods
        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }

        public string Email
        {
            get { return email;}
            set { email = value;}
        }

        public string Pin 
        { 
            get => $"{pin.Substring(0, pin.Length - 3)}XXX"; 
            set => pin = value;
        }

        public string Greeting()
        {
            return $"Fullname: {Fullname}, Age: {age}";
        }
        #endregion
    }
}

// access_modifier class class_name 
// {

// }

// getter, setter