using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouristRoutes.Dtos;
using TouristRoutes.Models;
using TouristRoutes.Services;

namespace TouristRoutes.Forms
{
    public partial class AnketaForm : Form
    {
        AccountService _accountServise;
        GetTagsService _getTagsService;
        private int _top = 20;

        public AnketaForm()
        {
            InitializeComponent();

            // Заполнение тегов
            int yPosition = 50;
            const int verticalSpacing = 40;


            _getTagsService = new GetTagsService();
            List<Tag> ageTags = _getTagsService.GetAgeTags();


            

            foreach (var ageTag in ageTags)
            {
                CheckBox ageCheckBox = new CheckBox
                {
                    Text = ageTag.TagName,
                    Location = new Point(20, yPosition),
                    AutoSize = true 
                };

                ageCheckBox.CheckedChanged += Group_CheckedChanged;

                ageGroupBox.Controls.Add(ageCheckBox);
                yPosition += verticalSpacing;
            }


            List<Tag> budgetTags = _getTagsService.GetBudgetTags();


            yPosition = 50;

            foreach (var budgetTag in budgetTags)
            {
                CheckBox budgetCheckBox = new CheckBox
                {
                    Text = budgetTag.TagName,
                    Location = new Point(20, yPosition),
                    AutoSize = true
                };

                budgetCheckBox.CheckedChanged += Group_CheckedChanged;

                budgetGroupBox.Controls.Add(budgetCheckBox);
                yPosition += verticalSpacing;
            }


            
            List<Tag> durationTags = _getTagsService.GetDurationTags();

            foreach (var durationTag in durationTags)
            {
                CheckBox durationCheckBox = new CheckBox
                {
                    Text = durationTag.TagName,
                    Location = new Point(20, yPosition),
                    AutoSize = true
                };

                durationCheckBox.CheckedChanged += Group_CheckedChanged;

                durationGroupBox.Controls.Add(durationCheckBox);
                yPosition += verticalSpacing;
            }


            
            List<Tag> levelOfTrainingTags = _getTagsService.GetLevelOfTrainingTags();

            foreach (var levelOfTrainingTag in levelOfTrainingTags)
            {
                CheckBox levelOfTrainingCheckBox = new CheckBox
                {
                    Text = levelOfTrainingTag.TagName,
                    Location = new Point(20, yPosition),
                    AutoSize = true
                };

                levelOfTrainingCheckBox.CheckedChanged += Group_CheckedChanged;

                levelOfTrainingGroupBox.Controls.Add(levelOfTrainingCheckBox);
                yPosition += verticalSpacing;
            }


            List<Tag> locationTags = _getTagsService.GetLocationTags();

            foreach (var locationTag in locationTags)
            {
                CheckBox locationCheckBox = new CheckBox
                {
                    Text = locationTag.TagName,
                    Location = new Point(20, yPosition),
                    AutoSize = true
                };

                locationCheckBox.CheckedChanged += Group_CheckedChanged;

                locationGroupBox.Controls.Add(locationCheckBox);
                yPosition += verticalSpacing;
            }


            List<Tag> purposeTags = _getTagsService.GetPurposeTags();

            foreach (var purposeTag in purposeTags)
            {
                CheckBox purposeCheckBox = new CheckBox
                {
                    Text = purposeTag.TagName,
                    Location = new Point(20, yPosition),
                    AutoSize = true
                };

                purposeCheckBox.CheckedChanged += Group_CheckedChanged;

                ageGroupBox.Controls.Add(purposeCheckBox);
                yPosition += verticalSpacing;
            }


            List<Tag> seasonTags = _getTagsService.GetSeasonTags();
         
            foreach (var seasonTag in seasonTags)
            {
                CheckBox seasonCheckBox = new CheckBox
                {
                    Text = seasonTag.TagName,
                    Location = new Point(20, yPosition),
                    AutoSize = true
                };

                seasonCheckBox.CheckedChanged += Group_CheckedChanged;

                seasonGroupBox.Controls.Add(seasonCheckBox);
                yPosition += verticalSpacing;
            }


            //    List<AgeTag> ageTags = _getTagsService.GetAgeTags();

            //    if (ageTags == null)
            //    {
            //        _fillTagsService = new FillTagsService();
            //        _fillTagsService.FillAgeTags();
            //        ageTags = _getTagsService.GetAgeTags();

            //    }



            //    foreach (var ageTag in ageTags)
            //    {
            //        CheckBox ageCheckBox = new CheckBox
            //        {
            //            Text = ageTag.TagName,
            //            Location = new Point(20, yPosition),
            //            AutoSize = true
            //        };

            //        ageCheckBox.CheckedChanged += Group_CheckedChanged;

            //        ageGroupBox.Controls.Add(ageCheckBox);
            //        yPosition += verticalSpacing;
            //    }



            //    _accountServise = new AccountService();
        }




        private void savedAnketaButton_Click(object sender, EventArgs e)
        {
            string tourismTypes = "";

            foreach (CheckBox rb in typeOfTourismGroupBox.Controls.OfType<CheckBox>())
            {
                if (rb.Checked)
                {
                    if (string.IsNullOrEmpty(tourismTypes))
                    {
                        tourismTypes += rb.Text;
                    }
                    else
                    {
                        tourismTypes += $",{rb.Text}";
                    }
                }
            }


            AnketaDto anketaDto = new AnketaDto
            {
                TypeOfTourism = tourismTypes
            };
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
