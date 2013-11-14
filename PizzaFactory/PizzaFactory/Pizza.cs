using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaFactory
{
	class Pizza
	{
		Pizza orderPizza()
		{
			Pizza pizza = new Pizza();

			pizza.prepare();
			pizza.bake();
			pizza.cut();
			pizza.box();

			return pizza;
		}

		void prepare()
		{}
		void bake()
		{ }
		void cut()
		{ }
		void box()
		{ }
	}
}
