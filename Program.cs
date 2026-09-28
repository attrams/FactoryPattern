// See https://aka.ms/new-console-template for more information

using FactoryPattern.Pizza;
using FactoryPattern.PizzaStore;

PizzaStore nyStore = new NYPizzaStore();
PizzaStore chicagoStore = new ChicagoPizzaStore();

Pizza pizza = nyStore.OrderPizza("cheese");
Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

pizza = chicagoStore.OrderPizza("veggie");
Console.WriteLine($"Joel ordered a {pizza.Name}\n");