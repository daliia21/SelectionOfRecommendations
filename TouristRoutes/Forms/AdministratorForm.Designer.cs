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
            addNewRouteButton = new Button();
            pictureLoadButton = new Button();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
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
            pictureLoadButton2 = new Button();
            label2 = new Label();
            checkedListBox2 = new CheckedListBox();
            routeDeleteButton = new Button();
            routeSaveButton2 = new Button();
            routePictureLabel2 = new Label();
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
            routePictureBox2 = new PictureBox();
            administratorsTabControl.SuspendLayout();
            addRouteTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)routePictureBox).BeginInit();
            updateRouteTabPage.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)routePictureBox2).BeginInit();
            SuspendLayout();
            // 
            // administratorsTabControl
            // 
            administratorsTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            administratorsTabControl.Controls.Add(addRouteTabPage);
            administratorsTabControl.Controls.Add(updateRouteTabPage);
            administratorsTabControl.Location = new Point(-5, 12);
            administratorsTabControl.Name = "administratorsTabControl";
            administratorsTabControl.SelectedIndex = 0;
            administratorsTabControl.Size = new Size(1712, 1550);
            administratorsTabControl.TabIndex = 0;
            // 
            // addRouteTabPage
            // 
            addRouteTabPage.BackColor = Color.FromArgb(75, 136, 158);
            addRouteTabPage.Controls.Add(addNewRouteButton);
            addRouteTabPage.Controls.Add(pictureLoadButton);
            addRouteTabPage.Controls.Add(label1);
            addRouteTabPage.Controls.Add(checkedListBox1);
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
            addRouteTabPage.Name = "addRouteTabPage";
            addRouteTabPage.Padding = new Padding(3);
            addRouteTabPage.Size = new Size(1696, 1496);
            addRouteTabPage.TabIndex = 0;
            addRouteTabPage.Text = "Добавление нового маршрута";
            // 
            // addNewRouteButton
            // 
            addNewRouteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addNewRouteButton.BackColor = Color.FromArgb(59, 102, 118);
            addNewRouteButton.Font = new Font("Segoe UI", 11F);
            addNewRouteButton.ForeColor = Color.White;
            addNewRouteButton.Location = new Point(643, 1366);
            addNewRouteButton.Name = "addNewRouteButton";
            addNewRouteButton.Size = new Size(267, 72);
            addNewRouteButton.TabIndex = 20;
            addNewRouteButton.Text = "ДОБАВИТЬ";
            addNewRouteButton.UseVisualStyleBackColor = false;
            addNewRouteButton.Click += addNewRouteButton_Click;
            // 
            // pictureLoadButton
            // 
            pictureLoadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureLoadButton.BackColor = Color.FromArgb(59, 102, 118);
            pictureLoadButton.Font = new Font("Segoe UI", 11F);
            pictureLoadButton.ForeColor = Color.White;
            pictureLoadButton.Location = new Point(274, 1366);
            pictureLoadButton.Name = "pictureLoadButton";
            pictureLoadButton.Size = new Size(288, 72);
            pictureLoadButton.TabIndex = 19;
            pictureLoadButton.Text = "ЗАГРУЗИТЬ ФОТО";
            pictureLoadButton.UseVisualStyleBackColor = false;
            pictureLoadButton.Click += pictureLoadButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(756, 817);
            label1.Name = "label1";
            label1.Size = new Size(756, 41);
            label1.TabIndex = 18;
            label1.Text = "Выберите теги, которые хотите добавить к маршруту:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "до 18", "от 18 до 25", "от 25 до 36", "от 36 до 50", "50+", "Эконом (до 30 тыс. руб.)", "Средний (от 30 - 70 тыс. руб.)", "Премиум (70+ тыс. руб.)", "1-3 дня", "5-7 дней", "10+ дней", "Новичок", "Любитель", "Профессионал", "Горные районы", "Лесные зоны", "Прибрежные регионы", "Исторические места", "Экзотические направления", "Отдых", "Обучение", "Культурное обогащение", "Лето", "Осень", "Зима", "Весна", "Рекреационный", "Экскурсионный", "Приключенческий", "Спортивный", "Шопинг" });
            checkedListBox1.Location = new Point(765, 887);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(747, 400);
            checkedListBox1.TabIndex = 17;
            // 
            // routeBackButton
            // 
            routeBackButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            routeBackButton.BackColor = Color.FromArgb(59, 102, 118);
            routeBackButton.Font = new Font("Segoe UI", 11F);
            routeBackButton.ForeColor = Color.White;
            routeBackButton.Location = new Point(1245, 1366);
            routeBackButton.Name = "routeBackButton";
            routeBackButton.Size = new Size(267, 72);
            routeBackButton.TabIndex = 16;
            routeBackButton.Text = "ОТМЕНА";
            routeBackButton.UseVisualStyleBackColor = false;
            routeBackButton.Click += routeBackButton_Click;
            // 
            // routeSaveButton
            // 
            routeSaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            routeSaveButton.BackColor = Color.FromArgb(59, 102, 118);
            routeSaveButton.Font = new Font("Segoe UI", 11F);
            routeSaveButton.ForeColor = Color.White;
            routeSaveButton.Location = new Point(945, 1366);
            routeSaveButton.Name = "routeSaveButton";
            routeSaveButton.Size = new Size(267, 72);
            routeSaveButton.TabIndex = 15;
            routeSaveButton.Text = "СОХРАНИТЬ";
            routeSaveButton.UseVisualStyleBackColor = false;
            routeSaveButton.Click += routeSaveButton_Click;
            // 
            // routePictureLabel
            // 
            routePictureLabel.AutoSize = true;
            routePictureLabel.Font = new Font("Segoe UI", 11F);
            routePictureLabel.ForeColor = Color.White;
            routePictureLabel.Location = new Point(167, 817);
            routePictureLabel.Name = "routePictureLabel";
            routePictureLabel.Size = new Size(241, 41);
            routePictureLabel.TabIndex = 14;
            routePictureLabel.Text = "Фото маршрута:";
            // 
            // routePictureBox
            // 
            routePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            routePictureBox.BackColor = Color.White;
            routePictureBox.Location = new Point(167, 887);
            routePictureBox.Name = "routePictureBox";
            routePictureBox.Size = new Size(505, 400);
            routePictureBox.TabIndex = 13;
            routePictureBox.TabStop = false;
            // 
            // routeDescriptionRichTextBox
            // 
            routeDescriptionRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeDescriptionRichTextBox.Location = new Point(167, 626);
            routeDescriptionRichTextBox.Name = "routeDescriptionRichTextBox";
            routeDescriptionRichTextBox.Size = new Size(1345, 155);
            routeDescriptionRichTextBox.TabIndex = 12;
            routeDescriptionRichTextBox.Text = "";
            // 
            // routeLevelOfTrainingTextBox
            // 
            routeLevelOfTrainingTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeLevelOfTrainingTextBox.Location = new Point(167, 503);
            routeLevelOfTrainingTextBox.Name = "routeLevelOfTrainingTextBox";
            routeLevelOfTrainingTextBox.Size = new Size(1345, 39);
            routeLevelOfTrainingTextBox.TabIndex = 10;
            // 
            // routeDurationTextBox
            // 
            routeDurationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeDurationTextBox.Location = new Point(167, 396);
            routeDurationTextBox.Name = "routeDurationTextBox";
            routeDurationTextBox.Size = new Size(1345, 39);
            routeDurationTextBox.TabIndex = 9;
            // 
            // routeLocationTextBox
            // 
            routeLocationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeLocationTextBox.Location = new Point(167, 275);
            routeLocationTextBox.Name = "routeLocationTextBox";
            routeLocationTextBox.Size = new Size(1345, 39);
            routeLocationTextBox.TabIndex = 8;
            // 
            // routePriceTextBox
            // 
            routePriceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routePriceTextBox.Location = new Point(167, 160);
            routePriceTextBox.Name = "routePriceTextBox";
            routePriceTextBox.Size = new Size(1345, 39);
            routePriceTextBox.TabIndex = 7;
            // 
            // routeNameTextBox
            // 
            routeNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeNameTextBox.Location = new Point(167, 57);
            routeNameTextBox.Name = "routeNameTextBox";
            routeNameTextBox.Size = new Size(1345, 39);
            routeNameTextBox.TabIndex = 6;
            // 
            // routeDescriptionLabel
            // 
            routeDescriptionLabel.AutoSize = true;
            routeDescriptionLabel.Font = new Font("Segoe UI", 11F);
            routeDescriptionLabel.ForeColor = Color.White;
            routeDescriptionLabel.Location = new Point(167, 562);
            routeDescriptionLabel.Name = "routeDescriptionLabel";
            routeDescriptionLabel.Size = new Size(307, 41);
            routeDescriptionLabel.TabIndex = 5;
            routeDescriptionLabel.Text = "Описание маршрута:";
            // 
            // routeLevelOfTrainingLabel
            // 
            routeLevelOfTrainingLabel.AutoSize = true;
            routeLevelOfTrainingLabel.Font = new Font("Segoe UI", 11F);
            routeLevelOfTrainingLabel.ForeColor = Color.White;
            routeLevelOfTrainingLabel.Location = new Point(167, 450);
            routeLevelOfTrainingLabel.Name = "routeLevelOfTrainingLabel";
            routeLevelOfTrainingLabel.Size = new Size(716, 41);
            routeLevelOfTrainingLabel.TabIndex = 4;
            routeLevelOfTrainingLabel.Text = "Уровень подготовки, необходимый для маршрута:";
            // 
            // routeDurationLabel
            // 
            routeDurationLabel.AutoSize = true;
            routeDurationLabel.Font = new Font("Segoe UI", 11F);
            routeDurationLabel.ForeColor = Color.White;
            routeDurationLabel.Location = new Point(167, 338);
            routeDurationLabel.Name = "routeDurationLabel";
            routeDurationLabel.Size = new Size(360, 41);
            routeDurationLabel.TabIndex = 3;
            routeDurationLabel.Text = "Длительность маршрута:";
            // 
            // routeLocationLabel
            // 
            routeLocationLabel.AutoSize = true;
            routeLocationLabel.Font = new Font("Segoe UI", 11F);
            routeLocationLabel.ForeColor = Color.White;
            routeLocationLabel.Location = new Point(167, 219);
            routeLocationLabel.Name = "routeLocationLabel";
            routeLocationLabel.Size = new Size(374, 41);
            routeLocationLabel.TabIndex = 2;
            routeLocationLabel.Text = "Расположение маршрута:";
            // 
            // routePriceLabel
            // 
            routePriceLabel.AutoSize = true;
            routePriceLabel.Font = new Font("Segoe UI", 11F);
            routePriceLabel.ForeColor = Color.White;
            routePriceLabel.Location = new Point(167, 116);
            routePriceLabel.Name = "routePriceLabel";
            routePriceLabel.Size = new Size(317, 41);
            routePriceLabel.TabIndex = 1;
            routePriceLabel.Text = "Стоимость маршрута:";
            // 
            // routeNameLabel
            // 
            routeNameLabel.AutoSize = true;
            routeNameLabel.Font = new Font("Segoe UI", 11F);
            routeNameLabel.ForeColor = Color.White;
            routeNameLabel.Location = new Point(167, 13);
            routeNameLabel.Name = "routeNameLabel";
            routeNameLabel.Size = new Size(301, 41);
            routeNameLabel.TabIndex = 0;
            routeNameLabel.Text = "Название маршрута:";
            // 
            // updateRouteTabPage
            // 
            updateRouteTabPage.BackColor = Color.FromArgb(75, 136, 158);
            updateRouteTabPage.Controls.Add(pictureLoadButton2);
            updateRouteTabPage.Controls.Add(label2);
            updateRouteTabPage.Controls.Add(checkedListBox2);
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
            updateRouteTabPage.Name = "updateRouteTabPage";
            updateRouteTabPage.Padding = new Padding(3);
            updateRouteTabPage.Size = new Size(1696, 1496);
            updateRouteTabPage.TabIndex = 1;
            updateRouteTabPage.Text = "Редактирование маршрута";
            // 
            // pictureLoadButton2
            // 
            pictureLoadButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureLoadButton2.BackColor = Color.FromArgb(59, 102, 118);
            pictureLoadButton2.Font = new Font("Segoe UI", 11F);
            pictureLoadButton2.ForeColor = Color.White;
            pictureLoadButton2.Location = new Point(496, 1372);
            pictureLoadButton2.Name = "pictureLoadButton2";
            pictureLoadButton2.Size = new Size(290, 72);
            pictureLoadButton2.TabIndex = 33;
            pictureLoadButton2.Text = "ЗАГРУЗИТЬ ФОТО";
            pictureLoadButton2.UseVisualStyleBackColor = false;
            pictureLoadButton2.Click += pictureLoadButton2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(861, 891);
            label2.Name = "label2";
            label2.Size = new Size(248, 41);
            label2.TabIndex = 32;
            label2.Text = "Выбранные теги:";
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "до 18", "от 18 до 25", "от 25 до 36", "от 36 до 50", "50+", "Эконом (до 30 тыс. руб.)", "Средний (от 30 - 70 тыс. руб.)", "Премиум (70+ тыс. руб.)", "1-3 дня", "5-7 дней", "10+ дней", "Новичок", "Любитель", "Профессионал", "Горные районы", "Лесные зоны", "Прибрежные регионы", "Исторические места", "Экзотические направления", "Отдых", "Обучение", "Культурное обогащение", "Лето", "Осень", "Зима", "Весна", "Рекреационный", "Экскурсионный", "Приключенческий", "Спортивный", "Шопинг" });
            checkedListBox2.Location = new Point(861, 938);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(747, 400);
            checkedListBox2.TabIndex = 31;
            // 
            // routeDeleteButton
            // 
            routeDeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            routeDeleteButton.BackColor = Color.FromArgb(59, 102, 118);
            routeDeleteButton.Font = new Font("Segoe UI", 11F);
            routeDeleteButton.ForeColor = Color.White;
            routeDeleteButton.Location = new Point(1035, 1372);
            routeDeleteButton.Name = "routeDeleteButton";
            routeDeleteButton.Size = new Size(267, 72);
            routeDeleteButton.TabIndex = 30;
            routeDeleteButton.Text = "УДАЛИТЬ";
            routeDeleteButton.UseVisualStyleBackColor = false;
            routeDeleteButton.Click += routeDeleteButton_Click;
            // 
            // routeSaveButton2
            // 
            routeSaveButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            routeSaveButton2.BackColor = Color.FromArgb(59, 102, 118);
            routeSaveButton2.Font = new Font("Segoe UI", 11F);
            routeSaveButton2.ForeColor = Color.White;
            routeSaveButton2.Location = new Point(1361, 1372);
            routeSaveButton2.Name = "routeSaveButton2";
            routeSaveButton2.Size = new Size(267, 72);
            routeSaveButton2.TabIndex = 29;
            routeSaveButton2.Text = "СОХРАНИТЬ";
            routeSaveButton2.UseVisualStyleBackColor = false;
            routeSaveButton2.Click += routeSaveButton2_Click;
            // 
            // routePictureLabel2
            // 
            routePictureLabel2.AutoSize = true;
            routePictureLabel2.Font = new Font("Segoe UI", 11F);
            routePictureLabel2.ForeColor = Color.White;
            routePictureLabel2.Location = new Point(426, 891);
            routePictureLabel2.Name = "routePictureLabel2";
            routePictureLabel2.Size = new Size(241, 41);
            routePictureLabel2.TabIndex = 28;
            routePictureLabel2.Text = "Фото маршрута:";
            // 
            // routeDescriptionRichTextBox2
            // 
            routeDescriptionRichTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeDescriptionRichTextBox2.Location = new Point(426, 641);
            routeDescriptionRichTextBox2.Name = "routeDescriptionRichTextBox2";
            routeDescriptionRichTextBox2.Size = new Size(1202, 198);
            routeDescriptionRichTextBox2.TabIndex = 26;
            routeDescriptionRichTextBox2.Text = "";
            // 
            // routeLevelOfTrainingTextBox2
            // 
            routeLevelOfTrainingTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeLevelOfTrainingTextBox2.Location = new Point(426, 518);
            routeLevelOfTrainingTextBox2.Name = "routeLevelOfTrainingTextBox2";
            routeLevelOfTrainingTextBox2.Size = new Size(1202, 39);
            routeLevelOfTrainingTextBox2.TabIndex = 25;
            // 
            // routeDurationTextBox2
            // 
            routeDurationTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeDurationTextBox2.Location = new Point(426, 411);
            routeDurationTextBox2.Name = "routeDurationTextBox2";
            routeDurationTextBox2.Size = new Size(1202, 39);
            routeDurationTextBox2.TabIndex = 24;
            // 
            // routeLocationTextBox2
            // 
            routeLocationTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeLocationTextBox2.Location = new Point(426, 290);
            routeLocationTextBox2.Name = "routeLocationTextBox2";
            routeLocationTextBox2.Size = new Size(1202, 39);
            routeLocationTextBox2.TabIndex = 23;
            // 
            // routePriceTextBox2
            // 
            routePriceTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routePriceTextBox2.Location = new Point(426, 175);
            routePriceTextBox2.Name = "routePriceTextBox2";
            routePriceTextBox2.Size = new Size(1202, 39);
            routePriceTextBox2.TabIndex = 22;
            // 
            // routeNameTextBox2
            // 
            routeNameTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeNameTextBox2.Location = new Point(426, 72);
            routeNameTextBox2.Name = "routeNameTextBox2";
            routeNameTextBox2.Size = new Size(1202, 39);
            routeNameTextBox2.TabIndex = 21;
            // 
            // routeDescriptionLabel2
            // 
            routeDescriptionLabel2.AutoSize = true;
            routeDescriptionLabel2.Font = new Font("Segoe UI", 11F);
            routeDescriptionLabel2.ForeColor = Color.White;
            routeDescriptionLabel2.Location = new Point(426, 577);
            routeDescriptionLabel2.Name = "routeDescriptionLabel2";
            routeDescriptionLabel2.Size = new Size(307, 41);
            routeDescriptionLabel2.TabIndex = 20;
            routeDescriptionLabel2.Text = "Описание маршрута:";
            // 
            // routeLevelOfTrainingLabel2
            // 
            routeLevelOfTrainingLabel2.AutoSize = true;
            routeLevelOfTrainingLabel2.Font = new Font("Segoe UI", 11F);
            routeLevelOfTrainingLabel2.ForeColor = Color.White;
            routeLevelOfTrainingLabel2.Location = new Point(426, 465);
            routeLevelOfTrainingLabel2.Name = "routeLevelOfTrainingLabel2";
            routeLevelOfTrainingLabel2.Size = new Size(716, 41);
            routeLevelOfTrainingLabel2.TabIndex = 19;
            routeLevelOfTrainingLabel2.Text = "Уровень подготовки, необходимый для маршрута:";
            // 
            // routeDurationLabel2
            // 
            routeDurationLabel2.AutoSize = true;
            routeDurationLabel2.Font = new Font("Segoe UI", 11F);
            routeDurationLabel2.ForeColor = Color.White;
            routeDurationLabel2.Location = new Point(426, 353);
            routeDurationLabel2.Name = "routeDurationLabel2";
            routeDurationLabel2.Size = new Size(360, 41);
            routeDurationLabel2.TabIndex = 18;
            routeDurationLabel2.Text = "Длительность маршрута:";
            // 
            // routeLocationLabel2
            // 
            routeLocationLabel2.AutoSize = true;
            routeLocationLabel2.Font = new Font("Segoe UI", 11F);
            routeLocationLabel2.ForeColor = Color.White;
            routeLocationLabel2.Location = new Point(426, 234);
            routeLocationLabel2.Name = "routeLocationLabel2";
            routeLocationLabel2.Size = new Size(374, 41);
            routeLocationLabel2.TabIndex = 17;
            routeLocationLabel2.Text = "Расположение маршрута:";
            // 
            // routePriceLabel2
            // 
            routePriceLabel2.AutoSize = true;
            routePriceLabel2.Font = new Font("Segoe UI", 11F);
            routePriceLabel2.ForeColor = Color.White;
            routePriceLabel2.Location = new Point(426, 131);
            routePriceLabel2.Name = "routePriceLabel2";
            routePriceLabel2.Size = new Size(317, 41);
            routePriceLabel2.TabIndex = 16;
            routePriceLabel2.Text = "Стоимость маршрута:";
            // 
            // routeNameLabel2
            // 
            routeNameLabel2.AutoSize = true;
            routeNameLabel2.Font = new Font("Segoe UI", 11F);
            routeNameLabel2.ForeColor = Color.White;
            routeNameLabel2.Location = new Point(426, 28);
            routeNameLabel2.Name = "routeNameLabel2";
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
            // routeListBoxLabel
            // 
            routeListBoxLabel.AutoSize = true;
            routeListBoxLabel.BackColor = Color.FromArgb(59, 102, 118);
            routeListBoxLabel.Font = new Font("Segoe UI", 11F);
            routeListBoxLabel.ForeColor = Color.White;
            routeListBoxLabel.Location = new Point(26, 18);
            routeListBoxLabel.Name = "routeListBoxLabel";
            routeListBoxLabel.Size = new Size(283, 41);
            routeListBoxLabel.TabIndex = 1;
            routeListBoxLabel.Text = "Список маршрутов";
            // 
            // routesListBox
            // 
            routesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            routesListBox.FormattingEnabled = true;
            routesListBox.Location = new Point(35, 113);
            routesListBox.Name = "routesListBox";
            routesListBox.Size = new Size(344, 1220);
            routesListBox.TabIndex = 0;
            routesListBox.SelectedIndexChanged += routesListBox_SelectedIndexChanged;
            // 
            // routePictureBox2
            // 
            routePictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            routePictureBox2.BackColor = Color.White;
            routePictureBox2.Location = new Point(426, 938);
            routePictureBox2.Name = "routePictureBox2";
            routePictureBox2.Size = new Size(403, 400);
            routePictureBox2.TabIndex = 27;
            routePictureBox2.TabStop = false;
            // 
            // AdministratorForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 136, 158);
            ClientSize = new Size(1700, 1552);
            Controls.Add(administratorsTabControl);
            Name = "AdministratorForm";
            Text = "Управление маршрутами";
            administratorsTabControl.ResumeLayout(false);
            addRouteTabPage.ResumeLayout(false);
            addRouteTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)routePictureBox).EndInit();
            updateRouteTabPage.ResumeLayout(false);
            updateRouteTabPage.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)routePictureBox2).EndInit();
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
        private CheckedListBox checkedListBox1;
        private Label label1;
        private Label label2;
        private CheckedListBox checkedListBox2;
        private Button pictureLoadButton;
        private Button addNewRouteButton;
        private Button pictureLoadButton2;
        private PictureBox routePictureBox2;
    }
}