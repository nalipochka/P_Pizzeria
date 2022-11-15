using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Pizzeria
{
    public abstract class Cheese
    {
        abstract public string Title { get; }
        abstract public double Price { get; }
    }
    public class Mozzarella : Cheese
    {
        public override string Title => "Mozzarella";

        public override double Price => 0.50;
    }
    public class Ricotta : Cheese
    {
        public override string Title => "Ricotta";

        public override double Price => 0.35;
    }
    public class Parmesan : Cheese
    {
        public override string Title => "Parmesan";

        public override double Price => 0.65;
    }
}
