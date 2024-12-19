using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserInput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ThrowCoin(bool userGuess)
        {
            Random random = new Random();
            int randomValue = random.Next();
            int result = randomValue % 2;
            textBox_result.Text += $"생성된 난수: {randomValue}, 연산 결과 : {result}\r\n";

            return userGuess == (result == 1);
        }


        private void button_input_Click(object sender, EventArgs e)
        {
            textBox_result.Text = textBox_input.Text;
        }

        private void radioButtonTrue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
