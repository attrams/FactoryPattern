using FactoryPattern.PizzaIngredient;

namespace FactoryPattern.Pizza;

public class CheesePizza(IPizzaIngredientFactory ingredientFactory) : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = ingredientFactory.CreateDough();
        Sauce = ingredientFactory.CreateSauce();
        Cheese = ingredientFactory.CreateCheese();
    }
}