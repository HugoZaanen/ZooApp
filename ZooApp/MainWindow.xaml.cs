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
using System.Windows.Threading;

namespace ZooApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Animal> Zoo = new ObservableCollection<Animal>();
        
        public MainWindow()
        {
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lstbx.ItemsSource = Zoo;
            dtgrd.ItemsSource = Zoo;

            var timer = new DispatcherTimer();

            timer.Tick += Timer_Tick;

            timer.Interval = new TimeSpan(0,0,0,0,500);

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Zoo.Count - 1; i++)
            {
                Animal dier = Zoo[i];
                dier.UseEnergy();

                if (dier.Energy < 0)
                {
                    
                }
            }
        }

        public void Refresh()
        {
            lstbx.ItemsSource = null;
            lstbx.ItemsSource = Zoo;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button butt = sender as Button;
            string n = (string)butt.Content;

            if (n == "Voeg Aap")
            {
                Monkey monk = new Monkey();
                monk.Name = "Aapje";
                Zoo.Add(monk);
            }
            else if (n == "Voeg Leeuw")
            {
                Lion lion = new Lion();
                lion.Name = "Cecil";
                Zoo.Add(lion);
            }
            else if (n == "Voeg Olifant")
            {
                Elephant elep = new Elephant();
                elep.Name = "Oli";
                Zoo.Add(elep);
            }           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (var animal in Zoo)
            {
                animal.Eat();        
            }
            Refresh();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            foreach (var animal in Zoo)
            {
                var a = animal as Monkey;

                if (a != null)
                {
                    a.Eat();
                }
            }
            Refresh();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            foreach (var animal in Zoo)
            {
                var a = animal as Lion;

                if (a != null)
                {
                    a.Eat();
                }
            }
            Refresh();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            foreach (var animal in Zoo)
            {
                var a = animal as Elephant;

                if (a != null)
                {
                    a.Eat();
                }
            }
            Refresh();
        }
    }
}
