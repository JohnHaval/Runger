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

namespace Runger
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class AboutProgrammer : Window
    {                 
        public AboutProgrammer()
        {
            InitializeComponent();
            Music.Content = "Music:Bossfight, Buku, \nF.O.O.L, Far Out, Gress, \nInfraction,KROWW, \nPax Impera, ZABO, Satara, \nShockOne, Blanke";
        }
    }
}
