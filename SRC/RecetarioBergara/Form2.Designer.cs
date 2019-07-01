namespace RecetarioBergara
{
    partial class Form2
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
            this.NombreReceta_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CantidadReceta_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgregarReceta_button = new System.Windows.Forms.Button();
            this.EliminarReceta_button = new System.Windows.Forms.Button();
            this.Receta_listBox = new System.Windows.Forms.ListBox();
            this.Ingrediente_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la receta";
            // 
            // NombreReceta_textBox
            // 
            this.NombreReceta_textBox.Location = new System.Drawing.Point(50, 81);
            this.NombreReceta_textBox.Name = "NombreReceta_textBox";
            this.NombreReceta_textBox.Size = new System.Drawing.Size(193, 20);
            this.NombreReceta_textBox.TabIndex = 1;
            this.NombreReceta_textBox.TextChanged += new System.EventHandler(this.NombreReceta_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrediente";
            // 
            // CantidadReceta_textBox
            // 
            this.CantidadReceta_textBox.Location = new System.Drawing.Point(176, 124);
            this.CantidadReceta_textBox.Name = "CantidadReceta_textBox";
            this.CantidadReceta_textBox.Size = new System.Drawing.Size(67, 20);
            this.CantidadReceta_textBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad";
            // 
            // AgregarReceta_button
            // 
            this.AgregarReceta_button.Location = new System.Drawing.Point(79, 150);
            this.AgregarReceta_button.Name = "AgregarReceta_button";
            this.AgregarReceta_button.Size = new System.Drawing.Size(145, 23);
            this.AgregarReceta_button.TabIndex = 6;
            this.AgregarReceta_button.Text = "Agregar";
            this.AgregarReceta_button.UseVisualStyleBackColor = true;
            this.AgregarReceta_button.Click += new System.EventHandler(this.AgregarReceta_button_Click);
            // 
            // EliminarReceta_button
            // 
            this.EliminarReceta_button.Location = new System.Drawing.Point(254, 273);
            this.EliminarReceta_button.Name = "EliminarReceta_button";
            this.EliminarReceta_button.Size = new System.Drawing.Size(67, 23);
            this.EliminarReceta_button.TabIndex = 7;
            this.EliminarReceta_button.Text = "Eliminar";
            this.EliminarReceta_button.UseVisualStyleBackColor = true;
            // 
            // Receta_listBox
            // 
            this.Receta_listBox.FormattingEnabled = true;
            this.Receta_listBox.Location = new System.Drawing.Point(254, 81);
            this.Receta_listBox.Name = "Receta_listBox";
            this.Receta_listBox.Size = new System.Drawing.Size(120, 186);
            this.Receta_listBox.TabIndex = 8;
            // 
            // Ingrediente_comboBox
            // 
            this.Ingrediente_comboBox.FormattingEnabled = true;
            this.Ingrediente_comboBox.Location = new System.Drawing.Point(50, 123);
            this.Ingrediente_comboBox.Name = "Ingrediente_comboBox";
            this.Ingrediente_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Ingrediente_comboBox.TabIndex = 9;
            this.Ingrediente_comboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ingrediente_comboBox);
            this.Controls.Add(this.Receta_listBox);
            this.Controls.Add(this.EliminarReceta_button);
            this.Controls.Add(this.AgregarReceta_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CantidadReceta_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreReceta_textBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreReceta_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CantidadReceta_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AgregarReceta_button;
        private System.Windows.Forms.Button EliminarReceta_button;
        private System.Windows.Forms.ListBox Receta_listBox;
        private System.Windows.Forms.ComboBox Ingrediente_comboBox;
    }
}