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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Osoba
        {
            public string jmeno { get; set; }
            public string prijmeni { get; set; }
            public string narozeni { get; set; }
        }
        public class Zamestnanec : Osoba
        {
            public string vzdelani { get; set; }
            public string pozice { get; set; }
            public int plat { get; set; }
            public override string ToString()
            {
                return jmeno +" "+ prijmeni + " " + narozeni + " " + vzdelani + " " + pozice + " " + plat;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Zamestnanec A = new Zamestnanec();
            A.jmeno = jmeno.Text;
            A.prijmeni = prijmeni.Text;
            A.narozeni = rok.Text;
            A.vzdelani = vzdelani.Text;
            A.pozice = pozice.Text;
            int Plat = int.Parse(plat.Text);
            A.plat = Plat;
            using (StreamWriter file = new StreamWriter("Zamestnanci.txt", append: true))
            {
                file.WriteLine(A.ToString());
            }
        }
    }
}
