namespace FactoryPattern.Pizza;

public class NYStyleVeggiePizza : Pizza
{
    public NYStyleVeggiePizza() : base("NY Style Veggie Pizza", "Thin Crust Dough", "Marinara Sauce")
    {
        AddToppings("Grated Reggiano Cheese");
        AddToppings("Garlic");
        AddToppings("Onion");
        AddToppings("Mushrooms");
    }
}