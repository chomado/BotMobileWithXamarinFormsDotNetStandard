using Microsoft.Bot.Connector.DirectLine;
using Prism.Unity;
using BotMobile.Views;
using BotMobile.Services;
using Xamarin.Forms;
using Microsoft.Practices.Unity;

namespace BotMobile
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            this.Container.RegisterTypeForNavigation<NavigationPage>();
            this.Container.RegisterTypeForNavigation<MainPage>();
            this.Container.RegisterType<IBotService, BotService>();
        }
    }
}