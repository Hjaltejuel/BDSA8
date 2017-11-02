﻿using BDSA2017.Assignment08.Entities;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BDSA2017.Assignment08.UWP
{   
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly MainPageViewModel _vm;

        public MainPage()
        {
            InitializeComponent();

            var connectionString = @"Data Source=slotcars.db";

            var builder = new DbContextOptionsBuilder<SlotCarContext>();
            builder.UseSqlite(connectionString);

            var context = new SlotCarContext(builder.Options);
            context.Database.EnsureCreatedAsync().Wait();

            var repository = new TrackRepository(context);

            _vm = new MainPageViewModel(repository);

            DataContext = _vm;
        }
    }
}
