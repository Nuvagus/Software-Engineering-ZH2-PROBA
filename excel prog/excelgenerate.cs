using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace excel_prog
{
    public partial class excelgenerate : UserControl
    {
        public excelgenerate()
        {
            InitializeComponent();
        }
        Excel.Application xlApp;
        Excel.Workbook wbApp;
        Excel.Worksheet wsApp;
        Excel.Worksheet chartws;
        Models.HajosContext context = new Models.HajosContext();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateExcel();
        }
        void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                wbApp = xlApp.Workbooks.Add(Missing.Value);
                wsApp = (Excel.Worksheet)wbApp.ActiveSheet;
                wsApp.Name = "Data";
                CreateTable();
                chartws = (Excel.Worksheet)wbApp.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);
                chartws.Name = "Chart";
                ChartGen();

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                wbApp.Close();
                xlApp.Quit();
                wbApp = null;
                xlApp = null;
            }
        }

        void CreateTable()
        {
            string[] headers = new string[]
            {
                "Question",
                "Answer 1",
                "Answer 2",
                "Answer 3",
                "Correct Answer",
                "Image"
            };

            wsApp.Cells[1, 1] = headers[0];

            var everyQ = context.Questions.ToList();
            object[,] dataT = new object[everyQ.Count(), headers.Count()];

            for (int i = 0; i < everyQ.Count(); i++)
            {
                dataT[i, 0] = everyQ[i].Question1;
                dataT[i, 1] = everyQ[i].Answer1;
                dataT[i, 2] = everyQ[i].Answer2;
                dataT[i, 3] = everyQ[i].Answer3;
                dataT[i, 4] = everyQ[i].CorrectAnswer;
                dataT[i, 5] = everyQ[i].Image;

            }

            int sorSzam = dataT.GetLength(0);
            int oszlSzam = dataT.GetLength(1);

            Excel.Range dataRange = wsApp.get_Range("A2", Type.Missing).get_Resize(sorSzam, oszlSzam);
            dataRange.Value2 = dataT;
            dataRange.Columns.AutoFit();

            Excel.Range headerRange = wsApp.get_Range("A1", Type.Missing).get_Resize(1, 6);
            headerRange.Font.Bold = true;
            dataRange.Font.Italic = true;
            dataRange.RowHeight = 20;

        }

        void ChartGen()
        {
            var everyQ = context.Questions.ToList();
            int a, b;
            Excel.Range chartRange = wsApp.get_Range("A1", "A2");
            if (int.TryParse(elsoTB.Text, out a) && int.TryParse(masodikTb.Text, out b))
            {
                chartRange = wsApp.get_Range($"E{a}", $"E{b}");
            }
            else if (elsoTB.Text != string.Empty && masodikTb.Text != string.Empty)
            {
                MessageBox.Show("Helytelen formátum lett megadva! A helyes formátum: szám");
            }
            else { chartRange = wsApp.get_Range("E2", $"E{everyQ.Count()}"); }

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)chartws.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = xlCharts.Add(10, 10, 350, 350);
            Excel.Chart chartPage = myChart.Chart;

            chartPage.SetSourceData(chartRange);

            chartPage.ChartType = Excel.XlChartType.xlXYScatter;
            chartPage.ChartWizard(Source: chartRange,
                Title: "Correct Answers Chart",
                CategoryTitle: "Data Set",
                ValueTitle: "Correct Answers");
        }

        private void excelgenerate_Load(object sender, EventArgs e)
        {

        }
    }
}
