using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Pizzeria
{
    public abstract class GenerationPizzaFactory
    {
        abstract public string Name { get; }
        abstract public Base CreateBase();
        abstract public Sauce CreateSauce();
        abstract public Cheese CreateCheese();
        abstract public List<Ingredient> CreateIngredients();
    }

    public class RomanPizzaFactory : GenerationPizzaFactory
    {
        public override string Name => "Roman Pizza";

        public override Base CreateBase()
        {
            return new Xxl();
        }

        public override Cheese CreateCheese()
        {
            return new Parmesan();
        }

        public override List<Ingredient> CreateIngredients()
        {
            return new List<Ingredient> { new Balyk(), new Mushroom() };
        }

        public override Sauce CreateSauce()
        {
            return new Barbecue();
        }
    }

    public class SicilianPizzaFactory : GenerationPizzaFactory
    {
        public override string Name => "Sicilian Pizza";

        public override Base CreateBase()
        {
            return new Standart();
        }

        public override Cheese CreateCheese()
        {
            return new Mozzarella();
        }

        public override List<Ingredient> CreateIngredients()
        {
            return new List<Ingredient> { new Chicken(), new Olives(), new Pineapple() };
        }

        public override Sauce CreateSauce()
        {
            return new Tomato();
        }
    }

    public class CalabrianPizzaFactory : GenerationPizzaFactory
    {
        public override string Name => "Calabrian Pizza";

        public override Base CreateBase()
        {
            return new Standart();
        }

        public override Cheese CreateCheese()
        {
            return new Ricotta();
        }

        public override List<Ingredient> CreateIngredients()
        {
            return new List<Ingredient> { new Seafood(), new Olives(), new Mushroom() };
        }

        public override Sauce CreateSauce()
        {
            return new Tomato();
        }
    }

    public class NeapolitanPizzaFactory : GenerationPizzaFactory
    {
        public override string Name => "Neapolitan Pizza";

        public override Base CreateBase()
        {
            return new Xxl();
        }

        public override Cheese CreateCheese()
        {
            return new Parmesan();
        }

        public override List<Ingredient> CreateIngredients()
        {
            return new List<Ingredient> { new Salami(), new Mushroom() };
        }

        public override Sauce CreateSauce()
        {
            return new Chile();
        }
    }
}
