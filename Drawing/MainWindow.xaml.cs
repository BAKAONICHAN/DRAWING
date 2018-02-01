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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Drawing
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DoubleAnimation widthanim = new DoubleAnimation();
            //DoubleAnimation heightanim = new DoubleAnimation();
            //widthanim.From = Ellipse.Width;
            //heightanim.From = Ellipse.Height;
            //widthanim.To = Ellipse.Width + 100;
            //heightanim.To = Ellipse.Height + 100;
            //widthanim.Duration = TimeSpan.FromSeconds(0.5);
            //heightanim.Duration = TimeSpan.FromSeconds(0.5);
            //widthanim.AutoReverse = true;
            //heightanim.AutoReverse = true;
            //widthanim.RepeatBehavior=RepeatBehavior.Forever;
            //heightanim.RepeatBehavior = RepeatBehavior.Forever;
            //Ellipse.BeginAnimation(Ellipse.WidthProperty,widthanim);
            //Ellipse.BeginAnimation(Ellipse.HeightProperty, heightanim);
        }       
    }
}
