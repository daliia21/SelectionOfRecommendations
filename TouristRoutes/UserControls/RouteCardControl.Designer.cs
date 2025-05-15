namespace TouristRoutes
{
    partial class RouteCardControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            routeDescriptionRichTextBox = new RichTextBox();
            panel1 = new Panel();
            routeNameLabel = new Label();
            routePriceLabel = new Label();
            routeDurationLabel = new Label();
            routeLocationLabel = new Label();
            routeLevelOfTrainingLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(217, 217, 217);
            pictureBox1.Location = new Point(48, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 355);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // routeDescriptionRichTextBox
            // 
            routeDescriptionRichTextBox.BackColor = Color.FromArgb(217, 217, 217);
            routeDescriptionRichTextBox.Enabled = false;
            routeDescriptionRichTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            routeDescriptionRichTextBox.Location = new Point(582, 260);
            routeDescriptionRichTextBox.Name = "routeDescriptionRichTextBox";
            routeDescriptionRichTextBox.ReadOnly = true;
            routeDescriptionRichTextBox.Size = new Size(1209, 143);
            routeDescriptionRichTextBox.TabIndex = 2;
            routeDescriptionRichTextBox.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 217, 217);
            panel1.Controls.Add(routeNameLabel);
            panel1.Location = new Point(582, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(1209, 41);
            panel1.TabIndex = 1;
            // 
            // routeNameLabel
            // 
            routeNameLabel.AutoSize = true;
            routeNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            routeNameLabel.Location = new Point(415, 1);
            routeNameLabel.Name = "routeNameLabel";
            routeNameLabel.Size = new Size(124, 32);
            routeNameLabel.TabIndex = 3;
            routeNameLabel.Text = "название";
            // 
            // routePriceLabel
            // 
            routePriceLabel.AutoSize = true;
            routePriceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            routePriceLabel.Location = new Point(582, 126);
            routePriceLabel.Name = "routePriceLabel";
            routePriceLabel.Size = new Size(137, 32);
            routePriceLabel.TabIndex = 3;
            routePriceLabel.Text = "стоимость";
            // 
            // routeDurationLabel
            // 
            routeDurationLabel.AutoSize = true;
            routeDurationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            routeDurationLabel.Location = new Point(582, 197);
            routeDurationLabel.Name = "routeDurationLabel";
            routeDurationLabel.Size = new Size(255, 32);
            routeDurationLabel.TabIndex = 4;
            routeDurationLabel.Text = "продолжительность";
            // 
            // routeLocationLabel
            // 
            routeLocationLabel.AutoSize = true;
            routeLocationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            routeLocationLabel.Location = new Point(1235, 126);
            routeLocationLabel.Name = "routeLocationLabel";
            routeLocationLabel.Size = new Size(189, 32);
            routeLocationLabel.TabIndex = 5;
            routeLocationLabel.Text = "расположение";
            // 
            // routeLevelOfTrainingLabel
            // 
            routeLevelOfTrainingLabel.AutoSize = true;
            routeLevelOfTrainingLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            routeLevelOfTrainingLabel.Location = new Point(1235, 197);
            routeLevelOfTrainingLabel.Name = "routeLevelOfTrainingLabel";
            routeLevelOfTrainingLabel.Size = new Size(257, 32);
            routeLevelOfTrainingLabel.TabIndex = 6;
            routeLevelOfTrainingLabel.Text = "уровень подготовки";
            // 
            // RouteCardControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 173, 144);
            Controls.Add(routeLevelOfTrainingLabel);
            Controls.Add(routeLocationLabel);
            Controls.Add(routeDurationLabel);
            Controls.Add(routePriceLabel);
            Controls.Add(routeDescriptionRichTextBox);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "RouteCardControl";
            Size = new Size(1876, 428);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private RichTextBox routeDescriptionRichTextBox;
        private Panel panel1;
        private Label routeNameLabel;
        private Label routePriceLabel;
        private Label routeDurationLabel;
        private Label routeLocationLabel;
        private Label routeLevelOfTrainingLabel;
    }
}
