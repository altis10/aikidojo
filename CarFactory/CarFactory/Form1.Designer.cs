namespace CarFactory
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.EngineStroke_comboBox = new System.Windows.Forms.ComboBox();
			this.CreateCar_button = new System.Windows.Forms.Button();
			this.EngineStroke = new System.Windows.Forms.Label();
			this.EngineFuel_comboBox = new System.Windows.Forms.ComboBox();
			this.Fuel_label = new System.Windows.Forms.Label();
			this.EngineCapacity_label = new System.Windows.Forms.Label();
			this.EngineCapacity_textBox = new System.Windows.Forms.TextBox();
			this.TireType_label = new System.Windows.Forms.Label();
			this.WheelMaterial_comboBox = new System.Windows.Forms.ComboBox();
			this.WheelMaterial_label = new System.Windows.Forms.Label();
			this.WheelNumber_comboBox = new System.Windows.Forms.ComboBox();
			this.WheelNumber_label = new System.Windows.Forms.Label();
			this.TireType_comboBox = new System.Windows.Forms.ComboBox();
			this.TireWidth_comboBox = new System.Windows.Forms.ComboBox();
			this.TireWidth_label = new System.Windows.Forms.Label();
			this.TireRatio_comboBox = new System.Windows.Forms.ComboBox();
			this.TireRatio_label = new System.Windows.Forms.Label();
			this.RaceCar_label = new System.Windows.Forms.Label();
			this.SportPackage_label = new System.Windows.Forms.Label();
			this.Leather_label = new System.Windows.Forms.Label();
			this.BodyType_comboBox = new System.Windows.Forms.ComboBox();
			this.BodyType_label = new System.Windows.Forms.Label();
			this.BodyColour_comboBox = new System.Windows.Forms.ComboBox();
			this.BodyColour_label = new System.Windows.Forms.Label();
			this.LigthsType_comboBox = new System.Windows.Forms.ComboBox();
			this.LigthsType_label = new System.Windows.Forms.Label();
			this.FuelTankMaterial_comboBox = new System.Windows.Forms.ComboBox();
			this.FuelTankMaterial_label = new System.Windows.Forms.Label();
			this.FuelCapacity_label = new System.Windows.Forms.Label();
			this.GearShiftType_comboBox = new System.Windows.Forms.ComboBox();
			this.GearShiftType_label = new System.Windows.Forms.Label();
			this.FuelTankCapacity_textBox = new System.Windows.Forms.TextBox();
			this.YesLeather_radioButton = new System.Windows.Forms.RadioButton();
			this.NoLeather_radioButton = new System.Windows.Forms.RadioButton();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.NoSport_radioButton = new System.Windows.Forms.RadioButton();
			this.YesSport_radioButton = new System.Windows.Forms.RadioButton();
			this.panel9 = new System.Windows.Forms.Panel();
			this.NoRace_radioButton = new System.Windows.Forms.RadioButton();
			this.YesRace_radioButton = new System.Windows.Forms.RadioButton();
			this.Interior_groupBox = new System.Windows.Forms.GroupBox();
			this.Engine_groupBox = new System.Windows.Forms.GroupBox();
			this.Wheelskit_groupBox = new System.Windows.Forms.GroupBox();
			this.Body_groupBox = new System.Windows.Forms.GroupBox();
			this.BodyMaterial_comboBox = new System.Windows.Forms.ComboBox();
			this.BodyMaterial_label = new System.Windows.Forms.Label();
			this.FuelTank_groupBox = new System.Windows.Forms.GroupBox();
			this.GearShift_groupBox = new System.Windows.Forms.GroupBox();
			this.Lights_groupBox = new System.Windows.Forms.GroupBox();
			this.Manufacturer_groupBox = new System.Windows.Forms.GroupBox();
			this.Manufacturer_comboBox = new System.Windows.Forms.ComboBox();
			this.Manufacturer_label = new System.Windows.Forms.Label();
			this.CarName_textBox = new System.Windows.Forms.TextBox();
			this.CarName_label = new System.Windows.Forms.Label();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel9.SuspendLayout();
			this.Interior_groupBox.SuspendLayout();
			this.Engine_groupBox.SuspendLayout();
			this.Wheelskit_groupBox.SuspendLayout();
			this.Body_groupBox.SuspendLayout();
			this.FuelTank_groupBox.SuspendLayout();
			this.GearShift_groupBox.SuspendLayout();
			this.Lights_groupBox.SuspendLayout();
			this.Manufacturer_groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// EngineStroke_comboBox
			// 
			this.EngineStroke_comboBox.FormattingEnabled = true;
			this.EngineStroke_comboBox.Location = new System.Drawing.Point(24, 48);
			this.EngineStroke_comboBox.Name = "EngineStroke_comboBox";
			this.EngineStroke_comboBox.Size = new System.Drawing.Size(121, 24);
			this.EngineStroke_comboBox.TabIndex = 0;
			this.EngineStroke_comboBox.SelectedIndexChanged += new System.EventHandler(this.EngineStroke_comboBox_SelectedIndexChanged);
			// 
			// CreateCar_button
			// 
			this.CreateCar_button.Location = new System.Drawing.Point(395, 635);
			this.CreateCar_button.Name = "CreateCar_button";
			this.CreateCar_button.Size = new System.Drawing.Size(84, 23);
			this.CreateCar_button.TabIndex = 1;
			this.CreateCar_button.Text = "CreateCar";
			this.CreateCar_button.UseVisualStyleBackColor = true;
			this.CreateCar_button.Click += new System.EventHandler(this.CreateCar_button_Click);
			// 
			// EngineStroke
			// 
			this.EngineStroke.AutoSize = true;
			this.EngineStroke.Location = new System.Drawing.Point(24, 25);
			this.EngineStroke.Name = "EngineStroke";
			this.EngineStroke.Size = new System.Drawing.Size(71, 17);
			this.EngineStroke.TabIndex = 2;
			this.EngineStroke.Text = "Stroke No";
			// 
			// EngineFuel_comboBox
			// 
			this.EngineFuel_comboBox.FormattingEnabled = true;
			this.EngineFuel_comboBox.Location = new System.Drawing.Point(24, 117);
			this.EngineFuel_comboBox.Name = "EngineFuel_comboBox";
			this.EngineFuel_comboBox.Size = new System.Drawing.Size(121, 24);
			this.EngineFuel_comboBox.TabIndex = 3;
			this.EngineFuel_comboBox.SelectedIndexChanged += new System.EventHandler(this.Fuel_comboBox_SelectedIndexChanged);
			// 
			// Fuel_label
			// 
			this.Fuel_label.AutoSize = true;
			this.Fuel_label.Location = new System.Drawing.Point(24, 94);
			this.Fuel_label.Name = "Fuel_label";
			this.Fuel_label.Size = new System.Drawing.Size(35, 17);
			this.Fuel_label.TabIndex = 4;
			this.Fuel_label.Text = "Fuel";
			// 
			// EngineCapacity_label
			// 
			this.EngineCapacity_label.AutoSize = true;
			this.EngineCapacity_label.Location = new System.Drawing.Point(24, 166);
			this.EngineCapacity_label.Name = "EngineCapacity_label";
			this.EngineCapacity_label.Size = new System.Drawing.Size(110, 17);
			this.EngineCapacity_label.TabIndex = 6;
			this.EngineCapacity_label.Text = "Engine Capacity";
			// 
			// EngineCapacity_textBox
			// 
			this.EngineCapacity_textBox.Location = new System.Drawing.Point(24, 187);
			this.EngineCapacity_textBox.Name = "EngineCapacity_textBox";
			this.EngineCapacity_textBox.Size = new System.Drawing.Size(121, 22);
			this.EngineCapacity_textBox.TabIndex = 7;
			this.EngineCapacity_textBox.TextChanged += new System.EventHandler(this.EngineCapacity_textBox_TextChanged);
			// 
			// TireType_label
			// 
			this.TireType_label.AutoSize = true;
			this.TireType_label.Location = new System.Drawing.Point(20, 151);
			this.TireType_label.Name = "TireType_label";
			this.TireType_label.Size = new System.Drawing.Size(69, 17);
			this.TireType_label.TabIndex = 12;
			this.TireType_label.Text = "Tire Type";
			// 
			// WheelMaterial_comboBox
			// 
			this.WheelMaterial_comboBox.FormattingEnabled = true;
			this.WheelMaterial_comboBox.Location = new System.Drawing.Point(20, 115);
			this.WheelMaterial_comboBox.Name = "WheelMaterial_comboBox";
			this.WheelMaterial_comboBox.Size = new System.Drawing.Size(121, 24);
			this.WheelMaterial_comboBox.TabIndex = 10;
			this.WheelMaterial_comboBox.SelectedIndexChanged += new System.EventHandler(this.WheelMaterial_comboBox_SelectedIndexChanged);
			// 
			// WheelMaterial_label
			// 
			this.WheelMaterial_label.AutoSize = true;
			this.WheelMaterial_label.Location = new System.Drawing.Point(20, 92);
			this.WheelMaterial_label.Name = "WheelMaterial_label";
			this.WheelMaterial_label.Size = new System.Drawing.Size(102, 17);
			this.WheelMaterial_label.TabIndex = 11;
			this.WheelMaterial_label.Text = "Wheel Material";
			// 
			// WheelNumber_comboBox
			// 
			this.WheelNumber_comboBox.FormattingEnabled = true;
			this.WheelNumber_comboBox.Location = new System.Drawing.Point(20, 55);
			this.WheelNumber_comboBox.Name = "WheelNumber_comboBox";
			this.WheelNumber_comboBox.Size = new System.Drawing.Size(121, 24);
			this.WheelNumber_comboBox.TabIndex = 8;
			this.WheelNumber_comboBox.SelectedIndexChanged += new System.EventHandler(this.WheelNumber_comboBox_SelectedIndexChanged);
			// 
			// WheelNumber_label
			// 
			this.WheelNumber_label.AutoSize = true;
			this.WheelNumber_label.Location = new System.Drawing.Point(20, 32);
			this.WheelNumber_label.Name = "WheelNumber_label";
			this.WheelNumber_label.Size = new System.Drawing.Size(70, 17);
			this.WheelNumber_label.TabIndex = 9;
			this.WheelNumber_label.Text = "Wheel No";
			// 
			// TireType_comboBox
			// 
			this.TireType_comboBox.FormattingEnabled = true;
			this.TireType_comboBox.Location = new System.Drawing.Point(23, 171);
			this.TireType_comboBox.Name = "TireType_comboBox";
			this.TireType_comboBox.Size = new System.Drawing.Size(121, 24);
			this.TireType_comboBox.TabIndex = 13;
			this.TireType_comboBox.SelectedIndexChanged += new System.EventHandler(this.TireType_comboBox_SelectedIndexChanged);
			// 
			// TireWidth_comboBox
			// 
			this.TireWidth_comboBox.FormattingEnabled = true;
			this.TireWidth_comboBox.Location = new System.Drawing.Point(23, 225);
			this.TireWidth_comboBox.Name = "TireWidth_comboBox";
			this.TireWidth_comboBox.Size = new System.Drawing.Size(121, 24);
			this.TireWidth_comboBox.TabIndex = 15;
			this.TireWidth_comboBox.SelectedIndexChanged += new System.EventHandler(this.TireWidth_comboBox_SelectedIndexChanged);
			// 
			// TireWidth_label
			// 
			this.TireWidth_label.AutoSize = true;
			this.TireWidth_label.Location = new System.Drawing.Point(20, 205);
			this.TireWidth_label.Name = "TireWidth_label";
			this.TireWidth_label.Size = new System.Drawing.Size(73, 17);
			this.TireWidth_label.TabIndex = 14;
			this.TireWidth_label.Text = "Tire Width";
			// 
			// TireRatio_comboBox
			// 
			this.TireRatio_comboBox.FormattingEnabled = true;
			this.TireRatio_comboBox.Location = new System.Drawing.Point(23, 278);
			this.TireRatio_comboBox.Name = "TireRatio_comboBox";
			this.TireRatio_comboBox.Size = new System.Drawing.Size(121, 24);
			this.TireRatio_comboBox.TabIndex = 17;
			this.TireRatio_comboBox.SelectedIndexChanged += new System.EventHandler(this.TireRatio_comboBox_SelectedIndexChanged);
			// 
			// TireRatio_label
			// 
			this.TireRatio_label.AutoSize = true;
			this.TireRatio_label.Location = new System.Drawing.Point(20, 258);
			this.TireRatio_label.Name = "TireRatio_label";
			this.TireRatio_label.Size = new System.Drawing.Size(70, 17);
			this.TireRatio_label.TabIndex = 16;
			this.TireRatio_label.Text = "Tire Ratio";
			// 
			// RaceCar_label
			// 
			this.RaceCar_label.AutoSize = true;
			this.RaceCar_label.Location = new System.Drawing.Point(11, 9);
			this.RaceCar_label.Name = "RaceCar_label";
			this.RaceCar_label.Size = new System.Drawing.Size(67, 17);
			this.RaceCar_label.TabIndex = 6;
			this.RaceCar_label.Text = "Race Car";
			// 
			// SportPackage_label
			// 
			this.SportPackage_label.AutoSize = true;
			this.SportPackage_label.Location = new System.Drawing.Point(12, 9);
			this.SportPackage_label.Name = "SportPackage_label";
			this.SportPackage_label.Size = new System.Drawing.Size(97, 17);
			this.SportPackage_label.TabIndex = 4;
			this.SportPackage_label.Text = "SportPackage";
			// 
			// Leather_label
			// 
			this.Leather_label.AutoSize = true;
			this.Leather_label.Location = new System.Drawing.Point(15, 9);
			this.Leather_label.Name = "Leather_label";
			this.Leather_label.Size = new System.Drawing.Size(57, 17);
			this.Leather_label.TabIndex = 2;
			this.Leather_label.Text = "Leather";
			// 
			// BodyType_comboBox
			// 
			this.BodyType_comboBox.FormattingEnabled = true;
			this.BodyType_comboBox.Location = new System.Drawing.Point(27, 117);
			this.BodyType_comboBox.Name = "BodyType_comboBox";
			this.BodyType_comboBox.Size = new System.Drawing.Size(121, 24);
			this.BodyType_comboBox.TabIndex = 3;
			this.BodyType_comboBox.SelectedIndexChanged += new System.EventHandler(this.BodyType_comboBox_SelectedIndexChanged);
			// 
			// BodyType_label
			// 
			this.BodyType_label.AutoSize = true;
			this.BodyType_label.Location = new System.Drawing.Point(27, 94);
			this.BodyType_label.Name = "BodyType_label";
			this.BodyType_label.Size = new System.Drawing.Size(72, 17);
			this.BodyType_label.TabIndex = 4;
			this.BodyType_label.Text = "BodyType";
			// 
			// BodyColour_comboBox
			// 
			this.BodyColour_comboBox.FormattingEnabled = true;
			this.BodyColour_comboBox.Location = new System.Drawing.Point(27, 48);
			this.BodyColour_comboBox.Name = "BodyColour_comboBox";
			this.BodyColour_comboBox.Size = new System.Drawing.Size(121, 24);
			this.BodyColour_comboBox.TabIndex = 0;
			this.BodyColour_comboBox.SelectedIndexChanged += new System.EventHandler(this.BodyColour_comboBox_SelectedIndexChanged);
			// 
			// BodyColour_label
			// 
			this.BodyColour_label.AutoSize = true;
			this.BodyColour_label.Location = new System.Drawing.Point(27, 25);
			this.BodyColour_label.Name = "BodyColour_label";
			this.BodyColour_label.Size = new System.Drawing.Size(49, 17);
			this.BodyColour_label.TabIndex = 2;
			this.BodyColour_label.Text = "Colour";
			// 
			// LigthsType_comboBox
			// 
			this.LigthsType_comboBox.FormattingEnabled = true;
			this.LigthsType_comboBox.Location = new System.Drawing.Point(31, 49);
			this.LigthsType_comboBox.Name = "LigthsType_comboBox";
			this.LigthsType_comboBox.Size = new System.Drawing.Size(121, 24);
			this.LigthsType_comboBox.TabIndex = 0;
			this.LigthsType_comboBox.SelectedIndexChanged += new System.EventHandler(this.LigthsType_comboBox_SelectedIndexChanged);
			// 
			// LigthsType_label
			// 
			this.LigthsType_label.AutoSize = true;
			this.LigthsType_label.Location = new System.Drawing.Point(31, 26);
			this.LigthsType_label.Name = "LigthsType_label";
			this.LigthsType_label.Size = new System.Drawing.Size(78, 17);
			this.LigthsType_label.TabIndex = 2;
			this.LigthsType_label.Text = "LigthsType";
			// 
			// FuelTankMaterial_comboBox
			// 
			this.FuelTankMaterial_comboBox.FormattingEnabled = true;
			this.FuelTankMaterial_comboBox.Location = new System.Drawing.Point(23, 120);
			this.FuelTankMaterial_comboBox.Name = "FuelTankMaterial_comboBox";
			this.FuelTankMaterial_comboBox.Size = new System.Drawing.Size(121, 24);
			this.FuelTankMaterial_comboBox.TabIndex = 3;
			this.FuelTankMaterial_comboBox.SelectedIndexChanged += new System.EventHandler(this.FuelTankMaterial_comboBox_SelectedIndexChanged);
			// 
			// FuelTankMaterial_label
			// 
			this.FuelTankMaterial_label.AutoSize = true;
			this.FuelTankMaterial_label.Location = new System.Drawing.Point(23, 97);
			this.FuelTankMaterial_label.Name = "FuelTankMaterial_label";
			this.FuelTankMaterial_label.Size = new System.Drawing.Size(125, 17);
			this.FuelTankMaterial_label.TabIndex = 4;
			this.FuelTankMaterial_label.Text = "Fuel Tank Material";
			// 
			// FuelCapacity_label
			// 
			this.FuelCapacity_label.AutoSize = true;
			this.FuelCapacity_label.Location = new System.Drawing.Point(23, 28);
			this.FuelCapacity_label.Name = "FuelCapacity_label";
			this.FuelCapacity_label.Size = new System.Drawing.Size(129, 17);
			this.FuelCapacity_label.TabIndex = 2;
			this.FuelCapacity_label.Text = "Fuel Tank Capacity";
			// 
			// GearShiftType_comboBox
			// 
			this.GearShiftType_comboBox.FormattingEnabled = true;
			this.GearShiftType_comboBox.Location = new System.Drawing.Point(25, 50);
			this.GearShiftType_comboBox.Name = "GearShiftType_comboBox";
			this.GearShiftType_comboBox.Size = new System.Drawing.Size(121, 24);
			this.GearShiftType_comboBox.TabIndex = 0;
			this.GearShiftType_comboBox.SelectedIndexChanged += new System.EventHandler(this.GearShiftType_comboBox_SelectedIndexChanged);
			// 
			// GearShiftType_label
			// 
			this.GearShiftType_label.AutoSize = true;
			this.GearShiftType_label.Location = new System.Drawing.Point(25, 27);
			this.GearShiftType_label.Name = "GearShiftType_label";
			this.GearShiftType_label.Size = new System.Drawing.Size(108, 17);
			this.GearShiftType_label.TabIndex = 2;
			this.GearShiftType_label.Text = "Gear Shift Type";
			// 
			// FuelTankCapacity_textBox
			// 
			this.FuelTankCapacity_textBox.Location = new System.Drawing.Point(26, 49);
			this.FuelTankCapacity_textBox.Name = "FuelTankCapacity_textBox";
			this.FuelTankCapacity_textBox.Size = new System.Drawing.Size(118, 22);
			this.FuelTankCapacity_textBox.TabIndex = 5;
			this.FuelTankCapacity_textBox.TextChanged += new System.EventHandler(this.FuelTankCapacity_textBox_TextChanged);
			// 
			// YesLeather_radioButton
			// 
			this.YesLeather_radioButton.AutoSize = true;
			this.YesLeather_radioButton.Location = new System.Drawing.Point(25, 32);
			this.YesLeather_radioButton.Name = "YesLeather_radioButton";
			this.YesLeather_radioButton.Size = new System.Drawing.Size(53, 21);
			this.YesLeather_radioButton.TabIndex = 7;
			this.YesLeather_radioButton.TabStop = true;
			this.YesLeather_radioButton.Text = "Yes";
			this.YesLeather_radioButton.UseVisualStyleBackColor = true;
			this.YesLeather_radioButton.CheckedChanged += new System.EventHandler(this.YesLeather_radioButton_CheckedChanged);
			// 
			// NoLeather_radioButton
			// 
			this.NoLeather_radioButton.AutoSize = true;
			this.NoLeather_radioButton.Location = new System.Drawing.Point(25, 59);
			this.NoLeather_radioButton.Name = "NoLeather_radioButton";
			this.NoLeather_radioButton.Size = new System.Drawing.Size(47, 21);
			this.NoLeather_radioButton.TabIndex = 8;
			this.NoLeather_radioButton.TabStop = true;
			this.NoLeather_radioButton.Text = "No";
			this.NoLeather_radioButton.UseVisualStyleBackColor = true;
			this.NoLeather_radioButton.CheckedChanged += new System.EventHandler(this.NoLeather_radioButton_CheckedChanged);
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.NoLeather_radioButton);
			this.panel7.Controls.Add(this.YesLeather_radioButton);
			this.panel7.Controls.Add(this.Leather_label);
			this.panel7.Location = new System.Drawing.Point(6, 26);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(128, 84);
			this.panel7.TabIndex = 10;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.NoSport_radioButton);
			this.panel8.Controls.Add(this.YesSport_radioButton);
			this.panel8.Controls.Add(this.SportPackage_label);
			this.panel8.Location = new System.Drawing.Point(160, 26);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(128, 84);
			this.panel8.TabIndex = 11;
			// 
			// NoSport_radioButton
			// 
			this.NoSport_radioButton.AutoSize = true;
			this.NoSport_radioButton.Location = new System.Drawing.Point(25, 59);
			this.NoSport_radioButton.Name = "NoSport_radioButton";
			this.NoSport_radioButton.Size = new System.Drawing.Size(47, 21);
			this.NoSport_radioButton.TabIndex = 8;
			this.NoSport_radioButton.TabStop = true;
			this.NoSport_radioButton.Text = "No";
			this.NoSport_radioButton.UseVisualStyleBackColor = true;
			this.NoSport_radioButton.CheckedChanged += new System.EventHandler(this.NoSport_radioButton_CheckedChanged);
			// 
			// YesSport_radioButton
			// 
			this.YesSport_radioButton.AutoSize = true;
			this.YesSport_radioButton.Location = new System.Drawing.Point(25, 32);
			this.YesSport_radioButton.Name = "YesSport_radioButton";
			this.YesSport_radioButton.Size = new System.Drawing.Size(53, 21);
			this.YesSport_radioButton.TabIndex = 7;
			this.YesSport_radioButton.TabStop = true;
			this.YesSport_radioButton.Text = "Yes";
			this.YesSport_radioButton.UseVisualStyleBackColor = true;
			this.YesSport_radioButton.CheckedChanged += new System.EventHandler(this.YesSport_radioButton_CheckedChanged);
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.NoRace_radioButton);
			this.panel9.Controls.Add(this.YesRace_radioButton);
			this.panel9.Controls.Add(this.RaceCar_label);
			this.panel9.Location = new System.Drawing.Point(316, 26);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(128, 84);
			this.panel9.TabIndex = 12;
			// 
			// NoRace_radioButton
			// 
			this.NoRace_radioButton.AutoSize = true;
			this.NoRace_radioButton.Location = new System.Drawing.Point(25, 59);
			this.NoRace_radioButton.Name = "NoRace_radioButton";
			this.NoRace_radioButton.Size = new System.Drawing.Size(47, 21);
			this.NoRace_radioButton.TabIndex = 8;
			this.NoRace_radioButton.TabStop = true;
			this.NoRace_radioButton.Text = "No";
			this.NoRace_radioButton.UseVisualStyleBackColor = true;
			this.NoRace_radioButton.CheckedChanged += new System.EventHandler(this.NoRace_radioButton_CheckedChanged);
			// 
			// YesRace_radioButton
			// 
			this.YesRace_radioButton.AutoSize = true;
			this.YesRace_radioButton.Location = new System.Drawing.Point(25, 32);
			this.YesRace_radioButton.Name = "YesRace_radioButton";
			this.YesRace_radioButton.Size = new System.Drawing.Size(53, 21);
			this.YesRace_radioButton.TabIndex = 7;
			this.YesRace_radioButton.TabStop = true;
			this.YesRace_radioButton.Text = "Yes";
			this.YesRace_radioButton.UseVisualStyleBackColor = true;
			this.YesRace_radioButton.CheckedChanged += new System.EventHandler(this.YesRace_radioButton_CheckedChanged);
			// 
			// Interior_groupBox
			// 
			this.Interior_groupBox.Controls.Add(this.panel9);
			this.Interior_groupBox.Controls.Add(this.panel7);
			this.Interior_groupBox.Controls.Add(this.panel8);
			this.Interior_groupBox.Location = new System.Drawing.Point(247, 289);
			this.Interior_groupBox.Name = "Interior_groupBox";
			this.Interior_groupBox.Size = new System.Drawing.Size(454, 132);
			this.Interior_groupBox.TabIndex = 10;
			this.Interior_groupBox.TabStop = false;
			this.Interior_groupBox.Text = "Interior";
			// 
			// Engine_groupBox
			// 
			this.Engine_groupBox.Controls.Add(this.EngineCapacity_textBox);
			this.Engine_groupBox.Controls.Add(this.EngineCapacity_label);
			this.Engine_groupBox.Controls.Add(this.EngineStroke);
			this.Engine_groupBox.Controls.Add(this.EngineFuel_comboBox);
			this.Engine_groupBox.Controls.Add(this.EngineStroke_comboBox);
			this.Engine_groupBox.Controls.Add(this.Fuel_label);
			this.Engine_groupBox.Location = new System.Drawing.Point(593, 21);
			this.Engine_groupBox.Name = "Engine_groupBox";
			this.Engine_groupBox.Size = new System.Drawing.Size(165, 237);
			this.Engine_groupBox.TabIndex = 11;
			this.Engine_groupBox.TabStop = false;
			this.Engine_groupBox.Text = "Engine";
			// 
			// Wheelskit_groupBox
			// 
			this.Wheelskit_groupBox.Controls.Add(this.TireRatio_comboBox);
			this.Wheelskit_groupBox.Controls.Add(this.TireType_label);
			this.Wheelskit_groupBox.Controls.Add(this.TireRatio_label);
			this.Wheelskit_groupBox.Controls.Add(this.WheelNumber_label);
			this.Wheelskit_groupBox.Controls.Add(this.TireWidth_comboBox);
			this.Wheelskit_groupBox.Controls.Add(this.WheelNumber_comboBox);
			this.Wheelskit_groupBox.Controls.Add(this.TireWidth_label);
			this.Wheelskit_groupBox.Controls.Add(this.WheelMaterial_label);
			this.Wheelskit_groupBox.Controls.Add(this.TireType_comboBox);
			this.Wheelskit_groupBox.Controls.Add(this.WheelMaterial_comboBox);
			this.Wheelskit_groupBox.Location = new System.Drawing.Point(26, 187);
			this.Wheelskit_groupBox.Name = "Wheelskit_groupBox";
			this.Wheelskit_groupBox.Size = new System.Drawing.Size(173, 322);
			this.Wheelskit_groupBox.TabIndex = 12;
			this.Wheelskit_groupBox.TabStop = false;
			this.Wheelskit_groupBox.Text = "Wheels Kit";
			// 
			// Body_groupBox
			// 
			this.Body_groupBox.Controls.Add(this.BodyMaterial_comboBox);
			this.Body_groupBox.Controls.Add(this.BodyType_comboBox);
			this.Body_groupBox.Controls.Add(this.BodyMaterial_label);
			this.Body_groupBox.Controls.Add(this.BodyType_label);
			this.Body_groupBox.Controls.Add(this.BodyColour_label);
			this.Body_groupBox.Controls.Add(this.BodyColour_comboBox);
			this.Body_groupBox.Location = new System.Drawing.Point(217, 21);
			this.Body_groupBox.Name = "Body_groupBox";
			this.Body_groupBox.Size = new System.Drawing.Size(170, 237);
			this.Body_groupBox.TabIndex = 13;
			this.Body_groupBox.TabStop = false;
			this.Body_groupBox.Text = "Body";
			// 
			// BodyMaterial_comboBox
			// 
			this.BodyMaterial_comboBox.FormattingEnabled = true;
			this.BodyMaterial_comboBox.Location = new System.Drawing.Point(27, 189);
			this.BodyMaterial_comboBox.Name = "BodyMaterial_comboBox";
			this.BodyMaterial_comboBox.Size = new System.Drawing.Size(121, 24);
			this.BodyMaterial_comboBox.TabIndex = 18;
			this.BodyMaterial_comboBox.SelectedIndexChanged += new System.EventHandler(this.BodyMaterial_comboBox_SelectedIndexChanged);
			// 
			// BodyMaterial_label
			// 
			this.BodyMaterial_label.AutoSize = true;
			this.BodyMaterial_label.Location = new System.Drawing.Point(27, 166);
			this.BodyMaterial_label.Name = "BodyMaterial_label";
			this.BodyMaterial_label.Size = new System.Drawing.Size(94, 17);
			this.BodyMaterial_label.TabIndex = 19;
			this.BodyMaterial_label.Text = "Body Material";
			// 
			// FuelTank_groupBox
			// 
			this.FuelTank_groupBox.Controls.Add(this.FuelTankCapacity_textBox);
			this.FuelTank_groupBox.Controls.Add(this.FuelTankMaterial_label);
			this.FuelTank_groupBox.Controls.Add(this.FuelTankMaterial_comboBox);
			this.FuelTank_groupBox.Controls.Add(this.FuelCapacity_label);
			this.FuelTank_groupBox.Location = new System.Drawing.Point(410, 21);
			this.FuelTank_groupBox.Name = "FuelTank_groupBox";
			this.FuelTank_groupBox.Size = new System.Drawing.Size(169, 154);
			this.FuelTank_groupBox.TabIndex = 14;
			this.FuelTank_groupBox.TabStop = false;
			this.FuelTank_groupBox.Text = "Fuel Tank";
			// 
			// GearShift_groupBox
			// 
			this.GearShift_groupBox.Controls.Add(this.GearShiftType_comboBox);
			this.GearShift_groupBox.Controls.Add(this.GearShiftType_label);
			this.GearShift_groupBox.Location = new System.Drawing.Point(764, 115);
			this.GearShift_groupBox.Name = "GearShift_groupBox";
			this.GearShift_groupBox.Size = new System.Drawing.Size(175, 100);
			this.GearShift_groupBox.TabIndex = 15;
			this.GearShift_groupBox.TabStop = false;
			this.GearShift_groupBox.Text = "Gear Shift";
			// 
			// Lights_groupBox
			// 
			this.Lights_groupBox.Controls.Add(this.LigthsType_comboBox);
			this.Lights_groupBox.Controls.Add(this.LigthsType_label);
			this.Lights_groupBox.Location = new System.Drawing.Point(764, 12);
			this.Lights_groupBox.Name = "Lights_groupBox";
			this.Lights_groupBox.Size = new System.Drawing.Size(175, 100);
			this.Lights_groupBox.TabIndex = 16;
			this.Lights_groupBox.TabStop = false;
			this.Lights_groupBox.Text = "Lights";
			// 
			// Manufacturer_groupBox
			// 
			this.Manufacturer_groupBox.Controls.Add(this.Manufacturer_comboBox);
			this.Manufacturer_groupBox.Controls.Add(this.Manufacturer_label);
			this.Manufacturer_groupBox.Location = new System.Drawing.Point(32, 21);
			this.Manufacturer_groupBox.Name = "Manufacturer_groupBox";
			this.Manufacturer_groupBox.Size = new System.Drawing.Size(167, 100);
			this.Manufacturer_groupBox.TabIndex = 17;
			this.Manufacturer_groupBox.TabStop = false;
			this.Manufacturer_groupBox.Text = "Manufacturer";
			// 
			// Manufacturer_comboBox
			// 
			this.Manufacturer_comboBox.FormattingEnabled = true;
			this.Manufacturer_comboBox.Location = new System.Drawing.Point(21, 50);
			this.Manufacturer_comboBox.Name = "Manufacturer_comboBox";
			this.Manufacturer_comboBox.Size = new System.Drawing.Size(121, 24);
			this.Manufacturer_comboBox.TabIndex = 3;
			this.Manufacturer_comboBox.SelectedIndexChanged += new System.EventHandler(this.Manufacturer_comboBox_SelectedIndexChanged);
			// 
			// Manufacturer_label
			// 
			this.Manufacturer_label.AutoSize = true;
			this.Manufacturer_label.Location = new System.Drawing.Point(21, 27);
			this.Manufacturer_label.Name = "Manufacturer_label";
			this.Manufacturer_label.Size = new System.Drawing.Size(92, 17);
			this.Manufacturer_label.TabIndex = 4;
			this.Manufacturer_label.Text = "Manufacturer";
			// 
			// CarName_textBox
			// 
			this.CarName_textBox.Location = new System.Drawing.Point(253, 465);
			this.CarName_textBox.Name = "CarName_textBox";
			this.CarName_textBox.Size = new System.Drawing.Size(100, 22);
			this.CarName_textBox.TabIndex = 18;
			// 
			// CarName_label
			// 
			this.CarName_label.AutoSize = true;
			this.CarName_label.Location = new System.Drawing.Point(253, 442);
			this.CarName_label.Name = "CarName_label";
			this.CarName_label.Size = new System.Drawing.Size(71, 17);
			this.CarName_label.TabIndex = 19;
			this.CarName_label.Text = "Car Name";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(993, 696);
			this.Controls.Add(this.CarName_label);
			this.Controls.Add(this.CarName_textBox);
			this.Controls.Add(this.Manufacturer_groupBox);
			this.Controls.Add(this.Lights_groupBox);
			this.Controls.Add(this.GearShift_groupBox);
			this.Controls.Add(this.FuelTank_groupBox);
			this.Controls.Add(this.Body_groupBox);
			this.Controls.Add(this.Wheelskit_groupBox);
			this.Controls.Add(this.Engine_groupBox);
			this.Controls.Add(this.Interior_groupBox);
			this.Controls.Add(this.CreateCar_button);
			this.Name = "Form1";
			this.Text = "CarFactory";
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.Interior_groupBox.ResumeLayout(false);
			this.Engine_groupBox.ResumeLayout(false);
			this.Engine_groupBox.PerformLayout();
			this.Wheelskit_groupBox.ResumeLayout(false);
			this.Wheelskit_groupBox.PerformLayout();
			this.Body_groupBox.ResumeLayout(false);
			this.Body_groupBox.PerformLayout();
			this.FuelTank_groupBox.ResumeLayout(false);
			this.FuelTank_groupBox.PerformLayout();
			this.GearShift_groupBox.ResumeLayout(false);
			this.GearShift_groupBox.PerformLayout();
			this.Lights_groupBox.ResumeLayout(false);
			this.Lights_groupBox.PerformLayout();
			this.Manufacturer_groupBox.ResumeLayout(false);
			this.Manufacturer_groupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox EngineStroke_comboBox;
		private System.Windows.Forms.Button CreateCar_button;
		private System.Windows.Forms.Label EngineStroke;
		private System.Windows.Forms.TextBox EngineCapacity_textBox;
		private System.Windows.Forms.Label EngineCapacity_label;
		private System.Windows.Forms.ComboBox EngineFuel_comboBox;
		private System.Windows.Forms.Label Fuel_label;
		private System.Windows.Forms.Label TireType_label;
		private System.Windows.Forms.ComboBox WheelMaterial_comboBox;
		private System.Windows.Forms.Label WheelMaterial_label;
		private System.Windows.Forms.ComboBox WheelNumber_comboBox;
		private System.Windows.Forms.Label WheelNumber_label;
		private System.Windows.Forms.ComboBox TireWidth_comboBox;
		private System.Windows.Forms.Label TireWidth_label;
		private System.Windows.Forms.ComboBox TireType_comboBox;
		private System.Windows.Forms.ComboBox TireRatio_comboBox;
		private System.Windows.Forms.Label TireRatio_label;
		private System.Windows.Forms.Label RaceCar_label;
		private System.Windows.Forms.Label SportPackage_label;
		private System.Windows.Forms.Label Leather_label;
		private System.Windows.Forms.ComboBox BodyType_comboBox;
		private System.Windows.Forms.Label BodyType_label;
		private System.Windows.Forms.ComboBox BodyColour_comboBox;
		private System.Windows.Forms.Label BodyColour_label;
		private System.Windows.Forms.ComboBox LigthsType_comboBox;
		private System.Windows.Forms.Label LigthsType_label;
		private System.Windows.Forms.ComboBox FuelTankMaterial_comboBox;
		private System.Windows.Forms.Label FuelTankMaterial_label;
		private System.Windows.Forms.Label FuelCapacity_label;
		private System.Windows.Forms.ComboBox GearShiftType_comboBox;
		private System.Windows.Forms.Label GearShiftType_label;
		private System.Windows.Forms.TextBox FuelTankCapacity_textBox;
		private System.Windows.Forms.RadioButton YesLeather_radioButton;
		private System.Windows.Forms.RadioButton NoLeather_radioButton;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.RadioButton NoSport_radioButton;
		private System.Windows.Forms.RadioButton YesSport_radioButton;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.RadioButton NoRace_radioButton;
		private System.Windows.Forms.RadioButton YesRace_radioButton;
		private System.Windows.Forms.GroupBox Interior_groupBox;
		private System.Windows.Forms.GroupBox Engine_groupBox;
		private System.Windows.Forms.GroupBox Wheelskit_groupBox;
		private System.Windows.Forms.GroupBox Body_groupBox;
		private System.Windows.Forms.GroupBox FuelTank_groupBox;
		private System.Windows.Forms.GroupBox GearShift_groupBox;
		private System.Windows.Forms.GroupBox Lights_groupBox;
		private System.Windows.Forms.GroupBox Manufacturer_groupBox;
		private System.Windows.Forms.ComboBox Manufacturer_comboBox;
		private System.Windows.Forms.Label Manufacturer_label;
		private System.Windows.Forms.ComboBox BodyMaterial_comboBox;
		private System.Windows.Forms.Label BodyMaterial_label;
		private System.Windows.Forms.TextBox CarName_textBox;
		private System.Windows.Forms.Label CarName_label;
	}
}

