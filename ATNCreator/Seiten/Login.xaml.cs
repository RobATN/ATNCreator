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
            if (File.Exists("settings.dat"))
            {
                Settings s = Settings.SettingsLaden("settings.dat");
                txt_user.Text = s.User;
                txt_password.Password = s.Password;
                txt_server.Text = s.Server;
            }
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            if (Database.TryLogin(txt_user.Text, txt_password.Password, txt_server.Text, "world") == true)
            {
                Settings setting = new Settings(txt_user.Text, txt_password.Password, txt_server.Text, "world");
                Settings.SettingsSpeichern(setting, "settings.dat");

                Seiten.Hauptmenü seite = new Seiten.Hauptmenü();

                login(seite);

            }
            else
            {
                MessageBox.Show("Keine Verbindung zum Server möglich.\nLogin Daten falsch?");
            }
        }
    }
}
