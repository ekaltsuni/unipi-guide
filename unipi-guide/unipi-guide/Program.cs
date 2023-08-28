using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Media;
using AxWMPLib;

namespace unipi_guide
{
    internal static class Program
    {
        /* Global class for getting and setting whether user is logged in or not across program
         * to control visibility of items between visitors and registered users */
        public static class userStatus
        {
            private static Boolean _registeredUser;
            public static Boolean registeredUser
            {
                get { return _registeredUser; }
                set { _registeredUser = value; }
            }
            private static Boolean _isAdmin;
            public static Boolean isAdmin
            {
                get { return _isAdmin; }
                set { _isAdmin = value; }
            }
        }

        /* Global class for getting and setting whether music is on or off 
  between forms */
        public static class Music
        {
            private static Boolean _musicStatus;
            public static Boolean musicStatus
            {
                get { return _musicStatus; }
                set { _musicStatus = value; }
            }
        }

        // Global class for getting and setting whether the music player will be on or off
        public static class MusicPlayer
        {
            private static SoundPlayer _player = new SoundPlayer("sound\\guitar_loop.wav");
            public static SoundPlayer player
            {
                get { return _player; }
                set { _player = value; }
            }
        }

        /* Global method to check music status in each form */
        public static void checkMusic(Control play, Control mute)
        {
            if (Music.musicStatus == true)
            {
                MusicPlayer.player.PlayLooping();
                play.Visible = false;
                mute.Visible = true;
            }
            else if (Music.musicStatus == false)
            {
                MusicPlayer.player.Stop();
                mute.Visible = false;
                play.Visible = true;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Music.musicStatus = true;
            MusicPlayer.player.PlayLooping();
            Application.Run(new homepage_form());
        }
    }
}
