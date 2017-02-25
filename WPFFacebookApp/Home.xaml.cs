using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Facebook;
using Microsoft.Win32;
using System.Runtime.InteropServices;


namespace WPFFacebookApp
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
//        #define STATUS_DEFAULT_TEXT 
//#define IMAGE_DIR_DEFAULT_TEXT
        private OpenFileDialog dlg;
        private FacebookClient FbC;
        FriendInfo InfoFriend = new FriendInfo();
        string user_id = "";
        public Action MethodToCall { get; set; }

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool InternetSetOption(
            int hInternet,
            int dwOption,
            IntPtr lpBuffer,
            int dwBufferLength
        );

        //public Home(FacebookClient FBClient, Action method)
        public Home(FacebookClient FBClient)
        {
            //MethodToCall = method;
            FbC = FBClient;
            InitializeComponent();
            dynamic me = FbC.Get("Me");
            TBInfos.Text = me.name;
            user_id = me.id;
            ProfilePicture.Source = new BitmapImage(new Uri("https://graph.facebook.com/" + me.id + "/picture/"));
            getStatus();
        }
        ~Home()
        {

        }

        private void btnChose_Click(object sender, RoutedEventArgs e)
        {
            dlg = new OpenFileDialog();
            dlg.DefaultExt = ".jpg";
            dlg.ShowDialog();
            txtImageDir.Text = dlg.FileName;
        }

        private void btnPost_Click(object sender, RoutedEventArgs e)
        {
            if (txtImageDir.Text != "Image...")
            {
                if (PostImage(txtStatus.Text, dlg.FileName))
                    MessageBox.Show("Photo uploaded!");
            }
            else
            {
                if (Post(txtStatus.Text))
                    MessageBox.Show("Status sent!");
            }
        }
        public bool Post(string status)
        {
            try
            {
                var postInfo = new Dictionary<string, object>();
                postInfo.Add("message", txtStatus.Text);
                FbC.Post("/me/feed", postInfo);
                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool PostImage(string status, string ImgPath)
        {
            try
            {
                FacebookMediaObject facebookUploader = new FacebookMediaObject
                {
                    FileName = ImgPath,
                    ContentType = "image/jpg"
                };
                var Photobytes = File.ReadAllBytes(ImgPath);
                facebookUploader.SetValue(Photobytes);
                var postInfo = new Dictionary<string, object>();
                postInfo.Add("message", txtStatus.Text);
                postInfo.Add("Photo", facebookUploader);
                FbC.Post("/photos", postInfo);
                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void txtStatus_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btbFriend_Click(object sender, RoutedEventArgs e)
        {
            btbFriend.Background = Brushes.LightBlue;
            btnGroup.Background = SystemColors.ControlBrush;

            dynamic FriendList = FbC.Get("/me/taggable_friends");
            while (FriendList.data.Count != 0)
            {
                int count = (int)FriendList.data.Count;
                for (int i = 0; i < count; i++)
                {
                    string name = FriendList.data[i].name;
                    string friend_id = FriendList.data[i].id;

                    InfoFriend.Add(name, friend_id);
                }
                if (FriendList.paging.next != null)
                    FriendList = FbC.Get(FriendList.paging.next);
                else
                    break;
                //string next_link = e.Uri.Fragment.Split('&')[0].Replace("#access_token=", "");
            }

            if (InfoFriend.FriendCount != 0)
            {
                for (int i = 0; i < InfoFriend.FriendCount; i++)
                {
                    txtRightPanel.Text += InfoFriend.FriendList[i].name + "\n";
                }
            }
        }

        private void btnGroup_Click(object sender, RoutedEventArgs e)
        {
            btnGroup.Background = Brushes.LightBlue;
            btbFriend.Background = SystemColors.ControlBrush;
            if (InfoFriend.FriendCount == 0)
            {
                dynamic FriendList = FbC.Get("/me/groups");
                int count = (int)FriendList.data.Count;
                for (int i = 0; i < count; i++)
                {
                    InfoFriend.Add(FriendList.data[i].name, FriendList.data[i].id);
                }
            }
            if (InfoFriend.FriendCount != 0)
            {
                for (int i = 0; i < InfoFriend.FriendCount; i++)
                {
                    txtRightPanel.Text += InfoFriend.FriendList[i].name + "\n";
                }
            }
        }

        private void getStatus()
        {
            List<string> newFeed = new List<string>();
            List<string> newFeedTime = new List<string>();
            if (txtFeed.Text == "")
            {
                dynamic myFeed = FbC.Get("/me/feed");
                int count = (int)myFeed.data.Count;
                for (int i = 0; i < count; i++)
                {
                    newFeed.Add(myFeed.data[i].message);
                    newFeedTime.Add(myFeed.data[i].created_time);
                }
            }
            for (int i = 0; i < newFeed.Count; i++)
            {
                if (newFeed[i] != null)
                    txtFeed.Text += newFeed[i] + "\n" + newFeedTime[i] + "\n\n";
            }
        }

        private void txtStatus_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtStatus.Text == "What do you feel?")
                txtStatus.Clear();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            //MethodToCall.Invoke();
            SupressCookiePersist();
            MainWindow login_form = new MainWindow();
            this.Close();
            login_form.Show();
        }
        public static bool SupressCookiePersist()
        {
            // 3 = INTERNET_SUPPRESS_COOKIE_PERSIST 
            // 81 = INTERNET_OPTION_SUPPRESS_BEHAVIOR
            return SetOption(81, 3);
        }

        static bool SetOption(int settingCode, int? option)
        {
            IntPtr optionPtr = IntPtr.Zero;
            int size = 0;
            if (option.HasValue)
            {
                size = sizeof(int);
                optionPtr = Marshal.AllocCoTaskMem(size);
                Marshal.WriteInt32(optionPtr, option.Value);
            }

            bool success = InternetSetOption(0, settingCode, optionPtr, size);

            if (optionPtr != IntPtr.Zero) Marshal.Release(optionPtr);
            return success;
        }

        private void txtImageDir_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtImageDir.Text == "Image...")
                txtImageDir.Clear();
        }
    }
}
