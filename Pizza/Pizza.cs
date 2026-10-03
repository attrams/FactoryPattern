using FactoryPattern.Ingredient.Cheese;
using FactoryPattern.Ingredient.Clams;
using FactoryPattern.Ingredient.Dough;
using FactoryPattern.Ingredient.Pepperoni;
using FactoryPattern.Ingredient.Sauce;
using FactoryPattern.Ingredient.Veggies;

namespace FactoryPattern.Pizza;

public abstract class Pizza
{
    public string Name { get; set; }
    public IDough Dough { get; protected set; }
    public ISauce Sauce { get; protected set; }
    public IVeggie[] Veggies { get; protected set; }
    public ICheese Cheese { get; protected set; }
    public IPepperoni Pepperoni { get; protected set; }
    public IClams Clams { get; protected set; }

    public abstract void Prepare();

    public virtual void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public virtual void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }
}