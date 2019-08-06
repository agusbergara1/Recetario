namespace RecetarioBergara
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Ingrediente_textBox = new System.Windows.Forms.TextBox();
            this.Cantidad_textBox = new System.Windows.Forms.TextBox();
            this.Precio_textBox = new System.Windows.Forms.TextBox();
            this.ListaIngredientes_listBox = new System.Windows.Forms.ListBox();
            this.Agregar_button = new System.Windows.Forms.Button();
            this.Modificar_button = new System.Windows.Forms.Button();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pdp_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre de Ingrediente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Precio";
            // 
            // Ingrediente_textBox
            // 
            this.Ingrediente_textBox.Location = new System.Drawing.Point(247, 76);
            this.Ingrediente_textBox.Name = "Ingrediente_textBox";
            this.Ingrediente_textBox.Size = new System.Drawing.Size(156, 20);
            this.Ingrediente_textBox.TabIndex = 3;
            this.Ingrediente_textBox.TextChanged += new System.EventHandler(this.Ingrediente_textBox_TextChanged);
            // 
            // Cantidad_textBox
            // 
            this.Cantidad_textBox.Location = new System.Drawing.Point(247, 130);
            this.Cantidad_textBox.Name = "Cantidad_textBox";
            this.Cantidad_textBox.Size = new System.Drawing.Size(156, 20);
            this.Cantidad_textBox.TabIndex = 4;
            // 
            // Precio_textBox
            // 
            this.Precio_textBox.Location = new System.Drawing.Point(247, 188);
            this.Precio_textBox.Name = "Precio_textBox";
            this.Precio_textBox.Size = new System.Drawing.Size(156, 20);
            this.Precio_textBox.TabIndex = 5;
            // 
            // ListaIngredientes_listBox
            // 
            this.ListaIngredientes_listBox.DisplayMember = "Nombre";
            this.ListaIngredientes_listBox.FormattingEnabled = true;
            this.ListaIngredientes_listBox.Location = new System.Drawing.Point(419, 76);
            this.ListaIngredientes_listBox.Name = "ListaIngredientes_listBox";
            this.ListaIngredientes_listBox.Size = new System.Drawing.Size(120, 238);
            this.ListaIngredientes_listBox.TabIndex = 6;
            // 
            // Agregar_button
            // 
            this.Agregar_button.Location = new System.Drawing.Point(247, 320);
            this.Agregar_button.Name = "Agregar_button";
            this.Agregar_button.Size = new System.Drawing.Size(75, 23);
            this.Agregar_button.TabIndex = 7;
            this.Agregar_button.Text = "Agregar";
            this.Agregar_button.UseVisualStyleBackColor = true;
            this.Agregar_button.Click += new System.EventHandler(this.Agregar_button_Click);
            // 
            // Modificar_button
            // 
            this.Modificar_button.Location = new System.Drawing.Point(329, 320);
            this.Modificar_button.Name = "Modificar_button";
            this.Modificar_button.Size = new System.Drawing.Size(74, 23);
            this.Modificar_button.TabIndex = 8;
            this.Modificar_button.Text = "Modificar";
            this.Modificar_button.UseVisualStyleBackColor = true;
            this.Modificar_button.Click += new System.EventHandler(this.Modificar_button_Click);
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.Location = new System.Drawing.Point(419, 320);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(75, 23);
            this.Eliminar_button.TabIndex = 9;
            this.Eliminar_button.Text = "Eliminar";
            this.Eliminar_button.UseVisualStyleBackColor = true;
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "INGREDIENTES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Punto de Pedido";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // pdp_textBox
            // 
            this.pdp_textBox.Location = new System.Drawing.Point(249, 246);
            this.pdp_textBox.Name = "pdp_textBox";
            this.pdp_textBox.Size = new System.Drawing.Size(154, 20);
            this.pdp_textBox.TabIndex = 12;
            this.pdp_textBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(808, 511);
            this.Controls.Add(this.pdp_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Eliminar_button);
            this.Controls.Add(this.Modificar_button);
            this.Controls.Add(this.Agregar_button);
            this.Controls.Add(this.ListaIngredientes_listBox);
            this.Controls.Add(this.Precio_textBox);
            this.Controls.Add(this.Cantidad_textBox);
            this.Controls.Add(this.Ingrediente_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Ingrediente_textBox;
        private System.Windows.Forms.TextBox Cantidad_textBox;
        private System.Windows.Forms.TextBox Precio_textBox;
        private System.Windows.Forms.ListBox ListaIngredientes_listBox;
        private System.Windows.Forms.Button Agregar_button;
        private System.Windows.Forms.Button Modificar_button;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pdp_textBox;
    }
}

