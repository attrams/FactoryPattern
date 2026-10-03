namespace FactoryPattern.PizzaStore;

using Pizza;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(PizzaType pizzaType)
    {
        throw new NotImplementedException();
    }
}