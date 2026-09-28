namespace FactoryPattern.PizzaStore;

using Pizza;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        Pizza pizza = type switch
        {
            "veggie" => new ChicagoStyleVeggiePizza(),
            _ => new ChicagoStyleCheesePizza()
        };

        return pizza;
    }
}