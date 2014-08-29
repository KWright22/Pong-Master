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
    public partial class newGamePage : PhoneApplicationPage
    {                              
       public newGamePage()
        {
            InitializeComponent();
            //this.p1listPicker.ItemsSource = Player1;
            //this.p2listPicker.ItemsSource = Player2;
        }

       protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
       {

           List<clsPlayer> player1LP;
           player1LP = new List<clsPlayer>();

           player1LP.Add(new clsPlayer {Name = "No Selection"});
           player1LP.AddRange(modPrefs.getPlayers());

           p1listPicker.ItemsSource = player1LP;
           p2listPicker.ItemsSource = player1LP;

           base.OnNavigatedTo(e);           

       }

       private void addP1Button_Click(object sender, RoutedEventArgs e)
       {
           this.NavigationService.Navigate(new Uri("/addPlayerPage.xaml", UriKind.Relative));
       }

       private void addP2Button_Click(object sender, RoutedEventArgs e)
       {
           this.NavigationService.Navigate(new Uri("/addPlayerPage.xaml", UriKind.Relative));
       }

       private void startGameButton_Click(object sender, RoutedEventArgs e)
       {

           int enteredScore;

           if (!int.TryParse(scoreTextBox.Text, out enteredScore))
           {
               MessageBox.Show("Please enter a valid score into the textbox.");
               return;
           }


           if (p1listPicker.SelectedItem == p2listPicker.SelectedItem)
           {
               MessageBox.Show("Stop trying to play with yourself.");
               return;
           }

           if (((clsPlayer) p1listPicker.SelectedItem).Name == "No Selection" || 
               ((clsPlayer) p2listPicker.SelectedItem).Name == "No Selection")
           {
               MessageBox.Show("Please select two different players.");
               return;
           }

           clsPingPongGame newGame = new clsPingPongGame();

           newGame.Time = 0;
           newGame.P1Score = 0;
           newGame.P2Score = 0;
           newGame.Player1 = (clsPlayer) p1listPicker.SelectedItem;
           newGame.Player2 = (clsPlayer) p2listPicker.SelectedItem;
           newGame.Score = enteredScore;

           newGame.Active = true;
           modPrefs.addGame(newGame);

           this.NavigationService.Navigate(new Uri("/gamePage.xaml?gameID="+newGame.GameID, UriKind.Relative));
       }
    }
}