using Appeals_Mes.Class;
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

namespace AppealsMes
{
    public partial class FormDate : Form
    {
        public FormDate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassAppeals.SelectAppealsTest(dateTimePicker1.Text,dateTimePicker2.Text);
            dataGridView1.DataSource = ClassAppeals.DtSelectAppealsTest;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Shapes.AddPicture(@"D:\Дипломный проект\AppealsMes\logoms.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 0, 0, 180, 45);
            Excel.Range _excelCells = (Excel.Range)xlWorkSheet.get_Range("E2", "I2").Cells;
            _excelCells.Merge(Type.Missing);
            _excelCells.Font.Underline = true;
            xlWorkSheet.Cells[2, 5] = "Информация об обращениях потребителей";
            xlWorkSheet.Cells[3, 5] = "с :";
            xlWorkSheet.Cells[3, 6] = dateTimePicker1.Text;
            xlWorkSheet.Cells[3, 7] = "по :";
            xlWorkSheet.Cells[3, 8] = dateTimePicker2.Text;

            Excel.Range _excelCells2 = (Excel.Range)xlWorkSheet.get_Range("A6", "B6").Cells;
            _excelCells2.Merge(Type.Missing);
            xlWorkSheet.Cells[6, 1] = "Организация:";
            Excel.Range _excelCells3 = (Excel.Range)xlWorkSheet.get_Range("C6", "G6").Cells;
            _excelCells3.Merge(Type.Missing);
            _excelCells3.Font.Underline = true;
            xlWorkSheet.Cells[6, 3] = "Акционерное общество Мурманэнергосбыт";
            Excel.Range _excelCells4 = (Excel.Range)xlWorkSheet.get_Range("A7", "B7").Cells;
            _excelCells4.Merge(Type.Missing);
            xlWorkSheet.Cells[7, 1] = "Вид деятельности:";
            Excel.Range _excelCells5 = (Excel.Range)xlWorkSheet.get_Range("C7", "H7").Cells;
            _excelCells5.Merge(Type.Missing);
            _excelCells5.Font.Underline = true;
            xlWorkSheet.Cells[7, 3] = "Производство, передача и распределение пара и горячей воды";
            Excel.Range _excelCells6 = (Excel.Range)xlWorkSheet.get_Range("A8", "C8").Cells;
            _excelCells6.Merge(Type.Missing);
            xlWorkSheet.Cells[8, 1] = "Организационно-правовая форма:";

            var SomeCell = (Excel.Range)xlWorkSheet.Cells[8, 1];
            SomeCell.RowHeight = 32;
            SomeCell.WrapText = true;

            Excel.Range _excelCells7 = (Excel.Range)xlWorkSheet.get_Range("D8", "I8").Cells;
            _excelCells7.Merge(Type.Missing);
            _excelCells7.Font.Underline = true;
            xlWorkSheet.Cells[8, 4] = "Непубличное акционерное общество/ Собственность субъектов РФ";
            var SomeCell2 = (Excel.Range)xlWorkSheet.Cells[8, 4];
            SomeCell2.WrapText = true;

            xlWorkSheet.Cells[9, 1] = "Адрес:";
            Excel.Range _excelCells8 = (Excel.Range)xlWorkSheet.get_Range("B9", "G9").Cells;
            _excelCells8.Merge(Type.Missing);
            _excelCells8.Font.Underline = true;
            xlWorkSheet.Cells[9, 2] = "Мурманская обл., г. Мурманск, ул. Свердлова, д. 39";

            xlWorkSheet.Cells[11, 1] = "Номер";
            xlWorkSheet.Cells[11, 1].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // верхняя внешняя
            xlWorkSheet.Cells[11, 1].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // правая внешняя
            xlWorkSheet.Cells[11, 1].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // левая внешняя
            xlWorkSheet.Cells[11, 2] = "ФИО клиента";
            xlWorkSheet.Cells[11, 2].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // верхняя внешняя
            xlWorkSheet.Cells[11, 2].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // правая внешняя
            xlWorkSheet.Cells[11, 2].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // левая внешняя
            xlWorkSheet.Cells[11, 3] = "ФИО сотрудника";
            xlWorkSheet.Cells[11, 3].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // верхняя внешняя
            xlWorkSheet.Cells[11, 3].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // правая внешняя
            xlWorkSheet.Cells[11, 3].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // левая внешняя
            xlWorkSheet.Cells[11, 4] = "Способ обращения";
            xlWorkSheet.Cells[11, 4].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // верхняя внешняя
            xlWorkSheet.Cells[11, 4].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // правая внешняя
            xlWorkSheet.Cells[11, 4].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // левая внешняя
            xlWorkSheet.Cells[11, 5] = "Способ обращения";
            xlWorkSheet.Cells[11, 5].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // верхняя внешняя
            xlWorkSheet.Cells[11, 5].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // правая внешняя
            xlWorkSheet.Cells[11, 5].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // левая внешняя
            xlWorkSheet.Cells[11, 6] = "Дата обращения";
            xlWorkSheet.Cells[11, 6].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // верхняя внешняя
            xlWorkSheet.Cells[11, 6].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // правая внешняя
            xlWorkSheet.Cells[11, 6].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // левая внешняя
            xlWorkSheet.Cells[11, 7] = "Кол-во проблем";
            xlWorkSheet.Cells[11, 7].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // верхняя внешняя
            xlWorkSheet.Cells[11, 7].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // правая внешняя
            xlWorkSheet.Cells[11, 7].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // левая внешняя

            int i = 0, j = 0, row = 12;
            for (i = 0; i <= dataGridView1.RowCount - 2; i++)
            {
                row = 12;
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {

                    xlWorkSheet.Cells[i + 12, j + 1] = dataGridView1[j, i].Value.ToString();

                    xlWorkSheet.Cells[i + 12, j + 1] = dataGridView1[j, i].Value.ToString();
                    Excel.Range excelCells999 = xlWorkSheet.Range[xlWorkSheet.Cells[i + 12, 1], xlWorkSheet.Cells[i + 12, 1]];
                    excelCells999.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;

                    xlWorkSheet.Cells[i + 12, j + 1].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // верхняя внешняя
                    xlWorkSheet.Cells[i + 12, j + 1].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // правая внешняя
                    xlWorkSheet.Cells[i + 12, j + 1].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // левая внешняя
                    xlWorkSheet.Cells[i + 12, j + 1].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                    excelCells999.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // верхняя внешняя
                    excelCells999.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // правая внешняя
                    excelCells999.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // левая внешняя
                    excelCells999.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                    Excel.Range excelCells998 = xlWorkSheet.Range[xlWorkSheet.Cells[i + 12, 2], xlWorkSheet.Cells[i + 12, 2]];
                    excelCells998.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // верхняя внешняя
                    excelCells998.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // правая внешняя
                    excelCells998.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // левая внешняя
                    excelCells998.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                    Excel.Range excelCells997 = xlWorkSheet.Range[xlWorkSheet.Cells[i + 12, 4], xlWorkSheet.Cells[i + 12, 4]];
                    excelCells997.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // верхняя внешняя
                    excelCells997.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // правая внешняя
                    excelCells997.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // левая внешняя
                    excelCells997.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                    Excel.Range excelCells996 = xlWorkSheet.Range[xlWorkSheet.Cells[i + 12, 5], xlWorkSheet.Cells[i + 12, 5]];
                    excelCells996.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // верхняя внешняя
                    excelCells996.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // правая внешняя
                    excelCells996.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // левая внешняя
                    excelCells996.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                    Excel.Range excelCells995 = xlWorkSheet.Range[xlWorkSheet.Cells[i + 12, 6], xlWorkSheet.Cells[i + 12, 6]];
                    excelCells995.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // верхняя внешняя
                    excelCells995.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // правая внешняя
                    excelCells995.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // левая внешняя
                    excelCells995.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                    Excel.Range excelCells994 = xlWorkSheet.Range[xlWorkSheet.Cells[i + 12, 7], xlWorkSheet.Cells[i + 12, 7]];
                    excelCells994.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // верхняя внешняя
                    excelCells994.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // правая внешняя
                    excelCells994.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // левая внешняя
                    excelCells994.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    row++;
                }
            }
            int num = dataGridView1.RowCount + 12;
            Excel.Range _excelCells55 = (Excel.Range)xlWorkSheet.get_Range("A" + num, "B" + +num).Cells;
            _excelCells55.Merge(Type.Missing);
            xlWorkSheet.Cells[num, 1] = "И.о. генерального директора:";
            var SomeCell3 = (Excel.Range)xlWorkSheet.Cells[num, 1];
            SomeCell3.RowHeight = 32;
            SomeCell3.WrapText = true;
            xlWorkSheet.Cells[num, 3] = "А.П. Истомина";
            Excel.Range _excelCells56 = (Excel.Range)xlWorkSheet.get_Range("C" + num, "D" + +num).Cells;
            _excelCells56.Merge(Type.Missing);
            _excelCells56.Font.Underline = true;

            xlWorkSheet.Cells[num, 5] = "Подпись";
            Excel.Range excelCells9945 = xlWorkSheet.Range[xlWorkSheet.Cells[num, 6], xlWorkSheet.Cells[num, 6]];
            excelCells9945.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

            xlWorkBook.SaveAs("AppealsClient.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlApp);
            releaseObject(xlWorkBook);
            releaseObject(xlWorkSheet);
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
