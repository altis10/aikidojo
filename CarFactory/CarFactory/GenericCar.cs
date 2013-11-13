using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
	class GenericCar : ICarInterface1
	{
		public GenericCar(Form1 myform) 
		{
			Manufacturer myManufacturer = new Manufacturer( );
			Body myBody = new Body();
			Engine myEngine = new Engine();
			GearShift myGearShift = new GearShift();
			FuelTank myFuelTank = new FuelTank();
			InteriorKit myInteriorKit = new InteriorKit();
			LightsKit myLightsKit = new LightsKit();
			WheelsKit myWheelsKit = new WheelsKit();

			this.GearShift = myGearShift.GearShiftType;
			this.CarColour = myBody.Colour;
			this.Fuel = myEngine.Fuel;
			this.FuelTankCapacity = myFuelTank.Capacity;
			this.WheelNumber = myWheelsKit.WheelNumber;
			this.Manufacturer = myManufacturer.ManufacturerName;
		}
		public string Manufacturer
		{
			get { return _manufacturer; }
			set { _manufacturer = value; }
		}
		private string _manufacturer;

		public string CarName
		{
			get { return _carname; }
			set { _carname = value; }
		}
		private string _carname;

		public int WheelNumber
		{
			get { return _wheelnumber; }
			set { _wheelnumber = value; }
		}
		private int _wheelnumber;

		public string CarColour
		{
			get { return _carcolour; }
			set { _carcolour = value; }
		}
		private string _carcolour;

		public string Fuel
		{
			get { return _fuel; }
			set { _fuel = value; }
		}
		private string _fuel;
		
		// On wheels, on caterpillar, on air.
		public string MovingMethode
		{
			get { return _movingmethode; }
			set { _movingmethode = value; }
		}
		private string _movingmethode = "wheels";

		public bool HasDriver
		{
			get { return _hasdriver; }
			set { _hasdriver = value; }
		}
		private bool _hasdriver;

		public string GearShift
		{
			get { return _gearshift; }
			set { _gearshift = value; }
		}
		private string _gearshift;

		public int FuelTankCapacity
		{
			get { return _fuelcapacity; }
			set { _fuelcapacity = value; }
		}
		private int _fuelcapacity;

		public void Steer()
		{ }

		public void FillWithGasoline()
		{ }

		public void StopEngine()
		{ }

		public void StartEngine()
		{ }

		// Using a pedal or manual clutch (for handicaped drivers)
		public void Accelerate()
		{ }

		public void Brake()
		{ }

		public void ChangeGear()
		{ }
	}
}
