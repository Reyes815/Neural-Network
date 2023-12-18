using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;


namespace NeuralNetworks
{
    public partial class Form1 : Form
    {
        NeuralNet neural_network;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Create_BPNNBtn_Click(object sender, EventArgs e)
        {
            neural_network = new NeuralNet(4,56,1);
        }

        private void Train_Btn_Click(object sender, EventArgs e)
        {
            for (int i = 0;i < 320;i++)
            {
                //0000-
                neural_network.setInputs(0, 0.0);
                neural_network.setInputs(1, 0.0);
                neural_network.setInputs(2, 0.0);
                neural_network.setInputs(3, 0.0);
                neural_network.setDesiredOutput(0, 0.0);
                neural_network.learn();
                //0001-
                neural_network.setInputs(0, 0.0);
                neural_network.setInputs(1, 0.0);
                neural_network.setInputs(2, 0.0);
                neural_network.setInputs(3, 1.0);
                neural_network.setDesiredOutput(0, 0.0);
                neural_network.learn();
                //0011-
                neural_network.setInputs(0, 0.0);
                neural_network.setInputs(1, 0.0);
                neural_network.setInputs(2, 1.0);
                neural_network.setInputs(3, 1.0);
                neural_network.setDesiredOutput(0, 0.0);
                neural_network.learn();
                //0111-
                neural_network.setInputs(0, 0.0);
                neural_network.setInputs(1, 1.0);
                neural_network.setInputs(2, 1.0);
                neural_network.setInputs(3, 1.0);
                neural_network.setDesiredOutput(0, 0.0);
                neural_network.learn();
                //1111-
                neural_network.setInputs(0, 1.0);
                neural_network.setInputs(1, 1.0);
                neural_network.setInputs(2, 1.0);
                neural_network.setInputs(3, 1.0);
                neural_network.setDesiredOutput(0, 1.0);
                neural_network.learn();
                //1110-
                neural_network.setInputs(0, 1.0);
                neural_network.setInputs(1, 1.0);
                neural_network.setInputs(2, 1.0);
                neural_network.setInputs(3, 0.0);
                neural_network.setDesiredOutput(0, 0.0);
                neural_network.learn();
                //1100-
                neural_network.setInputs(0, 1.0);
                neural_network.setInputs(1, 1.0);
                neural_network.setInputs(2, 0.0);
                neural_network.setInputs(3, 0.0);
                neural_network.setDesiredOutput(0, 0.0);
                neural_network.learn();
                //1000-
                neural_network.setInputs(0, 1.0);
                neural_network.setInputs(1, 0.0);
                neural_network.setInputs(2, 0.0);
                neural_network.setInputs(3, 0.0);
                neural_network.setDesiredOutput(0, 0.0);
                neural_network.learn();
                //1001-
                neural_network.setInputs(0, 1.0);
                neural_network.setInputs(1, 0.0);
                neural_network.setInputs(2, 0.0);
                neural_network.setInputs(3, 1.0);
                neural_network.setDesiredOutput(0, 0.0);
                neural_network.learn();
                //1101-
                neural_network.setInputs(0, 1.0);
                neural_network.setInputs(1, 1.0);
                neural_network.setInputs(2, 0.0);
                neural_network.setInputs(3, 1.0);
                neural_network.setDesiredOutput(0, 0.0);
                neural_network.learn();
                //1011-
                neural_network.setInputs(0, 1.0);
                neural_network.setInputs(1, 0.0);
                neural_network.setInputs(2, 1.0);
                neural_network.setInputs(3, 1.0);
                neural_network.setDesiredOutput(0, 0.0);
                neural_network.learn();
                //1010-
                neural_network.setInputs(0, 1.0);
                neural_network.setInputs(1, 0.0);
                neural_network.setInputs(2, 1.0);
                neural_network.setInputs(3, 0.0);
                neural_network.setDesiredOutput(0, 0.0);
                neural_network.learn();
                //0101-
                neural_network.setInputs(0, 0.0);
                neural_network.setInputs(1, 1.0);
                neural_network.setInputs(2, 0.0);
                neural_network.setInputs(3, 1.0);
                neural_network.setDesiredOutput(0, 0.0);
                neural_network.learn();
                //0010-
                neural_network.setInputs(0, 0.0);
                neural_network.setInputs(1, 0.0);
                neural_network.setInputs(2, 1.0);
                neural_network.setInputs(3, 0.0);
                neural_network.setDesiredOutput(0, 0.0);
                neural_network.learn();
                //0100-
                neural_network.setInputs(0, 0.0);
                neural_network.setInputs(1, 1.0);
                neural_network.setInputs(2, 0.0);
                neural_network.setInputs(3, 0.0);
                neural_network.setDesiredOutput(0, 0.0);
                neural_network.learn();
                //0110-
                neural_network.setInputs(0, 0.0);
                neural_network.setInputs(1, 1.0);
                neural_network.setInputs(2, 1.0);
                neural_network.setInputs(3, 0.0);
                neural_network.setDesiredOutput(0, 0.0);
                neural_network.learn();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Test_Btn_Click(object sender, EventArgs e)
        {
            neural_network.setInputs(0, Convert.ToDouble(input_txt1.Text));
            neural_network.setInputs(1, Convert.ToDouble(input_txt2.Text));
            neural_network.setInputs(2, Convert.ToDouble(input_txt3.Text));
            neural_network.setInputs(3, Convert.ToDouble(input_txt4.Text));
            neural_network.run();
            Answer_txt.Text = "" + neural_network.getOuputData(0); 
        }
    }
}
