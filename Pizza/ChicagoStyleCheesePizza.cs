namespace FactoryPattern.Pizza;

public class ChicagoStyleCheesePizza : Pizza
{
    public ChicagoStyleCheesePizza() : base("Chicago Style Deep Dish Cheese Pizza", "Extra Thick Crust Dough",
        "Plum Tomato Sauce")
    {
        AddToppings("Shredded Mozzarella Cheese");
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting the pizza into square slices");
    }
}