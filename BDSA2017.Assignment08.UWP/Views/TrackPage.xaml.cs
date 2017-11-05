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
namespace BDSA2017.Assignment08.UWP
{
    public sealed partial class TrackPage : Page

    {
        private TrackPageViewModel vm;

        public  TrackPage()
        {
           

            this.vm = App.ServiceProvider.GetService<TrackPageViewModel>();

            this.InitializeComponent();

            DataContext = vm;

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            vm.EmptyAndAdd((int) e.Parameter);
        }

    }
}
