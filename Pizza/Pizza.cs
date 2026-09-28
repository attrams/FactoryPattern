namespace FactoryPattern.Pizza;

public abstract class Pizza
{
    private string _name;
    private string _dough;
    private string _sauce;
    private List<string> _toppings;

    protected Pizza(string name, string dough, string sauce)
    {
        _name = name;
        _dough = dough;
        _sauce = sauce;
        _toppings = new List<string>();
    }

    protected void AddToppings(string topping)
    {
        _toppings.Add(topping);
    }

    public virtual void Prepare()
    {
        Console.WriteLine($"Preparing {_name}");
        Console.WriteLine("Tossing dough...");
        Console.WriteLine("Adding sauce...");
        Console.WriteLine("Adding toppings: ");
        foreach (var topping in _toppings)
        {
            Console.WriteLine($"  {topping}");
        }
    }

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

    public string Name => _name;
}