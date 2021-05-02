
namespace _8лаб
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
            this.yes_no = new System.Windows.Forms.Button();
            this.magic_ball = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yes_no
            // 
            this.yes_no.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.yes_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yes_no.Location = new System.Drawing.Point(151, 183);
            this.yes_no.Name = "yes_no";
            this.yes_no.Size = new System.Drawing.Size(182, 82);
            this.yes_no.TabIndex = 0;
            this.yes_no.Text = "Да или нет";
            this.yes_no.UseVisualStyleBackColor = false;
            this.yes_no.Click += new System.EventHandler(this.yes_no_Click);
            // 
            // magic_ball
            // 
            this.magic_ball.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.magic_ball.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.magic_ball.Location = new System.Drawing.Point(463, 183);
            this.magic_ball.Name = "magic_ball";
            this.magic_ball.Size = new System.Drawing.Size(182, 82);
            this.magic_ball.TabIndex = 1;
            this.magic_ball.Text = "Магический шар";
            this.magic_ball.UseVisualStyleBackColor = false;
            this.magic_ball.Click += new System.EventHandler(this.magic_ball_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.magic_ball);
            this.Controls.Add(this.yes_no);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yes_no;
        private System.Windows.Forms.Button magic_ball;
    }
}

