using TouristRoutes.Models;
using static TouristRoutes.Properties.Resources;

namespace TouristRoutes.Forms
{
    /// <summary>
    /// Форма детализации маршрута
    /// </summary>
    public partial class RouteDetailsForm : Form
    {
        private Route _route;

        /// <summary>
        /// Конструктор формы детализации
        /// </summary>
        public RouteDetailsForm(Route route)
        {
            InitializeComponent();
            _route = route;

            RouteNameLabel.Text = _route.RouteName;
            routeLocationLabel.Text = _route.RouteLocation;
            routeBudgetLabel.Text = _route.RoutePrice;
            routeDurationLabel.Text = _route.RouteDuration;
            routeLevelOfTrainingLabel.Text = _route.LevelOfTraining;
            routeDescriptionRichTextBox.Text = _route.RouteDescription;

            var imagePath = Path.Combine(Application.StartupPath, RoutePicturesFileName, _route.RouteImagePath);
            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }

            routeDescriptionRichTextBox.MouseDown += (s, e) =>
            {
                this.ActiveControl = null;
            };
        }
    }
}
