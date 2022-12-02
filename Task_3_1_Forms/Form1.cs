using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3_1_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		static double f(int n) 
		{
			return (double)(Math.Sqrt(n) + n);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			double res = (f(6) / 2) + (f(13) / 2) + (f(21) / 2);

			textBox1.Text = String.Format("{0:f4}", res);
		}
	}
}
