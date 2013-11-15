using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaFactory
{
	public class PizzaStore
	{
		SimplePizzaFactory factory;

		public PizzaStore(SimplePizzaFactory factory)
		{
			this.factory = factory;
		}

		public Pizza orderPizza(string type)
		{
			Pizza pizza;

			pizza = factory.createPizza("");

			pizza.prepare();
			pizza.bake();
			pizza.cut();
			pizza.box();

			return pizza;
		}
	}
}
