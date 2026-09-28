namespace FactoryPattern.PizzaStore;

using Pizza;

public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        Pizza pizza = type switch
        {
            "veggie" => new NYStyleVeggiePizza(),
            _ => new NYStyleCheesePizza()
        };

        return pizza;
    }
}