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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 247, 233);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(1418, 892);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(listBox1);
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(1418, 810);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.FromArgb(96, 118, 85);
            label1.Location = new Point(500, 17);
            label1.Name = "label1";
            label1.Size = new Size(384, 47);
            label1.TabIndex = 0;
            label1.Text = "Список рекомендаций";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1418, 804);
            listBox1.TabIndex = 0;
            // 
            // RecommendationsListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 118, 85);
            ClientSize = new Size(1414, 953);
            Controls.Add(panel1);
            Name = "RecommendationsListForm";
            Text = "Список рекомендаций";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ListBox listBox1;
    }
}