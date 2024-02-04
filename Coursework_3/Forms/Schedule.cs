using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Coursework_3
{
	public partial class Schedule : Form
	{
		public Schedule()
		{
			InitializeComponent();
		}

		static BD_Connection db = new BD_Connection();
		DataTable dataTable = new DataTable();
		MySqlDataAdapter adapter;
		MySqlCommand command;
		DataSet dataSet = new DataSet();

		private void Schedule_FormClosed(object sender, FormClosedEventArgs e)
		{
			HomForm homForm = new HomForm();
			homForm.Show();
			this.Hide();
		}
	}
}
