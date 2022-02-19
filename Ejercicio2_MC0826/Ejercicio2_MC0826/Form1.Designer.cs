namespace Ejercicio2_MC0826
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.EdadTxt = new System.Windows.Forms.TextBox();
            this.Agregarbnt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cleanbnt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Estudiante:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad del Estudiante:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(187, 192);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Seleccionar Registro";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(187, 77);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(193, 20);
            this.NombreTxt.TabIndex = 3;
            // 
            // EdadTxt
            // 
            this.EdadTxt.Location = new System.Drawing.Point(187, 128);
            this.EdadTxt.Name = "EdadTxt";
            this.EdadTxt.Size = new System.Drawing.Size(193, 20);
            this.EdadTxt.TabIndex = 4;
            // 
            // Agregarbnt
            // 
            this.Agregarbnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarbnt.Location = new System.Drawing.Point(393, 65);
            this.Agregarbnt.Name = "Agregarbnt";
            this.Agregarbnt.Size = new System.Drawing.Size(102, 41);
            this.Agregarbnt.TabIndex = 5;
            this.Agregarbnt.Text = "AGREGAR";
            this.Agregarbnt.UseVisualStyleBackColor = true;
            this.Agregarbnt.Click += new System.EventHandler(this.Agregarbnt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datos del Estudiante";
            // 
            // cleanbnt
            // 
            this.cleanbnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanbnt.Location = new System.Drawing.Point(393, 117);
            this.cleanbnt.Name = "cleanbnt";
            this.cleanbnt.Size = new System.Drawing.Size(102, 41);
            this.cleanbnt.TabIndex = 7;
            this.cleanbnt.Text = "LIMPIAR";
            this.cleanbnt.UseVisualStyleBackColor = true;
            this.cleanbnt.Click += new System.EventHandler(this.cleanbnt_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(393, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "BORRAR REGISTRO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cleanbnt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Agregarbnt);
            this.Controls.Add(this.EdadTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.TextBox EdadTxt;
        private System.Windows.Forms.Button Agregarbnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cleanbnt;
        private System.Windows.Forms.Button button1;
    }
}

