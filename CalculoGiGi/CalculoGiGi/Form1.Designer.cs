
namespace CalculoGiGi
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
            this.Nota1 = new System.Windows.Forms.Label();
            this.nota3 = new System.Windows.Forms.Label();
            this.nota4 = new System.Windows.Forms.Label();
            this.Nota2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.meida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nota1
            // 
            this.Nota1.AutoSize = true;
            this.Nota1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nota1.Location = new System.Drawing.Point(48, 40);
            this.Nota1.Name = "Nota1";
            this.Nota1.Size = new System.Drawing.Size(77, 26);
            this.Nota1.TabIndex = 0;
            this.Nota1.Text = "Nota 1";
            // 
            // nota3
            // 
            this.nota3.AutoSize = true;
            this.nota3.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota3.Location = new System.Drawing.Point(48, 196);
            this.nota3.Name = "nota3";
            this.nota3.Size = new System.Drawing.Size(77, 26);
            this.nota3.TabIndex = 0;
            this.nota3.Text = "Nota 3";
            // 
            // nota4
            // 
            this.nota4.AutoSize = true;
            this.nota4.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota4.Location = new System.Drawing.Point(48, 279);
            this.nota4.Name = "nota4";
            this.nota4.Size = new System.Drawing.Size(83, 26);
            this.nota4.TabIndex = 0;
            this.nota4.Text = "Nota  4";
            // 
            // Nota2
            // 
            this.Nota2.AutoSize = true;
            this.Nota2.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nota2.Location = new System.Drawing.Point(48, 113);
            this.Nota2.Name = "Nota2";
            this.Nota2.Size = new System.Drawing.Size(77, 26);
            this.Nota2.TabIndex = 0;
            this.Nota2.Text = "Nota 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(53, 225);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(53, 308);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 1;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // meida
            // 
            this.meida.AutoSize = true;
            this.meida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meida.Location = new System.Drawing.Point(365, 46);
            this.meida.Name = "meida";
            this.meida.Size = new System.Drawing.Size(72, 20);
            this.meida.TabIndex = 2;
            this.meida.Text = "Média =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 761);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.meida);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Nota2);
            this.Controls.Add(this.nota4);
            this.Controls.Add(this.nota3);
            this.Controls.Add(this.Nota1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nota1;
        private System.Windows.Forms.Label nota3;
        private System.Windows.Forms.Label nota4;
        private System.Windows.Forms.Label Nota2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label meida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

