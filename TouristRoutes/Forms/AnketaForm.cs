using TouristRoutes.Enums;
using TouristRoutes.Services;
using static TouristRoutes.Properties.Resources;

namespace TouristRoutes.Forms
{
    /// <summary>
    /// Форма для заполнения анкеты
    /// </summary>
    public partial class AnketaForm : Form
    {
        private AccountService _accountServise;
        private GetTagsService _getTagsService;

        /// <summary>
        /// Конструктор формы для заполнения анкеты
        /// </summary>
        public AnketaForm()
        {
            InitializeComponent();

            double curDpi;
            using (var g = this.CreateGraphics())
            {
                curDpi = g.DpiY;
            }

            var k = curDpi / 192.0;

            // Заполнение тегов
            var yPosition = 50 * k;
            var verticalSpacing = 40 * k;

            _getTagsService = new GetTagsService();
            var ageTags = _getTagsService.GetTagsForTagType(TagType.AgeTag);
           
            
            foreach (var ageTag in ageTags)
            {
                var ageCheckBox = new CheckBox
                {
                    Text = ageTag.TagName,
                    Location = new Point((int)(20 * k), (int)yPosition),
                    AutoSize = true 
                };

                ageCheckBox.CheckedChanged += Group_CheckedChanged;

                ageGroupBox.Controls.Add(ageCheckBox);
                yPosition += verticalSpacing;
            }

            
            yPosition = 50 * k;
            var budgetTags = _getTagsService.GetTagsForTagType(TagType.BudgetTag);
            
            foreach (var budgetTag in budgetTags)
            {
                var budgetCheckBox = new CheckBox
                {
                    Text = budgetTag.TagName,
                    Location = new Point((int)(20 * k), (int)yPosition),
                    AutoSize = true
                };

                budgetCheckBox.CheckedChanged += Group_CheckedChanged;

                budgetGroupBox.Controls.Add(budgetCheckBox);
                yPosition += verticalSpacing;
            }


            yPosition = 50 * k;
            var durationTags = _getTagsService.GetTagsForTagType(TagType.DurationTag);

            foreach (var durationTag in durationTags)
            {
                var durationCheckBox = new CheckBox
                {
                    Text = durationTag.TagName,
                    Location = new Point((int)(20 * k), (int)yPosition),
                    AutoSize = true
                };

                durationCheckBox.CheckedChanged += Group_CheckedChanged;

                durationGroupBox.Controls.Add(durationCheckBox);
                yPosition += verticalSpacing;
            }


            yPosition = 50 * k;
            var levelOfTrainingTags = _getTagsService.GetTagsForTagType(TagType.LevelOfTrainingTag);

            foreach (var levelOfTrainingTag in levelOfTrainingTags)
            {
                var levelOfTrainingCheckBox = new CheckBox
                {
                    Text = levelOfTrainingTag.TagName,
                    Location = new Point((int)(20 * k), (int)yPosition),
                    AutoSize = true
                };

                levelOfTrainingCheckBox.CheckedChanged += Group_CheckedChanged;

                levelOfTrainingGroupBox.Controls.Add(levelOfTrainingCheckBox);
                yPosition += verticalSpacing;
            }

            
            yPosition = 50 * k;
            var locationTags = _getTagsService.GetTagsForTagType(TagType.LocationTag);

            foreach (var locationTag in locationTags)
            {
                var locationCheckBox = new CheckBox
                {
                    Text = locationTag.TagName,
                    Location = new Point((int)(20 * k), (int)yPosition),
                    AutoSize = true
                };

                locationGroupBox.Controls.Add(locationCheckBox);
                yPosition += verticalSpacing;
            }

            
            yPosition = 50 * k;
            var purposeTags = _getTagsService.GetTagsForTagType(TagType.PurposeTag);

            foreach (var purposeTag in purposeTags)
            {
                var purposeCheckBox = new CheckBox
                {
                    Text = purposeTag.TagName,
                    Location = new Point((int)(20 * k), (int)yPosition),
                    AutoSize = true
                };

                purposeCheckBox.CheckedChanged += Group_CheckedChanged;

                purposeGroupBox.Controls.Add(purposeCheckBox);
                yPosition += verticalSpacing;
            }

            
            yPosition = 50 * k;
            var seasonTags = _getTagsService.GetTagsForTagType(TagType.SeasonTag);
         
            foreach (var seasonTag in seasonTags)
            {
                var seasonCheckBox = new CheckBox
                {
                    Text = seasonTag.TagName,
                    Location = new Point((int)(20 * k), (int)yPosition),
                    AutoSize = true
                };

                seasonGroupBox.Controls.Add(seasonCheckBox);
                yPosition += verticalSpacing;
            }

            
            yPosition = 50 * k;
            var typeOfTourismTags = _getTagsService.GetTagsForTagType(TagType.TypeOfTourismTag);

            foreach (var typeOfTourismTag in typeOfTourismTags)
            {
                var typeOfTourismCheckBox = new CheckBox
                {
                    Text = typeOfTourismTag.TagName,
                    Location = new Point((int)(20 * k), (int)yPosition),
                    AutoSize = true
                };

                typeOfTourismGroupBox.Controls.Add(typeOfTourismCheckBox);
                yPosition += verticalSpacing;
            }

            _accountServise = new AccountService();
        }


        private void savedAnketaButton_Click(object sender, EventArgs e)
        {
            var groupBoxes = new List<GroupBox> { ageGroupBox, budgetGroupBox, durationGroupBox,
            levelOfTrainingGroupBox, locationGroupBox, purposeGroupBox, seasonGroupBox, typeOfTourismGroupBox };
        
            var tagNames = new List<string>();

            foreach (var groupBox in groupBoxes)
            {
                foreach (var obj in groupBox.Controls)
                {
                    var checkBox = obj as CheckBox;

                    if (checkBox != null && checkBox.Checked)
                    {
                        tagNames.Add(checkBox.Text);
                    }
                }
            }

            _accountServise.AddTags(tagNames);

            MessageBox.Show(AnketaDataSavedMessage);
            this.Hide();
            var recommendationsListForm = new RecommendationsListForm();
            recommendationsListForm.Show();
        }

        private void Group_CheckedChanged(object sender, EventArgs e)
        {
            var currentCheckBox = sender as CheckBox;

            var parent = currentCheckBox.Parent as GroupBox;

            if (currentCheckBox.Checked)
            {
                foreach (var control in parent.Controls)
                {
                    if (control is CheckBox cb && cb != currentCheckBox)
                    {
                        cb.Checked = false;
                    }
                }
            }
        }
    }
}
