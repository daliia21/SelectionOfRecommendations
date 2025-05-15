using TouristRoutes.Models;
using TouristRoutes.Services;
using static TouristRoutes.Properties.Resources;


namespace TouristRoutes.Forms
{
    /// <summary>
    /// Форма списка рекомендаций
    /// <summary>
    public partial class RecommendationsListForm : Form
    {
        private RoutesSortService _recomendationListService;
        private RouteCardControl _selectedCard;
        private FavoriteRoutesForm _favoriteRoutesForm;


        /// <summary>
        /// Конструтор списка рекомендаций
        /// <summary>
        public RecommendationsListForm()
        {
            InitializeComponent();

            if (AppState.IsAdmin == false)
            {
                button1.Visible = false;
            }

            _recomendationListService = new RoutesSortService();
            var routeList = _recomendationListService.SortedRoutesByTagCount();
            foreach (var route in routeList)
            {
                var card = new RouteCardControl();
                card.SetRoute(route);
                card.Selected += Card_Selected;

                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void Card_Selected(object sender, EventArgs e)
        {
            if (_selectedCard != null && _selectedCard != sender)
            {
                _selectedCard.SetSelected(false);
            }

            _selectedCard = sender as RouteCardControl;
            _selectedCard?.SetSelected(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var administratorForm = new AdministratorForm(this);
            administratorForm.FormClosed += administratorForm.AdministratorForm_FormClosed;
            administratorForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_selectedCard == null)
            {
                MessageBox.Show(RouteUnselectMessage);
                return;
            }

            var selectedRoute = _selectedCard.Route;

            _favoriteRoutesForm = new FavoriteRoutesForm();
            _favoriteRoutesForm.AddToFavorites(selectedRoute);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _favoriteRoutesForm = new FavoriteRoutesForm();

            _favoriteRoutesForm.Show();
        }
    }
}
