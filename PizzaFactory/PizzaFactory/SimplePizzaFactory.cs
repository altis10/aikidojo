using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

	public abstract class Pizza
	{
		string name;
		string dough;
		string sauce;
		List<string> Toppings = new List<string>();

		public void prepare()
		{
			MessageBox.Show("Preparing" + name);
			MessageBox.Show("Tossing dough.");
			MessageBox.Show("Adding sauce...");
			MessageBox.Show("Ading toppings...");
		}
		public void bake()
		{
			MessageBox.Show("Baking");
		}
		public void cut()
		{
			MessageBox.Show("Cutting");
		}
		public void box()
		{
			MessageBox.Show("Boxing");
		}


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
