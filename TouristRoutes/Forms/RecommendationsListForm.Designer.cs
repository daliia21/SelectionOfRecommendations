namespace TouristRoutes.Forms
{
    partial class RecommendationsListForm
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
            label1 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.FromArgb(96, 118, 85);
            label1.Location = new Point(704, 14);
            label1.Name = "label1";
            label1.Size = new Size(384, 47);
            label1.TabIndex = 0;
            label1.Text = "Список рекомендаций";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 247, 233);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(1882, 1117);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(75, 136, 158);
            button2.Location = new Point(1418, 1019);
            button2.Name = "button2";
            button2.Size = new Size(414, 69);
            button2.TabIndex = 3;
            button2.Text = "ДОБАВИТЬ В ИЗБРАННОЕ";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(75, 136, 158);
            button1.Location = new Point(28, 1019);
            button1.Name = "button1";
            button1.Size = new Size(414, 69);
            button1.TabIndex = 2;
            button1.Text = "УПРАВЛЕНИЕ МАРШРУТАМИ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(96, 118, 85);
            flowLayoutPanel1.Location = new Point(3, 91);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1876, 913);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // RecommendationsListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 118, 85);
            ClientSize = new Size(1877, 1194);
            Controls.Add(panel1);
            Name = "RecommendationsListForm";
            Text = "Список рекомендаций";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
    }
}