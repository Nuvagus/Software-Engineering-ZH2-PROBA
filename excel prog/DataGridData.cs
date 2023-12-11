using excel_prog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excel_prog
{
    public partial class DataGridData : UserControl
    {
        public DataGridData()
        {
            InitializeComponent();
        }
        Models.EtkeztetesContext receptek = new Models.EtkeztetesContext();
        private void DataGridData_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = receptek.Recepteks.ToList();
        }
    }
}
