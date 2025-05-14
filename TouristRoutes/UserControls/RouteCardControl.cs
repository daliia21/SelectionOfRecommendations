using TouristRoutes.Models;
using static TouristRoutes.Properties.Resources;

namespace TouristRoutes
{
    /// <summary>
    /// Кастомный элемент, карта маршрута
    /// </summary>
    public partial class RouteCardControl: UserControl
    {
        /// <summary>
        /// Конструктор карты маршрута
        /// </summary>
        public RouteCardControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для заполнения полей карты маршрута
        /// </summary>
        public void SetRoute(Route route)
        {
            routeNameLabel.Text = route.RouteName;
            routePriceLabel.Text = route.RoutePrice;
            routeLocationLabel.Text = route.RouteLocation;
            routeDurationLabel.Text = route.RouteDuration;
            routeLevelOfTrainingLabel.Text = route.LevelOfTraining;
            routeDescriptionRichTextBox.Text = route.RouteDescription;

            var imagePath = Path.Combine(Application.StartupPath, RoutePicturesFileName, route.RouteImagePath);
            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }
    }
}
