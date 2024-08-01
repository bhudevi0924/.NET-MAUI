namespace MAUIusingXAMPP
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //registering the route for DetailsPage
            Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
        }
    }
}
