namespace MultiTarea
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Iniciarbtn = new System.Windows.Forms.Button();
            this.Cancelarbtn = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.Numbertxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progresstext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(43, 352);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(373, 36);
            this.progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(78, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "EMPEZAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(249, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(120, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 31);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // Iniciarbtn
            // 
            this.Iniciarbtn.BackColor = System.Drawing.Color.White;
            this.Iniciarbtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Iniciarbtn.Location = new System.Drawing.Point(65, 154);
            this.Iniciarbtn.Name = "Iniciarbtn";
            this.Iniciarbtn.Size = new System.Drawing.Size(158, 66);
            this.Iniciarbtn.TabIndex = 0;
            this.Iniciarbtn.Text = "INICIAR";
            this.Iniciarbtn.UseVisualStyleBackColor = false;
            this.Iniciarbtn.Click += new System.EventHandler(this.Iniciarbtn_Click);
            // 
            // Cancelarbtn
            // 
            this.Cancelarbtn.BackColor = System.Drawing.Color.White;
            this.Cancelarbtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cancelarbtn.Location = new System.Drawing.Point(229, 154);
            this.Cancelarbtn.Name = "Cancelarbtn";
            this.Cancelarbtn.Size = new System.Drawing.Size(158, 66);
            this.Cancelarbtn.TabIndex = 1;
            this.Cancelarbtn.Text = "CANCELAR";
            this.Cancelarbtn.UseVisualStyleBackColor = false;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(65, 240);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(322, 36);
            this.progress.TabIndex = 2;
            // 
            // Numbertxt
            // 
            this.Numbertxt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Numbertxt.Location = new System.Drawing.Point(112, 80);
            this.Numbertxt.Name = "Numbertxt";
            this.Numbertxt.Size = new System.Drawing.Size(199, 37);
            this.Numbertxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(101, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero de lineas:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(65, 326);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 84);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // progresstext
            // 
            this.progresstext.AutoSize = true;
            this.progresstext.Location = new System.Drawing.Point(215, 291);
            this.progresstext.Name = "progresstext";
            this.progresstext.Size = new System.Drawing.Size(23, 15);
            this.progresstext.TabIndex = 6;
            this.progresstext.Text = "0%";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(434, 441);
            this.Controls.Add(this.progresstext);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numbertxt);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.Cancelarbtn);
            this.Controls.Add(this.Iniciarbtn);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar progressBar1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Button Iniciarbtn;
        private Button Cancelarbtn;
        private ProgressBar progress;
        private TextBox Numbertxt;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label progresstext;
    }
}