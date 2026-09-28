namespace FactoryPattern.Pizza;

public class NYStyleCheesePizza : Pizza
{
    public NYStyleCheesePizza() : base("NY Style Sauce and Cheese Pizza", "Thin Crust Dough", "Marinara Sauce")
    {
        AddToppings("Grated Reggiano Cheese");
    }
}