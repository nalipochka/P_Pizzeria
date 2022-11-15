using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Pizzeria
{
    public abstract class Base
    {
        abstract public string Size { get; }
        abstract public double Price { get; }
    }

    public class Standart : Base
    {
        public override string Size => "Standart";

        public override double Price => 2.50;
    }
    public class Xxl : Base
    {
        public override string Size => "XXL";

        public override double Price => 4.50;
    }
}
