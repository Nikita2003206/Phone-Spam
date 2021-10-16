using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Phone_Spam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button_Otchet_Click(object sender, EventArgs e)
        {
            DateTime DataStart = dateTimePickerStart.Value.Date + dateTimePickerStart.Value.TimeOfDay;
            DateTime DataEnd = dateTimePickerEnd.Value.Date + dateTimePickerEnd.Value.TimeOfDay;
            //textBoxEnd.Text = DataStart +" "+ DataEnd;


            string[] array = textBoxStart.Text.Split(',', '\n');
            int numin1 = Convert.ToInt32(array[0]);
            int numin2 = Convert.ToInt32(array[5]);
            int numin3 = Convert.ToInt32(array[10]);
            int numin4 = Convert.ToInt32(array[15]);
            int numin5 = Convert.ToInt32(array[20]);
            int numin6 = Convert.ToInt32(array[25]);

            int numout1 = Convert.ToInt32(array[1]);
            int numout2 = Convert.ToInt32(array[6]);
            int numout3 = Convert.ToInt32(array[11]);
            int numout4 = Convert.ToInt32(array[16]);
            int numout5 = Convert.ToInt32(array[21]);
            int numout6 = Convert.ToInt32(array[26]);

            int date

            int[] date = new int[6];


            int[] numberin = new int[6];
            numberin[0] = numin1;
            numberin[1] = numin2;
            numberin[2] = numin3;
            numberin[3] = numin4;
            numberin[4] = numin5;
            numberin[5] = numin6;

            int[] numberout = new int[6];
            numberout[0] = numout1;
            numberout[1] = numout2;
            numberout[2] = numout3;
            numberout[3] = numout4;
            numberout[4] = numout5;
            numberout[5] = numout6;








        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveTable = new SaveFileDialog();
            saveTable.Filter = "Документ TXT (*.txt) |*.txt";
            if (saveTable.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream file = new FileStream(saveTable.FileName, FileMode.Create);
                    StreamWriter sw = new StreamWriter(file, Encoding.Default);
                    sw.Write(textBoxStart.Text);
                    sw.WriteLine();
                    sw.Close();
                }
                catch { }
            }




        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {


            OpenFileDialog openTableAsTXT = new OpenFileDialog();
            openTableAsTXT.Filter = "Документ TXT (*.txt) |*.txt";
            if (openTableAsTXT.ShowDialog() == DialogResult.OK)
            {
                textBoxStart.Text = File.ReadAllText(openTableAsTXT.FileName, Encoding.Default);
            }

        }
    }
}
