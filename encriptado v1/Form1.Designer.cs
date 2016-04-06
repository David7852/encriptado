namespace encriptado_v1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._filechoosebutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._encripbutton = new System.Windows.Forms.Button();
            this._desencriptarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _filechoosebutton
            // 
            this._filechoosebutton.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this._filechoosebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this._filechoosebutton.ForeColor = System.Drawing.Color.Firebrick;
            this._filechoosebutton.Location = new System.Drawing.Point(12, 38);
            this._filechoosebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._filechoosebutton.Name = "_filechoosebutton";
            this._filechoosebutton.Size = new System.Drawing.Size(222, 30);
            this._filechoosebutton.TabIndex = 0;
            this._filechoosebutton.Text = "Explorar";
            this._filechoosebutton.UseVisualStyleBackColor = true;
            this._filechoosebutton.Click += new System.EventHandler(this.filechoose);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(12, 132);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.MaximumSize = new System.Drawing.Size(220, 30);
            this.textBox1.MaxLength = 15;
            this.textBox1.MinimumSize = new System.Drawing.Size(220, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '•';
            this.textBox1.Size = new System.Drawing.Size(220, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // _encripbutton
            // 
            this._encripbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this._encripbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._encripbutton.ForeColor = System.Drawing.Color.OliveDrab;
            this._encripbutton.Location = new System.Drawing.Point(12, 76);
            this._encripbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._encripbutton.Name = "_encripbutton";
            this._encripbutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._encripbutton.Size = new System.Drawing.Size(105, 30);
            this._encripbutton.TabIndex = 2;
            this._encripbutton.Text = "Encriptar";
            this._encripbutton.UseVisualStyleBackColor = true;
            this._encripbutton.Click += new System.EventHandler(this.encriptar);
            // 
            // _desencriptarbutton
            // 
            this._desencriptarbutton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this._desencriptarbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this._desencriptarbutton.Location = new System.Drawing.Point(129, 76);
            this._desencriptarbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._desencriptarbutton.Name = "_desencriptarbutton";
            this._desencriptarbutton.Size = new System.Drawing.Size(105, 30);
            this._desencriptarbutton.TabIndex = 3;
            this._desencriptarbutton.Text = "Desencriptar";
            this._desencriptarbutton.UseVisualStyleBackColor = true;
            this._desencriptarbutton.Click += new System.EventHandler(this.desencriptar);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "                   Sin archivo                   ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 175);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._desencriptarbutton);
            this.Controls.Add(this._encripbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._filechoosebutton);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Encriptado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button _encripbutton;
        private System.Windows.Forms.Button _filechoosebutton;
        private System.Windows.Forms.Button _desencriptarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

