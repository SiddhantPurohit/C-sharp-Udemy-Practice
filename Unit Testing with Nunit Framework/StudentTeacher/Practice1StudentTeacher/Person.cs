using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1StudentTeacher
{
    class Person
    {
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public void setAge (int EnterYourAge)
        {
            Age = EnterYourAge;
        }

        public static string Greet()
        {
            return "Hello";
        }
    }

    class Student : Person
    {
        public string GoToCLass ()
        {
            return "I am going to class";
        }

    }
    class Teacher : Person
    {
        public string Explian ()
        {
            return "Explaination begins";
        }

    }

}
