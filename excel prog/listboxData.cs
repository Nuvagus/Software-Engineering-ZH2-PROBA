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
    public partial class listboxData : UserControl
    {
        public listboxData()
        {
            InitializeComponent();
        }
        Models.EtkeztetesContext contextE = new Models.EtkeztetesContext();
        private void listboxData_Load(object sender, EventArgs e)
        {
            NyersanyagListazas();
            FogasListazas();
        }
        private void NyersanyagListazas()
        {
            var hv = from x in contextE.Nyersanyagoks
                     where x.NyersanyagNev.Contains(tbNyersanyag.Text)
                     select x;

            listBox1.DataSource = hv.ToList();
            listBox1.DisplayMember = "NyersanyagNev";
        }
        private void FogasListazas()
        {
            var hv = from x in contextE.Fogasoks
                     where x.FogasNev.Contains(tbFogas.Text)
                     select x;

            listBox2.DataSource = hv.ToList();
            listBox2.DisplayMember = "FogasNev";
        }

        private void tbNyersanyag_TextChanged(object sender, EventArgs e)
        {
            NyersanyagListazas();
        }

        private void tbFogas_TextChanged(object sender, EventArgs e)
        {
            FogasListazas();
        }
    }
}
