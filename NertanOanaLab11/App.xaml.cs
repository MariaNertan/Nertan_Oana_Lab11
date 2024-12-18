using NertanOanaLab11.Data;
namespace NertanOanaLab11
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService()); 
            MainPage = new NavigationPage(new ListEntryPage());
        }
    }
}
