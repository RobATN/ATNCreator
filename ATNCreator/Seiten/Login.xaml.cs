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

namespace ATNCreator.Seiten
{
    /// <summary>
    /// Interaktionslogik für Login.xaml
    /// </summary>
    /// 

    public delegate void NAVLOGIN(Page seite);

    public partial class Login : Page
    {
        public event NAVLOGIN login;

        public Login()
        {
            InitializeComponent();
            CheckSettings();
        }

        private void CheckSettings()
        {
            //Erstmal schauen ob die settings.dat schon existiert
            if (File.Exists("settings.dat"))
            {
                //Tut sie! Dann mal in die SettingsClass laden
                Settings s = Settings.SettingsLaden("settings.dat");

                //Füllen der Textboxen mit den Infos aus den Settings
                txtBx_user.Text = s.User;
                txtBx_password.Password = s.Password;
                txtBx_server.Text = s.Server;
            }
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            //Login Versuchen
            if (Database.TryLogin(txtBx_user.Text, txtBx_password.Password, txtBx_server.Text, "world") == true)
            {
                //Klappt, also den eingegeben Scheiß fein in die settings.dat speichern
                Settings setting = new Settings(txtBx_user.Text, txtBx_password.Password, txtBx_server.Text, "world");
                Settings.SettingsSpeichern(setting, "settings.dat");

                //Und ab ins Hauptmenü
                Seiten.Hauptmenü seite = new Seiten.Hauptmenü();

                //Der Delegat NAVLOGIN befördert die Hauptmenü Seite ins MainWindow
                login(seite);
            }
            else
            {
                MessageBox.Show("Keine Verbindung zum Server möglich.\nLogin Daten falsch?");
            }
        }
    }
}
