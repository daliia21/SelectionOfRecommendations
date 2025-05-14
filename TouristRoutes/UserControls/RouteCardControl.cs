using TouristRoutes.Forms;
using TouristRoutes.Models;
using static TouristRoutes.Properties.Resources;

namespace TouristRoutes
{
    /// <summary>
    /// Кастомный элемент, карта маршрута
    /// </summary>
    public partial class RouteCardControl: UserControl
    {
        private Route _route;
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
            _route = route;

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

            this.DoubleClick += Card_DoubleClick;
            foreach (Control control in this.Controls)
            {
                control.DoubleClick += Card_DoubleClick;
            }

            this.Click += Card_Click;
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            var detailsForm = new RouteDetailsForm(_route);
            detailsForm.Show();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            
        }
    }
}
