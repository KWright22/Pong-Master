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
using System.Windows.Threading;

namespace pongMaster
{
    public partial class gamePage : PhoneApplicationPage
    {
        private clsPingPongGame game;
        private DispatcherTimer timer;

        public gamePage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e) 
        {
            timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000); // 1000 Milliseconds
            timer.Tick += new EventHandler(dt_Tick);
            timer.Start();

            if (NavigationContext.QueryString.ContainsKey("gameID"))
            {
                int gameID;

                gameID = int.Parse(NavigationContext.QueryString["gameID"]);
                game = modPrefs.getGameByGameID(gameID);

                p1ScoreTextBlock.Text = game.P1Score.ToString();
                p2ScoreTextBlock.Text = game.P2Score.ToString();

                p1NameTextBlock.Text = game.Player1.Name;
                p2NameTextBlock.Text = game.Player2.Name;

                if (!game.Active)
                {
                    timer.Stop();
                }
            }

            base.OnNavigatedTo(e);

        }

        private void p1IncrementButton_Click(object sender, RoutedEventArgs e)
        {
            if (game.Active)
            {
                game.P1Score++;
                p1ScoreTextBlock.Text = game.P1Score.ToString();
                checkScore();
            }
            
        }

        void dt_Tick(object sender, EventArgs e)
        {
            game.Time++;

            timerTextBlock.Text = game.Time.ToString();
        }

        private void checkScore()
        {
            if (game.P1Score >= game.Score)
            {
                if (game.P1Score >= game.P2Score+2)
                {
                    MessageBox.Show("Congratulations" + "" + p1NameTextBlock.Text + "" + "you've won the game!");
                    game.Active = false;
                    timer.Stop();
                    this.NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
                }
            }

            if (game.P2Score >= game.Score)
            {
                if (game.P2Score >= game.P1Score+2)
                {
                    MessageBox.Show("Congratulations" + "" + p2NameTextBlock.Text + "" + "you've won the game!");
                    game.Active = false;
                    timer.Stop();
                    this.NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
                }
            }

            modPrefs.saveGame(game);                
            
        }

        private void p2IncrementButton_Click(object sender, RoutedEventArgs e)
        {
            if (game.Active)
            {
                game.P2Score++;
                p2ScoreTextBlock.Text = game.P2Score.ToString();
                checkScore();
            }

        }


    }
}