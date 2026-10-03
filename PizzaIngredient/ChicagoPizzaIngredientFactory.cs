using FactoryPattern.Ingredient.Cheese;
using FactoryPattern.Ingredient.Clams;
using FactoryPattern.Ingredient.Dough;
using FactoryPattern.Ingredient.Pepperoni;
using FactoryPattern.Ingredient.Sauce;
using FactoryPattern.Ingredient.Veggies;

namespace FactoryPattern.PizzaIngredient;

public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
{
    public IDough CreateDough()
    {
        return new ThickCrustDough();
    }

    public ISauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public ICheese CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public IVeggie[] CreateVeggies()
    {
        IVeggie[] veggies = [new Spinach(), new BlackOlives(), new EggPlant()];
        return veggies;
    }

    public IPepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public IClams CreateClam()
    {
        return new FrozenClams();
    }
}