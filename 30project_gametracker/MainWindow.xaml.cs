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

namespace project_gametracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ComboBox comboBox;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_Copy2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_Copy4_TextChanged(object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
