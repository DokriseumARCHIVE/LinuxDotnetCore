using System;

namespace AppLinux
{
    public interface Person
    {
        bool setFirstname(string name);
        bool setLastname(string name);
        bool setAge(int age);
        bool setSex(char sex);
        string getFirstname();
        string getLastname();
        int getAge();
        char getSex();
        string ToString();
    }
}