using FactoryPattern.Ingredient.Cheese;
using FactoryPattern.Ingredient.Clams;
using FactoryPattern.Ingredient.Dough;
using FactoryPattern.Ingredient.Pepperoni;
using FactoryPattern.Ingredient.Sauce;
using FactoryPattern.Ingredient.Veggies;

namespace FactoryPattern.PizzaIngredient;

public interface IPizzaIngredientFactory
{
    public IDough CreateDough();
    public ISauce CreateSauce();
    public ICheese CreateCheese();
    public IVeggie[] CreateVeggies();
    public IPepperoni CreatePepperoni();
    public IClams CreateClam();
}