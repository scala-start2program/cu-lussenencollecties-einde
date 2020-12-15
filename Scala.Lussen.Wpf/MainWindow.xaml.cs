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

namespace Scala.Lussen.Wpf
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
        Random rnd = new Random();

        private void btnWhile1_Click(object sender, RoutedEventArgs e)
        {
            lstResultaat.Items.Clear();
            int getal = 0;
            while (getal < 10)
            {
                getal = getal + 1;
                lstResultaat.Items.Add(getal);
            }
        }

        private void btnWhile2_Click(object sender, RoutedEventArgs e)
        {
            lstResultaat.Items.Clear();
            int getal = 10;
            while (getal > 0)
            {
                lstResultaat.Items.Add(getal);
                getal = getal - 1;
            }
        }

        private void btnWhile3_Click(object sender, RoutedEventArgs e)
        {
            lstResultaat.Items.Clear();
            int teRaden = rnd.Next(1, 1001);
            int gokje = 0;
            int poging = 0;
            string zin;
            while (gokje != teRaden)
            {
                poging++;
                gokje = rnd.Next(1, 1001);
                zin = "Poging " + poging.ToString() + " : " + gokje.ToString();
                lstResultaat.Items.Insert(0, zin);
            }
        }

        private void btnFor1_Click(object sender, RoutedEventArgs e)
        {
            lstResultaat.Items.Clear();
            for (int teller = 1; teller <= 10; teller++)
            {
                lstResultaat.Items.Add(teller);
            }
        }

        private void btnFor2_Click(object sender, RoutedEventArgs e)
        {
            lstResultaat.Items.Clear();
            for (int teller = 10; teller >= 1; teller--)
            {
                lstResultaat.Items.Add(teller);
            }
        }

        private void btnFor3_Click(object sender, RoutedEventArgs e)
        {
            lstResultaat.Items.Clear();
            for (int even = 0; even <= 100; even += 2)
            {
                lstResultaat.Items.Add(even);
            }
        }

        private void btnFor4_Click(object sender, RoutedEventArgs e)
        {
            lstResultaat.Items.Clear();
            int basis = 7;
            string zin;
            for (int t = 1; t <= 10; t++)
            {
                int product = basis * t;
                zin = $"{basis} x {t} = {product}";
                lstResultaat.Items.Add(zin);
            }
        }

        private void btnFor5_Click(object sender, RoutedEventArgs e)
        {
            lstResultaat.Items.Clear();
            string zin = "Jantje zag eens pruimen hangen o als eieren zo groot";
            for (int t = 0; t < zin.Length; t++)
            {
                lstResultaat.Items.Add(zin.Substring(t, 1));
            }
        }

        private void btnFor6_Click(object sender, RoutedEventArgs e)
        {
            lstResultaat.Items.Clear();
            for (byte b = 65; b <= 90; b++)
            {
                string zin;
                zin = $"{(char)b} = {b}";
                lstResultaat.Items.Add(zin);
            }
        }

        private void btnFor7_Click(object sender, RoutedEventArgs e)
        {
            lstResultaat.Items.Clear();
            string zin = txtFor.Text.ToUpper();
            txtFor.Text = zin;
            int lengteVanDeZin = zin.Length;
            int letterTeller;
            for (byte b = 65; b <= 90; b++)
            {
                letterTeller = 0;
                for (int t = 0; t < lengteVanDeZin; t++)
                {
                    if ((char)b == char.Parse(zin.Substring(t, 1)))
                    {
                        letterTeller++;
                    }
                }
                lstResultaat.Items.Add($"{(char)b} komt {letterTeller} keer voor");
            }
        }

        private void btnArray1_Click(object sender, RoutedEventArgs e)
        {
            string[] dagenVanDeWeek = new string[7];
            dagenVanDeWeek[0] = "maandag";
            dagenVanDeWeek[1] = "dinsdag";
            dagenVanDeWeek[2] = "woensdag";
            dagenVanDeWeek[3] = "donderdag";
            dagenVanDeWeek[4] = "vrijdag";
            dagenVanDeWeek[5] = "zaterdag";
            dagenVanDeWeek[6] = "zondag";

            lstResultaat.Items.Clear();
            for (int r = 0; r < 7; r++)
            {
                lstResultaat.Items.Add(dagenVanDeWeek[r]);
            }
        }

        private void btnArray2_Click(object sender, RoutedEventArgs e)
        {
            int[] evenGetallen = new int[52];
            for (int r = 0; r <= 50; r++)
            {
                evenGetallen[r] = r * 2;
            }

            lstResultaat.Items.Clear();
            for (int r = 0; r <= 50; r++)
            {
                lstResultaat.Items.Add(evenGetallen[r]);
            }
        }

        private void btnArray3_Click(object sender, RoutedEventArgs e)
        {
            int[] winnendeGetallen = new int[6];
            for (int r = 0; r < 6; r++)
            {
                bool gevonden = true;
                int nieuwGetal = 0;
                while (gevonden == true)
                {
                    gevonden = false;
                    nieuwGetal = rnd.Next(1, 42);
                    for (int t = 0; t < 6; t++)
                    {
                        if (winnendeGetallen[t] == nieuwGetal)
                            gevonden = true;
                    }
                }
                winnendeGetallen[r] = nieuwGetal;
            }
            Array.Sort(winnendeGetallen);
            lstResultaat.Items.Clear();
            for (int r = 0; r < 6; r++)
            {
                lstResultaat.Items.Add(winnendeGetallen[r]);
            }
        }

        private void btnArray4_Click(object sender, RoutedEventArgs e)
        {
            string[,] weersverwachting = new string[7, 3];
            weersverwachting[0, 0] = "Maandag";
            weersverwachting[1, 0] = "Dinsdag";
            weersverwachting[2, 0] = "Woensdag";
            weersverwachting[3, 0] = "Donderdag";
            weersverwachting[4, 0] = "Vrijdag";
            weersverwachting[5, 0] = "Zaterdag";
            weersverwachting[6, 0] = "Zondag";

            for (int r = 0; r < 7; r++)
            {
                int temperatuur = rnd.Next(-5, 41);
                weersverwachting[r, 1] = temperatuur.ToString();
                if (temperatuur <= 0)
                    weersverwachting[r, 2] = "vorst";
                else if (temperatuur <= 10)
                    weersverwachting[r, 2] = "koud";
                else if (temperatuur <= 20)
                    weersverwachting[r, 2] = "frisjes";
                else if (temperatuur <= 30)
                    weersverwachting[r, 2] = "warm";
                else
                    weersverwachting[r, 2] = "Bloedheet";
            }
            lstResultaat.Items.Clear();
            string zin;
            for (int r = 0; r < 7; r++)
            {
                zin = $"{weersverwachting[r, 0]} : {weersverwachting[r, 1]}° C - {weersverwachting[r, 2]}";
                lstResultaat.Items.Add(zin);
            }
        }

        List<string> namen = new List<string>();
        private void btnList1_Click(object sender, RoutedEventArgs e)
        {
            string naam = txtNaam.Text.Trim();
            if (naam != "")
            {
                namen.Add(naam);
                ToonList();
                txtNaam.Text = "";
                txtNaam.Focus();
            }
        }
        private void ToonList()
        {
            lstResultaat.Items.Clear();
            for (int r = 0; r < namen.Count; r++)
            {
                lstResultaat.Items.Add(namen[r]);
            }
        }

        private void btnList2_Click(object sender, RoutedEventArgs e)
        {
            if (lstResultaat.SelectedItem != null)
            {
                string wisnaam = lstResultaat.SelectedItem.ToString();
                namen.Remove(wisnaam);
                ToonList();
            }
        }

        string volgorde = "ASC";
        private void btnList3_Click(object sender, RoutedEventArgs e)
        {
            if (volgorde == "ASC")
            {
                namen.Sort();
                volgorde = "DESC";
            }
            else
            {
                namen.Reverse();
                volgorde = "ASC";
            }
            ToonList();
        }

        private void btnForEach1_Click(object sender, RoutedEventArgs e)
        {
            lstResultaat.Items.Clear();
            string zin = txtFor.Text;
            foreach (char letter in zin)
            {
                lstResultaat.Items.Add(letter);
            }
        }

        private void btnForEach2_Click(object sender, RoutedEventArgs e)
        {
            lstResultaat.Items.Clear();
            List<int> getallen = new List<int>();
            for (int r = 1; r <= 10; r++)
            {
                getallen.Add(rnd.Next(0, 10000));
            }
            int som = 0;
            foreach (int getal in getallen)
            {
                lstResultaat.Items.Add($"{som} + {getal} = {som + getal} ");
                som += getal;
            }
        }

        private void btnForEach3_Click(object sender, RoutedEventArgs e)
        {
            lstResultaat.Items.Clear();
            ListBoxItem itm;
            foreach (System.Reflection.PropertyInfo property in typeof(Brushes).GetProperties())
            {
                SolidColorBrush borstel = (SolidColorBrush)property.GetValue(null, null);
                string naam = property.Name;
                itm = new ListBoxItem();
                itm.Content = naam;
                itm.Background = borstel;
                itm.Foreground = new SolidColorBrush(IdealTextColor(borstel.Color));
                lstResultaat.Items.Add(itm);
            }

        }
        private Color IdealTextColor(Color bg)
        {
            int nThreshold = 105;
            int bgDelta = Convert.ToInt32((bg.R * 0.299) + (bg.G * 0.587) + (bg.B * 0.114));

            Color foreColor = (255 - bgDelta < nThreshold) ? Color.FromRgb(0, 0, 0) : Color.FromRgb(255, 255, 255);
            return foreColor;
        }

        private void btnForEach4_Click(object sender, RoutedEventArgs e)
        {
            lstResultaat.Items.Clear();
            string teOnderzoekenMap = @"c:\windows";
            DirectoryInfo directoryInfo = new DirectoryInfo(teOnderzoekenMap);
            lstResultaat.Items.Add("De bestanden in " + teOnderzoekenMap + " : ");
            foreach (FileInfo fi in directoryInfo.GetFiles())
            {
                lstResultaat.Items.Add(fi.Name);
            }
            lstResultaat.Items.Add("===========");
            lstResultaat.Items.Add("De mappen in " + teOnderzoekenMap + " : ");
            foreach (DirectoryInfo di in directoryInfo.GetDirectories())
            {
                lstResultaat.Items.Add(di.Name);
            }

        }

        private void btnDo1_Click(object sender, RoutedEventArgs e)
        {
            bool verderdoen = true;
            int aantal = 0;
            do
            {
                aantal++;
                if (MessageBox.Show("Verderdoen?", aantal.ToString(), MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                    verderdoen = false;

            } while (verderdoen == true);
        }


        private void btnBreak_Click(object sender, RoutedEventArgs e)
        {
            // list van string aanmaken en tiental namen toevoegen
            List<string> namen = new List<string>();
            namen.Add("jan");
            namen.Add("piet");
            namen.Add("joris");
            namen.Add("korneel");
            namen.Add("anna");
            namen.Add("bart");
            namen.Add("charles");
            namen.Add("dirk");
            namen.Add("els");
            namen.Add("fernand");

            // in deze lijst op zoek gaan naar de plaats waar
            // "charles" voorkomt
            int positie = -1;
            bool gevonden = false;
            foreach(string naam in namen)
            {
                positie++;
                if(naam == "charles")
                {
                    gevonden = true;
                    break;
                }
            }
            if(gevonden)
            {
                MessageBox.Show("Charles zit op positie " + positie.ToString());
            }    
            else
            {
                MessageBox.Show("Charles niet gevonden");
            }
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            lstResultaat.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 != 0)
                {
                    continue;
                }
                lstResultaat.Items.Add($"{i} is deelbaar door 3");
            }
        }
    }
}
