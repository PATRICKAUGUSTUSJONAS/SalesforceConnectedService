﻿using Salesforce.VisualStudio.Services.ConnectedService.Utilities;
using Salesforce.VisualStudio.Services.ConnectedService.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Salesforce.VisualStudio.Services.ConnectedService.Views
{
    /// <summary>
    /// Interaction logic for RuntimeAuthenticationConfigPage.xaml
    /// </summary>
    internal partial class RuntimeAuthenticationConfigPage : UserControl
    {
        public RuntimeAuthenticationConfigPage(RuntimeAuthenticationViewModel authenticationViewModel)
        {
            this.InitializeComponent();

            this.DataContext = authenticationViewModel;
        }

        private RuntimeAuthenticationViewModel RuntimeAuthenticationViewModel
        {
            get { return (RuntimeAuthenticationViewModel)this.DataContext; }
        }

        private void MyDomain_LostFocus(object sender, RoutedEventArgs e)
        {
            this.RuntimeAuthenticationViewModel.MyDomainViewModel.IsMyDomainFocused = false;
        }

        private void MyDomain_GotFocus(object sender, RoutedEventArgs e)
        {
            this.RuntimeAuthenticationViewModel.MyDomainViewModel.IsMyDomainFocused = true;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            HyperlinkHelper.OpenSystemBrowser(e.Uri.AbsoluteUri);

            e.Handled = true;
        }
    }
}