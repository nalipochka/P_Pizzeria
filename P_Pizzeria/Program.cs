using P_Pizzeria;

Console.WriteLine("-------------------------------------------");
Pizza pizza_1 = new Pizza(new RomanPizzaFactory());
Console.WriteLine(pizza_1);
Console.WriteLine("-------------------------------------------");
Pizza pizza_2 = new Pizza(new SicilianPizzaFactory());
Console.WriteLine(pizza_2);
Console.WriteLine("-------------------------------------------");
Pizza pizza_3 = new Pizza(new CalabrianPizzaFactory());
Console.WriteLine(pizza_3);
Console.WriteLine("-------------------------------------------");
Pizza pizza_4 = new Pizza(new NeapolitanPizzaFactory());
Console.WriteLine(pizza_4);
Console.WriteLine("-------------------------------------------");