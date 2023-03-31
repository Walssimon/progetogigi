
namespace CalculoGiGi
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
            this.salario = new System.Windows.Forms.Label();
            this.textBoxsal = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelsalario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salario
            // 
            this.salario.AutoSize = true;
            this.salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salario.Location = new System.Drawing.Point(12, 9);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(74, 24);
            this.salario.TabIndex = 0;
            this.salario.Text = "Salario";
            // 
            // textBoxsal
            // 
            this.textBoxsal.Location = new System.Drawing.Point(16, 36);
            this.textBoxsal.Name = "textBoxsal";
            this.textBoxsal.Size = new System.Drawing.Size(99, 20);
            this.textBoxsal.TabIndex = 1;
            this.textBoxsal.TextChanged += new System.EventHandler(this.textBoxsal_TextChanged);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(254, 60);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 31);
            this.button5.TabIndex = 2;
            this.button5.Text = "Aumento 5%";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(254, 97);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(130, 31);
            this.button10.TabIndex = 2;
            this.button10.Text = "Aumento 10%";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(254, 134);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(130, 31);
            this.button15.TabIndex = 2;
            this.button15.Text = "Aumento 15%";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(254, 171);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(130, 31);
            this.button20.TabIndex = 2;
            this.button20.Text = "Aumento 20%";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Novo Salário";
            // 
            // labelsalario
            // 
            this.labelsalario.AutoSize = true;
            this.labelsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsalario.Location = new System.Drawing.Point(25, 318);
            this.labelsalario.Name = "labelsalario";
            this.labelsalario.Size = new System.Drawing.Size(0, 55);
            this.labelsalario.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelsalario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBoxsal);
            this.Controls.Add(this.salario);
            this.Name = "Form2";
            this.Text = "Aumento Salarial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salario;
        private System.Windows.Forms.TextBox textBoxsal;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelsalario;
    }
}