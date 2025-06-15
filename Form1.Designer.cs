namespace Calculator_Project
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
            Resulttext = new TextBox();
            buttonbackspace = new Button();
            btnclearentry = new Button();
            btnclear = new Button();
            buttonplusminus = new Button();
            buttn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            buttonadd = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            buttonsubtract = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            buttonmultp = new Button();
            buttonzero = new Button();
            buttondecimal = new Button();
            buttonequal = new Button();
            buttondiv = new Button();
            menuStrip1 = new MenuStrip();
            buttonPie = new Button();
            buttonLog = new Button();
            buttonsqrt = new Button();
            power2 = new Button();
            sinh = new Button();
            sin = new Button();
            e = new Button();
            powerY = new Button();
            cosh = new Button();
            cos = new Button();
            button12 = new Button();
            tanh = new Button();
            tan = new Button();
            ln = new Button();
            exp = new Button();
            moduls = new Button();
            Inverse = new Button();
            percentage = new Button();
            normalToolStripMenuItem = new ToolStripMenuItem();
            scientificToolStripMenuItem = new ToolStripMenuItem();
            graphicalToolStripMenuItem = new ToolStripMenuItem();
            modeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Resulttext
            // 
            Resulttext.BackColor = SystemColors.WindowText;
            Resulttext.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Resulttext.ForeColor = SystemColors.GradientActiveCaption;
            Resulttext.Location = new Point(16, 61);
            Resulttext.Name = "Resulttext";
            Resulttext.Size = new Size(327, 32);
            Resulttext.TabIndex = 0;
            Resulttext.Text = "0";
            Resulttext.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonbackspace
            // 
            buttonbackspace.BackColor = Color.SlateGray;
            buttonbackspace.Font = new Font("Wingdings", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 2);
            buttonbackspace.ForeColor = SystemColors.HighlightText;
            buttonbackspace.Location = new Point(16, 102);
            buttonbackspace.Name = "buttonbackspace";
            buttonbackspace.Size = new Size(84, 74);
            buttonbackspace.TabIndex = 1;
            buttonbackspace.Text = "";
            buttonbackspace.UseVisualStyleBackColor = false;
            buttonbackspace.Click += buttonbackspace_Click;
            // 
            // btnclearentry
            // 
            btnclearentry.BackColor = Color.SlateGray;
            btnclearentry.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btnclearentry.ForeColor = SystemColors.HighlightText;
            btnclearentry.Location = new Point(106, 102);
            btnclearentry.Name = "btnclearentry";
            btnclearentry.Size = new Size(75, 74);
            btnclearentry.TabIndex = 2;
            btnclearentry.Text = "CE";
            btnclearentry.UseVisualStyleBackColor = false;
            btnclearentry.Click += btnclearentry_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.SlateGray;
            btnclear.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btnclear.ForeColor = SystemColors.HighlightText;
            btnclear.Location = new Point(187, 102);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(75, 74);
            btnclear.TabIndex = 3;
            btnclear.Text = "C";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // buttonplusminus
            // 
            buttonplusminus.BackColor = Color.SlateGray;
            buttonplusminus.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            buttonplusminus.ForeColor = SystemColors.HighlightText;
            buttonplusminus.Location = new Point(268, 102);
            buttonplusminus.Name = "buttonplusminus";
            buttonplusminus.Size = new Size(75, 74);
            buttonplusminus.TabIndex = 4;
            buttonplusminus.Text = "±";
            buttonplusminus.UseVisualStyleBackColor = false;
            buttonplusminus.Click += buttonplusminus_Click;
            // 
            // buttn7
            // 
            buttn7.BackColor = Color.SlateGray;
            buttn7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            buttn7.ForeColor = SystemColors.HighlightText;
            buttn7.Location = new Point(16, 182);
            buttn7.Name = "buttn7";
            buttn7.Size = new Size(84, 74);
            buttn7.TabIndex = 1;
            buttn7.Text = "7";
            buttn7.UseVisualStyleBackColor = false;
            buttn7.Click += PressingNum;
            // 
            // btn8
            // 
            btn8.BackColor = Color.SlateGray;
            btn8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btn8.ForeColor = SystemColors.HighlightText;
            btn8.Location = new Point(106, 182);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 74);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += PressingNum;
            // 
            // btn9
            // 
            btn9.BackColor = Color.SlateGray;
            btn9.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btn9.ForeColor = SystemColors.HighlightText;
            btn9.Location = new Point(187, 182);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 74);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += PressingNum;
            // 
            // buttonadd
            // 
            buttonadd.BackColor = Color.SlateGray;
            buttonadd.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            buttonadd.ForeColor = SystemColors.HighlightText;
            buttonadd.Location = new Point(268, 182);
            buttonadd.Name = "buttonadd";
            buttonadd.Size = new Size(75, 74);
            buttonadd.TabIndex = 4;
            buttonadd.Text = "+";
            buttonadd.UseVisualStyleBackColor = false;
            buttonadd.Click += Operations;
            // 
            // btn4
            // 
            btn4.BackColor = Color.SlateGray;
            btn4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btn4.ForeColor = SystemColors.HighlightText;
            btn4.Location = new Point(16, 262);
            btn4.Name = "btn4";
            btn4.Size = new Size(84, 74);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += PressingNum;
            // 
            // btn5
            // 
            btn5.BackColor = Color.SlateGray;
            btn5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btn5.ForeColor = SystemColors.HighlightText;
            btn5.Location = new Point(106, 262);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 74);
            btn5.TabIndex = 2;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += PressingNum;
            // 
            // btn6
            // 
            btn6.BackColor = Color.SlateGray;
            btn6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btn6.ForeColor = SystemColors.HighlightText;
            btn6.Location = new Point(187, 262);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 74);
            btn6.TabIndex = 3;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += PressingNum;
            // 
            // buttonsubtract
            // 
            buttonsubtract.BackColor = Color.SlateGray;
            buttonsubtract.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            buttonsubtract.ForeColor = SystemColors.HighlightText;
            buttonsubtract.Location = new Point(268, 262);
            buttonsubtract.Name = "buttonsubtract";
            buttonsubtract.Size = new Size(75, 74);
            buttonsubtract.TabIndex = 4;
            buttonsubtract.Text = "-";
            buttonsubtract.UseVisualStyleBackColor = false;
            buttonsubtract.Click += Operations;
            // 
            // btn1
            // 
            btn1.BackColor = Color.SlateGray;
            btn1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btn1.ForeColor = SystemColors.HighlightText;
            btn1.Location = new Point(16, 342);
            btn1.Name = "btn1";
            btn1.Size = new Size(84, 74);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += PressingNum;
            // 
            // btn2
            // 
            btn2.BackColor = Color.SlateGray;
            btn2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btn2.ForeColor = SystemColors.HighlightText;
            btn2.Location = new Point(106, 342);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 74);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += PressingNum;
            // 
            // btn3
            // 
            btn3.BackColor = Color.SlateGray;
            btn3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btn3.ForeColor = SystemColors.HighlightText;
            btn3.Location = new Point(187, 342);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 74);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += PressingNum;
            // 
            // buttonmultp
            // 
            buttonmultp.BackColor = Color.SlateGray;
            buttonmultp.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            buttonmultp.ForeColor = SystemColors.HighlightText;
            buttonmultp.Location = new Point(268, 342);
            buttonmultp.Name = "buttonmultp";
            buttonmultp.Size = new Size(75, 74);
            buttonmultp.TabIndex = 4;
            buttonmultp.Text = "*";
            buttonmultp.UseVisualStyleBackColor = false;
            buttonmultp.Click += Operations;
            // 
            // buttonzero
            // 
            buttonzero.BackColor = Color.SlateGray;
            buttonzero.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            buttonzero.ForeColor = SystemColors.HighlightText;
            buttonzero.Location = new Point(16, 422);
            buttonzero.Name = "buttonzero";
            buttonzero.Size = new Size(84, 74);
            buttonzero.TabIndex = 1;
            buttonzero.Text = "0";
            buttonzero.UseVisualStyleBackColor = false;
            buttonzero.Click += PressingNum;
            // 
            // buttondecimal
            // 
            buttondecimal.BackColor = Color.SlateGray;
            buttondecimal.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            buttondecimal.ForeColor = SystemColors.HighlightText;
            buttondecimal.Location = new Point(106, 422);
            buttondecimal.Name = "buttondecimal";
            buttondecimal.Size = new Size(75, 74);
            buttondecimal.TabIndex = 2;
            buttondecimal.Text = ".";
            buttondecimal.UseVisualStyleBackColor = false;
            buttondecimal.Click += PressingNum;
            // 
            // buttonequal
            // 
            buttonequal.BackColor = Color.SlateGray;
            buttonequal.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            buttonequal.ForeColor = SystemColors.HighlightText;
            buttonequal.Location = new Point(187, 422);
            buttonequal.Name = "buttonequal";
            buttonequal.Size = new Size(75, 74);
            buttonequal.TabIndex = 3;
            buttonequal.Text = "=";
            buttonequal.UseVisualStyleBackColor = false;
            buttonequal.Click += buttonequal_Click;
            // 
            // buttondiv
            // 
            buttondiv.BackColor = Color.SlateGray;
            buttondiv.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            buttondiv.ForeColor = SystemColors.HighlightText;
            buttondiv.Location = new Point(268, 422);
            buttondiv.Name = "buttondiv";
            buttondiv.Size = new Size(75, 74);
            buttondiv.TabIndex = 4;
            buttondiv.Text = "/";
            buttondiv.UseVisualStyleBackColor = false;
            buttondiv.Click += Operations;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { modeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(863, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // buttonPie
            // 
            buttonPie.BackColor = Color.SlateGray;
            buttonPie.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPie.ForeColor = SystemColors.HighlightText;
            buttonPie.Location = new Point(413, 102);
            buttonPie.Name = "buttonPie";
            buttonPie.Size = new Size(75, 74);
            buttonPie.TabIndex = 4;
            buttonPie.Text = "π";
            buttonPie.UseVisualStyleBackColor = false;
            buttonPie.Click += Pie;
            // 
            // buttonLog
            // 
            buttonLog.BackColor = Color.SlateGray;
            buttonLog.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            buttonLog.ForeColor = SystemColors.HighlightText;
            buttonLog.Location = new Point(494, 102);
            buttonLog.Name = "buttonLog";
            buttonLog.Size = new Size(75, 74);
            buttonLog.TabIndex = 4;
            buttonLog.Text = "Log";
            buttonLog.UseVisualStyleBackColor = false;
            buttonLog.Click += log;
            // 
            // buttonsqrt
            // 
            buttonsqrt.BackColor = Color.SlateGray;
            buttonsqrt.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            buttonsqrt.ForeColor = SystemColors.HighlightText;
            buttonsqrt.Location = new Point(575, 102);
            buttonsqrt.Name = "buttonsqrt";
            buttonsqrt.Size = new Size(75, 74);
            buttonsqrt.TabIndex = 4;
            buttonsqrt.Text = "Sqrt";
            buttonsqrt.UseVisualStyleBackColor = false;
            buttonsqrt.Click += Squareroot;
            // 
            // power2
            // 
            power2.BackColor = Color.SlateGray;
            power2.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            power2.ForeColor = SystemColors.HighlightText;
            power2.Location = new Point(656, 183);
            power2.Name = "power2";
            power2.Size = new Size(75, 74);
            power2.TabIndex = 4;
            power2.Text = "x²";
            power2.UseVisualStyleBackColor = false;
            power2.Click += squaring;
            // 
            // sinh
            // 
            sinh.BackColor = Color.SlateGray;
            sinh.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            sinh.ForeColor = SystemColors.HighlightText;
            sinh.Location = new Point(413, 182);
            sinh.Name = "sinh";
            sinh.Size = new Size(75, 74);
            sinh.TabIndex = 4;
            sinh.Text = "Sinh";
            sinh.UseVisualStyleBackColor = false;
            sinh.Click += sinh_Click;
            // 
            // sin
            // 
            sin.BackColor = Color.SlateGray;
            sin.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            sin.ForeColor = SystemColors.HighlightText;
            sin.Location = new Point(494, 182);
            sin.Name = "sin";
            sin.Size = new Size(75, 74);
            sin.TabIndex = 4;
            sin.Text = "Sin";
            sin.UseVisualStyleBackColor = false;
            sin.Click += sin_Click;
            // 
            // e
            // 
            e.BackColor = Color.SlateGray;
            e.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            e.ForeColor = SystemColors.HighlightText;
            e.Location = new Point(575, 182);
            e.Name = "e";
            e.Size = new Size(75, 74);
            e.TabIndex = 4;
            e.Text = "e";
            e.UseVisualStyleBackColor = false;
            e.Click += e_Click;
            // 
            // powerY
            // 
            powerY.BackColor = Color.SlateGray;
            powerY.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            powerY.ForeColor = SystemColors.HighlightText;
            powerY.Location = new Point(656, 102);
            powerY.Name = "powerY";
            powerY.Size = new Size(75, 74);
            powerY.TabIndex = 4;
            powerY.Text = "^";
            powerY.UseVisualStyleBackColor = false;
            powerY.Click += Operations;
            // 
            // cosh
            // 
            cosh.BackColor = Color.SlateGray;
            cosh.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            cosh.ForeColor = SystemColors.HighlightText;
            cosh.Location = new Point(413, 262);
            cosh.Name = "cosh";
            cosh.Size = new Size(75, 74);
            cosh.TabIndex = 4;
            cosh.Text = "Cosh";
            cosh.UseVisualStyleBackColor = false;
            cosh.Click += cosh_Click;
            // 
            // cos
            // 
            cos.BackColor = Color.SlateGray;
            cos.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            cos.ForeColor = SystemColors.HighlightText;
            cos.Location = new Point(494, 262);
            cos.Name = "cos";
            cos.Size = new Size(75, 74);
            cos.TabIndex = 4;
            cos.Text = "Cos";
            cos.UseVisualStyleBackColor = false;
            cos.Click += cos_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.SlateGray;
            button12.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            button12.ForeColor = SystemColors.HighlightText;
            button12.Location = new Point(575, 262);
            button12.Name = "button12";
            button12.Size = new Size(75, 74);
            button12.TabIndex = 4;
            button12.Text = "x!";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // tanh
            // 
            tanh.BackColor = Color.SlateGray;
            tanh.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            tanh.ForeColor = SystemColors.HighlightText;
            tanh.Location = new Point(413, 342);
            tanh.Name = "tanh";
            tanh.Size = new Size(75, 74);
            tanh.TabIndex = 4;
            tanh.Text = "Tanh";
            tanh.UseVisualStyleBackColor = false;
            tanh.Click += tanh_Click;
            // 
            // tan
            // 
            tan.BackColor = Color.SlateGray;
            tan.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            tan.ForeColor = SystemColors.HighlightText;
            tan.Location = new Point(494, 342);
            tan.Name = "tan";
            tan.Size = new Size(75, 74);
            tan.TabIndex = 4;
            tan.Text = "Tan";
            tan.UseVisualStyleBackColor = false;
            tan.Click += tan_Click;
            // 
            // ln
            // 
            ln.BackColor = Color.SlateGray;
            ln.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            ln.ForeColor = SystemColors.HighlightText;
            ln.Location = new Point(575, 342);
            ln.Name = "ln";
            ln.Size = new Size(75, 74);
            ln.TabIndex = 4;
            ln.Text = "ln";
            ln.UseVisualStyleBackColor = false;
            ln.Click += ln_Click;
            // 
            // exp
            // 
            exp.BackColor = Color.SlateGray;
            exp.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            exp.ForeColor = SystemColors.HighlightText;
            exp.Location = new Point(413, 422);
            exp.Name = "exp";
            exp.Size = new Size(75, 74);
            exp.TabIndex = 4;
            exp.Text = "Exp";
            exp.UseVisualStyleBackColor = false;
            exp.Click += Operations;
            // 
            // moduls
            // 
            moduls.BackColor = Color.SlateGray;
            moduls.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            moduls.ForeColor = SystemColors.HighlightText;
            moduls.Location = new Point(494, 422);
            moduls.Name = "moduls";
            moduls.Size = new Size(75, 74);
            moduls.TabIndex = 4;
            moduls.Text = "Mod";
            moduls.UseVisualStyleBackColor = false;
            moduls.Click += Operations;
            // 
            // Inverse
            // 
            Inverse.BackColor = Color.SlateGray;
            Inverse.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            Inverse.ForeColor = SystemColors.HighlightText;
            Inverse.Location = new Point(575, 422);
            Inverse.Name = "Inverse";
            Inverse.Size = new Size(75, 74);
            Inverse.TabIndex = 4;
            Inverse.Text = "Inv";
            Inverse.UseVisualStyleBackColor = false;
            Inverse.Click += Inv;
            // 
            // percentage
            // 
            percentage.BackColor = Color.SlateGray;
            percentage.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            percentage.ForeColor = SystemColors.HighlightText;
            percentage.Location = new Point(656, 263);
            percentage.Name = "percentage";
            percentage.Size = new Size(75, 74);
            percentage.TabIndex = 4;
            percentage.Text = "%";
            percentage.UseVisualStyleBackColor = false;
            percentage.Click += percentage_Click;
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.Size = new Size(180, 22);
            normalToolStripMenuItem.Text = "Standard";
            normalToolStripMenuItem.Click += normalToolStripMenuItem_Click;
            // 
            // scientificToolStripMenuItem
            // 
            scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            scientificToolStripMenuItem.Size = new Size(180, 22);
            scientificToolStripMenuItem.Text = "Scientific";
            scientificToolStripMenuItem.Click += scientificToolStripMenuItem_Click;
            // 
            // graphicalToolStripMenuItem
            // 
            graphicalToolStripMenuItem.Name = "graphicalToolStripMenuItem";
            graphicalToolStripMenuItem.Size = new Size(180, 22);
            graphicalToolStripMenuItem.Text = "Graphical";
            graphicalToolStripMenuItem.Click += graphicalToolStripMenuItem_Click;
            // 
            // modeToolStripMenuItem
            // 
            modeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { normalToolStripMenuItem, scientificToolStripMenuItem, graphicalToolStripMenuItem });
            modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            modeToolStripMenuItem.Size = new Size(50, 20);
            modeToolStripMenuItem.Text = "Mode";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(863, 513);
            Controls.Add(buttondiv);
            Controls.Add(buttonequal);
            Controls.Add(buttonmultp);
            Controls.Add(btn3);
            Controls.Add(buttonsubtract);
            Controls.Add(btn6);
            Controls.Add(buttondecimal);
            Controls.Add(buttonadd);
            Controls.Add(btn2);
            Controls.Add(btn9);
            Controls.Add(btn5);
            Controls.Add(buttonzero);
            Controls.Add(percentage);
            Controls.Add(Inverse);
            Controls.Add(ln);
            Controls.Add(button12);
            Controls.Add(moduls);
            Controls.Add(powerY);
            Controls.Add(tan);
            Controls.Add(e);
            Controls.Add(cos);
            Controls.Add(exp);
            Controls.Add(power2);
            Controls.Add(tanh);
            Controls.Add(sin);
            Controls.Add(cosh);
            Controls.Add(buttonsqrt);
            Controls.Add(sinh);
            Controls.Add(buttonLog);
            Controls.Add(buttonPie);
            Controls.Add(buttonplusminus);
            Controls.Add(btn1);
            Controls.Add(btn8);
            Controls.Add(btn4);
            Controls.Add(btnclear);
            Controls.Add(buttn7);
            Controls.Add(btnclearentry);
            Controls.Add(buttonbackspace);
            Controls.Add(Resulttext);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Resulttext;
        private Button buttonbackspace;
        private Button btnclearentry;
        private Button btnclear;
        private Button buttonplusminus;
        private Button buttn7;
        private Button btn8;
        private Button btn9;
        private Button buttonadd;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button buttonsubtract;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button buttonmultp;
        private Button buttonzero;
        private Button buttondecimal;
        private Button buttonequal;
        private Button buttondiv;
        private MenuStrip menuStrip1;
        private Button buttonPie;
        private Button buttonLog;
        private Button buttonsqrt;
        private Button power2;
        private Button sinh;
        private Button sin;
        private Button e;
        private Button powerY;
        private Button cosh;
        private Button cos;
        private Button button12;
        private Button tanh;
        private Button tan;
        private Button ln;
        private Button exp;
        private Button moduls;
        private Button Inverse;
        private Button percentage;
        private ToolStripMenuItem modeToolStripMenuItem;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem scientificToolStripMenuItem;
        private ToolStripMenuItem graphicalToolStripMenuItem;
    }
}
