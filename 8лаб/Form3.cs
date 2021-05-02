using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8лаб
{
    public partial class Form3 : Form
    {
        Magic_Ball magic = new Magic_Ball();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Answer_ball.Text = magic.MainMethod();
        }
    }

    public class Magic_Ball
    {
        string[] prediction = new string[] { "Хорошие перспективы", "Бесспорно" , "Спроси позже", "Сконцентрируйся и спроси опять" , "Сконцентрируйся и спроси опять", "Даже не думай", "Можешь быть уверен в этом", "Знаки говорят — «да»", "Перспективы не очень хорошие"};
        decimal[] probability = new decimal[] {0.07M, 0.1M, 0.15M, 0.18M, 0.12M, 0.11M, 0.09M, 0.18M};
        Random rnd = new Random();

        public string MainMethod()
        {
            decimal A;
            A = rnd.Next(0, 10);
            A /= 10;
            int k = -1;
            do
            {
                k++;
                A -= probability[k];
            } while (A >= 0.001M);
            return prediction[k];
            
        }
    }
}
