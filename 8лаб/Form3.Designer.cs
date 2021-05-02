
namespace _8лаб
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.question2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Answer_ball = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.HotPink;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(458, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Магический шар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // question2
            // 
            this.question2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.question2.Location = new System.Drawing.Point(95, 159);
            this.question2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.question2.Name = "question2";
            this.question2.Size = new System.Drawing.Size(976, 30);
            this.question2.TabIndex = 2;
            this.question2.Text = "Введите вопрос";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.HotPink;
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(464, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Шар говорит...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Answer_ball
            // 
            this.Answer_ball.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Answer_ball.Location = new System.Drawing.Point(95, 388);
            this.Answer_ball.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Answer_ball.Name = "Answer_ball";
            this.Answer_ball.Size = new System.Drawing.Size(976, 30);
            this.Answer_ball.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 562);
            this.Controls.Add(this.Answer_ball);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.question2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox question2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Answer_ball;
    }
}