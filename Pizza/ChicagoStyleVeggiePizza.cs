namespace FactoryPattern.Pizza;

public class ChicagoStyleVeggiePizza : Pizza
{
    public ChicagoStyleVeggiePizza() : base("Chicago Deep Dish Veggie Pizza", "Extra Thick Crust Dough",
        "Plum Tomato Sauce")
    {
        AddToppings("Shredded Mozzarella Cheese");
        AddToppings("Black Olives");
        AddToppings("Spinach");
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting the pizza into square slices.");
    }
}