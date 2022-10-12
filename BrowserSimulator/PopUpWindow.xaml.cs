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

namespace BrowserSimulator
{
    /// <summary>
    /// Interaction logic for PopUp.xaml
    /// </summary>
    public partial class PopUpWindow : Window
    {
        public PopUpWindow(PopUpProps props)
        {
            InitializeComponent();

            DataContext = props;
        }
        private void BtnCloseModal_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }

    public class PopUpProps
    {
        public string Title { get; set; }
        public string Message { get; set; }

        public bool IsError { get; set; }
    }
}
