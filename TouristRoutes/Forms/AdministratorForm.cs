using System.Windows.Forms;
using TouristRoutes.Models;
using TouristRoutes.Services;

namespace TouristRoutes.Forms
{
    /// <summary>
    /// Форма администратора для управления маршрутами
    /// </summary>
    public partial class AdministratorForm : Form
    {
        RoutesRepository _routesRepository;
        List<Route> routeList;
        Route selectedRoute;
        private string _selectedImagePath;
        private string _savedImageFileName;

        /// <summary>
        /// Конструктор формы администратора
        /// </summary>
        public AdministratorForm()
        {
            InitializeComponent();

            _routesRepository = new RoutesRepository();
            routeList = _routesRepository.GetAllRoutesWithTags();

            routesListBox.DataSource = routeList;
            routesListBox.DisplayMember = "RouteName";
            routesListBox.ValueMember = "Id";

            selectedRoute = (Route)routesListBox.SelectedItem;

            if (selectedRoute != null)
            {
                routeNameTextBox2.Text = selectedRoute.RouteName;
                routePriceTextBox2.Text = selectedRoute.RoutePrice;
                routeLocationTextBox2.Text = selectedRoute.RouteLocation;
                routeDurationTextBox2.Text = selectedRoute.RouteDuration;
                routeLevelOfTrainingTextBox2.Text = selectedRoute.LevelOfTraining;
                routeDescriptionRichTextBox2.Text = selectedRoute.RouteDescription;
                string basePath = Path.Combine(Application.StartupPath, "Images");
                string imagePath = Path.Combine(basePath, selectedRoute.RouteImagePath);
                if (File.Exists(imagePath))
                {
                    routePictureBox.Image = Image.FromFile(imagePath);
                }
            }

            foreach (var tag in selectedRoute.RouteTags)
            {
                for (int i = 0; i < checkedListBox2.Items.Count; i++)
                {
                    var item = checkedListBox2.Items[i];
                    if (tag.Tag.TagName == item.ToString())
                    {
                        checkedListBox2.SetItemChecked(i, true);
                    }
                }
            }

        }

        private void routeSaveButton_Click(object sender, EventArgs e)
        {
            var route = new Route
            {
                RouteName = routeNameTextBox.Text,
                RoutePrice = routePriceTextBox.Text,
                RouteLocation = routeLocationTextBox.Text,
                RouteDuration = routeDurationTextBox.Text,
                RouteDescription = routeDescriptionRichTextBox.Text,
                LevelOfTraining = routeLevelOfTrainingTextBox.Text,
                RouteImagePath = _savedImageFileName
            };

            _routesRepository.AddNewRoute(route);

            var routeTags = new List<Tag>();

            var _getTagsService = new GetTagsService();
            var allTags = _getTagsService.GetAllTags();

            foreach (var tg in checkedListBox1.CheckedItems)
            {
                foreach (var _tg in allTags)
                {
                    if ((string)tg == _tg.TagName)
                    {
                        routeTags.Add(_tg);
                    }
                }
            }

            _routesRepository.AddTagsToRoute(route.Id, routeTags);

            MessageBox.Show("Маршрут добавлен!");
        }

        private void pictureLoadButton_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = ofd.FileName;

                    string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                    Directory.CreateDirectory(imagesFolder);

                    _savedImageFileName = Guid.NewGuid().ToString() + Path.GetExtension(_selectedImagePath);
                    string destinationPath = Path.Combine(imagesFolder, _savedImageFileName);

                    File.Copy(_selectedImagePath, destinationPath, overwrite: true);

                    LoadRouteImageToPictureBox(routePictureBox, destinationPath);
                }
            }
        }
       

        private void routeBackButton_Click(object sender, EventArgs e)
        {
            routeNameTextBox.Text = string.Empty;
            routePriceTextBox.Text = string.Empty;
            routeLocationTextBox.Text = string.Empty;
            routeDurationTextBox.Text = string.Empty;
            routeDescriptionRichTextBox.Text = string.Empty;
            routeLevelOfTrainingTextBox.Text = string.Empty;

            routePictureBox.Image?.Dispose();
            routePictureBox.Image = null;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            _selectedImagePath = null;
        }

        private void addNewRouteButton_Click(object sender, EventArgs e)
        {
            routeNameTextBox.Text = string.Empty;
            routePriceTextBox.Text = string.Empty;
            routeLocationTextBox.Text = string.Empty;
            routeDurationTextBox.Text = string.Empty;
            routeDescriptionRichTextBox.Text = string.Empty;
            routeLevelOfTrainingTextBox.Text = string.Empty;

            routePictureBox.Image?.Dispose();
            routePictureBox.Image = null;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            _selectedImagePath = null;
        }

        private void pictureLoadButton2_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = ofd.FileName;

                    string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                    Directory.CreateDirectory(imagesFolder);

                    _savedImageFileName = Guid.NewGuid().ToString() + Path.GetExtension(_selectedImagePath);
                    string destinationPath = Path.Combine(imagesFolder, _savedImageFileName);

                    File.Copy(_selectedImagePath, destinationPath, overwrite: true);

                    LoadRouteImageToPictureBox(routePictureBox, destinationPath);
                }
            }
        }

        private void routeSaveButton2_Click(object sender, EventArgs e)
        {
            var route = new Route
            {
                RouteName = routeNameTextBox2.Text,
                RoutePrice = routePriceTextBox2.Text,
                RouteLocation = routeLocationTextBox2.Text,
                RouteDuration = routeDurationTextBox2.Text,
                RouteDescription = routeDescriptionRichTextBox2.Text,
                LevelOfTraining = routeLevelOfTrainingTextBox2.Text,
                RouteImagePath = _savedImageFileName
            };

            var selectedRoute = (Route)routesListBox.SelectedItem;
            _routesRepository.UpdateRoute(selectedRoute.Id, route);
        }

        private void routeDeleteButton_Click(object sender, EventArgs e)
        {
            var selectedRoute = (Route)routesListBox.SelectedItem;
            _routesRepository.DeleteRouteById(selectedRoute);
           
            RefreshRouteList();
        }

        private void RefreshRouteList()
        {
            var routes = _routesRepository.GetAllRoutes();
            routesListBox.DataSource = null;
            routesListBox.DataSource = routes;
            routesListBox.DisplayMember = "RouteName";
            routesListBox.ValueMember = "Id";
        }

        /// <summary>
        /// Метод для загрузки изображения
        /// </summary>
        public void LoadRouteImageToPictureBox(PictureBox pictureBox, string imagePath)
        {
            if (File.Exists(imagePath))
            {
                pictureBox.Image?.Dispose();
                pictureBox.Image = Image.FromFile(imagePath);
            }
        }
    }
}
