namespace Conventor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double value = 0;
        public static class units
        {

            public static string[] lengthunits = {
                      " Nanometer (nm) "
                    , " Micrometer (µm) "
                    , " Millimeter (mm) "
                    , " Centimeter (cm)"
                    , " Meter (m)"
                    , " Kilometer (km)"
                    , " Inch (in)"
                    , " Foot (ft)"
                    , " Yard (yd)"
                    , " Mile (mi)"
            };

            public static string[] areaunits = {
                     "square kilometer (km²)"
                    ,"square hectometer (hm²)"
                    ,"square decameter (dam²)"
                    ,"square meter (m²)"
                    ,"square decimeter (dm²)"
                    ,"square centimeter (m²)"
                    ,"square millimeter (mm²)"
            };

            public static string[] volumeunits = {
                     "liter (L)"
                    ,"milliliter (mL)"
                    ,"cubic meter (m³)"
                    ,"cubic centimeter (cm³)"
                    ,"gallon"
                    ,"cubic feet (ft³)"
                    ,"cubic inch (in³)"
            };

            public static string[] Weightandmassunits = {
                     "kilograms (kg)"
                    ,"grams (g)"
                    ,"milligrams (mg)"
                    ,"tons (ton)"
                    ,"pounds (lb)"
                    ,"ounces (oz)"
            };

            public static string[] timeunits = {
                     "second(s)"
                    ,"minutes (.min)"
                    ,"hour (h)"
                    ,"day"
                    ,"week"
                    ,"months"
                    ,"year"
            };

            public static string[] temperatureunits = {
                     "Celsius (°C)"
                    ,"Fahrenheit (°F)"
                    ,"Kelvin (K)"
            };

            public static string[] energyunits = {
                     "Joule (J)"
                    ,"calories (cal)"
                    ,"Kilowatt hours (kWh)"
                    ,"BTU"
                    ,"foot pound"
            };

            public static string[] pressureunits = {
                     "Pascal (Pa)"
                    ,"bar"
                    ,"Centimeters of mercury (cmHg)"
                    ,"mercury meter (mHg)"
                    ,"atmosphere (atm)"
            };

            public static string[] speedunits = {
                     "meters per second (m/s)"
                    ,"kilometers per hour (km/h)"
                    ,"miles per hour (mph)"
            };

            public static string[] dataunits = {
                    " byte (b)"
                    ,"Byte (B)"
                    ,"Kilobyte (KB)"
                    ,"Megabyte (MB)"
                    ,"Gigabyte (GB)"
                    ,"Terabyte (TB)"
                    ,"Petabyte PB"
            };

            public static string[] numeralsystemunits = {
                     "Binary (BIN)"
                    ,"Octal (OCT)"
                    ,"Decimal (DEC)"
                    ,"Hexadecimal (HEX)"
            };





        }
        private void lengthmenu_Click(object sender, EventArgs e)
        {

            inputlistbox.Items.Clear();
            putputlistbox.Items.Clear();
            inputlistbox.Items.AddRange(units.lengthunits);
            putputlistbox.Items.AddRange(units.lengthunits);


        }

        private void areamenu_Click(object sender, EventArgs e)
        {
            inputlistbox.Items.Clear();
            putputlistbox.Items.Clear();
            inputlistbox.Items.AddRange(units.areaunits);
            putputlistbox.Items.AddRange(units.areaunits);

        }

        private void volumemenu_Click(object sender, EventArgs e)
        {
            inputlistbox.Items.Clear();
            putputlistbox.Items.Clear();
            inputlistbox.Items.AddRange(units.volumeunits);
            putputlistbox.Items.AddRange(units.volumeunits);
        }

        private void Weightandmassmenu_Click(object sender, EventArgs e)
        {
            inputlistbox.Items.Clear();
            putputlistbox.Items.Clear();
            inputlistbox.Items.AddRange(units.Weightandmassunits);
            putputlistbox.Items.AddRange(units.Weightandmassunits);
        }

        private void timemenu_Click(object sender, EventArgs e)
        {
            inputlistbox.Items.Clear();
            putputlistbox.Items.Clear();
            inputlistbox.Items.AddRange(units.timeunits);
            putputlistbox.Items.AddRange(units.timeunits);
        }

        private void temperaturemenu_Click(object sender, EventArgs e)
        {
            inputlistbox.Items.Clear();
            putputlistbox.Items.Clear();
            inputlistbox.Items.AddRange(units.temperatureunits);
            putputlistbox.Items.AddRange(units.temperatureunits);
        }

        private void energymenu_Click(object sender, EventArgs e)
        {
            inputlistbox.Items.Clear();
            putputlistbox.Items.Clear();
            inputlistbox.Items.AddRange(units.energyunits);
            putputlistbox.Items.AddRange(units.energyunits);
        }

        private void pressuremenu_Click(object sender, EventArgs e)
        {
            inputlistbox.Items.Clear();
            putputlistbox.Items.Clear();
            inputlistbox.Items.AddRange(units.pressureunits);
            putputlistbox.Items.AddRange(units.pressureunits);
        }

        private void speedmenu_Click(object sender, EventArgs e)
        {
            inputlistbox.Items.Clear();
            putputlistbox.Items.Clear();
            inputlistbox.Items.AddRange(units.speedunits);
            putputlistbox.Items.AddRange(units.speedunits);
        }

        private void datamenu_Click(object sender, EventArgs e)
        {
            inputlistbox.Items.Clear();
            putputlistbox.Items.Clear();
            inputlistbox.Items.AddRange(units.dataunits);
            putputlistbox.Items.AddRange(units.dataunits);
        }

        private void numeralsystemmenu_Click(object sender, EventArgs e)
        {
            inputlistbox.Items.Clear();
            putputlistbox.Items.Clear();
            inputlistbox.Items.AddRange(units.numeralsystemunits);
            putputlistbox.Items.AddRange(units.numeralsystemunits);
        }

        private void calculaotrbtn_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            // this.Close();
            this.Hide();
        }

        private void copybtn_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("چیزی برای کپی کردن وجود ندارد", "خطا");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void x2btn_Click(object sender, EventArgs e)
        {

            value = value * 2;
            textBox1.Text = value.ToString();
        }

        private void x3btn_Click(object sender, EventArgs e)
        {
            value = value * 3;
            textBox1.Text = value.ToString();
        }

        private void x10btn_Click(object sender, EventArgs e)
        {
            value = value * 10;
            textBox1.Text = value.ToString();
        }

        private void x5btn_Click(object sender, EventArgs e)
        {
            value = value * 5;
            textBox1.Text = value.ToString();
        }

        private void x100btn_Click(object sender, EventArgs e)
        {
            value = value * 100;
            textBox1.Text = value.ToString();
        }

        private void x1000btn_Click(object sender, EventArgs e)
        {
            value = value * 1000;
            textBox1.Text = value.ToString();
        }

        private void convertbtn_Click(object sender, EventArgs e)
        {

        }
    }
}