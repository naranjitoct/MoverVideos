namespace AppMoverVIdeos
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
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox11 = new CheckBox();
            button2 = new Button();
            label6 = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(244, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(374, 23);
            textBox1.TabIndex = 0;
            textBox1.Tag = "txtRoot";
            // 
            // button1
            // 
            button1.Location = new Point(624, 19);
            button1.Name = "button1";
            button1.Size = new Size(36, 23);
            button1.TabIndex = 1;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(221, 15);
            label1.TabIndex = 2;
            label1.Text = "Carpeta origen (Selecciona o copia ruta):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(143, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre Carpeta destino :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(244, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(374, 23);
            textBox2.TabIndex = 3;
            textBox2.Tag = "txtDest";
            textBox2.Text = "00_SOLO_VIDEOS";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ejecutar (real)", "Simular (dry-run)" });
            comboBox1.Location = new Point(57, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            comboBox1.Tag = "cmbMode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Modo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 140);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 9;
            label4.Text = "Acción";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Mover", "Copiar" });
            comboBox2.Location = new Point(57, 137);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 8;
            comboBox2.Tag = "cmbAction";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 180);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 10;
            label5.Text = "Extensiones:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(checkBox1);
            flowLayoutPanel1.Controls.Add(checkBox2);
            flowLayoutPanel1.Controls.Add(checkBox3);
            flowLayoutPanel1.Controls.Add(checkBox4);
            flowLayoutPanel1.Controls.Add(checkBox5);
            flowLayoutPanel1.Controls.Add(checkBox6);
            flowLayoutPanel1.Controls.Add(checkBox7);
            flowLayoutPanel1.Controls.Add(checkBox8);
            flowLayoutPanel1.Location = new Point(27, 204);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(239, 50);
            flowLayoutPanel1.TabIndex = 11;
            flowLayoutPanel1.Tag = "pnlExts";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(53, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Tag = "cbmp4";
            checkBox1.Text = ".mp4";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(62, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(52, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Tag = "cbm4v";
            checkBox2.Text = ".m4v";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(120, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(53, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Tag = "cbmov";
            checkBox3.Text = ".mov";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(179, 3);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(44, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Tag = "cbavi";
            checkBox4.Text = ".avi";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(3, 28);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(52, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Tag = "cbmkv";
            checkBox5.Text = ".mkv";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(61, 28);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(55, 19);
            checkBox6.TabIndex = 5;
            checkBox6.Tag = "cbwmv";
            checkBox6.Text = ".wmv";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(122, 28);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(42, 19);
            checkBox7.TabIndex = 6;
            checkBox7.Tag = "cbflv";
            checkBox7.Text = ".flv";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(170, 28);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(62, 19);
            checkBox8.TabIndex = 7;
            checkBox8.Tag = "cbmp4";
            checkBox8.Text = ".webm";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(115, 179);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(118, 19);
            checkBox11.TabIndex = 12;
            checkBox11.Tag = "chkAllExts";
            checkBox11.Text = "Seleccionar todas";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(332, 207);
            button2.Name = "button2";
            button2.Size = new Size(109, 48);
            button2.TabIndex = 13;
            button2.Tag = "btnRun";
            button2.Text = "EJECUTAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(474, 224);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 14;
            label6.Tag = "lblStatus";
            label6.Text = "ESTADO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 290);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(checkBox11);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox11;
        private Button button2;
        private Label label6;
    }
}
