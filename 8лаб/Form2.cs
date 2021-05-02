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
    public partial class Form2 : Form
    {
        Answer answer = new Answer();
        public Form2()
        {
            InitializeComponent();
        }

        private void answer1_Click(object sender, EventArgs e)
        {
            yes_or_no.Text = answer.MainMethod();
        }
    }

    public class Answer
    {
        Random rnd = new Random();
        decimal p = 0.5M;
        public string MainMethod()
        {
            decimal a = rnd.Next(0, 100);
            a /= 100;
            if (a < p)
            {
                return "Да";
            }
            return "Нет";
        }
    }
}
