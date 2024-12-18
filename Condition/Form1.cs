using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(this.button1_Click);
        }

        private bool ThrowCoin(bool userGuess)
        {
            Random random = new Random();
            int randomValue = random.Next();
            int result = randomValue % 2;
            textBox1.Text += $"생성된 난수: {randomValue}, 연산 결과 : {result}\r\n";

            return userGuess == (result == 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            bool userInput = true;

            bool result = ThrowCoin(userInput);

            if (result)
                textBox1.Text += "결과: 승리!";
            else
                textBox1.Text += "결과: 패배!";
        }
    }
}
