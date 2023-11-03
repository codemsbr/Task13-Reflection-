using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13_Reflection_
{
    internal class User
    {
        int Id;
        string Name;
        static int age;

        static void ChangeAge(int _age)
        {
           age = _age;
        }
    }
}
