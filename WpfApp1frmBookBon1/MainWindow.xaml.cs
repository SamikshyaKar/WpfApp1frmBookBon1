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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1frmBookBon1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOK_click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text.Trim();
            string Job = txtJob1.Text.Trim();

            if (name.Length > 0 && Job.Length > 0)
            {
                string text = string.Format("Hello {0}\n your Job is {1}\n : Thank you ", name,Job );

                MessageBox.Show(text,"Information" );

                txtName.Clear();
               
                txtName.Focus();
               

            }

            else MessageBox.Show("Please Enter the Name and Job Fields");
        }
    }
}
