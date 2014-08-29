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
using pongMaster.Utility;
using pongMaster.modelObjects;

namespace pongMaster
{
    public partial class previousGamesPage : PhoneApplicationPage
    {
        public previousGamesPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            previousGamesListBox.ItemsSource = modPrefs.getGames();

            base.OnNavigatedTo(e);
            
        }

        private void previousGamesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            clsPingPongGame game = (clsPingPongGame)previousGamesListBox.SelectedItem;
            this.NavigationService.Navigate(new Uri("/gamePage.xaml?gameID="+game.GameID, UriKind.Relative));
        }
    }
}