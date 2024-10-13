using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace subraction
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

        private void btnresult_Click(object sender, RoutedEventArgs e)
        {
            int NUM1 = Convert.ToInt32(txtvalue1.Text);
            int NUM2 = Convert.ToInt32(txtvalue2.Text);
            int OUTPUT = NUM1 - NUM2;
            MessageBox.Show(Convert.ToString(OUTPUT));

        }
    }
}