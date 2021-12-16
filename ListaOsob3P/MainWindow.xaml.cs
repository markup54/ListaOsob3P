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

namespace ListaOsob3P
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Osoba> ListaOsob { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }
        private void PrzygotujWiazanie()
        {
            ListaOsob = new ObservableCollection<Osoba>();
            ListaOsob.Add(new Osoba("Jaś", "Pomidor", "123456789"));
            ListaOsob.Add(new Osoba("Asia", "Marchewka", "123456789"));
            ListaOsob.Add(new Osoba("Ola", "Brzoskwinka", "123456789"));
            ListaOsob.Add(new Osoba("Szymon", "Ogórek", "123456789"));
            ListaOsob.Add(new Osoba("Antek", "Ananas", "123456789"));
            DataContext = this;
        }
    }
}
