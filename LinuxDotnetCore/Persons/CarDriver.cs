using System;
using System.Collections;

namespace AppLinux
{
    public class CarDriver : Driver
    {
        private String firstname;
        private String lastname;
        private int age;
        private char sex;
        private ArrayList cars = new ArrayList();

        public bool setFirstname(string name)
        {
            this.firstname = name;
            return true;
        }

        public bool setLastname(string name)
        {
            this.lastname = name;
            return true;
        }

        public bool setAge(int age)
        {
            this.age = age;
            return true;
        }

        public bool setSex(char sex)
        {
            this.sex = sex;
            return true;
        }

        public string getFirstname()
        {
            return this.firstname;
        }

        public string getLastname()
        {
            return this.lastname;
        }

        public int getAge()
        {
            return this.age;
        }

        public char getSex()
        {
            return this.sex;
        }

        public ArrayList getCars()
        {
            return this.cars;
        }

        public override string ToString()
        {
            String sexString = "---";
            if (sex == 'm')
            {
                sexString = "male";
            }
            if (sex == 'f')
            {
                sexString = "female";
            }
            return this.firstname + " " + this.lastname + ", " + this.age + ", " + sexString;
            // return base.ToString();
        }
    }
}