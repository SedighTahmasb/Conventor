namespace Conventor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox = new TextBox();
            label1 = new Label();
            inputlistbox = new ListBox();
            putputlistbox = new ListBox();
            formulatextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            lengthmenu = new ToolStripMenuItem();
            areamenu = new ToolStripMenuItem();
            volumemenu = new ToolStripMenuItem();
            Weightandmassmenu = new ToolStripMenuItem();
            timemenu = new ToolStripMenuItem();
            temperaturemenu = new ToolStripMenuItem();
            energymenu = new ToolStripMenuItem();
            pressuremenu = new ToolStripMenuItem();
            speedmenu = new ToolStripMenuItem();
            datamenu = new ToolStripMenuItem();
            numeralsystemmenu = new ToolStripMenuItem();
            x2btn = new Button();
            x3btn = new Button();
            x5btn = new Button();
            x10btn = new Button();
            x100btn = new Button();
            x1000btn = new Button();
            calculaotrbtn = new Button();
            copybtn = new Button();
            convertbtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 319);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox
            // 
            textBox.BackColor = SystemColors.Window;
            textBox.Location = new Point(437, 319);
            textBox.Margin = new Padding(3, 4, 3, 4);
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(222, 27);
            textBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(179, 11);
            label1.Name = "label1";
            label1.Size = new Size(122, 21);
            label1.TabIndex = 1;
            label1.Text = "Convert From";
            // 
            // inputlistbox
            // 
            inputlistbox.ColumnWidth = 5;
            inputlistbox.FormattingEnabled = true;
            inputlistbox.ItemHeight = 20;
            inputlistbox.Items.AddRange(new object[] { " " });
            inputlistbox.Location = new Point(179, 36);
            inputlistbox.Margin = new Padding(3, 4, 3, 4);
            inputlistbox.Name = "inputlistbox";
            inputlistbox.Size = new Size(222, 264);
            inputlistbox.TabIndex = 4;
            // 
            // putputlistbox
            // 
            putputlistbox.FormattingEnabled = true;
            putputlistbox.ImeMode = ImeMode.Alpha;
            putputlistbox.ItemHeight = 20;
            putputlistbox.Items.AddRange(new object[] { " " });
            putputlistbox.Location = new Point(437, 36);
            putputlistbox.Margin = new Padding(3, 4, 3, 4);
            putputlistbox.Name = "putputlistbox";
            putputlistbox.Size = new Size(222, 264);
            putputlistbox.TabIndex = 4;
            // 
            // formulatextBox
            // 
            formulatextBox.BackColor = SystemColors.Window;
            formulatextBox.Cursor = Cursors.IBeam;
            formulatextBox.Location = new Point(320, 427);
            formulatextBox.Margin = new Padding(3, 4, 3, 4);
            formulatextBox.Multiline = true;
            formulatextBox.Name = "formulatextBox";
            formulatextBox.ReadOnly = true;
            formulatextBox.Size = new Size(339, 85);
            formulatextBox.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(182, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(496, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.Gainsboro;
            menuStrip2.Dock = DockStyle.Left;
            menuStrip2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { lengthmenu, areamenu, volumemenu, Weightandmassmenu, timemenu, temperaturemenu, energymenu, pressuremenu, speedmenu, datamenu, numeralsystemmenu });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(7, 3, 0, 3);
            menuStrip2.RightToLeft = RightToLeft.No;
            menuStrip2.Size = new Size(182, 527);
            menuStrip2.TabIndex = 8;
            menuStrip2.Text = "menuStrip2";
            // 
            // lengthmenu
            // 
            lengthmenu.AccessibleRole = AccessibleRole.None;
            lengthmenu.Image = (Image)resources.GetObject("lengthmenu.Image");
            lengthmenu.ImageAlign = ContentAlignment.MiddleLeft;
            lengthmenu.Name = "lengthmenu";
            lengthmenu.Size = new Size(167, 27);
            lengthmenu.Text = "Length";
            lengthmenu.TextAlign = ContentAlignment.MiddleLeft;
            lengthmenu.Click += lengthmenu_Click;
            // 
            // areamenu
            // 
            areamenu.Image = (Image)resources.GetObject("areamenu.Image");
            areamenu.ImageAlign = ContentAlignment.MiddleLeft;
            areamenu.Name = "areamenu";
            areamenu.Size = new Size(167, 27);
            areamenu.Text = "Area";
            areamenu.TextAlign = ContentAlignment.MiddleLeft;
            areamenu.Click += areamenu_Click;
            // 
            // volumemenu
            // 
            volumemenu.Image = (Image)resources.GetObject("volumemenu.Image");
            volumemenu.ImageAlign = ContentAlignment.MiddleLeft;
            volumemenu.Name = "volumemenu";
            volumemenu.Size = new Size(167, 27);
            volumemenu.Text = "Volume";
            volumemenu.TextAlign = ContentAlignment.MiddleLeft;
            volumemenu.Click += volumemenu_Click;
            // 
            // Weightandmassmenu
            // 
            Weightandmassmenu.Image = (Image)resources.GetObject("Weightandmassmenu.Image");
            Weightandmassmenu.ImageAlign = ContentAlignment.MiddleLeft;
            Weightandmassmenu.Name = "Weightandmassmenu";
            Weightandmassmenu.Size = new Size(167, 27);
            Weightandmassmenu.Text = "Weight and mass";
            Weightandmassmenu.TextAlign = ContentAlignment.MiddleLeft;
            Weightandmassmenu.Click += Weightandmassmenu_Click;
            // 
            // timemenu
            // 
            timemenu.Image = (Image)resources.GetObject("timemenu.Image");
            timemenu.ImageAlign = ContentAlignment.MiddleLeft;
            timemenu.Name = "timemenu";
            timemenu.Size = new Size(167, 27);
            timemenu.Text = "time";
            timemenu.TextAlign = ContentAlignment.MiddleLeft;
            timemenu.Click += timemenu_Click;
            // 
            // temperaturemenu
            // 
            temperaturemenu.Image = (Image)resources.GetObject("temperaturemenu.Image");
            temperaturemenu.ImageAlign = ContentAlignment.MiddleLeft;
            temperaturemenu.Name = "temperaturemenu";
            temperaturemenu.Size = new Size(167, 27);
            temperaturemenu.Text = "temperature";
            temperaturemenu.TextAlign = ContentAlignment.MiddleLeft;
            temperaturemenu.Click += temperaturemenu_Click;
            // 
            // energymenu
            // 
            energymenu.Image = (Image)resources.GetObject("energymenu.Image");
            energymenu.ImageAlign = ContentAlignment.MiddleLeft;
            energymenu.Name = "energymenu";
            energymenu.Size = new Size(167, 27);
            energymenu.Text = "Energy";
            energymenu.TextAlign = ContentAlignment.MiddleLeft;
            energymenu.Click += energymenu_Click;
            // 
            // pressuremenu
            // 
            pressuremenu.Image = (Image)resources.GetObject("pressuremenu.Image");
            pressuremenu.ImageAlign = ContentAlignment.MiddleLeft;
            pressuremenu.Name = "pressuremenu";
            pressuremenu.Size = new Size(167, 27);
            pressuremenu.Text = "Pressure";
            pressuremenu.TextAlign = ContentAlignment.MiddleLeft;
            pressuremenu.Click += pressuremenu_Click;
            // 
            // speedmenu
            // 
            speedmenu.Image = (Image)resources.GetObject("speedmenu.Image");
            speedmenu.ImageAlign = ContentAlignment.MiddleLeft;
            speedmenu.Name = "speedmenu";
            speedmenu.Size = new Size(167, 27);
            speedmenu.Text = "Speed";
            speedmenu.TextAlign = ContentAlignment.MiddleLeft;
            speedmenu.Click += speedmenu_Click;
            // 
            // datamenu
            // 
            datamenu.Image = (Image)resources.GetObject("datamenu.Image");
            datamenu.ImageAlign = ContentAlignment.MiddleLeft;
            datamenu.Name = "datamenu";
            datamenu.Size = new Size(167, 27);
            datamenu.Text = "Data";
            datamenu.TextAlign = ContentAlignment.MiddleLeft;
            datamenu.Click += datamenu_Click;
            // 
            // numeralsystemmenu
            // 
            numeralsystemmenu.Image = (Image)resources.GetObject("numeralsystemmenu.Image");
            numeralsystemmenu.ImageAlign = ContentAlignment.MiddleLeft;
            numeralsystemmenu.Name = "numeralsystemmenu";
            numeralsystemmenu.Size = new Size(167, 27);
            numeralsystemmenu.Text = "Numeral system";
            numeralsystemmenu.TextAlign = ContentAlignment.MiddleLeft;
            numeralsystemmenu.Click += numeralsystemmenu_Click;
            // 
            // x2btn
            // 
            x2btn.Cursor = Cursors.Hand;
            x2btn.Location = new Point(178, 363);
            x2btn.Margin = new Padding(3, 4, 3, 4);
            x2btn.Name = "x2btn";
            x2btn.Size = new Size(64, 47);
            x2btn.TabIndex = 9;
            x2btn.Text = "2X";
            x2btn.UseVisualStyleBackColor = true;
            x2btn.Click += x2btn_Click;
            // 
            // x3btn
            // 
            x3btn.Cursor = Cursors.Hand;
            x3btn.Location = new Point(249, 363);
            x3btn.Margin = new Padding(3, 4, 3, 4);
            x3btn.Name = "x3btn";
            x3btn.Size = new Size(64, 47);
            x3btn.TabIndex = 9;
            x3btn.Text = "3X";
            x3btn.UseVisualStyleBackColor = true;
            x3btn.Click += x3btn_Click;
            // 
            // x5btn
            // 
            x5btn.Cursor = Cursors.Hand;
            x5btn.Location = new Point(249, 417);
            x5btn.Margin = new Padding(3, 4, 3, 4);
            x5btn.Name = "x5btn";
            x5btn.Size = new Size(64, 47);
            x5btn.TabIndex = 9;
            x5btn.Text = "5X";
            x5btn.UseVisualStyleBackColor = true;
            x5btn.Click += x5btn_Click;
            // 
            // x10btn
            // 
            x10btn.Cursor = Cursors.Hand;
            x10btn.Location = new Point(178, 417);
            x10btn.Margin = new Padding(3, 4, 3, 4);
            x10btn.Name = "x10btn";
            x10btn.Size = new Size(64, 47);
            x10btn.TabIndex = 9;
            x10btn.Text = "10X";
            x10btn.UseVisualStyleBackColor = true;
            x10btn.Click += x10btn_Click;
            // 
            // x100btn
            // 
            x100btn.Cursor = Cursors.Hand;
            x100btn.Location = new Point(178, 472);
            x100btn.Margin = new Padding(3, 4, 3, 4);
            x100btn.Name = "x100btn";
            x100btn.Size = new Size(64, 47);
            x100btn.TabIndex = 9;
            x100btn.Text = "100X";
            x100btn.UseVisualStyleBackColor = true;
            x100btn.Click += x100btn_Click;
            // 
            // x1000btn
            // 
            x1000btn.Cursor = Cursors.Hand;
            x1000btn.Location = new Point(249, 472);
            x1000btn.Margin = new Padding(3, 4, 3, 4);
            x1000btn.Name = "x1000btn";
            x1000btn.Size = new Size(64, 47);
            x1000btn.TabIndex = 9;
            x1000btn.Text = "1000X";
            x1000btn.UseVisualStyleBackColor = true;
            x1000btn.Click += x1000btn_Click;
            // 
            // calculaotrbtn
            // 
            calculaotrbtn.BackgroundImage = Properties.Resources.calculator_icon_;
            calculaotrbtn.BackgroundImageLayout = ImageLayout.Zoom;
            calculaotrbtn.Cursor = Cursors.Hand;
            calculaotrbtn.FlatStyle = FlatStyle.Flat;
            calculaotrbtn.ForeColor = SystemColors.Control;
            calculaotrbtn.Location = new Point(330, 363);
            calculaotrbtn.Margin = new Padding(3, 4, 3, 4);
            calculaotrbtn.Name = "calculaotrbtn";
            calculaotrbtn.RightToLeft = RightToLeft.No;
            calculaotrbtn.Size = new Size(57, 56);
            calculaotrbtn.TabIndex = 10;
            calculaotrbtn.UseVisualStyleBackColor = true;
            calculaotrbtn.Click += calculaotrbtn_Click;
            // 
            // copybtn
            // 
            copybtn.BackgroundImage = Properties.Resources.copying_icon;
            copybtn.BackgroundImageLayout = ImageLayout.Zoom;
            copybtn.Cursor = Cursors.Hand;
            copybtn.FlatStyle = FlatStyle.Flat;
            copybtn.ForeColor = SystemColors.Control;
            copybtn.Location = new Point(410, 363);
            copybtn.Margin = new Padding(3, 4, 3, 4);
            copybtn.Name = "copybtn";
            copybtn.Size = new Size(57, 56);
            copybtn.TabIndex = 10;
            copybtn.UseVisualStyleBackColor = true;
            copybtn.Click += copybtn_Click;
            // 
            // convertbtn
            // 
            convertbtn.Location = new Point(489, 363);
            convertbtn.Margin = new Padding(3, 4, 3, 4);
            convertbtn.Name = "convertbtn";
            convertbtn.Size = new Size(170, 56);
            convertbtn.TabIndex = 10;
            convertbtn.TextAlign = ContentAlignment.MiddleLeft;
            convertbtn.UseVisualStyleBackColor = true;
            convertbtn.Click += convertbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(469, 32);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 1;
            label2.Text = "Convert From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(437, 12);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 1;
            label3.Text = "Convert to";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(403, 307);
            label4.Name = "label4";
            label4.Size = new Size(39, 41);
            label4.TabIndex = 11;
            label4.Text = "=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(678, 527);
            Controls.Add(textBox1);
            Controls.Add(convertbtn);
            Controls.Add(copybtn);
            Controls.Add(calculaotrbtn);
            Controls.Add(x1000btn);
            Controls.Add(x5btn);
            Controls.Add(x100btn);
            Controls.Add(x10btn);
            Controls.Add(x3btn);
            Controls.Add(x2btn);
            Controls.Add(formulatextBox);
            Controls.Add(putputlistbox);
            Controls.Add(inputlistbox);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(label4);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox;
        private Label label1;
        private ListBox inputlistbox;
        public ListBox putputlistbox;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem lengthmenu;
        private ToolStripMenuItem areamenu;
        private ToolStripMenuItem volumemenu;
        private ToolStripMenuItem Weightandmassmenu;
        private ToolStripMenuItem timemenu;
        private ToolStripMenuItem temperaturemenu;
        private ToolStripMenuItem energymenu;
        private ToolStripMenuItem pressuremenu;
        private ToolStripMenuItem speedmenu;
        private ToolStripMenuItem datamenu;
        private ToolStripMenuItem numeralsystemmenu;
        private Button x2btn;
        private Button x3btn;
        private Button x5btn;
        private Button x10btn;
        private Button x100btn;
        private Button x1000btn;
        private Button calculaotrbtn;
        private Button copybtn;
        private Button convertbtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox formulatextBox;
        public TextBox textBox1;
    }
}