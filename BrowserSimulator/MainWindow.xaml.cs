using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using BrowserSimulator.Resources.Data;
using BrowserSimulator.Resources.Models;

using Microsoft.Web.WebView2.Wpf;
using Microsoft.Web.WebView2.Core;

namespace BrowserSimulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<PhoneType> _phoneTypes;
        Window _window;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            _window = App.Current.MainWindow;

            RegisterEnvFlags();
            SetupWindow();

            _phoneTypes = new();
            _phoneTypes = Lists.GetPhoneTypes();

            LoadPhonesToCombo();
            SetDefaultPhone();
            InitWebView();
        }

        private async void InitWebView()
        {
            await Browser.EnsureCoreWebView2Async(default);

            Browser.CoreWebView2.AddWebResourceRequestedFilter("*", CoreWebView2WebResourceContext.All);
            Browser.CoreWebView2.WebResourceRequested += RegisterHeaders;
        }
        private void LoadPhonesToCombo()
        {
            PhoneSelector.ItemsSource = _phoneTypes.Select(x => new { Value = x.Model }).ToList();
            PhoneSelector.DisplayMemberPath = "Value";
            PhoneSelector.SelectedValuePath = "Value";
        }
        private void SetDefaultPhone()
        {
            var defaultPhone = _phoneTypes.Where(x => x.IsDefault).FirstOrDefault();

            ChangePhone(defaultPhone);

            PhoneSelector.SelectedValue = defaultPhone.Model;
        }
        private void SetupWindow()
        {
            _window.Topmost = true;
            _window.ResizeMode = ResizeMode.NoResize;
        }
        private void ChangePhone(PhoneType phone)
        {
            _window.ResizeMode = ResizeMode.CanResize;

            _window.Title = phone.Header;
            _window.Width = phone.ViewPort.Width;
            _window.Height = phone.ViewPort.Height;

            _window.ResizeMode = ResizeMode.NoResize;
        }
        private static void RegisterEnvFlags()
        {
            Environment.SetEnvironmentVariable("WEBVIEW2_ADDITIONAL_BROWSER_ARGUMENTS", "--disable-features=msSmartScreenProtection");
        }
        private async void ExecScript(string script)
        {
            await Browser.ExecuteScriptAsync(script);
        }

        #region [EVENTS]
        private void Go_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Browser.CoreWebView2.Navigate(AddressBar.Text);
            }
            catch (Exception ex)
            {
                OpenPopUp(new PopUpProps
                {
                    Title = "Wrong URL",
                    Message = ex.Message,
                    IsError = true
                });
            }
        }
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            Browser.GoBack();
        }
        private void PhoneSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox cb)
            {
                var newPhone = _phoneTypes[cb.SelectedIndex];
                ChangePhone(newPhone);
            }
        }
        private void Navigating(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            AddressBar.Text = (sender as WebView2)?.Source.ToString();
        }
        private void Navigated(object sender, CoreWebView2NavigationCompletedEventArgs args)
        {
            AddressBar.Text = (sender as WebView2)?.Source.ToString();
        }
        private void RegisterHeaders(object sender, CoreWebView2WebResourceRequestedEventArgs args)
        {
            args.Request.Headers.SetHeader("sec-ch-ua-mobile", "1");
            args.Request.Headers.SetHeader("sec-ch-ua-platform", "Android");
            args.Request.Headers.SetHeader("sec-ch-ua-platform-version", "10");
            args.Request.Headers.SetHeader("User-Agent", "Mozilla/5.0 (Linux; Android 10; SM-G981B) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.162 Mobile Safari/537.36");
        }

        private void OpenPopUp(PopUpProps props)
        {
            var popup = new PopUpWindow(props)
            {
                Owner = this
            };

            popup.Show();
        }

        #endregion
    }
}
