namespace Actividad_Practica_4
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NombreCategoria = new System.Windows.Forms.TextBox();
            this.btn_AgregarCategoria = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_EliminarCategoria = new System.Windows.Forms.Button();
            this.txt_EliminarCategoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_IdCategoriaActualizar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NombreCategoriaA = new System.Windows.Forms.TextBox();
            this.btn_ActualizarCategoria = new System.Windows.Forms.Button();
            this.btn_CargarCategoria = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_Categoria = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_NombreCategoria);
            this.groupBox1.Controls.Add(this.btn_AgregarCategoria);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 145);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Categoria";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_NombreCategoria
            // 
            this.txt_NombreCategoria.Location = new System.Drawing.Point(6, 50);
            this.txt_NombreCategoria.Name = "txt_NombreCategoria";
            this.txt_NombreCategoria.Size = new System.Drawing.Size(204, 22);
            this.txt_NombreCategoria.TabIndex = 3;
            // 
            // btn_AgregarCategoria
            // 
            this.btn_AgregarCategoria.Location = new System.Drawing.Point(6, 78);
            this.btn_AgregarCategoria.Name = "btn_AgregarCategoria";
            this.btn_AgregarCategoria.Size = new System.Drawing.Size(189, 41);
            this.btn_AgregarCategoria.TabIndex = 12;
            this.btn_AgregarCategoria.Text = "Agregar";
            this.btn_AgregarCategoria.UseVisualStyleBackColor = true;
            this.btn_AgregarCategoria.Click += new System.EventHandler(this.btn_AgregarCategoria_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_EliminarCategoria);
            this.groupBox2.Controls.Add(this.txt_EliminarCategoria);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(276, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 129);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar";
            // 
            // btn_EliminarCategoria
            // 
            this.btn_EliminarCategoria.Location = new System.Drawing.Point(15, 76);
            this.btn_EliminarCategoria.Name = "btn_EliminarCategoria";
            this.btn_EliminarCategoria.Size = new System.Drawing.Size(196, 41);
            this.btn_EliminarCategoria.TabIndex = 13;
            this.btn_EliminarCategoria.Text = "Eliminar";
            this.btn_EliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // txt_EliminarCategoria
            // 
            this.txt_EliminarCategoria.Location = new System.Drawing.Point(15, 47);
            this.txt_EliminarCategoria.Name = "txt_EliminarCategoria";
            this.txt_EliminarCategoria.Size = new System.Drawing.Size(196, 22);
            this.txt_EliminarCategoria.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID Categoria";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_IdCategoriaActualizar);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_NombreCategoriaA);
            this.groupBox3.Controls.Add(this.btn_ActualizarCategoria);
            this.groupBox3.Location = new System.Drawing.Point(541, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 190);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actualizar";
            // 
            // txt_IdCategoriaActualizar
            // 
            this.txt_IdCategoriaActualizar.Location = new System.Drawing.Point(20, 45);
            this.txt_IdCategoriaActualizar.Name = "txt_IdCategoriaActualizar";
            this.txt_IdCategoriaActualizar.Size = new System.Drawing.Size(180, 22);
            this.txt_IdCategoriaActualizar.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre Categoria";
            // 
            // txt_NombreCategoriaA
            // 
            this.txt_NombreCategoriaA.Location = new System.Drawing.Point(20, 97);
            this.txt_NombreCategoriaA.Name = "txt_NombreCategoriaA";
            this.txt_NombreCategoriaA.Size = new System.Drawing.Size(185, 22);
            this.txt_NombreCategoriaA.TabIndex = 3;
            // 
            // btn_ActualizarCategoria
            // 
            this.btn_ActualizarCategoria.Location = new System.Drawing.Point(48, 138);
            this.btn_ActualizarCategoria.Name = "btn_ActualizarCategoria";
            this.btn_ActualizarCategoria.Size = new System.Drawing.Size(189, 41);
            this.btn_ActualizarCategoria.TabIndex = 12;
            this.btn_ActualizarCategoria.Text = "Actualizar";
            this.btn_ActualizarCategoria.UseVisualStyleBackColor = true;
            // 
            // btn_CargarCategoria
            // 
            this.btn_CargarCategoria.Location = new System.Drawing.Point(128, 222);
            this.btn_CargarCategoria.Name = "btn_CargarCategoria";
            this.btn_CargarCategoria.Size = new System.Drawing.Size(613, 70);
            this.btn_CargarCategoria.TabIndex = 22;
            this.btn_CargarCategoria.Text = "Cargar";
            this.btn_CargarCategoria.UseVisualStyleBackColor = true;
            this.btn_CargarCategoria.Click += new System.EventHandler(this.btn_CargarCategoria_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_Categoria);
            this.groupBox4.Location = new System.Drawing.Point(3, 298);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(873, 336);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mostrar";
            // 
            // dgv_Categoria
            // 
            this.dgv_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Categoria.Location = new System.Drawing.Point(9, 15);
            this.dgv_Categoria.Name = "dgv_Categoria";
            this.dgv_Categoria.RowHeadersWidth = 51;
            this.dgv_Categoria.RowTemplate.Height = 24;
            this.dgv_Categoria.Size = new System.Drawing.Size(849, 315);
            this.dgv_Categoria.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(878, 633);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_CargarCategoria);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Categorias";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NombreCategoria;
        private System.Windows.Forms.Button btn_AgregarCategoria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_EliminarCategoria;
        private System.Windows.Forms.TextBox txt_EliminarCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_IdCategoriaActualizar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NombreCategoriaA;
        private System.Windows.Forms.Button btn_ActualizarCategoria;
        private System.Windows.Forms.Button btn_CargarCategoria;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_Categoria;
    }
}