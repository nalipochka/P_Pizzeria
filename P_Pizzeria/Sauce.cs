using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Pizzeria
{
    public abstract class Sauce
    {
        abstract public string Title { get; }
        abstract public double Price { get; }
    }
    public class Tomato : Sauce
    {
        public override string Title => "Tomato";
        public override double Price => 0.15;
    }
    public class Barbecue : Sauce
    {
        public override string Title => "Barbecue";
        public override double Price => 0.50;
    }
    public class Chile : Sauce
    {
        public override string Title => "Chile";
        public override double Price => 0.70;
    }
}
