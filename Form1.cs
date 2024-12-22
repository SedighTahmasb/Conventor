namespace Conventor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal convertNum;
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
            if (textBox1.Text != "" && textBox1.Text != "0")
            {
                try
                {
                      convertNum = decimal.Parse(textBox1.Text);
                }
                catch
                {
                    MessageBox.Show("عدد قابل تبدیل نیست", "خطا");
                }
                if (inputlistbox.SelectedIndex != -1 && putputlistbox.SelectedIndex != -1)
                {
                    string fromUnit = inputlistbox.SelectedItem.ToString();
                    string toUnit = putputlistbox.SelectedItem.ToString();
                    string conversionFormula;
                    decimal result = ConvertUnits(convertNum,fromUnit, toUnit, out conversionFormula);
                    textBox.Text = FormatResult(result);
                    formulatextBox.Text = conversionFormula;

                }
                else
                {
                    MessageBox.Show("ابتدا واحد مبدا و مقصد را مشخص کنید", "خطا");

                }
            }
            else
            {
                MessageBox.Show("لطفا یک عدد غیر صفر وارد کنید", "خطا");
            }
        }

        private decimal ConvertUnits(decimal value, string fromUnit, string toUnit, out string formula)
        {
            decimal baseUnit = value;
            formula = "";

            switch (fromUnit.Trim())
            {
                case "Nanometer (nm)":
                    baseUnit = value * 1e-9m;
                    formula += $"{value} نانومتر معادل {baseUnit} متر است.\n";
                    break;
                case "Micrometer (µm)":
                    baseUnit = value * 1e-6m; 
                    formula += $"{value} میکرومتر معادل {baseUnit} متر است.\n";
                    break;
                case "Millimeter (mm)":
                    baseUnit = value * 1e-3m;
                    formula += $"{value} میلی‌متر معادل {baseUnit} متر است.\n";
                    break;
                case "Centimeter (cm)":
                    baseUnit = value * 1e-2m;
                    formula += $"{value} سانتی‌متر معادل {baseUnit} متر است.\n";
                    break;
                case "Meter (m)":
                    baseUnit = value;
                    formula += $"{value} متر همان {baseUnit} متر است.\n";
                    break;
                case "Kilometer (km)":
                    baseUnit = value * 1e3m;
                    formula += $"{value} کیلومتر معادل {baseUnit} متر است.\n";
                    break;
                case "Inch (in)":
                    baseUnit = value * 0.0254m; 
                    formula += $"{value} اینچ معادل {baseUnit} متر است.\n";
                    break;
                case "Foot (ft)":
                    baseUnit = value * 0.3048m; 
                    formula += $"{value} فوت معادل {baseUnit} متر است.\n";
                    break;
                case "Yard (yd)":
                    baseUnit = value * 0.9144m; 
                    formula += $"{value} یارد معادل {baseUnit} متر است.\n";
                    break;
                case "Mile (mi)":
                    baseUnit = value * 1609.34m; 
                    formula += $"{value} مایل معادل {baseUnit} متر است.\n";
                    break;

                // زمان
                case "second(s)":
                    baseUnit = value;
                    formula += $"{value} ثانیه همان {baseUnit} ثانیه است.\n";
                    break;
                case "minutes (.min)":
                    baseUnit = value * 60m;
                    formula += $"{value} دقیقه معادل {baseUnit} ثانیه است.\n";
                    break;
                case "hour (h)":
                    baseUnit = value * 3600m;
                    formula += $"{value} ساعت معادل {baseUnit} ثانیه است.\n";
                    break;
                case "day":
                    baseUnit = value * 86400m;
                    formula += $"{value} روز معادل {baseUnit} ثانیه است.\n";
                    break;
                case "week":
                    baseUnit = value * 604800m;
                    formula += $"{value} هفته معادل {baseUnit} ثانیه است.\n";
                    break;
                case "months":
                    baseUnit = value * 2629800m;
                    formula += $"{value} ماه معادل {baseUnit} ثانیه است.\n";
                    break;
                case "year":
                    baseUnit = value * 31557600m; 
                    formula += $"{value} سال معادل {baseUnit} ثانیه است.\n";
                    break;
            }

            decimal result = baseUnit;
            switch (toUnit.Trim())
            {
                // طول
                case "Nanometer (nm)":
                    result = baseUnit / 1e-9m; 
                    formula += $"برای تبدیل به نانومتر، {baseUnit} متر را بر 1e-9 تقسیم می‌کنیم: نتیجه = {result} نانومتر.";
                    break;
                case "Micrometer (µm)":
                    result = baseUnit / 1e-6m; 
                    formula += $"برای تبدیل به میکرومتر، {baseUnit} متر را بر 1e-6 تقسیم می‌کنیم: نتیجه = {result} میکرومتر.";
                    break;
                case "Millimeter (mm)":
                    result = baseUnit / 1e-3m;
                    formula += $"برای تبدیل به میلی‌متر، {baseUnit} متر را بر 1e-3 تقسیم می‌کنیم: نتیجه = {result} میلی‌متر.";
                    break;
                case "Centimeter (cm)":
                    result = baseUnit / 1e-2m; 
                    formula += $"برای تبدیل به سانتی‌متر، {baseUnit} متر را بر 1e-2 تقسیم می‌کنیم: نتیجه = {result} سانتی‌متر.";
                    break;
                case "Meter (m)":
                    result = baseUnit; 
                    formula += $"نتیجه نهایی همان {result} متر است.";
                    break;
                case "Kilometer (km)":
                    result = baseUnit / 1e3m;
                    formula += $"برای تبدیل به کیلومتر، {baseUnit} متر را بر 1e3 تقسیم می‌کنیم: نتیجه = {result} کیلومتر.";
                    break;
                case "Inch (in)":
                    result = baseUnit / 0.0254m; 
                    formula += $"برای تبدیل به اینچ، {baseUnit} متر را بر 0.0254 تقسیم می‌کنیم: نتیجه = {result} اینچ.";
                    break;
                case "Foot (ft)":
                    result = baseUnit / 0.3048m; 
                    formula += $"برای تبدیل به فوت، {baseUnit} متر را بر 0.3048 تقسیم می‌کنیم: نتیجه = {result} فوت.";
                    break;
                case "Yard (yd)":
                    result = baseUnit / 0.9144m; 
                    formula += $"برای تبدیل به یارد، {baseUnit} متر را بر 0.9144 تقسیم می‌کنیم: نتیجه = {result} یارد.";
                    break;
                case "Mile (mi)":
                    result = baseUnit / 1609.34m; 
                    formula += $"برای تبدیل به مایل، {baseUnit} متر را بر 1609.34 تقسیم می‌کنیم: نتیجه = {result} مایل.";
                    break;

                case "second(s)":
                    result = baseUnit;
                    formula += $"نتیجه نهایی همان {result} ثانیه است.";
                    break;
                case "minutes (.min)":
                    result = baseUnit / 60m;
                    formula += $"برای تبدیل به دقیقه، {baseUnit} ثانیه را بر 60 تقسیم می‌کنیم: نتیجه = {result} دقیقه.";
                    break;
                case "hour (h)":
                    result = baseUnit / 3600m;
                    formula += $"برای تبدیل به ساعت، {baseUnit} ثانیه را بر 3600 تقسیم می‌کنیم: نتیجه = {result} ساعت.";
                    break;
                case "day":
                    result = baseUnit / 86400m;
                    formula += $"برای تبدیل به روز، {baseUnit} ثانیه را بر 86400 تقسیم می‌کنیم: نتیجه = {result} روز.";
                    break;
                case "week":
                    result = baseUnit / 604800m;
                    formula += $"برای تبدیل به هفته، {baseUnit} ثانیه را بر 604800 تقسیم می‌کنیم: نتیجه = {result} هفته.";
                    break;
                case "months":
                    result = baseUnit / 2629800m;
                    formula += $"برای تبدیل به ماه، {baseUnit} ثانیه را بر 2629800 تقسیم می‌کنیم: نتیجه = {result} ماه.";
                    break;
                case "year":
                    result = baseUnit / 31557600m; 
                    formula += $"برای تبدیل به سال، {baseUnit} ثانیه را بر 31557600 تقسیم می‌کنیم: نتیجه = {result} سال.";
                    break;
            }

            return result;
        }




        private string FormatResult(decimal result)
        {
            string resultString = result.ToString();

            int totalDigits = resultString.Replace(".", "").Replace("-", "").Length;

            if (totalDigits > 26)
            {
                resultString = resultString.Substring(0, 26);
            }

            if (result % 1 == 0)
            {
                return result.ToString("F0");
            }

            return resultString;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }
    }
}