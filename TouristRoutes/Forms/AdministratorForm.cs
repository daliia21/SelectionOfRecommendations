using System.Windows.Forms;
using TouristRoutes.Models;
using TouristRoutes.Services;
using static TouristRoutes.Properties.Resources;

namespace TouristRoutes.Forms
{
    /// <summary>
    /// Форма администратора для управления маршрутами
    /// </summary>
    public partial class AdministratorForm : Form
    {
        private RoutesRepository _routesRepository;
        private List<Route> _routeList;
        private Route _selectedRoute;
        private string _selectedImagePath;
        private string _savedImageFileName;

        /// <summary>
        /// Конструктор формы администратора
        /// </summary>
        public AdministratorForm()
        {
            InitializeComponent();

            _routesRepository = new RoutesRepository();
            _routeList = _routesRepository.GetAllRoutesWithTags();

            routesListBox.DataSource = _routeList;
            routesListBox.DisplayMember = "RouteName";
            routesListBox.ValueMember = "Id";

            
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

            MessageBox.Show(RouteAddMessage);
            RefreshRouteList();
        }

        private void pictureLoadButton_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = ofd.FileName;

                    var imagesFolder = Path.Combine(Application.StartupPath, RoutePicturesFileName);
                    Directory.CreateDirectory(imagesFolder);

                    _savedImageFileName = Guid.NewGuid().ToString() + Path.GetExtension(_selectedImagePath);
                    var destinationPath = Path.Combine(imagesFolder, _savedImageFileName);

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

                    var imagesFolder = Path.Combine(Application.StartupPath, RoutePicturesFileName);
                    Directory.CreateDirectory(imagesFolder);

                    _savedImageFileName = Guid.NewGuid().ToString() + Path.GetExtension(_selectedImagePath);
                    var destinationPath = Path.Combine(imagesFolder, _savedImageFileName);

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

            var selectedRoute = (Route)routesListBox.SelectedItem;

            _routesRepository.UpdateRoute(selectedRoute.Id, route);
            _routesRepository.AddTagsToRoute(selectedRoute.Id, routeTags);
            RefreshRouteList();
        }

        private void routeDeleteButton_Click(object sender, EventArgs e)
        {
            _selectedRoute = (Route)routesListBox.SelectedItem;
            var result = MessageBox.Show(
                RouteDeleteConfirmMessage,
                RouteDeleteConfirm,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _selectedRoute = (Route)routesListBox.SelectedItem;
                _routesRepository.DeleteRouteById(_selectedRoute);
                MessageBox.Show(RouteDeleteMessage);
                RefreshRouteList();
            }                
        }

       
        private void routesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            routePictureBox.Image?.Dispose();
            routePictureBox.Image = null;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, false);
            }

            _selectedImagePath = null;

            _selectedRoute = (Route)routesListBox.SelectedItem;

            if (_selectedRoute != null)
            {
                routeNameTextBox2.Text = _selectedRoute.RouteName;
                routePriceTextBox2.Text = _selectedRoute.RoutePrice;
                routeLocationTextBox2.Text = _selectedRoute.RouteLocation;
                routeDurationTextBox2.Text = _selectedRoute.RouteDuration;
                routeLevelOfTrainingTextBox2.Text = _selectedRoute.LevelOfTraining;
                routeDescriptionRichTextBox2.Text = _selectedRoute.RouteDescription;
                var basePath = Path.Combine(Application.StartupPath, RoutePicturesFileName);
                var imagePath = Path.Combine(basePath, _selectedRoute.RouteImagePath);
                if (File.Exists(imagePath))
                {
                    routePictureBox2.Image = Image.FromFile(imagePath);
                }
            }

            if (_selectedRoute != null)
            {
                foreach (var tag in _selectedRoute.RouteTags)
                {
                    if (tag.Tag == null) continue;

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
        }

        private void RefreshRouteList()
        {
            var routes = _routesRepository.GetAllRoutes();
            routesListBox.DataSource = null;
            routesListBox.DataSource = routes;
            routesListBox.DisplayMember = "RouteName";
            routesListBox.ValueMember = "Id";
        }
       
        private void LoadRouteImageToPictureBox(PictureBox pictureBox, string imagePath)
        {
            if (File.Exists(imagePath))
            {
                pictureBox.Image?.Dispose();
                pictureBox.Image = Image.FromFile(imagePath);
            }
        }
    }
}
