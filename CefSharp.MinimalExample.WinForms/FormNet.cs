using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CefSharp.MinimalExample.WinForms
{
    public partial class FormNet : Form
    {
        private readonly ChromiumWebBrowser _browser;

        public FormNet()
        {
            InitializeComponent();

            _browser = new ChromiumWebBrowser { Dock = DockStyle.Fill };

            _browser.IsBrowserInitializedChanged += _browser_IsBrowserInitializedChanged;

            string directory = AppDomain.CurrentDomain.BaseDirectory;
            LoadUrl(directory + "index.html");

            cefPanel.Controls.Add(_browser);
        }

        private void _browser_IsBrowserInitializedChanged(object sender, EventArgs e)
        {
            _browser.ShowDevTools();
        }

        private void LoadUrl(string urlString)
        {
            // No action unless the user types in some sort of url
            if (string.IsNullOrEmpty(urlString))
            {
                return;
            }

            Uri url;

            var success = Uri.TryCreate(urlString, UriKind.RelativeOrAbsolute, out url);

            // Basic parsing was a success, now we need to perform additional checks
            if (success)
            {
                // Load absolute urls directly.
                // You may wish to validate the scheme is http/https
                // e.g. url.Scheme == Uri.UriSchemeHttp || url.Scheme == Uri.UriSchemeHttps
                if (url.IsAbsoluteUri)
                {
                    //browser.LoadUrl(urlString);
                    _browser.Load(urlString);

                    return;
                }

                // Relative Url
                // We'll do some additional checks to see if we can load the Url
                // or if we pass the url off to the search engine
                var hostNameType = Uri.CheckHostName(urlString);

                if (hostNameType == UriHostNameType.IPv4 || hostNameType == UriHostNameType.IPv6)
                {
                    //browser.LoadUrl(urlString);
                    _browser.Load(urlString);

                    return;
                }

                if (hostNameType == UriHostNameType.Dns)
                {
                    try
                    {
                        var hostEntry = Dns.GetHostEntry(urlString);
                        if (hostEntry.AddressList.Length > 0)
                        {
                            //browser.LoadUrl(urlString);
                            _browser.Load(urlString);

                            return;
                        }
                    }
                    catch (Exception)
                    {
                        // Failed to resolve the host
                    }
                }
            }

            // Failed parsing load urlString is a search engine
            var searchUrl = "https://www.google.com/search?q=" + Uri.EscapeDataString(urlString);

            //browser.LoadUrl(searchUrl);
            _browser.Load(urlString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browserPanel.Visible = false;
            _browser.Focus();
        }

        //private void SetFocus()
        //{
        //    if (textBox.InvokeRequired)
        //    {
        //        // Call SetFocus method on the UI thread
        //        textBox.Invoke(new Action(SetFocus));
        //    }
        //    else
        //    {
        //        // Set focus to the TextBox
        //        textBox.Focus();
        //    }
        //}
    }
}
