using System;
using System.Collections.Generic;
using System.IO;
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
using Core;

namespace ATNCreator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    /// 
    public delegate void NAVIGATE(Page seite);

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Seiten.Login seite = new Seiten.Login();
            ContentArea.Content = seite;
            Application.Current.MainWindow.Title = "ATNCreator | Login";

            seite.login += FirstLogin;
        }

        public void FirstLogin(Page seite)
        {
            ContentArea.Content = seite;
            menu.Visibility = Visibility.Visible;
            Application.Current.MainWindow.Height = 400;
            Application.Current.MainWindow.Width = 600;
            Application.Current.MainWindow.Title = "ATNCreator | Hauptmenü";
        }

        public void NavigatePage(Page seite)
        {
            ContentArea.Content = seite;
        }


        private void btnBeenden_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnNPCErstellen_Click(object sender, RoutedEventArgs e)
        {
            Seiten.NPCErstellen seite = new Seiten.NPCErstellen();
            NavigatePage(seite);
            Application.Current.MainWindow.Title = "ATNCreator | NPC erstellen";
            Application.Current.MainWindow.Height = 600;
            Application.Current.MainWindow.Width = 750;
        }


        private void btnItemErstellen_Click(object sender, RoutedEventArgs e)
        {
            Seiten.Item seite = new Seiten.Item();
            NavigatePage(seite);
            Application.Current.MainWindow.Title = "ATNCreator | Item erstellen";
            Application.Current.MainWindow.Height = 600;
            Application.Current.MainWindow.Width = 750;
        }

        private void btnQuestErstellen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGameobjectErstellen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAccountTools_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnStatistiken_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnÜber_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNPCSuchen_Click(object sender, RoutedEventArgs e)
        {
            Seiten.NPCSuchen seite = new Seiten.NPCSuchen();
            NavigatePage(seite);
            seite.nav += this.NavigatePage;
            Application.Current.MainWindow.Title = "ATNCreator | NPC Suchen";
            Application.Current.MainWindow.Height = 400;
            Application.Current.MainWindow.Width = 600;
        }
    }
}
