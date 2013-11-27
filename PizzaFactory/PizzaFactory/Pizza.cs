using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaFactory
{
	public abstract class PizzaStore
	{
		public Pizza orderPizza(string type)
		{
			Pizza pizza;

			pizza = createPizza(type);

			pizza.prepare();
			pizza.bake();
			pizza.cut();
			pizza.box();

			return pizza;
		}

		protected abstract Pizza createPizza(string type);
	}

	public class NYPizzaStore : PizzaStore
	{
		public Pizza orderPizza(string type)
		{
			Pizza pizza;

			pizza = createPizza(type);

			pizza.prepare();
			pizza.bake();
			pizza.cut();
			pizza.box();

			return pizza;
		}

		public Pizza createPizza(string type)
		{
			Pizza pizza = null;

			if (String.Compare(type, "cheese") == 0)
			{
				pizza = new NYVeggiePizza();
			}
			else if (String.Compare(type, "pepperoni") == 0)
			{
				pizza = new NYPepperoniPizza();
			}
			else if (String.Compare(type, "clam") == 0)
			{
				pizza = new NYClamPizza();
			}
			else if (String.Compare(type, "veggie") == 0)
			{
				pizza = new NYVeggiePizza();
			}

			return pizza;
		}

		public class NYVeggiePizza : Pizza
		{
		}
		public class NYPepperoniPizza : Pizza
		{
		}
		public class NYCheesePizza : Pizza
		{
		}
		public class NYClamPizza : Pizza
		{
		}
	}
}
