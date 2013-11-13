using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarFactory
{
	public partial class Form1 : Form
	{


		public Form1()
		{
			InitializeComponent();
			CarElements newelements = new CarElements();
			Manufacturer_comboBox.DataSource = newelements.Manufacturer;
			BodyColour_comboBox.DataSource = newelements.Colour;
			BodyMaterial_comboBox.DataSource = newelements.BodyMaterial;
			BodyType_comboBox.DataSource = newelements.BodyType;
			FuelTankMaterial_comboBox.DataSource = newelements.FuelTankMaterial;
			EngineStroke_comboBox.DataSource = newelements.EngineStroke;
			EngineFuel_comboBox.DataSource = newelements.EngineFuel;
			LigthsType_comboBox.DataSource = newelements.LightsKit;
			GearShiftType_comboBox.DataSource = newelements.GearShiftType;
			WheelMaterial_comboBox.DataSource = newelements.WheelMaterial;
			WheelNumber_comboBox.DataSource = newelements.WheelNumber;
			TireType_comboBox.DataSource = newelements.TireType;
			TireWidth_comboBox.DataSource = newelements.TireWidth;
			TireRatio_comboBox.DataSource = newelements.TireRatio;
		}

		private void CreateCar_button_Click(object sender, EventArgs e)
		{
			GenericCar Car = new GenericCar(this);
			
		}

		private void Manufacturer_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void BodyColour_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void BodyType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void BodyMaterial_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void FuelTankCapacity_textBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void FuelTankMaterial_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void EngineStroke_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Fuel_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void EngineCapacity_textBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void LigthsType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void GearShiftType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void WheelNumber_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void WheelMaterial_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void TireType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void TireWidth_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void TireRatio_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void YesLeather_radioButton_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void NoLeather_radioButton_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void YesSport_radioButton_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void NoSport_radioButton_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void YesRace_radioButton_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void NoRace_radioButton_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
