using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Pizzeria
{
    public class Pizza
    {
        string Name;
        Base basis;
        Sauce sauce;
        Cheese cheese;
        List<Ingredient> ingredients;

        public Pizza(GenerationPizzaFactory factory)
        {
            Name = factory.Name;
            basis = factory.CreateBase();
            sauce = factory.CreateSauce();
            cheese = factory.CreateCheese();
            ingredients = factory.CreateIngredients();
        }
        public double CalculatePrice()
        {
            double price = basis.Price + sauce.Price + cheese.Price;
            foreach (var item in ingredients)
            {
                price+=item.Price;
            }
            return price;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\t{Name}\t");
            sb.AppendLine($"Base: \r\t\t{basis.Size}");
            sb.AppendLine($"Sauce: \r\t\t{sauce.Title}");
            sb.AppendLine($"Cheese: \r\t\t{cheese.Title}");
            sb.AppendLine($"Ingredients:");
            foreach (var item in ingredients)
            {
                sb.AppendLine($"\r\t\t {item.Title}");
            }
            sb.Append($"Total price: {Math.Round(CalculatePrice(),2)}$");
            return sb.ToString();
            
        }
    }
}
