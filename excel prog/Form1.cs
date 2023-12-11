using Microsoft.Office.Interop.Excel;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace excel_prog
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        // Példányosítjuk a UserControl-t
        excelgenerate excel = new excelgenerate();
        listboxData lb = new listboxData();
        DataGridData dgD = new DataGridData();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void excelToPanel()
        {
            panel1.Controls.Clear();
            // Ellenőrizzük, hogy a Panel még nem tartalmazza-e a UserControl-t
            if (!panel1.Controls.Contains(excel))
            {
                // UserControl hozzáadása a Panel-hez
                panel1.Controls.Add(excel);

                // UserControl méretének beállítása a Panel méretéhez igazítva
                excel.Dock = DockStyle.Fill;
            }
            else { MessageBox.Show("Hiba a panel betöltésénél!"); }
        }
        private void listbUcToPanel()
        {
            panel1.Controls.Clear();
            // Ellenőrizzük, hogy a Panel még nem tartalmazza-e a UserControl-t
            if (!panel1.Controls.Contains(lb))
            {
                // UserControl hozzáadása a Panel-hez
                panel1.Controls.Add(lb);

                // UserControl méretének beállítása a Panel méretéhez igazítva
                lb.Dock = DockStyle.Fill;
            }
            else { MessageBox.Show("Hiba a panel betöltésénél!"); }
        }
        private void dgDToPanel()
        {
            panel1.Controls.Clear();
            // Ellenőrizzük, hogy a Panel még nem tartalmazza-e a UserControl-t
            if (!panel1.Controls.Contains(dgD))
            {
                // UserControl hozzáadása a Panel-hez
                panel1.Controls.Add(dgD);

                // UserControl méretének beállítása a Panel méretéhez igazítva
                dgD.Dock = DockStyle.Fill;
            }
            else { MessageBox.Show("Hiba a panel betöltésénél!"); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            excelToPanel();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Megerősítő kérdés megjelenítése
            DialogResult result = MessageBox.Show("Biztosan ki akarsz lépni az alkalmazásból?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Ellenőrizzük, hogy a felhasználó az "Igen"-t választotta-e
            if (result == DialogResult.Yes)
            {
                // Kilépés az alkalmazásból
                System.Windows.Forms.Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listbUcToPanel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgDToPanel();
        }
    }
}