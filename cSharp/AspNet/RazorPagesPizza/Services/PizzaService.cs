using RazorPagesPizza.Models;

namespace RazorPagesPizza.Services;
public static class PizzaService
{
	static List<Pizza> Pizzas { get; }
	static int nextID = 4;
	static PizzaService()
	{
		Pizzas = new List<Pizza>
				{
					new Pizza { Id = 1, Name = "Classic Italian", Price = 20.00M, Size = PizzaSize.Large, IsGlutenFree = false },
					new Pizza { Id = 2, Name = "Veggie", Price = 15.00M, Size = PizzaSize.Medium, IsGlutenFree = true },
					new Pizza { Id = 3, Name = "Supreme Meatball", Price = 35.00M, Size = PizzaSize.DiabetesLarge, IsGlutenFree = false }
				};
	}

	public static List<Pizza> GetAll() => Pizzas;
	public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);
	public static void Add(Pizza pizza)
	{
		pizza.Id = nextID++;
		Pizzas.Add(pizza);
	}

	public static void Delete(int id)
	{
		
		Pizza? pizza = Get(id);
		if (pizza is null) 
			return;

		Pizzas.Remove(pizza);
	}

	public static void Update(Pizza pizza)
	{
		int index = Pizzas.FindIndex(p => p.Id == pizza.Id);
		if (index == -1)
			return;

		Pizzas[index] = pizza;
	}
}