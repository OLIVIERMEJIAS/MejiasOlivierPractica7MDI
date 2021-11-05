
namespace Mejías_Olivier___Práctica_5
{
    partial class frmVenderEntradas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedulaAsignar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.txtMensajeAsignar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnValidarCedula = new System.Windows.Forms.Button();
            this.btnValidarPal = new System.Windows.Forms.Button();
            this.btnValidarGram = new System.Windows.Forms.Button();
            this.btnValidarGen = new System.Windows.Forms.Button();
            this.txtNumPal = new System.Windows.Forms.TextBox();
            this.txtNumGram = new System.Windows.Forms.TextBox();
            this.txtNumGen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula del Cliente";
            // 
            // txtCedulaAsignar
            // 
            this.txtCedulaAsignar.Location = new System.Drawing.Point(59, 95);
            this.txtCedulaAsignar.Name = "txtCedulaAsignar";
            this.txtCedulaAsignar.Size = new System.Drawing.Size(98, 20);
            this.txtCedulaAsignar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "GENERAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "GRAMILLA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PALCO VIP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "TIPOS DE ENTRADA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "NÚMERO";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Enabled = false;
            this.btnAsignar.Location = new System.Drawing.Point(328, 229);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(262, 55);
            this.btnAsignar.TabIndex = 10;
            this.btnAsignar.Text = "ASIGNAR";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // txtMensajeAsignar
            // 
            this.txtMensajeAsignar.Location = new System.Drawing.Point(59, 321);
            this.txtMensajeAsignar.Name = "txtMensajeAsignar";
            this.txtMensajeAsignar.Size = new System.Drawing.Size(531, 20);
            this.txtMensajeAsignar.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mensaje";
            // 
            // btnValidarCedula
            // 
            this.btnValidarCedula.Location = new System.Drawing.Point(68, 137);
            this.btnValidarCedula.Name = "btnValidarCedula";
            this.btnValidarCedula.Size = new System.Drawing.Size(75, 23);
            this.btnValidarCedula.TabIndex = 13;
            this.btnValidarCedula.Text = "VALIDAR";
            this.btnValidarCedula.UseVisualStyleBackColor = true;
            this.btnValidarCedula.Click += new System.EventHandler(this.btnValidarCedula_Click);
            // 
            // btnValidarPal
            // 
            this.btnValidarPal.Location = new System.Drawing.Point(515, 187);
            this.btnValidarPal.Name = "btnValidarPal";
            this.btnValidarPal.Size = new System.Drawing.Size(75, 23);
            this.btnValidarPal.TabIndex = 17;
            this.btnValidarPal.Text = "VALIDAR";
            this.btnValidarPal.UseVisualStyleBackColor = true;
            this.btnValidarPal.Click += new System.EventHandler(this.btnValidarPal_Click);
            // 
            // btnValidarGram
            // 
            this.btnValidarGram.Location = new System.Drawing.Point(515, 134);
            this.btnValidarGram.Name = "btnValidarGram";
            this.btnValidarGram.Size = new System.Drawing.Size(75, 23);
            this.btnValidarGram.TabIndex = 18;
            this.btnValidarGram.Text = "VALIDAR";
            this.btnValidarGram.UseVisualStyleBackColor = true;
            this.btnValidarGram.Click += new System.EventHandler(this.btnValidarGram_Click);
            // 
            // btnValidarGen
            // 
            this.btnValidarGen.Location = new System.Drawing.Point(515, 92);
            this.btnValidarGen.Name = "btnValidarGen";
            this.btnValidarGen.Size = new System.Drawing.Size(75, 23);
            this.btnValidarGen.TabIndex = 19;
            this.btnValidarGen.Text = "VALIDAR";
            this.btnValidarGen.UseVisualStyleBackColor = true;
            this.btnValidarGen.Click += new System.EventHandler(this.btnValidarGen_Click);
            // 
            // txtNumPal
            // 
            this.txtNumPal.Enabled = false;
            this.txtNumPal.Location = new System.Drawing.Point(328, 185);
            this.txtNumPal.Name = "txtNumPal";
            this.txtNumPal.Size = new System.Drawing.Size(98, 20);
            this.txtNumPal.TabIndex = 20;
            // 
            // txtNumGram
            // 
            this.txtNumGram.Enabled = false;
            this.txtNumGram.Location = new System.Drawing.Point(328, 140);
            this.txtNumGram.Name = "txtNumGram";
            this.txtNumGram.Size = new System.Drawing.Size(98, 20);
            this.txtNumGram.TabIndex = 21;
            // 
            // txtNumGen
            // 
            this.txtNumGen.Enabled = false;
            this.txtNumGen.Location = new System.Drawing.Point(328, 95);
            this.txtNumGen.Name = "txtNumGen";
            this.txtNumGen.Size = new System.Drawing.Size(98, 20);
            this.txtNumGen.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(287, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(331, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Para asingar entradas de varios tipos, debe dar click en cada Validar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(12, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Si se bloquea un espacio, solo valide la cédula de nuevo.";
            // 
            // frmVenderEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 382);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumGen);
            this.Controls.Add(this.txtNumGram);
            this.Controls.Add(this.txtNumPal);
            this.Controls.Add(this.btnValidarGen);
            this.Controls.Add(this.btnValidarGram);
            this.Controls.Add(this.btnValidarPal);
            this.Controls.Add(this.btnValidarCedula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMensajeAsignar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCedulaAsignar);
            this.Controls.Add(this.label1);
            this.Name = "frmVenderEntradas";
            this.Text = "VenderEntradas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedulaAsignar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.TextBox txtMensajeAsignar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnValidarCedula;
        private System.Windows.Forms.Button btnValidarPal;
        private System.Windows.Forms.Button btnValidarGram;
        private System.Windows.Forms.Button btnValidarGen;
        private System.Windows.Forms.TextBox txtNumPal;
        private System.Windows.Forms.TextBox txtNumGram;
        private System.Windows.Forms.TextBox txtNumGen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}