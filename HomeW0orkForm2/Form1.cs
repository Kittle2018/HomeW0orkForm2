using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeW0orkForm2
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += ShowMesBox;
        }

        private void ShowMesBox(object sender, EventArgs e)
        {
            string[] array = { "Студент: Атамеев Егор", "Предмет: Windows Forms", "Группа: РПО.СТ.ПВ111" };
            int numSymbol = 0;
            string caption;

            for (int i = 0; i < array.Length; i++)
            {
                numSymbol += array[i].Length;
                caption = (array.Length - 1 == i) ? $"MessageBox {i + 1}. Среднее число символов - {numSymbol / array.Length}" : $"MessageBox {i + 1}";
                MessageBox.Show(array[i], caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
