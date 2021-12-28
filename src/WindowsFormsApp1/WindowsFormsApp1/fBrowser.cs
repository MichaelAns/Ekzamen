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
    public partial class fBrowser : Form
    {
        string path;
        public fBrowser()
        {
            InitializeComponent();
        }
        public fBrowser(string path)
        {
            try
            {
                this.path = path;
                InitializeComponent();
            }
            catch (Exception)
            {
                MessageBox.Show("Видимо файл не выбран", "Исключение");
            }
            
        }

        private void fBrowser_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(path);
        }
    }
}
