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

		private void Login_ToolStrip_MenuItem_Click(object sender, EventArgs e)
		{
			LogIn_Form logInForm = new LogIn_Form();
			logInForm.ShowDialog();
		}

		private void студентаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LogIn_People logIn_Pipel = new LogIn_People();
			logIn_Pipel.Show();
		}
	}
}
