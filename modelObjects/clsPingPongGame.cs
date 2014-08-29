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
using System.Runtime.Serialization;
using pongMaster.Utility;

namespace pongMaster.modelObjects
{
    [DataContract]
    public class clsPingPongGame
    {
        [DataMember]
        public int Time { get; set; }
        [DataMember]
        public int P1Score { get; set; }
        [DataMember]
        public int P2Score { get; set; }
        [DataMember]
        public int GameID { get; set; }
        [DataMember]
        public clsPlayer Player1 { get; set; }
        [DataMember]
        public clsPlayer Player2 { get; set; }
        [DataMember]
        public bool Active { get; set; }
        [DataMember]
        public int Score { get; set; }
        public String GameName
        {
            get
            {
                if (Active)
                {
                    return Player1.Name + " " + P1Score + " " + Player2.Name + " " + P2Score + " " + " " + "In Progress";
                }
                else
                {
                    return Player1.Name + " " + P1Score + " " + Player2.Name + " " + P2Score + " " + " " + "Completed"; ;
                }
            }
        
        }

    }
}
