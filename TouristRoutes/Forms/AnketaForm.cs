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
using TouristRoutes.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TouristRoutes.Forms
{
    public partial class AnketaForm : Form
    {
        AccountService _accountServise;
        public AnketaForm()
        {
            InitializeComponent();
            _accountServise = new AccountService();
        }




        private void savedAnketaButton_Click(object sender, EventArgs e)
        {
            AnketaDto anketaDto = new AnketaDto();

            foreach (CheckBox rb in ageGroupBox.Controls.OfType<CheckBox>())
            {
                if (rb.Checked)
                {
                    anketaDto.AgeCategory = rb.Text;
                    break;
                }
            }
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
