using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaFactory
{
	public class SimplePizzaFactory
	{
		public Pizza createPizza(string type)
		{
			Pizza pizza = null;

			if (String.Compare(type, "cheese") == 0)
			{
				pizza = new VeggiePizza();
			}
			else if (String.Compare(type, "pepperoni") == 0)
			{
				pizza = new PepperoniPizza();
			}
			else if (String.Compare(type, "clam") == 0)
			{
				pizza = new ClamPizza();
			}
			else if (String.Compare(type, "veggie") == 0)
			{
				pizza = new VeggiePizza();
			}

			return pizza;
		}
	}

	public class Pizza
	{
		public void prepare()
		{ }
		public void bake()
		{ }
		public void cut()
		{ }
		public void box()
		{ }
	}

	public class VeggiePizza : Pizza
	{
	}
	public class PepperoniPizza : Pizza
	{
	}
	public class CheesePizza : Pizza
	{
	}
	public class ClamPizza : Pizza
	{
	}
}
