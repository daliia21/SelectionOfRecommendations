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
using TouristRoutes.Models.TagModels;
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

            List<AgeTag> ageTags = _getTagsService.GetAgeTags();

            foreach (var ageTag in ageTags)
            {
                CheckBox ageCheckBox = new CheckBox();

                ageCheckBox.Text = ageTag.TagName;



                ageGroupBox.Controls.Add(ageCheckBox);
            }



            _accountServise = new AccountService();
        }




        private void savedAnketaButton_Click(object sender, EventArgs e)
        {
            string tourismTypes = "";

            foreach (CheckBox rb in groupBox2.Controls.OfType<CheckBox>())
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




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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
