using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void окрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                }
            }           
            fBrowser f = new fBrowser(path);
            f.Show();
            this.Size = new Size(1300, 800);
            label1.Visible = label2.Visible = tbX.Visible = tbY.Visible = button1.Visible = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAbout f = new fAbout();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Double.Parse(tbX.Text);
                double y = Double.Parse(tbY.Text);
                if (!((x <= 5.5 && y >= 2) && (x >= -5.5 && y <= 6)))
                {
                    MessageBox.Show("Точка лежит вне области", "Автоматизация расчетов");
                    this.Text = "Точка лежит вне области";
                }
                else if ((x * x + y * y == 36) || (x * x + y * y == 16))
                {
                    MessageBox.Show("Точка лежит на границе", "Автоматизация расчетов");
                    this.Text = "Точка лежит на границе";
                }
                else if ((x * x + y * y <= 5.5 * 5.5) && (x * x + y * y >= 3.5 * 3.5))
                {
                    MessageBox.Show("Точка лежит на области", "Автоматизация расчетов");
                    this.Text = "Точка лежит в области";
                }
                else
                {
                    MessageBox.Show("Точка лежит вне области", "Автоматизация расчетов");
                    this.Text = "Точка лежит вне области";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Исключение");
            }
        }
    }
}
