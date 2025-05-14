using TouristRoutes.Models;
using TouristRoutes.Services;

namespace TouristRoutes.Forms
{
    /// <summary>
    /// Форма списка рекомендаций
    /// <summary>
    public partial class RecommendationsListForm : Form
    {
        private RoutesSortService _recomendationListService;

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

                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var administratorForm = new AdministratorForm();
            administratorForm.Show();
        }
    }
}
