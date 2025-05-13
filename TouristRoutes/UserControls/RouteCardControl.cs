using TouristRoutes.Models;

namespace TouristRoutes
{
    public partial class RouteCardControl: UserControl
    {
        public RouteCardControl()
        {
            InitializeComponent();
        }

        public void SetRoute(Route route)
        {
            routeNameLabel.Text = route.RouteName;
            routePriceLabel.Text = route.RoutePrice;
            routeLocationLabel.Text = route.RouteLocation;
            routeDurationLabel.Text = route.RouteDuration;
            routeLevelOfTrainingLabel.Text = route.LevelOfTraining;
            routeDescriptionRichTextBox.Text = route.RouteDescription;

            string imagePath = Path.Combine(Application.StartupPath, "Images", route.RouteImagePath);
            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }
    }
}
