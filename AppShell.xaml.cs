﻿namespace MauiApp2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(DevisTypesPage)), typeof(DevisTypesPage));
        }
    }
}
