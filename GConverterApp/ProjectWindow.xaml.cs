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
using System.Windows.Media.Animation;

namespace GConverterApp
{
    /// <summary>
    /// Логика взаимодействия для ProjectWindow.xaml
    /// </summary>
    public partial class ProjectWindow : Window
    {
        public ProjectWindow()
        {
            InitializeComponent();
        }

        private void openMenu(object sender, RoutedEventArgs e)
        {
            DoubleAnimation anim = new DoubleAnimation();
            if (RightMenu.Width > 0)
            {
                anim.From = 250;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.5);
                RightMenu.BeginAnimation(WidthProperty, anim);
                return;
            }

            anim.From = 0;
            anim.To = 250;
            anim.Duration = TimeSpan.FromSeconds(0.5);
            RightMenu.BeginAnimation(WidthProperty, anim);
        }
    }
}
