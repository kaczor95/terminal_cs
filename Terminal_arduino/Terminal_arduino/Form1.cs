using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal_arduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort.PortName = "COM3";
            serialPort.BaudRate = 9600;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            serialPort.Open();

            panelOpen.BackColor = Color.Lime;
            panelClose.BackColor = SystemColors.Control;


        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            serialPort.Close();

            panelClose.BackColor = Color.Red;
            panelOpen.BackColor = SystemColors.Control;
        }
    }
}
