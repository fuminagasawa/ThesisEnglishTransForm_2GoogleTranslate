using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ronbunn_kaigyo {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {


			string source = textBox1.Text;
			string result = source;

			result = System.Text.RegularExpressions.Regex.Replace(result, "\n" , " ");
			result = System.Text.RegularExpressions.Regex.Replace(result, "\r", "");
			result = System.Text.RegularExpressions.Regex.Replace(result, "\\.", ".\r\n\r\n");
			//result = System.Text.RegularExpressions.Regex.Replace(result, ".", "!");


			textBox2.Text = result;


		}

		private void button2_Click(object sender, EventArgs e) {
			textBox1.Text = "";
		}

		private void button3_Click(object sender, EventArgs e) {
			textBox2.Text = "";
		}

		private void button4_Click(object sender, EventArgs e) {

			Clipboard.SetText(textBox2.Text);
		}
	}
}
