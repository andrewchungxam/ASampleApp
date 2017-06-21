using System;

using Xamarin.Forms;
using ASampleApp.View;
using ASampleApp.Data;

namespace ASampleApp
{
    public class App : Application
    {
        public static DogRepository DogRepo { get; set; }

        public App()
        {
            String dbPath = FileAccessHelper.GetLocalFilePath("people.db3");
            DogRepo = new DogRepository(dbPath);
            DogRepo.AddNewDog("Olive", "Brown");
            // The root page of your application
            MainPage = new NavigationPage(new FirstPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
