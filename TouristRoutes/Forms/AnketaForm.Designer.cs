namespace TouristRoutes.Forms
{
    partial class AnketaForm
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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ageGroupBox = new GroupBox();
            durationGroupBox = new GroupBox();
            locationGroupBox = new GroupBox();
            seasonGroupBox = new GroupBox();
            levelOfTrainingGroupBox = new GroupBox();
            purposeGroupBox = new GroupBox();
            budgetGroupBox = new GroupBox();
            typeOfTourismGroupBox = new GroupBox();
            savedAnketaButton = new Button();
            label2 = new Label();
            panel2 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoScrollMinSize = new Size(25, 5);
            panel1.AutoSize = true;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(savedAnketaButton);
            panel1.Location = new Point(-4, -452);
            panel1.Name = "panel1";
            panel1.Size = new Size(1608, 2642);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(ageGroupBox);
            flowLayoutPanel1.Controls.Add(durationGroupBox);
            flowLayoutPanel1.Controls.Add(locationGroupBox);
            flowLayoutPanel1.Controls.Add(seasonGroupBox);
            flowLayoutPanel1.Controls.Add(levelOfTrainingGroupBox);
            flowLayoutPanel1.Controls.Add(purposeGroupBox);
            flowLayoutPanel1.Controls.Add(budgetGroupBox);
            flowLayoutPanel1.Controls.Add(typeOfTourismGroupBox);
            flowLayoutPanel1.Location = new Point(392, 539);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(851, 1776);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // ageGroupBox
            // 
            ageGroupBox.ForeColor = Color.White;
            ageGroupBox.Location = new Point(3, 3);
            ageGroupBox.Name = "ageGroupBox";
            ageGroupBox.Size = new Size(824, 254);
            ageGroupBox.TabIndex = 2;
            ageGroupBox.TabStop = false;
            ageGroupBox.Text = "Возраст";
            // 
            // durationGroupBox
            // 
            durationGroupBox.ForeColor = Color.White;
            durationGroupBox.Location = new Point(3, 263);
            durationGroupBox.Name = "durationGroupBox";
            durationGroupBox.Size = new Size(824, 178);
            durationGroupBox.TabIndex = 5;
            durationGroupBox.TabStop = false;
            durationGroupBox.Text = "Предпочтительная длительность поездки:";
            // 
            // locationGroupBox
            // 
            locationGroupBox.ForeColor = Color.White;
            locationGroupBox.Location = new Point(3, 447);
            locationGroupBox.Name = "locationGroupBox";
            locationGroupBox.Size = new Size(824, 261);
            locationGroupBox.TabIndex = 6;
            locationGroupBox.TabStop = false;
            locationGroupBox.Text = "Куда чаще всего ездите?";
            // 
            // seasonGroupBox
            // 
            seasonGroupBox.ForeColor = Color.White;
            seasonGroupBox.Location = new Point(3, 714);
            seasonGroupBox.Name = "seasonGroupBox";
            seasonGroupBox.Size = new Size(824, 220);
            seasonGroupBox.TabIndex = 7;
            seasonGroupBox.TabStop = false;
            seasonGroupBox.Text = "В какой сезон хотите путешествовать? (можно выбрать несколько):";
            // 
            // levelOfTrainingGroupBox
            // 
            levelOfTrainingGroupBox.ForeColor = Color.White;
            levelOfTrainingGroupBox.Location = new Point(3, 940);
            levelOfTrainingGroupBox.Name = "levelOfTrainingGroupBox";
            levelOfTrainingGroupBox.Size = new Size(824, 179);
            levelOfTrainingGroupBox.TabIndex = 8;
            levelOfTrainingGroupBox.TabStop = false;
            levelOfTrainingGroupBox.Text = "Уровень подготовки:";
            // 
            // purposeGroupBox
            // 
            purposeGroupBox.ForeColor = Color.White;
            purposeGroupBox.Location = new Point(3, 1125);
            purposeGroupBox.Name = "purposeGroupBox";
            purposeGroupBox.Size = new Size(824, 179);
            purposeGroupBox.TabIndex = 9;
            purposeGroupBox.TabStop = false;
            purposeGroupBox.Text = "Какова цель вашей поездки?";
            // 
            // budgetGroupBox
            // 
            budgetGroupBox.ForeColor = Color.White;
            budgetGroupBox.Location = new Point(3, 1310);
            budgetGroupBox.Name = "budgetGroupBox";
            budgetGroupBox.Size = new Size(824, 185);
            budgetGroupBox.TabIndex = 4;
            budgetGroupBox.TabStop = false;
            budgetGroupBox.Text = "Какой бюджет на поездку (на человека)?";
            // 
            // typeOfTourismGroupBox
            // 
            typeOfTourismGroupBox.ForeColor = Color.White;
            typeOfTourismGroupBox.Location = new Point(3, 1501);
            typeOfTourismGroupBox.Name = "typeOfTourismGroupBox";
            typeOfTourismGroupBox.Size = new Size(824, 269);
            typeOfTourismGroupBox.TabIndex = 3;
            typeOfTourismGroupBox.TabStop = false;
            typeOfTourismGroupBox.Text = "Какой вид туризма вам ближе? (можно выбрать несколько):";
            // 
            // savedAnketaButton
            // 
            savedAnketaButton.BackColor = Color.FromArgb(75, 136, 158);
            savedAnketaButton.Font = new Font("Segoe UI", 13F);
            savedAnketaButton.ForeColor = Color.White;
            savedAnketaButton.Location = new Point(615, 2386);
            savedAnketaButton.Name = "savedAnketaButton";
            savedAnketaButton.Size = new Size(332, 66);
            savedAnketaButton.TabIndex = 10;
            savedAnketaButton.Text = "ЗАВЕРШИТЬ";
            savedAnketaButton.UseVisualStyleBackColor = false;
            savedAnketaButton.Click += savedAnketaButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(330, 19);
            label2.Name = "label2";
            label2.Size = new Size(984, 41);
            label2.TabIndex = 1;
            label2.Text = "Заполните анкету, чтобы мы могли подобрать для вас рекомендации!";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(59, 102, 118);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1966, 72);
            panel2.TabIndex = 2;
            // 
            // AnketaForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(75, 136, 158);
            ClientSize = new Size(1599, 1469);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AnketaForm";
            Text = "AnketaForm";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button savedAnketaButton;
        private Label label2;
        private Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox ageGroupBox;
        private GroupBox typeOfTourismGroupBox;
        private GroupBox budgetGroupBox;
        private GroupBox durationGroupBox;
        private GroupBox locationGroupBox;
        private GroupBox seasonGroupBox;
        private GroupBox levelOfTrainingGroupBox;
        private GroupBox purposeGroupBox;
    }
}