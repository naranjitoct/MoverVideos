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
            txtRoot = new TextBox();
            btnBrowseRoot = new Button();
            label1 = new Label();
            label2 = new Label();
            txtDest = new TextBox();
            cmbMode = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cmbAction = new ComboBox();
            label5 = new Label();
            pnlExts = new FlowLayoutPanel();
            chkExtMp4 = new CheckBox();
            chkExtM4v = new CheckBox();
            chkExtMov = new CheckBox();
            chkExtAvi = new CheckBox();
            chkExtMkv = new CheckBox();
            chkExtWmv = new CheckBox();
            chkExtFlv = new CheckBox();
            chkExtWebm = new CheckBox();
            chkExtM2ts = new CheckBox();
            chkAllExts = new CheckBox();
            btnRun = new Button();
            lblStatus = new Label();
            chkExt3gp = new CheckBox();
            pnlExts.SuspendLayout();
            SuspendLayout();
            // 
            // txtRoot
            // 
            txtRoot.Location = new Point(244, 19);
            txtRoot.Name = "txtRoot";
            txtRoot.Size = new Size(374, 23);
            txtRoot.TabIndex = 0;
            // 
            // btnBrowseRoot
            // 
            btnBrowseRoot.Location = new Point(624, 19);
            btnBrowseRoot.Name = "btnBrowseRoot";
            btnBrowseRoot.Size = new Size(36, 23);
            btnBrowseRoot.TabIndex = 1;
            btnBrowseRoot.Text = "...";
            btnBrowseRoot.UseVisualStyleBackColor = true;
            btnBrowseRoot.Click += btnBrowseRoot_Click;
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
            // txtDest
            // 
            txtDest.Location = new Point(244, 57);
            txtDest.Name = "txtDest";
            txtDest.Size = new Size(374, 23);
            txtDest.TabIndex = 3;
            txtDest.Text = "00_SOLO_VIDEOS";
            // 
            // cmbMode
            // 
            cmbMode.FormattingEnabled = true;
            cmbMode.Items.AddRange(new object[] { "Ejecutar (real)", "Simular (dry-run)" });
            cmbMode.Location = new Point(57, 99);
            cmbMode.Name = "cmbMode";
            cmbMode.Size = new Size(121, 23);
            cmbMode.TabIndex = 6;
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
            // cmbAction
            // 
            cmbAction.FormattingEnabled = true;
            cmbAction.Items.AddRange(new object[] { "Mover", "Copiar" });
            cmbAction.Location = new Point(57, 137);
            cmbAction.Name = "cmbAction";
            cmbAction.Size = new Size(121, 23);
            cmbAction.TabIndex = 8;
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
            // pnlExts
            // 
            pnlExts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlExts.AutoSize = true;
            pnlExts.Controls.Add(chkExtMp4);
            pnlExts.Controls.Add(chkExtM4v);
            pnlExts.Controls.Add(chkExtMov);
            pnlExts.Controls.Add(chkExtAvi);
            pnlExts.Controls.Add(chkExtMkv);
            pnlExts.Controls.Add(chkExtWmv);
            pnlExts.Controls.Add(chkExtFlv);
            pnlExts.Controls.Add(chkExtWebm);
            pnlExts.Controls.Add(chkExtM2ts);
            pnlExts.Controls.Add(chkExt3gp);
            pnlExts.Location = new Point(27, 204);
            pnlExts.Name = "pnlExts";
            pnlExts.Size = new Size(239, 75);
            pnlExts.TabIndex = 11;
            // 
            // chkExtMp4
            // 
            chkExtMp4.AutoSize = true;
            chkExtMp4.Location = new Point(3, 3);
            chkExtMp4.Name = "chkExtMp4";
            chkExtMp4.Size = new Size(53, 19);
            chkExtMp4.TabIndex = 0;
            chkExtMp4.Text = ".mp4";
            chkExtMp4.UseVisualStyleBackColor = true;
            // 
            // chkExtM4v
            // 
            chkExtM4v.AutoSize = true;
            chkExtM4v.Location = new Point(62, 3);
            chkExtM4v.Name = "chkExtM4v";
            chkExtM4v.Size = new Size(52, 19);
            chkExtM4v.TabIndex = 1;
            chkExtM4v.Text = ".m4v";
            chkExtM4v.UseVisualStyleBackColor = true;
            // 
            // chkExtMov
            // 
            chkExtMov.AutoSize = true;
            chkExtMov.Location = new Point(120, 3);
            chkExtMov.Name = "chkExtMov";
            chkExtMov.Size = new Size(53, 19);
            chkExtMov.TabIndex = 2;
            chkExtMov.Text = ".mov";
            chkExtMov.UseVisualStyleBackColor = true;
            // 
            // chkExtAvi
            // 
            chkExtAvi.AutoSize = true;
            chkExtAvi.Location = new Point(179, 3);
            chkExtAvi.Name = "chkExtAvi";
            chkExtAvi.Size = new Size(44, 19);
            chkExtAvi.TabIndex = 3;
            chkExtAvi.Text = ".avi";
            chkExtAvi.UseVisualStyleBackColor = true;
            // 
            // chkExtMkv
            // 
            chkExtMkv.AutoSize = true;
            chkExtMkv.Location = new Point(3, 28);
            chkExtMkv.Name = "chkExtMkv";
            chkExtMkv.Size = new Size(52, 19);
            chkExtMkv.TabIndex = 4;
            chkExtMkv.Text = ".mkv";
            chkExtMkv.UseVisualStyleBackColor = true;
            // 
            // chkExtWmv
            // 
            chkExtWmv.AutoSize = true;
            chkExtWmv.Location = new Point(61, 28);
            chkExtWmv.Name = "chkExtWmv";
            chkExtWmv.Size = new Size(55, 19);
            chkExtWmv.TabIndex = 5;
            chkExtWmv.Text = ".wmv";
            chkExtWmv.UseVisualStyleBackColor = true;
            // 
            // chkExtFlv
            // 
            chkExtFlv.AutoSize = true;
            chkExtFlv.Location = new Point(122, 28);
            chkExtFlv.Name = "chkExtFlv";
            chkExtFlv.Size = new Size(42, 19);
            chkExtFlv.TabIndex = 6;
            chkExtFlv.Text = ".flv";
            chkExtFlv.UseVisualStyleBackColor = true;
            // 
            // chkExtWebm
            // 
            chkExtWebm.AutoSize = true;
            chkExtWebm.Location = new Point(170, 28);
            chkExtWebm.Name = "chkExtWebm";
            chkExtWebm.Size = new Size(62, 19);
            chkExtWebm.TabIndex = 7;
            chkExtWebm.Text = ".webm";
            chkExtWebm.UseVisualStyleBackColor = true;
            // 
            // chkExtM2ts
            // 
            chkExtM2ts.AutoSize = true;
            chkExtM2ts.Location = new Point(3, 53);
            chkExtM2ts.Name = "chkExtM2ts";
            chkExtM2ts.Size = new Size(55, 19);
            chkExtM2ts.TabIndex = 8;
            chkExtM2ts.Tag = "chkExtM2ts";
            chkExtM2ts.Text = ".m2ts";
            chkExtM2ts.UseVisualStyleBackColor = true;
            // 
            // chkAllExts
            // 
            chkAllExts.AutoSize = true;
            chkAllExts.Location = new Point(115, 179);
            chkAllExts.Name = "chkAllExts";
            chkAllExts.Size = new Size(118, 19);
            chkAllExts.TabIndex = 12;
            chkAllExts.Text = "Seleccionar todas";
            chkAllExts.UseVisualStyleBackColor = true;
            chkAllExts.CheckedChanged += chkAllExts_CheckedChanged;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(325, 99);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(109, 48);
            btnRun.TabIndex = 13;
            btnRun.Text = "EJECUTAR";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(282, 161);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(477, 65);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "ESTADO:";
            lblStatus.Click += lblStatus_Click;
            // 
            // chkExt3gp
            // 
            chkExt3gp.AutoSize = true;
            chkExt3gp.Location = new Point(64, 53);
            chkExt3gp.Name = "chkExt3gp";
            chkExt3gp.Size = new Size(49, 19);
            chkExt3gp.TabIndex = 9;
            chkExt3gp.Tag = "chkExt3gp";
            chkExt3gp.Text = ".3gp";
            chkExt3gp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 290);
            Controls.Add(lblStatus);
            Controls.Add(btnRun);
            Controls.Add(chkAllExts);
            Controls.Add(pnlExts);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbAction);
            Controls.Add(label3);
            Controls.Add(cmbMode);
            Controls.Add(label2);
            Controls.Add(txtDest);
            Controls.Add(label1);
            Controls.Add(btnBrowseRoot);
            Controls.Add(txtRoot);
            Name = "Form1";
            Text = "MENU PRINCIPAL";
            Load += Form1_Load;
            pnlExts.ResumeLayout(false);
            pnlExts.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRoot;
        private Button btnBrowseRoot;
        private Label label1;
        private Label label2;
        private TextBox txtDest;
        private ComboBox cmbMode;
        private Label label3;
        private Label label4;
        private ComboBox cmbAction;
        private Label label5;
        private FlowLayoutPanel pnlExts;
        private CheckBox chkExtMp4;
        private CheckBox chkExtM4v;
        private CheckBox chkExtMov;
        private CheckBox chkExtAvi;
        private CheckBox chkExtMkv;
        private CheckBox chkExtWmv;
        private CheckBox chkExtFlv;
        private CheckBox chkExtWebm;
        private CheckBox chkAllExts;
        private Button btnRun;
        private Label lblStatus;
        private CheckBox chkExtM2ts;
        private CheckBox chkExt3gp;
    }
}
    