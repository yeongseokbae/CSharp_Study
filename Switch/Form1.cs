using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch
{
    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_result.Clear();

            string userInput = textBox_input.Text.Trim();

            if (Enum.TryParse(userInput, out Days day))
            {
                switch (day)
                {
                    case Days.Monday:
                        textBox_result.Text = "월";
                        break;
                    case Days.Tuesday:
                        textBox_result.Text = "화";
                        break;
                    case Days.Wednesday:
                        textBox_result.Text = "수";
                        break;
                    case Days.Thursday:
                        textBox_result.Text = "목";
                        break;
                    case Days.Friday:
                        textBox_result.Text = "금";
                        break;
                    case Days.Saturday:
                        textBox_result.Text = "토";
                        break;
                    case Days.Sunday:
                        textBox_result.Text = "일";
                        break;
                }
            }
            else
            {
                textBox_result.Text = "요일을 정확히 입력해주세요";
            }
        }
    }
}
