using TouristRoutes.Models;
using TouristRoutes.Services;

namespace TouristRoutes.Forms
{
    public partial class FavoriteRoutesForm : Form
    {

        private AppDbContext _dbContext;
        private RoutesRepository _routeRepository;
        private RouteCardControl _selectedCard;


        public FavoriteRoutesForm()
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            _routeRepository = new RoutesRepository();

            var _currentUser = AppState.CurrentAppUser;

            var routeList = _routeRepository.GetFavoriteRoutesForUser(_currentUser.Id);
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

        public void AddToFavorites(Route route)
        {
            var _currentUser = AppState.CurrentAppUser;

            var alreadyFavorite = _dbContext.UserInfoFavoriteRoutes.Any(ufr =>
                ufr.AppUserId == _currentUser.Id && ufr.RouteId == route.Id);

            if (alreadyFavorite)
            {
                MessageBox.Show("Маршрут уже добавлен в избранное");
                return;
            }

            var favorite = new UserFavoriteRoute
            {
                AppUserId = _currentUser.Id,
                RouteId = route.Id
            };

            _dbContext.UserInfoFavoriteRoutes.Add(favorite);
            _dbContext.SaveChanges();
            var card = new RouteCardControl();
            card.SetRoute(route);
            flowLayoutPanel1.Controls.Add(card);
            MessageBox.Show("Маршрут добавлен в список избранных!");

        }

        public void RemoveRouteFromFavorites(int userId, int routeId)
        {
            
            var favorite = _dbContext.UserInfoFavoriteRoutes
                .FirstOrDefault(ufr => ufr.AppUserId == userId && ufr.RouteId == routeId);

            if (favorite != null)
            {
                _dbContext.UserInfoFavoriteRoutes.Remove(favorite);
                _dbContext.SaveChanges();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _currentUser = AppState.CurrentAppUser;
            if (_selectedCard == null)
            {
                MessageBox.Show("Выберите маршрут");
                return;
            }

            var selectedRoute = _selectedCard.Route;

            
            this.RemoveRouteFromFavorites(_currentUser.Id ,selectedRoute.Id);
            MessageBox.Show("Маршрут удален из списка избранных");
            this.Hide();
            var favoriteForm = new FavoriteRoutesForm();
            favoriteForm.Show();
        }
    }
}
