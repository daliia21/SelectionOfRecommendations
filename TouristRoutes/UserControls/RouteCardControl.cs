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
        /// Публичное поле, возвращающее _route
        /// </summary>
        public Route Route => _route;

        /// <summary>
        /// Метка выбранного маршрута
        /// </summary>
        public bool IsSelected { get; private set; } = false;

        /// <summary>
        /// Событие Selected
        /// </summary>
        public event EventHandler Selected;
        private Color _defaultBackColor;

        /// <summary>
        /// Конструктор карты маршрута
        /// </summary>
        public RouteCardControl()
        {
            InitializeComponent();
            _defaultBackColor = this.BackColor;
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
            foreach (Control control in this.Controls)
            {
                control.DoubleClick += Card_Click;
            }


        }

        /// <summary>
        /// Метод для установки выбора карты маршрута
        /// </summary>
        public void SetSelected(bool selected)
        {
            IsSelected = selected;
            this.BackColor = selected ? Color.DarkGray : _defaultBackColor; 
        }

        protected virtual void OnSelected()
        {
            Selected?.Invoke(this, EventArgs.Empty);
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            var detailsForm = new RouteDetailsForm(_route);
            detailsForm.Show();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            OnSelected();
        }
    }
}
