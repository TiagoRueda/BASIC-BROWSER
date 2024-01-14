using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Security.Policy;

namespace BasicBrowser
{
    public partial class Form1 : Form
    {
        private string DefaultUrl = "google.com";

        #region Init
        public Form1()
        {
            InitializeComponent();
            UrlBox.Text = DefaultUrl;
            BTGo.PerformClick();
        }

        private async Task TkInitialized()
        {
            await WBView.EnsureCoreWebView2Async(null);
        }
        #endregion

        #region Button
        private void BTBack_Click(object sender, EventArgs e)
        {
            WBView.CoreWebView2.GoBack();
        }

        private void BTForward_Click(object sender, EventArgs e)
        {
            WBView.CoreWebView2.GoForward();
        }

        private async void BTGo_Click(object sender, EventArgs e)
        {
            if (UrlBox.Text != "")
            {
                await TkInitialized();
                if (!UrlBox.Text.EndsWith(".com", StringComparison.OrdinalIgnoreCase))
                {
                    UrlBox.Text += ".com";
                }
                WBView.CoreWebView2.Navigate("http://" + UrlBox.Text);
            }
        }
        #endregion

        #region EventHandlers
        private void WBView_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            Form1.ActiveForm.Text = "Basic Browser | " + WBView.CoreWebView2.DocumentTitle;
        }

        private async void UrlBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (UrlBox.Text != "")
                {
                    await TkInitialized();
                    if (!UrlBox.Text.EndsWith(".com", StringComparison.OrdinalIgnoreCase))
                    {
                        UrlBox.Text += ".com";
                    }
                    WBView.CoreWebView2.Navigate("http://" + UrlBox.Text);
                }
            }
        }

        private void BTHome_Click(object sender, EventArgs e)
        {
            UrlBox.Text = "";
            UrlBox.Text = DefaultUrl;
            WBView.CoreWebView2.Navigate("http://" + UrlBox.Text);
            BTGo.PerformClick();
        }
        #endregion
    }
}