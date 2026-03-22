namespace ProiectPAW_OpreaAndreea_1059D
{
    partial class FormProdus
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumeProdus = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRaioane = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMagazine2 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.butonRenunta1 = new ProiectPAW_OpreaAndreea_1059D.ButonRenunta();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume Produs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantitate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pret";
            // 
            // tbNumeProdus
            // 
            this.tbNumeProdus.Location = new System.Drawing.Point(269, 123);
            this.tbNumeProdus.Name = "tbNumeProdus";
            this.tbNumeProdus.Size = new System.Drawing.Size(188, 22);
            this.tbNumeProdus.TabIndex = 3;
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(269, 170);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(188, 22);
            this.tbPret.TabIndex = 4;
            this.tbPret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPret_KeyPress);
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(269, 217);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(188, 22);
            this.tbCantitate.TabIndex = 5;
            this.tbCantitate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantitate_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(53, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salveaza Produs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Selecteaza Raionul";
            // 
            // cbRaioane
            // 
            this.cbRaioane.FormattingEnabled = true;
            this.cbRaioane.Location = new System.Drawing.Point(269, 74);
            this.cbRaioane.Name = "cbRaioane";
            this.cbRaioane.Size = new System.Drawing.Size(188, 24);
            this.cbRaioane.TabIndex = 8;
            this.cbRaioane.Validating += new System.ComponentModel.CancelEventHandler(this.cbRaioane_Validating);
            this.cbRaioane.Validated += new System.EventHandler(this.cbRaioane_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Selecteaza Magazinul";
            // 
            // cbMagazine2
            // 
            this.cbMagazine2.FormattingEnabled = true;
            this.cbMagazine2.Location = new System.Drawing.Point(269, 25);
            this.cbMagazine2.Name = "cbMagazine2";
            this.cbMagazine2.Size = new System.Drawing.Size(188, 24);
            this.cbMagazine2.TabIndex = 10;
            this.cbMagazine2.SelectedIndexChanged += new System.EventHandler(this.cbMagazine2_SelectedIndexChanged);
            this.cbMagazine2.Validating += new System.ComponentModel.CancelEventHandler(this.cbMagazine2_Validating);
            this.cbMagazine2.Validated += new System.EventHandler(this.cbMagazine2_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.butonRenunta1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbCantitate);
            this.panel1.Controls.Add(this.tbNumeProdus);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbPret);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbMagazine2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbRaioane);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 390);
            this.panel1.TabIndex = 11;
            // 
            // butonRenunta1
            // 
            this.butonRenunta1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butonRenunta1.ForeColor = System.Drawing.Color.SteelBlue;
            this.butonRenunta1.Location = new System.Drawing.Point(279, 244);
            this.butonRenunta1.Name = "butonRenunta1";
            this.butonRenunta1.Size = new System.Drawing.Size(178, 107);
            this.butonRenunta1.TabIndex = 11;
            // 
            // FormProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(520, 375);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormProdus";
            this.Text = "Produs";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumeProdus;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRaioane;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMagazine2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private ButonRenunta butonRenunta1;
    }
}