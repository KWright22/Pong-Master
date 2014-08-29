using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using pongMaster.modelObjects;
using pongMaster.Utility;

namespace pongMaster
{
    public partial class addPlayerPage : PhoneApplicationPage
    {
        public addPlayerPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (playerTextBox.Text == "")
            {
                MessageBox.Show("Please enter a valid name in the text box.");
                return;
            }

            clsPlayer newPlayer = new clsPlayer();

            newPlayer.Name = playerTextBox.Text;

            foreach (clsPlayer player in modPrefs.getPlayers())
            {
                if (newPlayer.Name == player.Name)
                {
                    MessageBox.Show("This player name already exists. Please enter a valid name.");
                    return;
                }                
            }

            modPrefs.addPlayer(newPlayer);

            NavigationService.GoBack();


        }
    }
}