using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace DevSkillAdmissionTest
{
    public class LinqQuery
    {
        public List<int> FindNumbersGreaterThanFifty(List<int> numbers)
        {
            return (from number in numbers where number > 50 select number).ToList();
        }
    }
}
