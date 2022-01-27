using System;
using System.Windows;
using System.Windows.Media;


/// Kurssi: Olio-ohjelmointi INTIM21A6
/// Tehtävä: WPF-laskin
/// Tekijä: Aleksi Bovellan


namespace WPF_laskin
{

    /// Interaction logic for MainWindow.xaml

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        /// Alustuksia

        public static int kierrosluku = 1;
        public static int ekaLuku = 0;
        public static int tokaLuku = 0;
        public static int summa = 0;


        /// Numeropainikkeiden seuraukset ja lukujen muistitoiminto. Tarvitsee inputin "painalluksen luku", esim. tutki(2) 
        
        private void tutki(int painallus) {

            if (kierrosluku == 1) {

                box_results.Text = painallus.ToString();
                ekaLuku = painallus;
                tokaLuku = 0;
                kierrosluku++;
                box_status.Background = Brushes.Yellow;
                box_status.Foreground = Brushes.Black;
                box_status.Text = "Odottaa #2 numeroa ...";
                lbl_guide.Content = "Ensimmäinen numerosi on tallennettu. Valitse toinen numerosi.";

            }
            else {

                box_results.Text = Convert.ToString(painallus);
                tokaLuku = painallus;
                box_status.Text = "Molemmat numerot OK!";
                lbl_guide.Content = "Toinenkin numerosi on tallennettu. Paina = nappia laskeaksesi ne yhteen.";
                kierrosluku = 1;

            }
            
        }


        /// Summapainikkeen = saldotoiminto. Sisältää myös tarkistusmekanismin että molemmat luvut on ensin saatu.

        private void yhdista() {

            if (ekaLuku == 0) {

                kierrosluku = 1;
                box_results.Text = "0";
                tokaLuku = 0;
                lbl_guide.Content = "Yritä uudelleen. Valitse ensin molemmat numerot. Vasta sen jälkeen = nappia.";
                box_status.Text = "Valmis. Odottaa #1 numeroa ...";
                box_status.Background = Brushes.Green;
                box_status.Foreground = Brushes.White;

            }
            else {

                if (tokaLuku == 0) {
                    kierrosluku = 1;
                    box_results.Text = "0";
                    ekaLuku = 0;
                    lbl_guide.Content = "Yritä uudelleen. Valitse ensin molemmat numerot. Vasta sen jälkeen = nappia.";
                    box_status.Text = "Valmis. Odottaa #1 numeroa ...";
                    box_status.Background = Brushes.Green;
                    box_status.Foreground = Brushes.White;

                }
                else {

                    int summa = ekaLuku + tokaLuku;
                    box_results.Text = Convert.ToString(summa);
                    box_status.Background = Brushes.Green;
                    box_status.Foreground = Brushes.White;
                    box_status.Text = "Valmis. Odottaa #1 numeroa ...";
                    ekaLuku = 0;
                    tokaLuku = 0;
                    lbl_guide.Content = "Klikkaa ensin yhtä numeroa, ja sitten toista, jonka jälkeen = napilla ne summautuvat yhteen.";

                }
            }
        }

                  
        ///  Nappien määritykset. Eli, painallus lähinnä siirretään vaan omaan funktioonsa tutkittavaksi.

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            tutki(1);
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            tutki(2);
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            tutki(3);
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            tutki(4);
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            tutki(5);
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            tutki(6);
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            tutki(7);
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            tutki(8);
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            tutki(9);
        }

        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            yhdista();
        }

    }

}
