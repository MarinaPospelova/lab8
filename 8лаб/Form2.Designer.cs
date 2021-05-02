
namespace _8лаб
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
            this.question1 = new System.Windows.Forms.TextBox();
            this.answer1 = new System.Windows.Forms.Button();
            this.yes_or_no = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(260, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Игра \"Да или нет\"";
            // 
            // question1
            // 
            this.question1.Location = new System.Drawing.Point(122, 104);
            this.question1.Name = "question1";
            this.question1.Size = new System.Drawing.Size(576, 26);
            this.question1.TabIndex = 2;
            this.question1.Text = "Введите вопрос";
            // 
            // answer1
            // 
            this.answer1.BackColor = System.Drawing.SystemColors.Info;
            this.answer1.Location = new System.Drawing.Point(318, 161);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(170, 53);
            this.answer1.TabIndex = 3;
            this.answer1.Text = "Получить ответ";
            this.answer1.UseVisualStyleBackColor = false;
            this.answer1.Click += new System.EventHandler(this.answer1_Click);
            // 
            // yes_or_no
            // 
            this.yes_or_no.Location = new System.Drawing.Point(346, 266);
            this.yes_or_no.Name = "yes_or_no";
            this.yes_or_no.Size = new System.Drawing.Size(120, 26);
            this.yes_or_no.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yes_or_no);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.question1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox question1;
        private System.Windows.Forms.Button answer1;
        private System.Windows.Forms.TextBox yes_or_no;
    }
}