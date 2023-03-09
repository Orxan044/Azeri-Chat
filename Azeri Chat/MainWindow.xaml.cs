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

namespace Azeri_Chat
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Message.Text != string.Empty)
            {
                Grid grid = new Grid() { Margin = new Thickness(2, 0, 0, 0) };
                TextBox textbox = new TextBox()
                {
                    IsReadOnly = true,
                    Text = Message.Text,
                    HorizontalAlignment = HorizontalAlignment.Right,
                    Margin = new Thickness(0, 0, 3, 0),
                    BorderThickness = new Thickness(0),
                    Padding = new Thickness(0, 0, 0, 0),
                    FontSize = 16,
                    TextWrapping = TextWrapping.Wrap,
                    MaxWidth = 250,
                    Height = 10
                };
                Label label = new Label()
                {
                    Content = DateTime.Now.ToString("HH:mm"),
                    FontFamily = new FontFamily("Arial Rounded MT Bold"),
                    Margin = new Thickness(0, 0, 0, 3)
                };
                gonderen_yer.Children.Add(textbox);
                gonderen_yer.Children.Add(label);
                Message.Clear();

            }
            else
            {
                MessageBox.Show("Dont Null");
            }
        }

    }
}
