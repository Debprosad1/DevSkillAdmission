using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkillAdmissionTest
{
    public static class Test
    {
        public static ValueTuple<string, int, double> DoSomeThing(string name, int age, double weight)
        {
            return (name, age, weight);
        }
    }
}
