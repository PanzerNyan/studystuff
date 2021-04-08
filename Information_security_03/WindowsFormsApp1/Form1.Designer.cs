
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Encryptbutton = new System.Windows.Forms.Button();
            this.Decryptbutton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 53);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 27);
            this.textBox1.TabIndex = 0;
            // 
            // Encryptbutton
            // 
            this.Encryptbutton.Location = new System.Drawing.Point(11, 122);
            this.Encryptbutton.Name = "Encryptbutton";
            this.Encryptbutton.Size = new System.Drawing.Size(267, 26);
            this.Encryptbutton.TabIndex = 1;
            this.Encryptbutton.Text = "Encrypt";
            this.Encryptbutton.UseVisualStyleBackColor = true;
            this.Encryptbutton.Click += new System.EventHandler(this.Encryptbutton_Click);
            // 
            // Decryptbutton
            // 
            this.Decryptbutton.Location = new System.Drawing.Point(13, 154);
            this.Decryptbutton.Name = "Decryptbutton";
            this.Decryptbutton.Size = new System.Drawing.Size(267, 26);
            this.Decryptbutton.TabIndex = 2;
            this.Decryptbutton.Text = "Decrypt";
            this.Decryptbutton.UseVisualStyleBackColor = true;
            this.Decryptbutton.Click += new System.EventHandler(this.Decryptbutton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 88);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 27);
            this.textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(291, 203);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Decryptbutton);
            this.Controls.Add(this.Encryptbutton);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Futura LtCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Encryptbutton;
        private System.Windows.Forms.Button Decryptbutton;
        private System.Windows.Forms.TextBox textBox2;
    }
}

