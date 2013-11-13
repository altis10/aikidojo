using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
	class CarElements
	{
		public List<string> GearShiftType = new List<string> { "automatic", "manual" };
		public List<string> LightsKit = new List<string> { "classic", "sport", "LED" };
		public List<string> FuelTankMaterial = new List<string> { "steel", "INOX", "other" };
		public List<int> EngineStroke = new List<int> { 4, 2 };
		public List<string> EngineFuel = new List<string> { "petrol", "diesel" };
		public List<string> Colour = new List<string> { "white", "black", "blue", "green", "red", "Red Ferrari" };
		public List<string> BodyType = new List<string> { "limousine", "hatchback", "break", "SUV" };
		public List<string> BodyMaterial = new List<string> { "iron_sheet", "aluminiunm", "plastic", "composite" };
		public List<int> WheelNumber = new List<int> { 2, 3, 4 };
		public List<string> WheelMaterial = new List<string> { "steel", "alloy", "composite" };
		public List<string> TireType = new List<string> { "summer", "winter" };
		public List<string> Manufacturer = new List<string> { "BMW", "Dacia", "Mercedes", "Lotus", "Aston Martin", "Audi", "Smart" };
		public List<int> TireWidth = new List<int> { 145, 155, 165, 185, 195, 205, 215 };
		public List<int> TireRatio = new List<int> { 50, 55, 60, 65, 70, 80 };
	}
}
