namespace TouristRoutes.Forms
{
    partial class FavoriteRoutesForm
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
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 247, 233);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(2, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(1882, 1117);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.FromArgb(96, 118, 85);
            label1.Location = new Point(811, 16);
            label1.Name = "label1";
            label1.Size = new Size(200, 47);
            label1.TabIndex = 1;
            label1.Text = "Избранное";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(96, 118, 85);
            flowLayoutPanel1.Location = new Point(0, 84);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1876, 913);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(75, 136, 158);
            button1.Location = new Point(1515, 1027);
            button1.Name = "button1";
            button1.Size = new Size(325, 59);
            button1.TabIndex = 2;
            button1.Text = "УБРАТЬ ИЗ ИЗБРАННОГО";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FavoriteRoutesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 118, 85);
            ClientSize = new Size(1877, 1194);
            Controls.Add(panel1);
            Name = "FavoriteRoutesForm";
            Text = "FavoriteRoutesForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Button button1;
    }
}