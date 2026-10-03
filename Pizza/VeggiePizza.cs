using FactoryPattern.PizzaIngredient;

namespace FactoryPattern.Pizza;

public class VeggiePizza(IPizzaIngredientFactory ingredientFactory) : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = ingredientFactory.CreateDough();
        Sauce = ingredientFactory.CreateSauce();
        Cheese = ingredientFactory.CreateCheese();
        Veggies = ingredientFactory.CreateVeggies();
    }
}