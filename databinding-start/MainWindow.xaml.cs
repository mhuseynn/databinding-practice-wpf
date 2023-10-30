using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace databinding_start
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Message> messages { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            messages = new()
            {
                new("Salam",DateTime.Now),
                new("Necesiz",DateTime.Now),
                 new("How old are you",DateTime.Now),
                new("How are you",DateTime.Now),
                 new("Whta are you doing",DateTime.Now),
                new("i am fine",DateTime.Now),
                 new("Thanks",DateTime.Now),
                new("you?",DateTime.Now),
                 new("Salam",DateTime.Now),
                new("Salam",DateTime.Now)
            };
            DataContext = this;
        }






    }
}
