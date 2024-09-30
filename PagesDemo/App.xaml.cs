namespace PagesDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            //MainPage = new MainPage();
            //MainPage = new ContentPageDemo();
            MainPage =new TabbedPageDemo();
        }
    }
}
