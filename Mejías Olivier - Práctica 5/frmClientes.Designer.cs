
namespace Mejías_Olivier___Práctica_5
{
    partial class frmClientes
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
            this.txtDatoCedulaCliente = new System.Windows.Forms.TextBox();
            this.txtNombreAsignar = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnListarCli = new System.Windows.Forms.Button();
            this.btnElimCli = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lvwClientes = new System.Windows.Forms.ListView();
            this.clmCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnCedula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnApellido1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnApellido2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnEntradComp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnActivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwEntradas = new System.Windows.Forms.ListView();
            this.clnEvento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListarTodosCli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDatoCedulaCliente
            // 
            this.txtDatoCedulaCliente.Location = new System.Drawing.Point(56, 80);
            this.txtDatoCedulaCliente.Name = "txtDatoCedulaCliente";
            this.txtDatoCedulaCliente.Size = new System.Drawing.Size(100, 20);
            this.txtDatoCedulaCliente.TabIndex = 0;
            // 
            // txtNombreAsignar
            // 
            this.txtNombreAsignar.Location = new System.Drawing.Point(177, 80);
            this.txtNombreAsignar.Name = "txtNombreAsignar";
            this.txtNombreAsignar.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAsignar.TabIndex = 1;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(301, 80);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(100, 20);
            this.txtPrimerApellido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CÉDULA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOMBRE ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "PRIMER APELLIDO ";
            // 
            // btnListarCli
            // 
            this.btnListarCli.Location = new System.Drawing.Point(56, 118);
            this.btnListarCli.Name = "btnListarCli";
            this.btnListarCli.Size = new System.Drawing.Size(100, 34);
            this.btnListarCli.TabIndex = 7;
            this.btnListarCli.Text = "LISTAR";
            this.btnListarCli.UseVisualStyleBackColor = true;
            this.btnListarCli.Click += new System.EventHandler(this.btnListarCli_Click);
            // 
            // btnElimCli
            // 
            this.btnElimCli.Location = new System.Drawing.Point(177, 120);
            this.btnElimCli.Name = "btnElimCli";
            this.btnElimCli.Size = new System.Drawing.Size(100, 77);
            this.btnElimCli.TabIndex = 8;
            this.btnElimCli.Text = "ELIMINAR (click antes en la lista)";
            this.btnElimCli.UseVisualStyleBackColor = true;
            this.btnElimCli.Click += new System.EventHandler(this.btnElimCli_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(301, 118);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(100, 79);
            this.btnAgregarCliente.TabIndex = 9;
            this.btnAgregarCliente.Text = "AGREGAR ";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(60, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Obligatorio siempre";
            // 
            // lvwClientes
            // 
            this.lvwClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCliente,
            this.clnCedula,
            this.clnNombre,
            this.clnApellido1,
            this.clnApellido2,
            this.clnEntradComp,
            this.clnActivo});
            this.lvwClientes.HideSelection = false;
            this.lvwClientes.Location = new System.Drawing.Point(56, 203);
            this.lvwClientes.Name = "lvwClientes";
            this.lvwClientes.Size = new System.Drawing.Size(721, 235);
            this.lvwClientes.TabIndex = 11;
            this.lvwClientes.UseCompatibleStateImageBehavior = false;
            this.lvwClientes.View = System.Windows.Forms.View.Details;
            // 
            // clmCliente
            // 
            this.clmCliente.Text = "Cliente";
            // 
            // clnCedula
            // 
            this.clnCedula.Text = "Cédula";
            // 
            // clnNombre
            // 
            this.clnNombre.Text = "Nombre";
            this.clnNombre.Width = 66;
            // 
            // clnApellido1
            // 
            this.clnApellido1.Text = "Primer Apellido";
            this.clnApellido1.Width = 96;
            // 
            // clnApellido2
            // 
            this.clnApellido2.Text = "Segundo Apellido";
            this.clnApellido2.Width = 107;
            // 
            // clnEntradComp
            // 
            this.clnEntradComp.Text = "Entradas Compradas";
            this.clnEntradComp.Width = 121;
            // 
            // clnActivo
            // 
            this.clnActivo.Text = "Activo";
            // 
            // lvwEntradas
            // 
            this.lvwEntradas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnTipo,
            this.clnEvento,
            this.clnValor});
            this.lvwEntradas.HideSelection = false;
            this.lvwEntradas.Location = new System.Drawing.Point(416, 12);
            this.lvwEntradas.Name = "lvwEntradas";
            this.lvwEntradas.Size = new System.Drawing.Size(361, 185);
            this.lvwEntradas.TabIndex = 12;
            this.lvwEntradas.UseCompatibleStateImageBehavior = false;
            this.lvwEntradas.View = System.Windows.Forms.View.Details;
            // 
            // clnEvento
            // 
            this.clnEvento.Text = "Evento";
            // 
            // clnTipo
            // 
            this.clnTipo.Text = "Tipo";
            this.clnTipo.Width = 66;
            // 
            // clnValor
            // 
            this.clnValor.Text = "Valor (colones)";
            this.clnValor.Width = 131;
            // 
            // btnListarTodosCli
            // 
            this.btnListarTodosCli.Location = new System.Drawing.Point(56, 159);
            this.btnListarTodosCli.Name = "btnListarTodosCli";
            this.btnListarTodosCli.Size = new System.Drawing.Size(100, 38);
            this.btnListarTodosCli.TabIndex = 13;
            this.btnListarTodosCli.Text = "LISTAR TODOS";
            this.btnListarTodosCli.UseVisualStyleBackColor = true;
            this.btnListarTodosCli.Click += new System.EventHandler(this.btnListarTodosCli_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarTodosCli);
            this.Controls.Add(this.lvwEntradas);
            this.Controls.Add(this.lvwClientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnElimCli);
            this.Controls.Add(this.btnListarCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.txtNombreAsignar);
            this.Controls.Add(this.txtDatoCedulaCliente);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatoCedulaCliente;
        private System.Windows.Forms.TextBox txtNombreAsignar;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnListarCli;
        private System.Windows.Forms.Button btnElimCli;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvwClientes;
        private System.Windows.Forms.ColumnHeader clmCliente;
        private System.Windows.Forms.ColumnHeader clnCedula;
        private System.Windows.Forms.ColumnHeader clnNombre;
        private System.Windows.Forms.ColumnHeader clnApellido1;
        private System.Windows.Forms.ColumnHeader clnApellido2;
        private System.Windows.Forms.ListView lvwEntradas;
        private System.Windows.Forms.ColumnHeader clnEntradComp;
        private System.Windows.Forms.ColumnHeader clnActivo;
        private System.Windows.Forms.ColumnHeader clnEvento;
        private System.Windows.Forms.ColumnHeader clnTipo;
        private System.Windows.Forms.ColumnHeader clnValor;
        private System.Windows.Forms.Button btnListarTodosCli;
    }
}