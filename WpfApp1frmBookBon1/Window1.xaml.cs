using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1frmBookBon1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

       

        private void btnclick_click(object sender, RoutedEventArgs e)
        {
            string yourname = txtName1.Text.Trim();
            string yourjob = txtJob.Text.Trim();
            if (yourname.Length > 0 && yourjob.Length > 0)
            {

                string msg = string.Format("Hello {0} \n your Job Is {1} : Thank You ", yourname, yourjob);

                MessageBox.Show(msg, "information ");
                txtName1.Clear();
                txtJob.Clear();
                txtName1.Focus();

            }

            else MessageBox.Show("Enter name and Job " , "Error");
        }
    }
}
