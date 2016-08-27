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
using Core.Entities;
using System.Data;

namespace ATNCreator.Seiten
{
    /// <summary>
    /// Interaktionslogik für NPCSuchen.xaml
    /// </summary>
    public partial class NPCSuchen : Page
    {

        public NAVIGATE nav;

        public NPCSuchen()
        {
            InitializeComponent();
            chkbxNamenSuchen.IsChecked = true;
        }

        public void NavigatePage(Page seite)
        {
            nav(seite);
            
        }

        private void btnNPCsuchen_Click(object sender, RoutedEventArgs e)
        {
            //Alte Suchergebnisse löschen
            lstBxErgebnisse.Items.Clear();

            NPC_HelperClass npchelper = new NPC_HelperClass("settings.dat");
            DataTable dt = new DataTable();

            //Suchen wir nach einer ID?
            if (chkbxEntryIDSuchen.IsChecked == true)
            {
                //Absichern falls jmd text eingegeben hat statt zahlen
                int id;
                bool res = Int32.TryParse(txtbxSuchen.Text, out id); 
                if (res == true)
                {
                    //Ergebnisse von npchelper.SearchNPCbyID(id) in DatenTabelle speichern
                    dt = npchelper.SearchNPCbyID(id); 
                }
            }
            else if(chkbxNamenSuchen.IsChecked == true) //Ok, wir suchen einen Namen!
                dt = npchelper.SearchNPCbyName(txtbxSuchen.Text); //Ergebnisse von npchelper.SearchNPCbyID(id) in DatenTabelle speichern

            //Ergebnisse durch ne Schleife boxen um sie für die Listbox ansehnlich zu machen
            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                string s;

                if(dt.Rows[i].ItemArray[2].ToString() == "" || dt.Rows[i].ItemArray[2].ToString() == " ") //Für den Fall dass wir keinen SubName haben, schreiben wir auch keinen in die Listbox
                    s = "Entry ID:" + dt.Rows[i].ItemArray[0].ToString() + "|\t" + dt.Rows[i].ItemArray[1].ToString(); //String für Listbox vorbereiten (Ohne SubName)
                else
                    s = "Entry ID:" + dt.Rows[i].ItemArray[0].ToString() + "|\t" + dt.Rows[i].ItemArray[1].ToString() + " - '" + dt.Rows[i].ItemArray[2].ToString() + "'"; //String für Listbox vorbereiten (Mit SubName)
                
                //Ab in die ListBox damit
                lstBxErgebnisse.Items.Add(s); 
            }


        }

        private void btnNPCBearbeiten_Click(object sender, RoutedEventArgs e)
        {
            if (lstBxErgebnisse.Items.Count <= 0)
                return;

            string[] split1 = lstBxErgebnisse.SelectedItem.ToString().Split(':');
            string[] split2 = split1[1].Split('|');


            int id;
            bool res = Int32.TryParse(split2[0], out id);
            if (res == true)
            {
                Seiten.NPCErstellen seite = new Seiten.NPCErstellen();
                NavigatePage(seite);
                Application.Current.MainWindow.Height = 600;
                Application.Current.MainWindow.Width = 750;
                Application.Current.MainWindow.Title = "ATNCreator | Item Bearbeiten";
                seite.LoadNPCData(id, "settings.dat");
            }
        }

        private void chkbxEntryIDSuchen_Checked(object sender, RoutedEventArgs e)
        {
            chkbxNamenSuchen.IsChecked = false;
        }

        private void chkbxNamenSuchen_Checked(object sender, RoutedEventArgs e)
        {
            chkbxEntryIDSuchen.IsChecked = false;
        }

        private void lstBxErgebnisse_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            btnNPCBearbeiten_Click(sender, e);
        }

        private void txtbxSuchen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnNPCsuchen_Click(sender, e);
            }
        }

        private void lstBxErgebnisse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnNPCBearbeiten_Click(sender, e);
            }
        }
    }
}
