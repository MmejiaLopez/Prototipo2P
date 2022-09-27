
namespace Empleados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.panelNominas = new System.Windows.Forms.Panel();
            this.btnConcepto = new System.Windows.Forms.Button();
            this.btnNominaFecha = new System.Windows.Forms.Button();
            this.btnNomina = new System.Windows.Forms.Button();
            this.btnNominas = new System.Windows.Forms.Button();
            this.panelEmpleados = new System.Windows.Forms.Panel();
            this.btnPuesto = new System.Windows.Forms.Button();
            this.btnDepartamento = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelNominas.SuspendLayout();
            this.panelEmpleados.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(164)))), ((int)(((byte)(242)))));
            this.panelSideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSideMenu.Controls.Add(this.btnProveedor);
            this.panelSideMenu.Controls.Add(this.panelNominas);
            this.panelSideMenu.Controls.Add(this.btnNominas);
            this.panelSideMenu.Controls.Add(this.panelEmpleados);
            this.panelSideMenu.Controls.Add(this.btnEmpleado);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(237, 1041);
            this.panelSideMenu.TabIndex = 3;
            // 
            // btnProveedor
            // 
            this.btnProveedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedor.FlatAppearance.BorderSize = 0;
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btnProveedor.Location = new System.Drawing.Point(0, 419);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnProveedor.Size = new System.Drawing.Size(237, 39);
            this.btnProveedor.TabIndex = 4;
            this.btnProveedor.Text = "Salir";
            this.btnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedor.UseVisualStyleBackColor = true;
            // 
            // panelNominas
            // 
            this.panelNominas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(215)))), ((int)(((byte)(249)))));
            this.panelNominas.Controls.Add(this.btnConcepto);
            this.panelNominas.Controls.Add(this.btnNominaFecha);
            this.panelNominas.Controls.Add(this.btnNomina);
            this.panelNominas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNominas.Location = new System.Drawing.Point(0, 292);
            this.panelNominas.Name = "panelNominas";
            this.panelNominas.Size = new System.Drawing.Size(237, 127);
            this.panelNominas.TabIndex = 3;
            // 
            // btnConcepto
            // 
            this.btnConcepto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConcepto.FlatAppearance.BorderSize = 0;
            this.btnConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcepto.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnConcepto.Location = new System.Drawing.Point(0, 70);
            this.btnConcepto.Name = "btnConcepto";
            this.btnConcepto.Padding = new System.Windows.Forms.Padding(64, 0, 0, 0);
            this.btnConcepto.Size = new System.Drawing.Size(237, 35);
            this.btnConcepto.TabIndex = 2;
            this.btnConcepto.Text = "Concepto";
            this.btnConcepto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConcepto.UseVisualStyleBackColor = true;
            this.btnConcepto.Click += new System.EventHandler(this.btnConcepto_Click);
            // 
            // btnNominaFecha
            // 
            this.btnNominaFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNominaFecha.FlatAppearance.BorderSize = 0;
            this.btnNominaFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNominaFecha.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnNominaFecha.Location = new System.Drawing.Point(0, 35);
            this.btnNominaFecha.Name = "btnNominaFecha";
            this.btnNominaFecha.Padding = new System.Windows.Forms.Padding(64, 0, 0, 0);
            this.btnNominaFecha.Size = new System.Drawing.Size(237, 35);
            this.btnNominaFecha.TabIndex = 1;
            this.btnNominaFecha.Text = "Fecha";
            this.btnNominaFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNominaFecha.UseVisualStyleBackColor = true;
            this.btnNominaFecha.Click += new System.EventHandler(this.btnNominaFecha_Click);
            // 
            // btnNomina
            // 
            this.btnNomina.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNomina.FlatAppearance.BorderSize = 0;
            this.btnNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNomina.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnNomina.Location = new System.Drawing.Point(0, 0);
            this.btnNomina.Name = "btnNomina";
            this.btnNomina.Padding = new System.Windows.Forms.Padding(64, 0, 0, 0);
            this.btnNomina.Size = new System.Drawing.Size(237, 35);
            this.btnNomina.TabIndex = 0;
            this.btnNomina.Text = "Nomina";
            this.btnNomina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNomina.UseVisualStyleBackColor = true;
            this.btnNomina.Click += new System.EventHandler(this.btnNomina_Click);
            // 
            // btnNominas
            // 
            this.btnNominas.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNominas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNominas.FlatAppearance.BorderSize = 0;
            this.btnNominas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNominas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNominas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btnNominas.Location = new System.Drawing.Point(0, 253);
            this.btnNominas.Name = "btnNominas";
            this.btnNominas.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnNominas.Size = new System.Drawing.Size(237, 39);
            this.btnNominas.TabIndex = 2;
            this.btnNominas.Text = "Nominas";
            this.btnNominas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNominas.UseVisualStyleBackColor = true;
            this.btnNominas.Click += new System.EventHandler(this.btnNominas_Click);
            // 
            // panelEmpleados
            // 
            this.panelEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(215)))), ((int)(((byte)(249)))));
            this.panelEmpleados.Controls.Add(this.btnPuesto);
            this.panelEmpleados.Controls.Add(this.btnDepartamento);
            this.panelEmpleados.Controls.Add(this.btnEmpleados);
            this.panelEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmpleados.Location = new System.Drawing.Point(0, 126);
            this.panelEmpleados.Name = "panelEmpleados";
            this.panelEmpleados.Size = new System.Drawing.Size(237, 127);
            this.panelEmpleados.TabIndex = 1;
            // 
            // btnPuesto
            // 
            this.btnPuesto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPuesto.FlatAppearance.BorderSize = 0;
            this.btnPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuesto.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnPuesto.Location = new System.Drawing.Point(0, 70);
            this.btnPuesto.Name = "btnPuesto";
            this.btnPuesto.Padding = new System.Windows.Forms.Padding(64, 0, 0, 0);
            this.btnPuesto.Size = new System.Drawing.Size(237, 35);
            this.btnPuesto.TabIndex = 2;
            this.btnPuesto.Text = "Puesto";
            this.btnPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPuesto.UseVisualStyleBackColor = true;
            this.btnPuesto.Click += new System.EventHandler(this.btnPuesto_Click);
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepartamento.FlatAppearance.BorderSize = 0;
            this.btnDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartamento.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnDepartamento.Location = new System.Drawing.Point(0, 35);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Padding = new System.Windows.Forms.Padding(64, 0, 0, 0);
            this.btnDepartamento.Size = new System.Drawing.Size(237, 35);
            this.btnDepartamento.TabIndex = 1;
            this.btnDepartamento.Text = "Departamento";
            this.btnDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartamento.UseVisualStyleBackColor = true;
            this.btnDepartamento.Click += new System.EventHandler(this.btnDepartamento_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnEmpleados.Location = new System.Drawing.Point(0, 0);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(64, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(237, 35);
            this.btnEmpleados.TabIndex = 0;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btnEmpleado.Location = new System.Drawing.Point(0, 87);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnEmpleado.Size = new System.Drawing.Size(237, 39);
            this.btnEmpleado.TabIndex = 0;
            this.btnEmpleado.Text = "Empleados";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(237, 87);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 87);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelSideMenu);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelNominas.ResumeLayout(false);
            this.panelEmpleados.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Panel panelNominas;
        private System.Windows.Forms.Button btnConcepto;
        private System.Windows.Forms.Button btnNominaFecha;
        private System.Windows.Forms.Button btnNomina;
        private System.Windows.Forms.Button btnNominas;
        private System.Windows.Forms.Panel panelEmpleados;
        private System.Windows.Forms.Button btnPuesto;
        private System.Windows.Forms.Button btnDepartamento;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

