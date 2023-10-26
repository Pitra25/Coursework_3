using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_3
{
	public partial class HomForm : Form
	{
		public HomForm()
		{
			InitializeComponent();
		}

		private void входToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LogIn_Form logInForm = new LogIn_Form();
			logInForm.ShowDialog();
		}
	}
}
