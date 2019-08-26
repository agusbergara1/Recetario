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
            this.Recetas_listBox = new System.Windows.Forms.ListBox();
            this.Ingrediente_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ModificarReceta_button = new System.Windows.Forms.Button();
            this.GuardarReceta_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GuardarContenido_button = new System.Windows.Forms.Button();
            this.EliminarContenido_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ContenidoReceta_listBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ModificarContenido_button = new System.Windows.Forms.Button();
            this.AgregarContenido_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la receta";
            // 
            // NombreReceta_textBox
            // 
            this.NombreReceta_textBox.Location = new System.Drawing.Point(21, 51);
            this.NombreReceta_textBox.Name = "NombreReceta_textBox";
            this.NombreReceta_textBox.Size = new System.Drawing.Size(193, 20);
            this.NombreReceta_textBox.TabIndex = 1;
            this.NombreReceta_textBox.TextChanged += new System.EventHandler(this.NombreReceta_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrediente";
            // 
            // CantidadReceta_textBox
            // 
            this.CantidadReceta_textBox.Location = new System.Drawing.Point(9, 85);
            this.CantidadReceta_textBox.Name = "CantidadReceta_textBox";
            this.CantidadReceta_textBox.Size = new System.Drawing.Size(67, 20);
            this.CantidadReceta_textBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad";
            // 
            // AgregarReceta_button
            // 
            this.AgregarReceta_button.Location = new System.Drawing.Point(21, 82);
            this.AgregarReceta_button.Name = "AgregarReceta_button";
            this.AgregarReceta_button.Size = new System.Drawing.Size(104, 23);
            this.AgregarReceta_button.TabIndex = 6;
            this.AgregarReceta_button.Text = "Agregar";
            this.AgregarReceta_button.UseVisualStyleBackColor = true;
            this.AgregarReceta_button.Click += new System.EventHandler(this.AgregarReceta_button_Click);
            // 
            // EliminarReceta_button
            // 
            this.EliminarReceta_button.Location = new System.Drawing.Point(220, 212);
            this.EliminarReceta_button.Name = "EliminarReceta_button";
            this.EliminarReceta_button.Size = new System.Drawing.Size(55, 23);
            this.EliminarReceta_button.TabIndex = 7;
            this.EliminarReceta_button.Text = "Eliminar";
            this.EliminarReceta_button.UseVisualStyleBackColor = true;
            // 
            // Recetas_listBox
            // 
            this.Recetas_listBox.FormattingEnabled = true;
            this.Recetas_listBox.Location = new System.Drawing.Point(220, 20);
            this.Recetas_listBox.Name = "Recetas_listBox";
            this.Recetas_listBox.Size = new System.Drawing.Size(120, 186);
            this.Recetas_listBox.TabIndex = 8;
            this.Recetas_listBox.SelectedIndexChanged += new System.EventHandler(this.Receta_listBox_SelectedIndexChanged);
            // 
            // Ingrediente_comboBox
            // 
            this.Ingrediente_comboBox.FormattingEnabled = true;
            this.Ingrediente_comboBox.Location = new System.Drawing.Point(9, 45);
            this.Ingrediente_comboBox.Name = "Ingrediente_comboBox";
            this.Ingrediente_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Ingrediente_comboBox.TabIndex = 9;
            this.Ingrediente_comboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ModificarReceta_button);
            this.groupBox1.Controls.Add(this.GuardarReceta_button);
            this.groupBox1.Controls.Add(this.Recetas_listBox);
            this.groupBox1.Controls.Add(this.EliminarReceta_button);
            this.groupBox1.Controls.Add(this.AgregarReceta_button);
            this.groupBox1.Controls.Add(this.NombreReceta_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 263);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crea tu receta";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // ModificarReceta_button
            // 
            this.ModificarReceta_button.Location = new System.Drawing.Point(131, 82);
            this.ModificarReceta_button.Name = "ModificarReceta_button";
            this.ModificarReceta_button.Size = new System.Drawing.Size(75, 23);
            this.ModificarReceta_button.TabIndex = 10;
            this.ModificarReceta_button.Text = "Modificar";
            this.ModificarReceta_button.UseVisualStyleBackColor = true;
            // 
            // GuardarReceta_button
            // 
            this.GuardarReceta_button.Location = new System.Drawing.Point(281, 213);
            this.GuardarReceta_button.Name = "GuardarReceta_button";
            this.GuardarReceta_button.Size = new System.Drawing.Size(59, 23);
            this.GuardarReceta_button.TabIndex = 9;
            this.GuardarReceta_button.Text = "Guardar";
            this.GuardarReceta_button.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GuardarContenido_button);
            this.groupBox2.Controls.Add(this.EliminarContenido_button);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ContenidoReceta_listBox);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(389, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 263);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compone tu receta";
            // 
            // GuardarContenido_button
            // 
            this.GuardarContenido_button.Location = new System.Drawing.Point(253, 234);
            this.GuardarContenido_button.Name = "GuardarContenido_button";
            this.GuardarContenido_button.Size = new System.Drawing.Size(70, 23);
            this.GuardarContenido_button.TabIndex = 16;
            this.GuardarContenido_button.Text = "Guardar";
            this.GuardarContenido_button.UseVisualStyleBackColor = true;
            // 
            // EliminarContenido_button
            // 
            this.EliminarContenido_button.Location = new System.Drawing.Point(191, 234);
            this.EliminarContenido_button.Name = "EliminarContenido_button";
            this.EliminarContenido_button.Size = new System.Drawing.Size(56, 23);
            this.EliminarContenido_button.TabIndex = 15;
            this.EliminarContenido_button.Text = "Eliminar";
            this.EliminarContenido_button.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ingredientes de tu receta";
            // 
            // ContenidoReceta_listBox
            // 
            this.ContenidoReceta_listBox.FormattingEnabled = true;
            this.ContenidoReceta_listBox.Location = new System.Drawing.Point(191, 33);
            this.ContenidoReceta_listBox.Name = "ContenidoReceta_listBox";
            this.ContenidoReceta_listBox.Size = new System.Drawing.Size(132, 199);
            this.ContenidoReceta_listBox.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ModificarContenido_button);
            this.groupBox3.Controls.Add(this.AgregarContenido_button);
            this.groupBox3.Controls.Add(this.Ingrediente_comboBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.CantidadReceta_textBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(7, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 152);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // ModificarContenido_button
            // 
            this.ModificarContenido_button.Location = new System.Drawing.Point(108, 123);
            this.ModificarContenido_button.Name = "ModificarContenido_button";
            this.ModificarContenido_button.Size = new System.Drawing.Size(60, 23);
            this.ModificarContenido_button.TabIndex = 11;
            this.ModificarContenido_button.Text = "Modificar";
            this.ModificarContenido_button.UseVisualStyleBackColor = true;
            // 
            // AgregarContenido_button
            // 
            this.AgregarContenido_button.Location = new System.Drawing.Point(9, 123);
            this.AgregarContenido_button.Name = "AgregarContenido_button";
            this.AgregarContenido_button.Size = new System.Drawing.Size(93, 23);
            this.AgregarContenido_button.TabIndex = 10;
            this.AgregarContenido_button.Text = "Agregar";
            this.AgregarContenido_button.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Selecciona tu receta";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreReceta_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CantidadReceta_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AgregarReceta_button;
        private System.Windows.Forms.Button EliminarReceta_button;
        private System.Windows.Forms.ListBox Recetas_listBox;
        private System.Windows.Forms.ComboBox Ingrediente_comboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ModificarReceta_button;
        private System.Windows.Forms.Button GuardarReceta_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GuardarContenido_button;
        private System.Windows.Forms.Button EliminarContenido_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ContenidoReceta_listBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ModificarContenido_button;
        private System.Windows.Forms.Button AgregarContenido_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}