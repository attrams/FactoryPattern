using FactoryPattern.Ingredient.Cheese;
using FactoryPattern.Ingredient.Clams;
using FactoryPattern.Ingredient.Dough;
using FactoryPattern.Ingredient.Pepperoni;
using FactoryPattern.Ingredient.Sauce;
using FactoryPattern.Ingredient.Veggies;

namespace FactoryPattern.PizzaIngredient;

public class NYPizzaIngredientFactory : IPizzaIngredientFactory
{
    public IDough CreateDough()
    {
        return new ThinCrustDough();
    }

    public ISauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public ICheese CreateCheese()
    {
        return new ReggianoCheese();
    }

    public IVeggie[] CreateVeggies()
    {
        IVeggie[] veggies = [new Garlic(), new Onion(), new Mushroom(), new RedPepper()];
        return veggies;
    }

    public IPepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public IClams CreateClam()
    {
        return new FreshClams();
    }
}