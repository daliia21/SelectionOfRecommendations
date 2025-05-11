namespace TouristRoutes.Forms
{
    partial class AdministratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            administratorsTabControl = new TabControl();
            addRouteTabPage = new TabPage();
            routeBackButton = new Button();
            routeSaveButton = new Button();
            routePictureLabel = new Label();
            routePictureBox = new PictureBox();
            routeDescriptionRichTextBox = new RichTextBox();
            routeLevelOfTrainingTextBox = new TextBox();
            routeDurationTextBox = new TextBox();
            routeLocationTextBox = new TextBox();
            routePriceTextBox = new TextBox();
            routeNameTextBox = new TextBox();
            routeDescriptionLabel = new Label();
            routeLevelOfTrainingLabel = new Label();
            routeDurationLabel = new Label();
            routeLocationLabel = new Label();
            routePriceLabel = new Label();
            routeNameLabel = new Label();
            updateRouteTabPage = new TabPage();
            routeDeleteButton = new Button();
            routeSaveButton2 = new Button();
            routePictureLabel2 = new Label();
            routePictureBox2 = new PictureBox();
            routeDescriptionRichTextBox2 = new RichTextBox();
            routeLevelOfTrainingTextBox2 = new TextBox();
            routeDurationTextBox2 = new TextBox();
            routeLocationTextBox2 = new TextBox();
            routePriceTextBox2 = new TextBox();
            routeNameTextBox2 = new TextBox();
            routeDescriptionLabel2 = new Label();
            routeLevelOfTrainingLabel2 = new Label();
            routeDurationLabel2 = new Label();
            routeLocationLabel2 = new Label();
            routePriceLabel2 = new Label();
            routeNameLabel2 = new Label();
            panel1 = new Panel();
            routeListBoxLabel = new Label();
            routesListBox = new ListBox();
            administratorsTabControl.SuspendLayout();
            addRouteTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)routePictureBox).BeginInit();
            updateRouteTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)routePictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            administratorsTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            administratorsTabControl.Controls.Add(addRouteTabPage);
            administratorsTabControl.Controls.Add(updateRouteTabPage);
            administratorsTabControl.Location = new Point(-5, 12);
            administratorsTabControl.Name = "tabControl1";
            administratorsTabControl.SelectedIndex = 0;
            administratorsTabControl.Size = new Size(1712, 1334);
            administratorsTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            addRouteTabPage.BackColor = Color.FromArgb(75, 136, 158);
            addRouteTabPage.Controls.Add(routeBackButton);
            addRouteTabPage.Controls.Add(routeSaveButton);
            addRouteTabPage.Controls.Add(routePictureLabel);
            addRouteTabPage.Controls.Add(routePictureBox);
            addRouteTabPage.Controls.Add(routeDescriptionRichTextBox);
            addRouteTabPage.Controls.Add(routeLevelOfTrainingTextBox);
            addRouteTabPage.Controls.Add(routeDurationTextBox);
            addRouteTabPage.Controls.Add(routeLocationTextBox);
            addRouteTabPage.Controls.Add(routePriceTextBox);
            addRouteTabPage.Controls.Add(routeNameTextBox);
            addRouteTabPage.Controls.Add(routeDescriptionLabel);
            addRouteTabPage.Controls.Add(routeLevelOfTrainingLabel);
            addRouteTabPage.Controls.Add(routeDurationLabel);
            addRouteTabPage.Controls.Add(routeLocationLabel);
            addRouteTabPage.Controls.Add(routePriceLabel);
            addRouteTabPage.Controls.Add(routeNameLabel);
            addRouteTabPage.Location = new Point(8, 46);
            addRouteTabPage.Name = "tabPage1";
            addRouteTabPage.Padding = new Padding(3);
            addRouteTabPage.Size = new Size(1696, 1280);
            addRouteTabPage.TabIndex = 0;
            addRouteTabPage.Text = "Добавление нового маршрута";
            // 
            // button2
            // 
            routeBackButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            routeBackButton.BackColor = Color.FromArgb(59, 102, 118);
            routeBackButton.Font = new Font("Segoe UI", 11F);
            routeBackButton.ForeColor = Color.White;
            routeBackButton.Location = new Point(1245, 1150);
            routeBackButton.Name = "button2";
            routeBackButton.Size = new Size(267, 72);
            routeBackButton.TabIndex = 16;
            routeBackButton.Text = "ОТМЕНА";
            routeBackButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            routeSaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            routeSaveButton.BackColor = Color.FromArgb(59, 102, 118);
            routeSaveButton.Font = new Font("Segoe UI", 11F);
            routeSaveButton.ForeColor = Color.White;
            routeSaveButton.Location = new Point(945, 1150);
            routeSaveButton.Name = "button1";
            routeSaveButton.Size = new Size(267, 72);
            routeSaveButton.TabIndex = 15;
            routeSaveButton.Text = "СОХРАНИТЬ";
            routeSaveButton.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            routePictureLabel.AutoSize = true;
            routePictureLabel.Font = new Font("Segoe UI", 11F);
            routePictureLabel.ForeColor = Color.White;
            routePictureLabel.Location = new Point(167, 876);
            routePictureLabel.Name = "label7";
            routePictureLabel.Size = new Size(241, 41);
            routePictureLabel.TabIndex = 14;
            routePictureLabel.Text = "Фото маршрута:";
            // 
            // pictureBox1
            // 
            routePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            routePictureBox.BackColor = Color.White;
            routePictureBox.Location = new Point(167, 923);
            routePictureBox.Name = "pictureBox1";
            routePictureBox.Size = new Size(505, 299);
            routePictureBox.TabIndex = 13;
            routePictureBox.TabStop = false;
            // 
            // richTextBox1
            // 
            routeDescriptionRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeDescriptionRichTextBox.Location = new Point(167, 626);
            routeDescriptionRichTextBox.Name = "richTextBox1";
            routeDescriptionRichTextBox.Size = new Size(1345, 198);
            routeDescriptionRichTextBox.TabIndex = 12;
            routeDescriptionRichTextBox.Text = "";
            // 
            // textBox5
            // 
            routeLevelOfTrainingTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeLevelOfTrainingTextBox.Location = new Point(167, 503);
            routeLevelOfTrainingTextBox.Name = "textBox5";
            routeLevelOfTrainingTextBox.Size = new Size(1345, 39);
            routeLevelOfTrainingTextBox.TabIndex = 10;
            // 
            // textBox4
            // 
            routeDurationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeDurationTextBox.Location = new Point(167, 396);
            routeDurationTextBox.Name = "textBox4";
            routeDurationTextBox.Size = new Size(1345, 39);
            routeDurationTextBox.TabIndex = 9;
            // 
            // textBox3
            // 
            routeLocationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeLocationTextBox.Location = new Point(167, 275);
            routeLocationTextBox.Name = "textBox3";
            routeLocationTextBox.Size = new Size(1345, 39);
            routeLocationTextBox.TabIndex = 8;
            // 
            // textBox2
            // 
            routePriceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routePriceTextBox.Location = new Point(167, 160);
            routePriceTextBox.Name = "textBox2";
            routePriceTextBox.Size = new Size(1345, 39);
            routePriceTextBox.TabIndex = 7;
            // 
            // textBox1
            // 
            routeNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeNameTextBox.Location = new Point(167, 57);
            routeNameTextBox.Name = "textBox1";
            routeNameTextBox.Size = new Size(1345, 39);
            routeNameTextBox.TabIndex = 6;
            // 
            // label6
            // 
            routeDescriptionLabel.AutoSize = true;
            routeDescriptionLabel.Font = new Font("Segoe UI", 11F);
            routeDescriptionLabel.ForeColor = Color.White;
            routeDescriptionLabel.Location = new Point(167, 562);
            routeDescriptionLabel.Name = "label6";
            routeDescriptionLabel.Size = new Size(307, 41);
            routeDescriptionLabel.TabIndex = 5;
            routeDescriptionLabel.Text = "Описание маршрута:";
            // 
            // label5
            // 
            routeLevelOfTrainingLabel.AutoSize = true;
            routeLevelOfTrainingLabel.Font = new Font("Segoe UI", 11F);
            routeLevelOfTrainingLabel.ForeColor = Color.White;
            routeLevelOfTrainingLabel.Location = new Point(167, 450);
            routeLevelOfTrainingLabel.Name = "label5";
            routeLevelOfTrainingLabel.Size = new Size(716, 41);
            routeLevelOfTrainingLabel.TabIndex = 4;
            routeLevelOfTrainingLabel.Text = "Уровень подготовки, необходимый для маршрута:";
            // 
            // label4
            // 
            routeDurationLabel.AutoSize = true;
            routeDurationLabel.Font = new Font("Segoe UI", 11F);
            routeDurationLabel.ForeColor = Color.White;
            routeDurationLabel.Location = new Point(167, 338);
            routeDurationLabel.Name = "label4";
            routeDurationLabel.Size = new Size(360, 41);
            routeDurationLabel.TabIndex = 3;
            routeDurationLabel.Text = "Длительность маршрута:";
            // 
            // label3
            // 
            routeLocationLabel.AutoSize = true;
            routeLocationLabel.Font = new Font("Segoe UI", 11F);
            routeLocationLabel.ForeColor = Color.White;
            routeLocationLabel.Location = new Point(167, 219);
            routeLocationLabel.Name = "label3";
            routeLocationLabel.Size = new Size(374, 41);
            routeLocationLabel.TabIndex = 2;
            routeLocationLabel.Text = "Расположение маршрута:";
            // 
            // label2
            // 
            routePriceLabel.AutoSize = true;
            routePriceLabel.Font = new Font("Segoe UI", 11F);
            routePriceLabel.ForeColor = Color.White;
            routePriceLabel.Location = new Point(167, 116);
            routePriceLabel.Name = "label2";
            routePriceLabel.Size = new Size(317, 41);
            routePriceLabel.TabIndex = 1;
            routePriceLabel.Text = "Стоимость маршрута:";
            // 
            // label1
            // 
            routeNameLabel.AutoSize = true;
            routeNameLabel.Font = new Font("Segoe UI", 11F);
            routeNameLabel.ForeColor = Color.White;
            routeNameLabel.Location = new Point(167, 13);
            routeNameLabel.Name = "label1";
            routeNameLabel.Size = new Size(301, 41);
            routeNameLabel.TabIndex = 0;
            routeNameLabel.Text = "Название маршрута:";
            // 
            // tabPage2
            // 
            updateRouteTabPage.BackColor = Color.FromArgb(75, 136, 158);
            updateRouteTabPage.Controls.Add(routeDeleteButton);
            updateRouteTabPage.Controls.Add(routeSaveButton2);
            updateRouteTabPage.Controls.Add(routePictureLabel2);
            updateRouteTabPage.Controls.Add(routePictureBox2);
            updateRouteTabPage.Controls.Add(routeDescriptionRichTextBox2);
            updateRouteTabPage.Controls.Add(routeLevelOfTrainingTextBox2);
            updateRouteTabPage.Controls.Add(routeDurationTextBox2);
            updateRouteTabPage.Controls.Add(routeLocationTextBox2);
            updateRouteTabPage.Controls.Add(routePriceTextBox2);
            updateRouteTabPage.Controls.Add(routeNameTextBox2);
            updateRouteTabPage.Controls.Add(routeDescriptionLabel2);
            updateRouteTabPage.Controls.Add(routeLevelOfTrainingLabel2);
            updateRouteTabPage.Controls.Add(routeDurationLabel2);
            updateRouteTabPage.Controls.Add(routeLocationLabel2);
            updateRouteTabPage.Controls.Add(routePriceLabel2);
            updateRouteTabPage.Controls.Add(routeNameLabel2);
            updateRouteTabPage.Controls.Add(panel1);
            updateRouteTabPage.Controls.Add(routesListBox);
            updateRouteTabPage.Location = new Point(8, 46);
            updateRouteTabPage.Name = "tabPage2";
            updateRouteTabPage.Padding = new Padding(3);
            updateRouteTabPage.Size = new Size(1696, 1280);
            updateRouteTabPage.TabIndex = 1;
            updateRouteTabPage.Text = "Редактирование маршрута";
            // 
            // button4
            // 
            routeDeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            routeDeleteButton.BackColor = Color.FromArgb(59, 102, 118);
            routeDeleteButton.Font = new Font("Segoe UI", 11F);
            routeDeleteButton.ForeColor = Color.White;
            routeDeleteButton.Location = new Point(1050, 1150);
            routeDeleteButton.Name = "button4";
            routeDeleteButton.Size = new Size(267, 72);
            routeDeleteButton.TabIndex = 30;
            routeDeleteButton.Text = "УДАЛИТЬ";
            routeDeleteButton.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            routeSaveButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            routeSaveButton2.BackColor = Color.FromArgb(59, 102, 118);
            routeSaveButton2.Font = new Font("Segoe UI", 11F);
            routeSaveButton2.ForeColor = Color.White;
            routeSaveButton2.Location = new Point(1361, 1150);
            routeSaveButton2.Name = "button3";
            routeSaveButton2.Size = new Size(267, 72);
            routeSaveButton2.TabIndex = 29;
            routeSaveButton2.Text = "СОХРАНИТЬ";
            routeSaveButton2.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            routePictureLabel2.AutoSize = true;
            routePictureLabel2.Font = new Font("Segoe UI", 11F);
            routePictureLabel2.ForeColor = Color.White;
            routePictureLabel2.Location = new Point(426, 891);
            routePictureLabel2.Name = "label9";
            routePictureLabel2.Size = new Size(241, 41);
            routePictureLabel2.TabIndex = 28;
            routePictureLabel2.Text = "Фото маршрута:";
            // 
            // pictureBox2
            // 
            routePictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            routePictureBox2.BackColor = Color.White;
            routePictureBox2.Location = new Point(426, 938);
            routePictureBox2.Name = "pictureBox2";
            routePictureBox2.Size = new Size(403, 299);
            routePictureBox2.TabIndex = 27;
            routePictureBox2.TabStop = false;
            // 
            // richTextBox2
            // 
            routeDescriptionRichTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeDescriptionRichTextBox2.Location = new Point(426, 641);
            routeDescriptionRichTextBox2.Name = "richTextBox2";
            routeDescriptionRichTextBox2.Size = new Size(1202, 198);
            routeDescriptionRichTextBox2.TabIndex = 26;
            routeDescriptionRichTextBox2.Text = "";
            // 
            // textBox6
            // 
            routeLevelOfTrainingTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeLevelOfTrainingTextBox2.Location = new Point(426, 518);
            routeLevelOfTrainingTextBox2.Name = "textBox6";
            routeLevelOfTrainingTextBox2.Size = new Size(1202, 39);
            routeLevelOfTrainingTextBox2.TabIndex = 25;
            // 
            // textBox7
            // 
            routeDurationTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeDurationTextBox2.Location = new Point(426, 411);
            routeDurationTextBox2.Name = "textBox7";
            routeDurationTextBox2.Size = new Size(1202, 39);
            routeDurationTextBox2.TabIndex = 24;
            // 
            // textBox8
            // 
            routeLocationTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeLocationTextBox2.Location = new Point(426, 290);
            routeLocationTextBox2.Name = "textBox8";
            routeLocationTextBox2.Size = new Size(1202, 39);
            routeLocationTextBox2.TabIndex = 23;
            // 
            // textBox9
            // 
            routePriceTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routePriceTextBox2.Location = new Point(426, 175);
            routePriceTextBox2.Name = "textBox9";
            routePriceTextBox2.Size = new Size(1202, 39);
            routePriceTextBox2.TabIndex = 22;
            // 
            // textBox10
            // 
            routeNameTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeNameTextBox2.Location = new Point(426, 72);
            routeNameTextBox2.Name = "textBox10";
            routeNameTextBox2.Size = new Size(1202, 39);
            routeNameTextBox2.TabIndex = 21;
            // 
            // label10
            // 
            routeDescriptionLabel2.AutoSize = true;
            routeDescriptionLabel2.Font = new Font("Segoe UI", 11F);
            routeDescriptionLabel2.ForeColor = Color.White;
            routeDescriptionLabel2.Location = new Point(426, 577);
            routeDescriptionLabel2.Name = "label10";
            routeDescriptionLabel2.Size = new Size(307, 41);
            routeDescriptionLabel2.TabIndex = 20;
            routeDescriptionLabel2.Text = "Описание маршрута:";
            // 
            // label11
            // 
            routeLevelOfTrainingLabel2.AutoSize = true;
            routeLevelOfTrainingLabel2.Font = new Font("Segoe UI", 11F);
            routeLevelOfTrainingLabel2.ForeColor = Color.White;
            routeLevelOfTrainingLabel2.Location = new Point(426, 465);
            routeLevelOfTrainingLabel2.Name = "label11";
            routeLevelOfTrainingLabel2.Size = new Size(716, 41);
            routeLevelOfTrainingLabel2.TabIndex = 19;
            routeLevelOfTrainingLabel2.Text = "Уровень подготовки, необходимый для маршрута:";
            // 
            // label12
            // 
            routeDurationLabel2.AutoSize = true;
            routeDurationLabel2.Font = new Font("Segoe UI", 11F);
            routeDurationLabel2.ForeColor = Color.White;
            routeDurationLabel2.Location = new Point(426, 353);
            routeDurationLabel2.Name = "label12";
            routeDurationLabel2.Size = new Size(360, 41);
            routeDurationLabel2.TabIndex = 18;
            routeDurationLabel2.Text = "Длительность маршрута:";
            // 
            // label13
            // 
            routeLocationLabel2.AutoSize = true;
            routeLocationLabel2.Font = new Font("Segoe UI", 11F);
            routeLocationLabel2.ForeColor = Color.White;
            routeLocationLabel2.Location = new Point(426, 234);
            routeLocationLabel2.Name = "label13";
            routeLocationLabel2.Size = new Size(374, 41);
            routeLocationLabel2.TabIndex = 17;
            routeLocationLabel2.Text = "Расположение маршрута:";
            // 
            // label14
            // 
            routePriceLabel2.AutoSize = true;
            routePriceLabel2.Font = new Font("Segoe UI", 11F);
            routePriceLabel2.ForeColor = Color.White;
            routePriceLabel2.Location = new Point(426, 131);
            routePriceLabel2.Name = "label14";
            routePriceLabel2.Size = new Size(317, 41);
            routePriceLabel2.TabIndex = 16;
            routePriceLabel2.Text = "Стоимость маршрута:";
            // 
            // label15
            // 
            routeNameLabel2.AutoSize = true;
            routeNameLabel2.Font = new Font("Segoe UI", 11F);
            routeNameLabel2.ForeColor = Color.White;
            routeNameLabel2.Location = new Point(426, 28);
            routeNameLabel2.Name = "label15";
            routeNameLabel2.Size = new Size(301, 41);
            routeNameLabel2.TabIndex = 15;
            routeNameLabel2.Text = "Название маршрута:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 102, 118);
            panel1.Controls.Add(routeListBoxLabel);
            panel1.Location = new Point(35, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 70);
            panel1.TabIndex = 2;
            // 
            // label8
            // 
            routeListBoxLabel.AutoSize = true;
            routeListBoxLabel.BackColor = Color.FromArgb(59, 102, 118);
            routeListBoxLabel.Font = new Font("Segoe UI", 11F);
            routeListBoxLabel.ForeColor = Color.White;
            routeListBoxLabel.Location = new Point(26, 18);
            routeListBoxLabel.Name = "label8";
            routeListBoxLabel.Size = new Size(283, 41);
            routeListBoxLabel.TabIndex = 1;
            routeListBoxLabel.Text = "Список маршрутов";
            // 
            // listBox1
            // 
            routesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            routesListBox.FormattingEnabled = true;
            routesListBox.Location = new Point(35, 113);
            routesListBox.Name = "listBox1";
            routesListBox.Size = new Size(344, 1124);
            routesListBox.TabIndex = 0;
            // 
            // AdministratorForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 136, 158);
            ClientSize = new Size(1700, 1336);
            Controls.Add(administratorsTabControl);
            Name = "AdministratorForm";
            Text = "Управление маршрутами";
            administratorsTabControl.ResumeLayout(false);
            addRouteTabPage.ResumeLayout(false);
            addRouteTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)routePictureBox).EndInit();
            updateRouteTabPage.ResumeLayout(false);
            updateRouteTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)routePictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl administratorsTabControl;
        private TabPage addRouteTabPage;
        private TabPage updateRouteTabPage;
        private Label routeLocationLabel;
        private Label routePriceLabel;
        private Label routeNameLabel;
        private Label routeDurationLabel;
        private TextBox routePriceTextBox;
        private TextBox routeNameTextBox;
        private Label routeDescriptionLabel;
        private Label routeLevelOfTrainingLabel;
        private TextBox routeLevelOfTrainingTextBox;
        private TextBox routeDurationTextBox;
        private TextBox routeLocationTextBox;
        private RichTextBox routeDescriptionRichTextBox;
        private Label routePictureLabel;
        private PictureBox routePictureBox;
        private Button routeSaveButton;
        private Button routeBackButton;
        private Label routeListBoxLabel;
        private ListBox routesListBox;
        private Panel panel1;
        private Label routePictureLabel2;
        private PictureBox routePictureBox2;
        private RichTextBox routeDescriptionRichTextBox2;
        private TextBox routeLevelOfTrainingTextBox2;
        private TextBox routeDurationTextBox2;
        private TextBox routeLocationTextBox2;
        private TextBox routePriceTextBox2;
        private TextBox routeNameTextBox2;
        private Label routeDescriptionLabel2;
        private Label routeLevelOfTrainingLabel2;
        private Label routeDurationLabel2;
        private Label routeLocationLabel2;
        private Label routePriceLabel2;
        private Label routeNameLabel2;
        private Button routeDeleteButton;
        private Button routeSaveButton2;
    }
}