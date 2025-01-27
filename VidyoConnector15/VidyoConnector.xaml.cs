﻿using System.Windows;
using System.Windows.Controls;
using VidyoConnector.ViewModel;

namespace VidyoConnector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ((VidyoConnectorViewModel)DataContext).Init(VideoPanel_prime.Handle, VideoPanel_second.Handle, VideoPanel_third.Handle, VideoPanel_fourth.Handle, VideoPanel_fifth.Handle, VideoPanel_local.Handle);
        }

        private void FrameworkElement_OnSizeChanged(object sender, SizeChangedEventArgs e)
        {

            var host = ((System.Windows.Forms.Integration.WindowsFormsHost)sender);
            
            ((VidyoConnectorViewModel)DataContext).AdjustVideoPanelSize(host.Child.Handle, (uint)host.ActualWidth, (uint)host.ActualHeight, host.Name);
        }

        private void MenuItemCameras_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedMenuItem = sender as MenuItem;
            if (selectedMenuItem != null)
            {
                ((VidyoConnectorViewModel)DataContext).SetSelectedLocalCamera(selectedMenuItem.DataContext);
            }
        }

        private void MenuItemVideoContent_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedMenuItem = sender as MenuItem;
            if (selectedMenuItem != null)
            {
                ((VidyoConnectorViewModel)DataContext).SetSelectedVideoContent(selectedMenuItem.DataContext);
            }
        }

        private void MenuItemMicrophones_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedMenuItem = sender as MenuItem;
            if (selectedMenuItem != null)
            {
                ((VidyoConnectorViewModel)DataContext).SetSelectedLocalMicrophone(selectedMenuItem.DataContext);
            }
        }

        private void MenuItemAudioContent_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedMenuItem = sender as MenuItem;
            if (selectedMenuItem != null)
            {
                ((VidyoConnectorViewModel)DataContext).SetSelectedAudioContent(selectedMenuItem.DataContext);
            }
        }

        private void MenuItemSpeakers_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedMenuItem = sender as MenuItem;
            if (selectedMenuItem != null)
            {
                ((VidyoConnectorViewModel)DataContext).SetSelectedLocalSpeaker(selectedMenuItem.DataContext);
            }
        }

        private void MenuItemSharesMonitors_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedMenuItem = sender as MenuItem;
            if (selectedMenuItem != null)
            {
                ((VidyoConnectorViewModel)DataContext).SetSelectedLocalMonitor(selectedMenuItem.DataContext);
            }
        }

        private void MenuItemSharesWindows_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedMenuItem = sender as MenuItem;
            if (selectedMenuItem != null)
            {
                ((VidyoConnectorViewModel)DataContext).SetSelectedLocalWindow(selectedMenuItem.DataContext);
            }
        }

        private void BtnChat_Click(object sender, RoutedEventArgs e)
        {
            var connectionState = ((VidyoConnectorViewModel)DataContext).ConnectionState;
            if (connectionState == Model.ConnectionState.Connected)
            {
                if (gridChat.Visibility == Visibility.Collapsed)
                {
                    gridChat.Visibility = Visibility.Visible;
                }
                else if (gridChat.Visibility == Visibility.Visible)
                {
                    gridChat.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
