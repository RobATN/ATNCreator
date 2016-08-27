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
using Core;
using System.Data;

namespace ATNCreator.Seiten
{
    /// <summary>
    /// Interaktionslogik für NPC.xaml
    /// </summary>
    public partial class NPCErstellen : Page
    {
        public NPCErstellen()
        {
            InitializeComponent();
        }

        public void LoadNPCData(int entryID, string Settingspath)
        {
            Database db = new Database(Settingspath);
            DataTable dt = new DataTable();

            dt = db.SelectMySQLQuery("*", "creature_template", "entry", "=", entryID.ToString());

            txtBx_EntryID.Text = dt.Rows[0].ItemArray[0].ToString();                                    //Entry ID
            txtBx_Name.Text = dt.Rows[0].ItemArray[10].ToString();                                      //Name
            txtBx_SubName.Text = dt.Rows[0].ItemArray[11].ToString();                                   //Subname
            txtBx_MinLevel.Text = dt.Rows[0].ItemArray[14].ToString();                                  //minLevel
            txtBx_MaxLevel.Text = dt.Rows[0].ItemArray[15].ToString();                                  //maxLevel
            txtBx_Faction.Text = dt.Rows[0].ItemArray[17].ToString();                                   //faction
            cmbBx_Rank.SelectedIndex = Convert.ToInt32(dt.Rows[0].ItemArray[22]);                       //rank

            switch (Convert.ToInt32(dt.Rows[0].ItemArray[28]))                                          //unit_class
            {
                default: break;

                case 1:
                    cmbBx_Class.SelectedIndex = 0;
                    break;
                case 2:
                    cmbBx_Class.SelectedIndex = 1;
                    break;
                case 4:
                    cmbBx_Class.SelectedIndex = 2;
                    break;
                case 8:
                    cmbBx_Class.SelectedIndex = 3;
                    break;

            }

            switch (Convert.ToInt32(dt.Rows[0].ItemArray[32]))                                          //Family
            {
                case 0: break;
                case 1: //Wolf
                    cmbBx_Family.SelectedIndex = 0;
                    break;
                case 2: //Cat
                    cmbBx_Family.SelectedIndex = 1;
                    break;
                case 3: //Spider
                    cmbBx_Family.SelectedIndex = 2;
                    break;
                case 4: //Bear
                    cmbBx_Family.SelectedIndex = 3;
                    break;
                case 5: //Boar
                    cmbBx_Family.SelectedIndex = 4;
                    break;
                case 6: //Crocolisk
                    cmbBx_Family.SelectedIndex = 5;
                    break;
                case 7: //Carrion Bird
                    cmbBx_Family.SelectedIndex = 6;
                    break;
                case 8: //Crab
                    cmbBx_Family.SelectedIndex = 7;
                    break;
                case 9: //Gorilla
                    cmbBx_Family.SelectedIndex = 8;
                    break;
                case 11: //Raptor
                    cmbBx_Family.SelectedIndex = 9;
                    break;
                case 12: //Tallstrider
                    cmbBx_Family.SelectedIndex = 10;
                    break;
                case 15: //Felhunter
                    cmbBx_Family.SelectedIndex = 11;
                    break;
                case 16: //Voidwalker
                    cmbBx_Family.SelectedIndex = 12;
                    break;
                case 17: //Succubus
                    cmbBx_Family.SelectedIndex = 13;
                    break;
                case 19: //Doomguard
                    cmbBx_Family.SelectedIndex = 14;
                    break;
                case 20: //Scorpid
                    cmbBx_Family.SelectedIndex = 15;
                    break;
                case 21: // Turtle
                    cmbBx_Family.SelectedIndex = 16;
                    break;
                case 23: //Imp
                    cmbBx_Family.SelectedIndex = 17;
                    break;
                case 24: //Bat
                    cmbBx_Family.SelectedIndex = 18;
                    break;
                case 25: //Hyena
                    cmbBx_Family.SelectedIndex = 19;
                    break;
                case 26: //Owl
                    cmbBx_Family.SelectedIndex = 20;
                    break;
                case 27: //Wind Serpent
                    cmbBx_Family.SelectedIndex = 21;
                    break;
                case 28: //Remote Control
                    cmbBx_Family.SelectedIndex = 22;
                    break;
                case 29: //Felguard
                    cmbBx_Family.SelectedIndex = 23;
                    break;
                case 30: //Dragonhawk
                    cmbBx_Family.SelectedIndex = 24;
                    break;
                case 31: //Ravager
                    cmbBx_Family.SelectedIndex = 25;
                    break;
                case 32: //Warp Stalker
                    cmbBx_Family.SelectedIndex = 26;
                    break;
                case 33: //Sporebat
                    cmbBx_Family.SelectedIndex = 27;
                    break;
                case 34: // Nether Ray
                    cmbBx_Family.SelectedIndex = 28;
                    break;
                case 35: //Serpent
                    cmbBx_Family.SelectedIndex = 29;
                    break;
                case 37: //Moth
                    cmbBx_Family.SelectedIndex = 30;
                    break;
                case 38: //Chimera
                    cmbBx_Family.SelectedIndex = 31;
                    break;
                case 39: //Devilsaur
                    cmbBx_Family.SelectedIndex = 32;
                    break;
                case 40: // Ghoul
                    cmbBx_Family.SelectedIndex = 33;
                    break;
                case 41: //Silitid
                    cmbBx_Family.SelectedIndex = 34;
                    break;
                case 42: //Worm
                    cmbBx_Family.SelectedIndex = 35;
                    break;
                case 43: //Rhino
                    cmbBx_Family.SelectedIndex = 36;
                    break;
                case 44: //Wasp
                    cmbBx_Family.SelectedIndex = 37;
                    break;
                case 45: //Core Hound
                    cmbBx_Family.SelectedIndex = 38;
                    break;
                case 46: //Spirit Beast
                    cmbBx_Family.SelectedIndex = 39;
                    break;
                default: MessageBox.Show("Family außerhalb Range 1-46"); break;
            }


            cmbBx_Type.SelectedIndex = Convert.ToInt32(dt.Rows[0].ItemArray[37]);                               //Type

            if (Convert.ToInt32(dt.Rows[0].ItemArray[39]) != 0)                                                 //LootID
                chkBx_LootID.IsChecked = true;

            txtBx_LootID.Text = dt.Rows[0].ItemArray[39].ToString();                                            //LootID

            txtBx_minGold.Text = dt.Rows[0].ItemArray[58].ToString();                                           //mingold
            txtBx_maxGold.Text = dt.Rows[0].ItemArray[59].ToString();                                           //maxgold

            switch (Convert.ToInt32(dt.Rows[0].ItemArray[61]))                                                  //MovementType
            {
                case 0: rdbtn_MoveIdle.IsChecked = true; break;
                case 1: rdbtn_MoveRand.IsChecked = true; break;
                case 2: rdbtn_MoveWaypoints.IsChecked = true; break;
                default: MessageBox.Show("MoveType außerhalb Range 0-2"); break;
            }

            int inhType = Convert.ToInt32(dt.Rows[0].ItemArray[62]);                                            //InhabitType

            if ((inhType & 1) == 1) //Ground
            {
                chkBx_Boden.IsChecked = true;
            }
            if ((inhType & 2) == 2) //Water
            {
                chkBx_Wasser.IsChecked = true;
            }
            if ((inhType & 4) == 4) //Flying
            {
                chkBx_Luft.IsChecked = true;
            }

        }

