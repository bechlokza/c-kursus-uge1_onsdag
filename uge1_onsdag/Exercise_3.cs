using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uge1_onsdag
{
    internal class Exercise_3
    {
        public string Tickets(int age)
        {
            switch (age)
            {
                case < 3:
                    return "The ticket is free";
                    break;
                case < 12:
                    return "The ticket price is $10";
                    break;
                default:
                    return "The ticket price is $15";
                    break;
            }
        }
    }
}
