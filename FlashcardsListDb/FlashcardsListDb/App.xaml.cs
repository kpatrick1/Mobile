using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FlashcardsListDb.Model;
using System.IO;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FlashcardsListDb
{
    public partial class App : Application
    {
        static QuestionDb database;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static QuestionDb Database
        {
            get
            {
                if (database == null)
                {
                    database = new QuestionDb(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "QuestionList.db3"));

                    Card c = new Card
                    {
                        Question = "The President Rules the world",
                        Answer = true,
                        IsCorrect = false,
                        ImageName = "dice"
                    };
                    database.SaveItemAsync(c);
                    c = new Card
                    {
                        Question = "Xaml is Amazing",
                        Answer = true,
                        IsCorrect = false,
                        ImageName = "dice"
                    };
                    database.SaveItemAsync(c);
                    c = new Card
                    {
                        Question = "Xamarin is Easy",
                        Answer = false,
                        IsCorrect = false,
                        ImageName = "dice"
                    };
                    database.SaveItemAsync(c);
                    c = new Card
                    {
                        Question = "School is time consuming",
                        Answer = false,
                        IsCorrect = false,
                        ImageName = "dice"
                    };
                    database.SaveItemAsync(c);


                }
                return database;
            }
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
