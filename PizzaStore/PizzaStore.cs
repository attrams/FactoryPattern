namespace FactoryPattern.PizzaStore;

using Pizza;

public abstract class PizzaStore
{
    public Pizza OrderPizza(PizzaType pizzaType)
    {
        Pizza pizza = CreatePizza(pizzaType);
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    protected abstract Pizza CreatePizza(PizzaType pizzaType);
}