using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Pizzeria
{
    abstract public class Ingredient
    {
        abstract public string Title { get; }
        abstract public double Price { get; }
    }

    public class Olives : Ingredient
    {
        public override string Title => "Olives";

        public override double Price => 0.20;
    }
    public class Pineapple : Ingredient                     
    {
        public override string Title => "Pineapple";

        public override double Price => 0.30;
    }
    public class Mushroom : Ingredient
    {
        public override string Title => "Mushrooms";

        public override double Price => 0.25;
    }
    public class Seafood : Ingredient
    {
        public override string Title => "Seafood";

        public override double Price => 0.60;
    }
    public class Chicken : Ingredient
    {
        public override string Title => "Chicken";

        public override double Price => 0.50;
    }
    public class Salami : Ingredient
    {
        public override string Title => "Salami";

        public override double Price => 0.40;
    }
    public class Balyk : Ingredient
    {
        public override string Title => "Balyk";

        public override double Price => 0.60;
    }
}