        private void txtBx_Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblNPCNameCurrent.Content = txtBx_Name.Text;
        }

        private void txtBx_SubName_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblNPCSubNameCurrent.Content = txtBx_SubName.Text;
        }

        private void txtBx_EntryID_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblEntryIDCurrent.Content = txtBx_EntryID.Text;
        }

        private void txtBx_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void btn_Speichern_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_GenerateEntryID_Click(object sender, RoutedEventArgs e)
        {
            Database db = new Database("settings.dat");
            int newId = db.GetNewEntryID("entry", "creature_template");

            txtBx_EntryID.Text = newId.ToString();
        }

        private void rdbtn_MoveRand_Checked(object sender, RoutedEventArgs e)
        {
            if(rdbtn_MoveWaypoints != null)
                rdbtn_MoveWaypoints.IsChecked = false;

            if (rdbtn_MoveIdle != null)
                rdbtn_MoveIdle.IsChecked = false;
        }

        private void rdbtn_MoveWaypoints_Checked(object sender, RoutedEventArgs e)
        {
            if (rdbtn_MoveIdle != null)
                rdbtn_MoveIdle.IsChecked = false;

            if (rdbtn_MoveRand != null)
                rdbtn_MoveRand.IsChecked = false;
        }

        private void rdbtn_MoveIdle_Checked(object sender, RoutedEventArgs e)
        {
            if (rdbtn_MoveWaypoints != null)
                rdbtn_MoveWaypoints.IsChecked = false;

            if (rdbtn_MoveRand != null)
                rdbtn_MoveRand.IsChecked = false;
        }

        private void cmbBx_Type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (cmbBx_Family == null)
                return;

            switch (((ComboBox)sender).SelectedIndex)
            {
                case 1:
                case 3:
                    cmbBx_Family.IsEnabled = true;
                    break;

                default:
                    {
                        cmbBx_Family.IsEnabled = false;
                        cmbBx_Family.SelectedIndex = -1;
                    }
                    break;
            }
        }

        private void chkBx_ImportModel_Checked(object sender, RoutedEventArgs e)
        {
            grpBx_ImportModel.Visibility = Visibility.Visible;
            grpBx_Model.Visibility = Visibility.Hidden;
                

        }

        private void chkBx_ImportModel_Unchecked(object sender, RoutedEventArgs e)
        {
            grpBx_ImportModel.Visibility = Visibility.Hidden;
            grpBx_Model.Visibility = Visibility.Visible;
        }
    }
}
