using CrudMaui.Views;

namespace CrudMaui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private readonly static Type[] _routablesPageTypes = [typeof(LoginPage) ,  typeof(FacturacionPage)];

        private void RegisterRoutes()
        {
            foreach (var pageType in _routablesPageTypes)
            {
                Routing.RegisterRoute(pageType.Name, pageType);

            }
        }
    }
}
