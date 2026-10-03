using FactoryPattern.PizzaIngredient;

namespace FactoryPattern.Pizza;

public class PepperoniPizza(IPizzaIngredientFactory ingredientFactory) : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = ingredientFactory.CreateDough();
        Sauce = ingredientFactory.CreateSauce();
        Cheese = ingredientFactory.CreateCheese();
        Veggies = ingredientFactory.CreateVeggies();
        Pepperoni = ingredientFactory.CreatePepperoni();
    }
}