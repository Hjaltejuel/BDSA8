using BDSA2017.Assignment08.Entities;
using BDSA2017.Assignment08.Models;
using BDSA2017.Assignment08.UWP.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Extensions.DependencyInjection;
using Windows.UI.Core;
using System.Windows.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BDSA2017.Assignment08.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private readonly MainPageViewModel vm;
       

        public MainPage()
        {

            vm = App.ServiceProvider.GetService<MainPageViewModel>();
            vm.GoToTrackPage = new RelayCommand(o => Frame.Navigate(typeof(TrackPage), o));
            this.InitializeComponent();

          


            DataContext = vm;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var list = sender as ListView;
            var selectedTrack = list.SelectedItem as TrackViewModel;

             vm.GoToTrackPage.Execute(selectedTrack.Id);

        }

     

    }
}
