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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Timers;
using System.Threading;
using Facebook;
using System.Net;
// for DllImportAttribute

namespace WPFFacebookApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FacebookClient FBClient;
        public string AccessToken { get; set; }
        //private Home HomePage;

        public MainWindow()
        {
            InitializeComponent();
            LoginForm();
        }

        public void LoginForm()
        {
            this.WBrowser.Navigate(new Uri("https://www.facebook.com/dialog/oauth?client_id=161362154349121&redirect_uri=https://www.facebook.com/connect/login_success.html&response_type=token"));
        }

        private void WBrowser_Navigated(object sender, NavigationEventArgs e)
        {
            if (e.Uri.ToString().Contains("#access_token"))
            {
                this.AccessToken = e.Uri.Fragment.Split(new char[] { '&' })[0].Replace("#access_token=", "");
                AccessToken = "EAACSwg3j4kEBAFaDtFf2W75URwDDnOEfwLvTvmhivsXcCFjfdMh3jWZCZABvxssaDP6BbvYwZAQ3IkZA5eriJZA6VyRtBowRhR6ZApiiNmFpzPV2dIcIhbUmC5eZBz7hsE206QbwQSVcGodhSfnNcUCZBuIl0eQRM1AZD";
                this.InitHomePage(this.AccessToken);
            }
        }
        public void InitHomePage(string AccessToken)
        {
            this.FBClient = new FacebookClient(AccessToken);
            //Home home = new Home(this.FBClient, new Action(ReInvoke));
            Home home = new Home(this.FBClient);
            home.Show();
            this.Close();
            //this.HomePage = home;
            //this.HomePage.Show();
            //this.Hide();
        }

        //invoke function
        //maybe use later, implement by Home home = new Home(this.FBClient, new Action(ReInvoke));
        //public void ReInvoke()
        //{
        //    this.HomePage.Close();

        //    if (!this.HomePage.IsVisible)
        //    {
        //        var logoutParameters = new Dictionary<string, object>
        //          {
        //             {"access_token", AccessToken},
        //              { "next", "http://localhost:8691" }
        //          };

        //        var logoutUrl = FBClient.GetLogoutUrl(logoutParameters);

        //        WBrowser.Navigate(new Uri(logoutUrl.ToString()));
        //        //SupressCookiePersist();
        //        this.Show();
        //        this.LoginForm();
        //    }
        //}
    }
}