using FactoryPattern.PizzaIngredient;

namespace FactoryPattern.PizzaStore;

using Pizza;

public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(PizzaType pizzaType)
    {
        IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

        return pizzaType switch
        {
            PizzaType.Cheese => new CheesePizza(ingredientFactory) { Name = "New York Style Cheese Pizza" },
            PizzaType.Veggie => new VeggiePizza(ingredientFactory) { Name = "New York Style Veggie Pizza" },
            PizzaType.Clam => new ClamPizza(ingredientFactory) { Name = "New York Style Clam Pizza" },
            PizzaType.Pepperoni => new PepperoniPizza(ingredientFactory) { Name = "New York Style Pepperoni Pizza" },
            _ => throw new ArgumentOutOfRangeException(nameof(pizzaType), pizzaType, "Invalid pizza type")
        };
    }
}