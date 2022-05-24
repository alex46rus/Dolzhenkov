using Dolzhenkov.Models;
using Dolzhenkov.Services;
using Dolzhenkov.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dolzhenkov
{
    public partial class App : Application
    {
        static TextdateBase dataBase;

        // Create the database connection as a singleton.
        internal static TextdateBase DataBase
        {
            get
            {
                if (dataBase == null)
                {
                    dataBase = new TextdateBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TextTest.db3"));
                }
                return dataBase;
            }
        }
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
