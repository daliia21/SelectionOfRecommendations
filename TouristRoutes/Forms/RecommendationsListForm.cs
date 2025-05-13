namespace TouristRoutes.Forms
{
    /// <summary>
    /// Форма списка рекомендаций
    /// <summary>
    public partial class RecommendationsListForm : Form
    {
        /// <summary>
        /// Конструтор списка рекомендаций
        /// <summary>
        public RecommendationsListForm()
        {
            InitializeComponent();
        }

        private void openAdministratorFormButton_Click(object sender, EventArgs e)
        {
            var administratorForm = new AdministratorForm();
            administratorForm.Show();
        }
    }
}
