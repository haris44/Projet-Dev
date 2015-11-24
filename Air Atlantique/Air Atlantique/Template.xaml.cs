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

namespace Air_Atlantique
{
    /// <summary>
    /// Logique d'interaction pour Template.xaml
    /// </summary>
    public partial class Template : Page
    {
        public Template()
        {
            InitializeComponent();
           
        }
    
    public void mailNotif(int nombre)
        {
            if (nombre <= 0)
                notifCircle.Visibility = Visibility.Collapsed;
            else
            {
                notifCircle.Visibility = Visibility.Visible;
                notif.Content = nombre.ToString();
            }
        }
    }
}
