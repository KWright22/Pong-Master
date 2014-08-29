using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using pongMaster.modelObjects;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;

namespace pongMaster.Utility
{
    public static class modPrefs
    {
        private const string PLAYERLIST = "PlayerList";
        private const string GAMELIST_KEY = "GameList";

        public static List<clsPlayer> getPlayers()
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains(PLAYERLIST))
            {
                return (List<clsPlayer>)IsolatedStorageSettings.ApplicationSettings[PLAYERLIST];
            }

            return new List<clsPlayer>();
        }

        public static void addPlayer(clsPlayer PlayerToSave)
        {
            List<clsPlayer> playerList = getPlayers();
            playerList.Add(PlayerToSave);
            savePlayerList(playerList);
        }

        public static void savePlayerList(List<clsPlayer> PlayerListToSave)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains(PLAYERLIST))
            {
                IsolatedStorageSettings.ApplicationSettings[PLAYERLIST] = PlayerListToSave;
            }
            else
            {
                IsolatedStorageSettings.ApplicationSettings.Add(PLAYERLIST, PlayerListToSave);
            }

            IsolatedStorageSettings.ApplicationSettings.Save();
        }

        public static List<clsPingPongGame> getGames()
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains(GAMELIST_KEY))
            {
                return (List<clsPingPongGame>)IsolatedStorageSettings.ApplicationSettings[GAMELIST_KEY];
            }

            return new List<clsPingPongGame>();
        }

        public static void addGame(clsPingPongGame GameToSave)
        {
            List<clsPingPongGame> gameList = getGames();            

            Random randomnumber = new Random();
            int number = randomnumber.Next(1, 1000000);
            
            bool gotID = true;

            do
            {
                number = randomnumber.Next(1, 1000000);
                gotID = true;

                foreach (clsPingPongGame game in getGames())
                {
                    if (number == game.GameID)
                    {
                        gotID = false;

                    }
                    
                }

            } while (gotID == false);

            GameToSave.GameID = number;

            gameList.Add(GameToSave);
            saveGameList(gameList);
        }

        public static void saveGameList(List<clsPingPongGame> GameListToSave)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains(GAMELIST_KEY))
            {
                IsolatedStorageSettings.ApplicationSettings[GAMELIST_KEY] = GameListToSave;
            }
            else
            {
                IsolatedStorageSettings.ApplicationSettings.Add(GAMELIST_KEY, GameListToSave);
            }

            IsolatedStorageSettings.ApplicationSettings.Save();
        }

        public static clsPingPongGame getGameByGameID(int GameID)
        {
            foreach (clsPingPongGame game in getGames())
            {
                if (GameID == game.GameID)
                {
                    return game;

                }
            }

            return null;
        }

        public static void saveGame(clsPingPongGame game)
        {
            List<clsPingPongGame> gameList = getGames();

            foreach (clsPingPongGame gameInList in getGames())
            {
                if (gameInList.GameID == game.GameID)
                {
                    gameList.Remove(gameInList);
                    break;
                }
            }

            gameList.Add(game);
            saveGameList(gameList);
        }

    }
}
