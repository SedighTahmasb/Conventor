namespace Conventor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double result;
        bool errorCheck;

        double convertNum;
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
                    ,"Hexadouble (HEX)"
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
            form.ShowDialog();
            // this.Close();
            this.Hide();

        }

        private void copybtn_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBox.Text);
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
            try
            {
                value = Convert.ToDouble(textBox1.Text);

                value = value * 2;
                textBox1.Text = value.ToString();
            }
            catch
            {
                MessageBox.Show("عددی برای ضرب وجود ندارد", "خطا");
            }
        }

        private void x3btn_Click(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToDouble(textBox1.Text);

                value = value * 3;
                textBox1.Text = value.ToString();
            }
            catch
            {
                MessageBox.Show("عددی برای ضرب وجود ندارد", "خطا");

            }
        }

        private void x10btn_Click(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToDouble(textBox1.Text);

                value = value * 10;
                textBox1.Text = value.ToString();
            }
            catch
            {
                MessageBox.Show("عددی برای ضرب وجود ندارد", "خطا");

            }
        }

        private void x5btn_Click(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToDouble(textBox1.Text);

                value = value * 5;
                textBox1.Text = value.ToString();
            }
            catch
            {
                MessageBox.Show("عددی برای ضرب وجود ندارد", "خطا");

            }
        }

        private void x100btn_Click(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToDouble(textBox1.Text);

                value = value * 100;
                textBox1.Text = value.ToString();
            }
            catch
            {
                MessageBox.Show("عددی برای ضرب وجود ندارد", "خطا");

            }
        }

        private void x1000btn_Click(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToDouble(textBox1.Text);

                value = value * 1000;
                textBox1.Text = value.ToString();
            }
            catch
            {
                MessageBox.Show("عددی برای ضرب وجود ندارد", "خطا");

            }
        }

        private void convertbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "0")
            {
                try
                {
                    convertNum = double.Parse(textBox1.Text);
                }
                catch
                {
                    MessageBox.Show("فرمت عدد نامعتبر است", "خطا");
                }




                if (inputlistbox.SelectedIndex != -1 && putputlistbox.SelectedIndex != -1)
                {
                    string fromUnit = inputlistbox.SelectedItem.ToString();
                    string toUnit = putputlistbox.SelectedItem.ToString();
                    string conversionFormula;
                    double result = ConvertUnits(convertNum, fromUnit, toUnit, out conversionFormula);

                    textBox.Text = FormatResult(result);
                  

                    if (putputlistbox.SelectedItem == "Binary (BIN)")
                    {
                        if (double.Parse(textBox1.Text) >= 0 && double.Parse(textBox1.Text) <= 255)
                        {
                            string input = textBox.Text;

                            if (int.TryParse(input, out int number))
                            {

                                string paddedNumber = number.ToString("D8").PadLeft(8, '0');

                                textBox.Text = paddedNumber.Substring(0, 8);
                            }
                        }
                        else
                        {
                            MessageBox.Show("خطای محاسباتی.لطفا برای محاسبه صحیح عددی بین 0 تا 255 وارد کنید", "خطا");
                            textBox1.Text = "";
                            textBox.Text = "";
                            formulatextBox.Text = "";
                            return;
                        }
                    }
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

        private double ConvertUnits(double value, string fromUnit, string toUnit, out string formula)
        {
            double baseUnit = value;
            formula = "";
            try
            {
                switch (fromUnit.Trim())
                {
                    case "Nanometer (nm)":
                        baseUnit = value * 1e-9;
                        formula += $"{value} نانومتر معادل {baseUnit} متر است.\n";
                        break;
                    case "Micrometer (µm)":
                        baseUnit = value * 1e-6;
                        formula += $"{value} میکرومتر معادل {baseUnit} متر است.\n";
                        break;
                    case "Millimeter (mm)":
                        baseUnit = value * 1e-3;
                        formula += $"{value} میلی‌متر معادل {baseUnit} متر است.\n";
                        break;
                    case "Centimeter (cm)":
                        baseUnit = value * 1e-2;
                        formula += $"{value} سانتی‌متر معادل {baseUnit} متر است.\n";
                        break;
                    case "Meter (m)":
                        baseUnit = value;
                        formula += $"{value} متر همان {baseUnit} متر است.\n";
                        break;
                    case "Kilometer (km)":
                        baseUnit = value * 1e3;
                        formula += $"{value} کیلومتر معادل {baseUnit} متر است.\n";
                        break;
                    case "Inch (in)":
                        baseUnit = value * 0.0254;
                        formula += $"{value} اینچ معادل {baseUnit} متر است.\n";
                        break;
                    case "Foot (ft)":
                        baseUnit = value * 0.3048;
                        formula += $"{value} فوت معادل {baseUnit} متر است.\n";
                        break;
                    case "Yard (yd)":
                        baseUnit = value * 0.9144;
                        formula += $"{value} یارد معادل {baseUnit} متر است.\n";
                        break;
                    case "Mile (mi)":
                        baseUnit = value * 1609.34;
                        formula += $"{value} مایل معادل {baseUnit} متر است.\n";
                        break;

                    // زمان
                    case "second(s)":
                        baseUnit = value;
                        formula += $"{value} ثانیه همان {baseUnit} ثانیه است.\n";
                        break;
                    case "minutes (.min)":
                        baseUnit = value * 60;
                        formula += $"{value} دقیقه معادل {baseUnit} ثانیه است.\n";
                        break;
                    case "hour (h)":
                        baseUnit = value * 3600;
                        formula += $"{value} ساعت معادل {baseUnit} ثانیه است.\n";
                        break;
                    case "day":
                        baseUnit = value * 86400;
                        formula += $"{value} روز معادل {baseUnit} ثانیه است.\n";
                        break;
                    case "week":
                        baseUnit = value * 604800;
                        formula += $"{value} هفته معادل {baseUnit} ثانیه است.\n";
                        break;
                    case "months":
                        baseUnit = value * 2629800;
                        formula += $"{value} ماه معادل {baseUnit} ثانیه است.\n";
                        break;
                    case "year":
                        baseUnit = value * 31557600;
                        formula += $"{value} سال معادل {baseUnit} ثانیه است.\n";
                        break;
                    //حافظه



                    case " byte (b)":
                        baseUnit = value;
                        formula += $"{value} بیت همان {baseUnit} بیت است.\n";
                        break;
                    case "Byte (B)":
                        baseUnit = value * 8;
                        formula += $"{value} بایت معادل {baseUnit} بیت است.\n";
                        break;
                    case "Kilobyte (KB)":
                        baseUnit = value * 8e3;
                        formula += $"{value} کیلوبایت معادل {baseUnit} بیت است.\n";
                        break;
                    case "Megabyte (MB)":
                        baseUnit = value * 8e6;
                        formula += $"{value} مگابایت معادل {baseUnit} بیت است.\n";
                        break;
                    case "Gigabyte (GB)":
                        baseUnit = value * 8e9;
                        formula += $"{value} گیگابایت معادل {baseUnit} بیت است.\n";
                        break;
                    case "Terabyte (TB)":
                        baseUnit = value * 8e12;
                        formula += $"{value} ترابایت معادل {baseUnit} بیت است.\n";
                        break;
                    case "Petabyte PB":
                        baseUnit = value * 8e15;
                        formula += $"{value} پتابایت معادل {baseUnit} بیت است.\n";
                        break;

                    // تبدیل واحدهای سرعت به متر بر ثانیه
                    case "meters per second (m/s)":
                        baseUnit = value;
                        formula += $"{value} متر بر ثانیه همان {baseUnit} متر بر ثانیه است.\n";
                        break;
                    case "kilometers per hour (km/h)":
                        baseUnit = value * (1e3 / 3.6e3); 
                        formula += $"{value} کیلومتر بر ساعت معادل {baseUnit} متر بر ثانیه است.\n";
                        break;
                    case "miles per hour (mph)":
                        baseUnit = value * (160 / 3600.0); 
                        formula += $"{value} مایل بر ساعت معادل {baseUnit} متر بر ثانیه است.\n";
                        break;

                    // تبدیل دما
                    case "Celsius (°C)":
                        baseUnit = value; 
                        formula += $"{value} درجه سلسیوس همان {baseUnit} درجه سلسیوس است.\n";
                        break;
                    case "Fahrenheit (°F)":
                        baseUnit = (value - 32) * 5 / 9; 
                        formula += $"{value} درجه فارنهایت معادل {baseUnit} درجه سلسیوس است.\n";
                        break;
                    case "Kelvin (K)":
                        baseUnit = value - 273.15; 
                        formula += $"{value} کلوین معادل {baseUnit} درجه سلسیوس است.\n";
                        break;

                    // تبدیل وزن و جرم
                    case "kilograms (kg)":
                        baseUnit = value;
                        formula += $"{value} کیلوگرم همان {baseUnit} کیلوگرم است.\n";
                        break;
                    case "grams (g)":
                        baseUnit = value / 1000;
                        formula += $"{value} گرم معادل {baseUnit} کیلوگرم است.\n";
                        break;
                    case "milligrams (mg)":
                        baseUnit = value / 1e6;
                        formula += $"{value} میلی‌گرم معادل {baseUnit} کیلوگرم است.\n";
                        break;
                    case "tons (ton)":
                        baseUnit = value * 1000;
                        formula += $"{value} تن معادل {baseUnit} کیلوگرم است.\n";
                        break;
                    case "pounds (lb)":
                        baseUnit = value * 0.453592;
                        formula += $"{value} پوند معادل {baseUnit} کیلوگرم است.\n";
                        break;
                    case "ounces (oz)":
                        baseUnit = value * 0.0283495;
                        formula += $"{value} اونس معادل {baseUnit} کیلوگرم است.\n";
                        break;
                    // تبدیل واحدهای انرژی
                    case "Joule (J)":
                        baseUnit = value; 
                        formula += $"{value} ژول همان {baseUnit} ژول است.\n";
                        break;
                    case "calories (cal)":
                        baseUnit = value * 4.184; 
                        formula += $"{value} کالری معادل {baseUnit} ژول است.\n";
                        break;
                    case "Kilowatt hours (kWh)":
                        baseUnit = value * 3.6e6; 
                        formula += $"{value} کیلووات ساعت معادل {baseUnit} ژول است.\n";
                        break;
                    case "BTU":
                        baseUnit = value * 1055.06; 
                        formula += $"{value} BTU معادل {baseUnit} ژول است.\n";
                        break;
                    case "foot pound":
                        baseUnit = value * 1.35582; 
                        formula += $"{value} فوت پوند معادل {baseUnit} ژول است.\n";
                        break;
                    // تبدیل واحدهای عددی
                    case "Binary (BIN)":
                        baseUnit = Convert.ToDouble(Convert.ToInt32(value.ToString(), 2));
                        formula += $"{value} باینری معادل {baseUnit} دسیمال است.\n";
                        break;
                    case "Octal (OCT)":
                        baseUnit = Convert.ToDouble(Convert.ToInt32(value.ToString(), 8));
                        formula += $"{value} اکتال معادل {baseUnit} دسیمال است.\n";
                        break;
                    case "Decimal (DEC)":
                        baseUnit = value; 
                        formula += $"{value} دسیمال همان {baseUnit} دسیمال است.\n";
                        break;
                    case "Hexadouble (HEX)":
                       
                        baseUnit = Convert.ToDouble(Convert.ToInt32(value.ToString(), 16));
                        formula += $"{value} هگزادسیمال معادل {baseUnit} دسیمال است.\n";
                        break;


                    // تبدیل واحدهای فشار
                    case "Pascal (Pa)":
                        baseUnit = value; 
                        formula += $"{value} پاسکال همان {baseUnit} پاسکال است.\n";
                        break;
                    case "bar":
                        baseUnit = value * 1e5; 
                        formula += $"{value} بار معادل {baseUnit} پاسکال است.\n";
                        break;

                    case "mercury meter (mHg)":
                        baseUnit = value * 133322.387415; 
                        formula += $"{value} متر جیوه معادل {baseUnit} پاسکال است.\n";
                        break;
                    case "atmosphere (atm)":
                        baseUnit = value * 101325; 
                        formula += $"{value} اتمسفر معادل {baseUnit} پاسکال است.\n";
                        break;



                    case "liter (L)":
                        baseUnit = value * 0.001; 
                        formula += $"{value} لیتر معادل {baseUnit} متر مکعب است.\n";
                        break;
                    case "milliliter (mL)":
                        baseUnit = value * 1e-6; 
                        formula += $"{value} میلی‌لیتر معادل {baseUnit} متر مکعب است.\n";
                        break;
                    case "cubic meter (m³)":
                        baseUnit = value; 
                        formula += $"{value} متر مکعب همان {baseUnit} متر مکعب است.\n";
                        break;
                    case "cubic centimeter (cm³)":
                        baseUnit = value * 1e-6; 
                        formula += $"{value} سانتی‌متر مکعب معادل {baseUnit} متر مکعب است.\n";
                        break;
                    case "gallon":
                        baseUnit = value * 0.00378541; 
                        formula += $"{value} گالن معادل {baseUnit} متر مکعب است.\n";
                        break;

                    case "cubic feet (ft³)":
                        baseUnit = value * 0.0283168; 
                        formula += $"{value} فوت مکعب معادل {baseUnit} متر مکعب است.\n";
                        break;
                    case "cubic inch (in³)":
                        baseUnit = value * 0.0000163871; 
                        formula += $"{value} اینچ مکعب معادل {baseUnit} متر مکعب است.\n";
                        break;



                    case "square kilometer (km²)":
                        baseUnit = value * 1_000_000; 
                        formula += $"{value} کیلومتر مربع معادل {baseUnit} متر مربع است.\n";
                        break;
                    case "square hectometer (hm²)":
                        baseUnit = value * 10_000; 
                        formula += $"{value} هکتومتر مربع معادل {baseUnit} متر مربع است.\n";
                        break;
                    case "square decameter (dam²)":
                        baseUnit = value * 100;
                        formula += $"{value} دکامتر مربع معادل {baseUnit} متر مربع است.\n";
                        break;
                    case "square meter (m²)":
                        baseUnit = value; 
                        formula += $"{value} متر مربع همان {baseUnit} متر مربع است.\n";
                        break;
                    case "square decimeter (dm²)":
                        baseUnit = value * 0.01; 
                        formula += $"{value} دسی‌متر مربع معادل {baseUnit} متر مربع است.\n";
                        break;
                    case "square centimeter (m²)":
                        baseUnit = value * 0.0001; 
                        formula += $"{value} سانتی‌متر مربع معادل {baseUnit} متر مربع است.\n";
                        break;
                    case "square millimeter (mm²)":
                        baseUnit = value * 0.000001; 
                        formula += $"{value} میلی‌متر مربع معادل {baseUnit} متر مربع است.\n";
                        break;

                }

                result = baseUnit;
                switch (toUnit.Trim())
                {
                    // طول
                    case "Nanometer (nm)":
                        result = baseUnit / 1e-9;
                        formula += $"برای تبدیل به نانومتر، {baseUnit} متر را بر 1e-9 تقسیم می‌کنیم: نتیجه = {result} نانومتر.";
                        break;
                    case "Micrometer (µm)":
                        result = baseUnit / 1e-6;
                        formula += $"برای تبدیل به میکرومتر، {baseUnit} متر را بر 1e-6 تقسیم می‌کنیم: نتیجه = {result} میکرومتر.";
                        break;
                    case "Millimeter (mm)":
                        result = baseUnit / 1e-3;
                        formula += $"برای تبدیل به میلی‌متر، {baseUnit} متر را بر 1e-3 تقسیم می‌کنیم: نتیجه = {result} میلی‌متر.";
                        break;
                    case "Centimeter (cm)":
                        result = baseUnit / 1e-2;
                        formula += $"برای تبدیل به سانتی‌متر، {baseUnit} متر را بر 1e-2 تقسیم می‌کنیم: نتیجه = {result} سانتی‌متر.";
                        break;
                    case "Meter (m)":
                        result = baseUnit;
                        formula += $"نتیجه نهایی همان {result} متر است.";
                        break;
                    case "Kilometer (km)":
                        result = baseUnit / 1e3;
                        formula += $"برای تبدیل به کیلومتر، {baseUnit} متر را بر 1e3 تقسیم می‌کنیم: نتیجه = {result} کیلومتر.";
                        break;
                    case "Inch (in)":
                        result = baseUnit / 0.0254;
                        formula += $"برای تبدیل به اینچ، {baseUnit} متر را بر 0.0254 تقسیم می‌کنیم: نتیجه = {result} اینچ.";
                        break;
                    case "Foot (ft)":
                        result = baseUnit / 0.3048;
                        formula += $"برای تبدیل به فوت، {baseUnit} متر را بر 0.3048 تقسیم می‌کنیم: نتیجه = {result} فوت.";
                        break;
                    case "Yard (yd)":
                        result = baseUnit / 0.9144;
                        formula += $"برای تبدیل به یارد، {baseUnit} متر را بر 0.9144 تقسیم می‌کنیم: نتیجه = {result} یارد.";
                        break;
                    case "Mile (mi)":
                        result = baseUnit / 1609.34;
                        formula += $"برای تبدیل به مایل، {baseUnit} متر را بر 1609.34 تقسیم می‌کنیم: نتیجه = {result} مایل.";
                        break;

                    case "second(s)":
                        result = baseUnit;
                        formula += $"نتیجه نهایی همان {result} ثانیه است.";
                        break;
                    case "minutes (.min)":
                        result = baseUnit / 60;
                        formula += $"برای تبدیل به دقیقه، {baseUnit} ثانیه را بر 60 تقسیم می‌کنیم: نتیجه = {result} دقیقه.";
                        break;
                    case "hour (h)":
                        result = baseUnit / 3600;
                        formula += $"برای تبدیل به ساعت، {baseUnit} ثانیه را بر 3600 تقسیم می‌کنیم: نتیجه = {result} ساعت.";
                        break;
                    case "day":
                        result = baseUnit / 86400;
                        formula += $"برای تبدیل به روز، {baseUnit} ثانیه را بر 86400 تقسیم می‌کنیم: نتیجه = {result} روز.";
                        break;
                    case "week":
                        result = baseUnit / 604800;
                        formula += $"برای تبدیل به هفته، {baseUnit} ثانیه را بر 604800 تقسیم می‌کنیم: نتیجه = {result} هفته.";
                        break;
                    case "months":
                        result = baseUnit / 2629800;
                        formula += $"برای تبدیل به ماه، {baseUnit} ثانیه را بر 2629800 تقسیم می‌کنیم: نتیجه = {result} ماه.";
                        break;
                    case "year":
                        result = baseUnit / 31557600;
                        formula += $"برای تبدیل به سال، {baseUnit} ثانیه را بر 31557600 تقسیم می‌کنیم: نتیجه = {result} سال.";
                        break;
                    //حافظه

                    case " byte (b)":
                        result = baseUnit;
                        formula += $"نتیجه نهایی همان {result} بیت است.";
                        break;
                    case "Byte (B)":
                        result = baseUnit / 8;
                        formula += $"برای تبدیل به بایت، {baseUnit} بیت را بر 8 تقسیم می‌کنیم: نتیجه = {result} بایت.";
                        break;
                    case "Kilobyte (KB)":
                        result = baseUnit / 8e3;
                        formula += $"برای تبدیل به کیلوبایت، {baseUnit} بیت را بر 8000 تقسیم می‌کنیم: نتیجه = {result} کیلوبایت.";
                        break;
                    case "Megabyte (MB)":
                        result = baseUnit / 8e6;
                        formula += $"برای تبدیل به مگابایت، {baseUnit} بیت را بر 8000000 تقسیم می‌کنیم: نتیجه = {result} مگابایت.";
                        break;
                    case "Gigabyte (GB)":
                        result = baseUnit / 8e9;
                        formula += $"برای تبدیل به گیگابایت، {baseUnit} بیت را بر 8000000000 تقسیم می‌کنیم: نتیجه = {result} گیگابایت.";
                        break;
                    case "Terabyte (TB)":
                        result = baseUnit / 8e12;
                        formula += $"برای تبدیل به ترابایت، {baseUnit} بیت را بر 8000000000000 تقسیم می‌کنیم: نتیجه = {result} ترابایت.";
                        break;
                    case "Petabyte PB":
                        result = baseUnit / 8e15;
                        formula += $"برای تبدیل به پتابایت، {baseUnit} بیت را بر 8000000000000000 تقسیم می‌کنیم: نتیجه = {result} پتابایت.";
                        break;

                    // واحدهای سرعت

                    case "meters per second (m/s)":
                        result = baseUnit;
                        formula += $"نتیجه نهایی همان {result} متر بر ثانیه است.";
                        break;
                    case "kilometers per hour (km/h)":
                        result = baseUnit * (3600.0 / 1000.0); 
                        formula += $"برای تبدیل به کیلومتر بر ساعت، {baseUnit} متر بر ثانیه را در (3600/1000) ضرب می‌کنیم: نتیجه = {result} کیلومتر بر ساعت.";
                        break;
                    case "miles per hour (mph)":
                        result = baseUnit * (3600.0 / 1609.34); 
                        formula += $"برای تبدیل به مایل بر ساعت، {baseUnit} متر بر ثانیه را در (3600/1609.34) ضرب می‌کنیم: نتیجه = {result} مایل بر ساعت.";
                        break;

                    // تبدیل دما
                    case "Celsius (°C)":
                        result = baseUnit; 
                        formula += $"نتیجه نهایی همان {result} درجه سلسیوس است.";
                        break;
                    case "Fahrenheit (°F)":
                        result = (baseUnit * 9 / 5) + 32; 
                        formula += $"برای تبدیل به فارنهایت، {baseUnit} درجه سلسیوس را در 9/5 ضرب کرده و 32 اضافه می‌کنیم: نتیجه = {result} درجه فارنهایت.";
                        break;
                    case "Kelvin (K)":
                        result = baseUnit + 273.15; 
                        formula += $"برای تبدیل به کلوین، {baseUnit} درجه سلسیوس را با 273.15 جمع می‌کنیم: نتیجه = {result} کلوین.";
                        break;

                    // وزن و جرم
                    case "kilograms (kg)":
                        result = baseUnit;
                        formula += $"نتیجه نهایی همان {result} کیلوگرم است.";
                        break;
                    case "grams (g)":
                        result = baseUnit * 1000;
                        formula += $"برای تبدیل به گرم، {baseUnit} کیلوگرم را در 1000 ضرب می‌کنیم: نتیجه = {result} گرم.";
                        break;
                    case "milligrams (mg)":
                        result = baseUnit * 1e6;
                        formula += $"برای تبدیل به میلی‌گرم، {baseUnit} کیلوگرم را در 1e6 ضرب می‌کنیم: نتیجه = {result} میلی‌گرم.";
                        break;
                    case "tons (ton)":
                        result = baseUnit / 1000;
                        formula += $"برای تبدیل به تن، {baseUnit} کیلوگرم را بر 1000 تقسیم می‌کنیم: نتیجه = {result} تن.";
                        break;
                    case "pounds (lb)":
                        result = baseUnit / 0.453592;
                        formula += $"برای تبدیل به پوند، {baseUnit} کیلوگرم را بر 0.453592 تقسیم می‌کنیم: نتیجه = {result} پوند.";
                        break;
                    case "ounces (oz)":
                        result = baseUnit / 0.0283495;
                        formula += $"برای تبدیل به اونس، {baseUnit} کیلوگرم را بر 0.0283495 تقسیم می‌کنیم: نتیجه = {result} اونس.";
                        break;
                    // انرژی
                    case "Joule (J)":
                        result = baseUnit; 
                        formula += $"نتیجه نهایی همان {result} ژول است.";
                        break;
                    case "calories (cal)":
                        result = baseUnit / 4.184; 
                        formula += $"برای تبدیل به کالری، {baseUnit} ژول را بر 4.184 تقسیم می‌کنیم: نتیجه = {result} کالری.";
                        break;
                    case "Kilowatt hours (kWh)":
                        result = baseUnit / 3.6e6; 
                        formula += $"برای تبدیل به کیلووات ساعت، {baseUnit} ژول را بر 3.6 میلیون تقسیم می‌کنیم: نتیجه = {result} کیلووات ساعت.";
                        break;
                    case "BTU":
                        result = baseUnit / 1055.06; 
                        formula += $"برای تبدیل به BTU، {baseUnit} ژول را بر 1055.06 تقسیم می‌کنیم: نتیجه = {result} BTU.";
                        break;
                    case "foot pound":
                        result = baseUnit / 1.35582; 
                        formula += $"برای تبدیل به فوت پوند، {baseUnit} ژول را بر 1.35582 تقسیم می‌کنیم: نتیجه = {result} فوت پوند.";
                        break;

                    case "Binary (BIN)":
                        result = Convert.ToDouble(Convert.ToString((int)baseUnit, 2));
                        formula += $"نتیجه نهایی در سیستم باینری: {result}.";
                        break;
                    case "Octal (OCT)":
                        result = Convert.ToDouble(Convert.ToString((int)baseUnit, 8));
                        formula += $"نتیجه نهایی در سیستم اکتال: {result}.";
                        break;
                    case "Decimal (DEC)":
                        result = baseUnit;
                        formula += $"نتیجه نهایی همان {result} دسیمال است.";
                        break;
                    case "Hexadouble (HEX)":
                        result = Convert.ToDouble(Convert.ToString((int)baseUnit, 16));
                        formula += $"نتیجه نهایی در سیستم هگزادسیمال: {result}.";
                        break;



                    // تبدیل واحدهای فشار
                    case "Pascal (Pa)":
                        result = baseUnit;
                        formula += $"نتیجه نهایی همان {result} پاسکال است.";
                        break;
                    case "bar":
                        result = baseUnit / 1e5;
                        formula += $"برای تبدیل به بار، {baseUnit} پاسکال را بر 100000 تقسیم می‌کنیم: نتیجه = {result} بار.";
                        break;

                    case "mercury meter (mHg)":
                        result = baseUnit / 133322.387415;
                        formula += $"برای تبدیل به متر جیوه، {baseUnit} پاسکال را بر 133322.387415 تقسیم می‌کنیم: نتیجه = {result} متر جیوه.";
                        break;
                    case "atmosphere (atm)":
                        result = baseUnit / 101325;
                        formula += $"برای تبدیل به اتمسفر، {baseUnit} پاسکال را بر 101325 تقسیم می‌کنیم: نتیجه = {result} اتمسفر.";
                        break;



                    // حجم
                    case "liter (L)":
                        result = baseUnit / 0.001; 
                        formula += $"برای تبدیل به لیتر، {baseUnit} متر مکعب را بر 0.001 تقسیم می‌کنیم: نتیجه = {result} لیتر.";
                        break;
                    case "milliliter (mL)":
                        result = baseUnit / 1e-6; 
                        formula += $"برای تبدیل به میلی‌لیتر، {baseUnit} متر مکعب را بر 1e-6 تقسیم می‌کنیم: نتیجه = {result} میلی‌لیتر.";
                        break;
                    case "cubic meter (m³)":
                        result = baseUnit; 
                        formula += $"نتیجه نهایی همان {result} متر مکعب است.";
                        break;
                    case "cubic centimeter (cm³)":
                        result = baseUnit / 1e-6;
                        formula += $"برای تبدیل به سانتی‌متر مکعب، {baseUnit} متر مکعب را بر 1e-6 تقسیم می‌کنیم: نتیجه = {result} سانتی‌متر مکعب.";
                        break;
                    case "gallon":
                        result = baseUnit / 0.00378541; 
                        formula += $"برای تبدیل به گالن، {baseUnit} متر مکعب را بر 0.00378541 تقسیم می‌کنیم: نتیجه = {result} گالن.";
                        break;

                    case "cubic feet (ft³)":
                        result = baseUnit / 0.0283168; 
                        formula += $"برای تبدیل به فوت مکعب، {baseUnit} متر مکعب را بر 0.0283168 تقسیم می‌کنیم: نتیجه = {result} فوت مکعب.";
                        break;
                    case "cubic inch (in³)":
                        result = baseUnit / 0.0000163871; 
                        formula += $"برای تبدیل به اینچ مکعب، {baseUnit} متر مکعب را بر 0.0000163871 تقسیم می‌کنیم: نتیجه = {result} اینچ مکعب.";
                        break;



                    case "square kilometer (km²)":
                        result = baseUnit / 1_000_000; 
                        formula += $"برای تبدیل به کیلومتر مربع، {baseUnit} متر مربع را بر 1,000,000 تقسیم می‌کنیم: نتیجه = {result} کیلومتر مربع.";
                        break;
                    case "square hectometer (hm²)":
                        result = baseUnit / 10_000; 
                        formula += $"برای تبدیل به هکتومتر مربع، {baseUnit} متر مربع را بر 10,000 تقسیم می‌کنیم: نتیجه = {result} هکتومتر مربع.";
                        break;
                    case "square decameter (dam²)":
                        result = baseUnit / 100; 
                        formula += $"برای تبدیل به دکامتر مربع، {baseUnit} متر مربع را بر 100 تقسیم می‌کنیم: نتیجه = {result} دکامتر مربع.";
                        break;
                    case "square meter (m²)":
                        result = baseUnit; 
                        formula += $"نتیجه نهایی همان {result} متر مربع است.";
                        break;
                    case "square decimeter (dm²)":
                        result = baseUnit / 0.01; 
                        formula += $"برای تبدیل به دسی‌متر مربع، {baseUnit} متر مربع را بر 0.01 تقسیم می‌کنیم: نتیجه = {result} دسی‌متر مربع.";
                        break;
                    case "square centimeter (m²)":
                        result = baseUnit / 0.0001;
                        formula += $"برای تبدیل به سانتی‌متر مربع، {baseUnit} متر مربع را بر 0.0001 تقسیم می‌کنیم: نتیجه = {result} سانتی‌متر مربع.";
                        break;
                    case "square millimeter (mm²)":
                        result = baseUnit / 0.000001; 
                        formula += $"برای تبدیل به میلی‌متر مربع، {baseUnit} متر مربع را بر 0.000001 تقسیم می‌کنیم: نتیجه = {result} میلی‌متر مربع.";
                        break;
                }
            }
            catch
            {
                MessageBox.Show("عدد قابل تبدیل نیست", "خطا");
                formulatextBox.Text = " ";
                textBox.Text = " ";
                errorCheck = true;
            }


            return result;
        }




        private string FormatResult(double result)
        {
            string resultString = result.ToString();

            int totalDigits = resultString.Replace(".", "").Replace("-", "").Length;

            if (totalDigits > 20)
            {
                resultString = resultString.Substring(0, 20);
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

            //if (inputlistbox.SelectedItem == "Hexadouble (HEX)")
            //{
            //    e.Handled = false;

            //}
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
   
    }
}