namespace Actividad_Practica_4
{
    partial class form3
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
            this.dgv_Proveedores = new System.Windows.Forms.DataGridView();
            this.btn_CargarProveedor = new System.Windows.Forms.Button();
            this.btn_EliminarProveedor = new System.Windows.Forms.Button();
            this.txt_EliminarProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NombreProveedor = new System.Windows.Forms.TextBox();
            this.btn_AgregarProveedor = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TelefonoProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CorreoProveedor = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CorreoA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TelefonoProveedorA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_NombreProveedorA = new System.Windows.Forms.TextBox();
            this.btn_ActualizarProvee = new System.Windows.Forms.Button();
            this.txt_IdProoveedorA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proveedores)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Proveedores
            // 
            this.dgv_Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Proveedores.Location = new System.Drawing.Point(0, 21);
            this.dgv_Proveedores.Name = "dgv_Proveedores";
            this.dgv_Proveedores.RowHeadersWidth = 51;
            this.dgv_Proveedores.RowTemplate.Height = 24;
            this.dgv_Proveedores.Size = new System.Drawing.Size(1229, 346);
            this.dgv_Proveedores.TabIndex = 0;
            this.dgv_Proveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Proveedores_CellContentClick);
            // 
            // btn_CargarProveedor
            // 
            this.btn_CargarProveedor.Location = new System.Drawing.Point(272, 252);
            this.btn_CargarProveedor.Name = "btn_CargarProveedor";
            this.btn_CargarProveedor.Size = new System.Drawing.Size(613, 70);
            this.btn_CargarProveedor.TabIndex = 27;
            this.btn_CargarProveedor.Text = "Cargar";
            this.btn_CargarProveedor.UseVisualStyleBackColor = true;
            this.btn_CargarProveedor.Click += new System.EventHandler(this.btn_CargarProveedor_Click);
            // 
            // btn_EliminarProveedor
            // 
            this.btn_EliminarProveedor.Location = new System.Drawing.Point(15, 75);
            this.btn_EliminarProveedor.Name = "btn_EliminarProveedor";
            this.btn_EliminarProveedor.Size = new System.Drawing.Size(196, 41);
            this.btn_EliminarProveedor.TabIndex = 13;
            this.btn_EliminarProveedor.Text = "Eliminar";
            this.btn_EliminarProveedor.UseVisualStyleBackColor = true;
            this.btn_EliminarProveedor.Click += new System.EventHandler(this.btn_EliminarProveedor_Click);
            // 
            // txt_EliminarProveedor
            // 
            this.txt_EliminarProveedor.Location = new System.Drawing.Point(15, 47);
            this.txt_EliminarProveedor.Name = "txt_EliminarProveedor";
            this.txt_EliminarProveedor.Size = new System.Drawing.Size(196, 22);
            this.txt_EliminarProveedor.TabIndex = 14;
            this.txt_EliminarProveedor.TextChanged += new System.EventHandler(this.txt_EliminarProveedor_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID Proveedor";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_EliminarProveedor);
            this.groupBox2.Controls.Add(this.txt_EliminarProveedor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(513, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 129);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Proveedor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_NombreProveedor
            // 
            this.txt_NombreProveedor.Location = new System.Drawing.Point(6, 50);
            this.txt_NombreProveedor.Name = "txt_NombreProveedor";
            this.txt_NombreProveedor.Size = new System.Drawing.Size(204, 22);
            this.txt_NombreProveedor.TabIndex = 3;
            this.txt_NombreProveedor.TextChanged += new System.EventHandler(this.txt_NombreProveedor_TextChanged);
            // 
            // btn_AgregarProveedor
            // 
            this.btn_AgregarProveedor.Location = new System.Drawing.Point(246, 85);
            this.btn_AgregarProveedor.Name = "btn_AgregarProveedor";
            this.btn_AgregarProveedor.Size = new System.Drawing.Size(189, 53);
            this.btn_AgregarProveedor.TabIndex = 12;
            this.btn_AgregarProveedor.Text = "Agregar";
            this.btn_AgregarProveedor.UseVisualStyleBackColor = true;
            this.btn_AgregarProveedor.Click += new System.EventHandler(this.btn_AgregarProveedor_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_Proveedores);
            this.groupBox4.Location = new System.Drawing.Point(3, 328);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1229, 367);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mostrar";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_CorreoProveedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_TelefonoProveedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_NombreProveedor);
            this.groupBox1.Controls.Add(this.btn_AgregarProveedor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 146);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Telefono";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_TelefonoProveedor
            // 
            this.txt_TelefonoProveedor.Location = new System.Drawing.Point(221, 45);
            this.txt_TelefonoProveedor.Name = "txt_TelefonoProveedor";
            this.txt_TelefonoProveedor.Size = new System.Drawing.Size(204, 22);
            this.txt_TelefonoProveedor.TabIndex = 14;
            this.txt_TelefonoProveedor.TextChanged += new System.EventHandler(this.txt_TelefonoProveedor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Correo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_CorreoProveedor
            // 
            this.txt_CorreoProveedor.Location = new System.Drawing.Point(6, 111);
            this.txt_CorreoProveedor.Name = "txt_CorreoProveedor";
            this.txt_CorreoProveedor.Size = new System.Drawing.Size(204, 22);
            this.txt_CorreoProveedor.TabIndex = 16;
            this.txt_CorreoProveedor.TextChanged += new System.EventHandler(this.txt_CorreoProveedor_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_IdProoveedorA);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txt_CorreoA);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txt_TelefonoProveedorA);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txt_NombreProveedorA);
            this.groupBox5.Controls.Add(this.btn_ActualizarProvee);
            this.groupBox5.Location = new System.Drawing.Point(750, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(459, 217);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Actualizar";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Correo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_CorreoA
            // 
            this.txt_CorreoA.Location = new System.Drawing.Point(9, 164);
            this.txt_CorreoA.Name = "txt_CorreoA";
            this.txt_CorreoA.Size = new System.Drawing.Size(204, 22);
            this.txt_CorreoA.TabIndex = 16;
            this.txt_CorreoA.TextChanged += new System.EventHandler(this.txt_CorreoA_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefono";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_TelefonoProveedorA
            // 
            this.txt_TelefonoProveedorA.Location = new System.Drawing.Point(221, 45);
            this.txt_TelefonoProveedorA.Name = "txt_TelefonoProveedorA";
            this.txt_TelefonoProveedorA.Size = new System.Drawing.Size(204, 22);
            this.txt_TelefonoProveedorA.TabIndex = 14;
            this.txt_TelefonoProveedorA.TextChanged += new System.EventHandler(this.txt_TelefonoProveedorA_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nombre Proveedor";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_NombreProveedorA
            // 
            this.txt_NombreProveedorA.Location = new System.Drawing.Point(12, 107);
            this.txt_NombreProveedorA.Name = "txt_NombreProveedorA";
            this.txt_NombreProveedorA.Size = new System.Drawing.Size(204, 22);
            this.txt_NombreProveedorA.TabIndex = 3;
            this.txt_NombreProveedorA.TextChanged += new System.EventHandler(this.txt_NombreProveedorA_TextChanged);
            // 
            // btn_ActualizarProvee
            // 
            this.btn_ActualizarProvee.Location = new System.Drawing.Point(249, 107);
            this.btn_ActualizarProvee.Name = "btn_ActualizarProvee";
            this.btn_ActualizarProvee.Size = new System.Drawing.Size(189, 67);
            this.btn_ActualizarProvee.TabIndex = 12;
            this.btn_ActualizarProvee.Text = "Actualizar";
            this.btn_ActualizarProvee.UseVisualStyleBackColor = true;
            this.btn_ActualizarProvee.Click += new System.EventHandler(this.btn_ActualizarProvee_Click);
            // 
            // txt_IdProoveedorA
            // 
            this.txt_IdProoveedorA.Location = new System.Drawing.Point(15, 45);
            this.txt_IdProoveedorA.Name = "txt_IdProoveedorA";
            this.txt_IdProoveedorA.Size = new System.Drawing.Size(180, 22);
            this.txt_IdProoveedorA.TabIndex = 18;
            this.txt_IdProoveedorA.TextChanged += new System.EventHandler(this.txt_IdProoveedorA_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "ID";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1236, 697);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btn_CargarProveedor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "form3";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proveedores)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Proveedores;
        private System.Windows.Forms.Button btn_CargarProveedor;
        private System.Windows.Forms.Button btn_EliminarProveedor;
        private System.Windows.Forms.TextBox txt_EliminarProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NombreProveedor;
        private System.Windows.Forms.Button btn_AgregarProveedor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CorreoProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TelefonoProveedor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CorreoA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TelefonoProveedorA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_NombreProveedorA;
        private System.Windows.Forms.Button btn_ActualizarProvee;
        private System.Windows.Forms.TextBox txt_IdProoveedorA;
        private System.Windows.Forms.Label label9;
    }
}