﻿using FoodClock.Views;

namespace FoodClock
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPageMenu();
        }
    }
}
