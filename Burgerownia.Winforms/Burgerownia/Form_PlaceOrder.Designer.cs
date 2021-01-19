
namespace Burgerownia.Winforms
{
    partial class Form_PlaceOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PlaceOrder));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.pictureBox_burgerOfADay = new System.Windows.Forms.PictureBox();
            this.pictureBox_burgersIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox_dolarSignIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox_refreshmentsIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox_YourOrder = new System.Windows.Forms.PictureBox();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.tableLayoutPanel.SuspendLayout();
            this.panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_burgerOfADay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_burgersIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dolarSignIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_refreshmentsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_YourOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.66845F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.33155F));
            this.tableLayoutPanel.Controls.Add(this.panel_Left, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pictureBox_YourOrder, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panel_Right, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 648);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // panel_Left
            // 
            this.panel_Left.Controls.Add(this.pictureBox_burgerOfADay);
            this.panel_Left.Controls.Add(this.pictureBox_burgersIcon);
            this.panel_Left.Controls.Add(this.pictureBox_dolarSignIcon);
            this.panel_Left.Controls.Add(this.pictureBox_refreshmentsIcon);
            this.panel_Left.Location = new System.Drawing.Point(3, 125);
            this.panel_Left.Name = "panel_Left";
            this.tableLayoutPanel.SetRowSpan(this.panel_Left, 2);
            this.panel_Left.Size = new System.Drawing.Size(199, 523);
            this.panel_Left.TabIndex = 3;
            // 
            // pictureBox_burgerOfADay
            // 
            this.pictureBox_burgerOfADay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_burgerOfADay.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_burgerOfADay.Image")));
            this.pictureBox_burgerOfADay.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_burgerOfADay.Name = "pictureBox_burgerOfADay";
            this.pictureBox_burgerOfADay.Size = new System.Drawing.Size(200, 109);
            this.pictureBox_burgerOfADay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_burgerOfADay.TabIndex = 3;
            this.pictureBox_burgerOfADay.TabStop = false;
            // 
            // pictureBox_burgersIcon
            // 
            this.pictureBox_burgersIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_burgersIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_burgersIcon.Image")));
            this.pictureBox_burgersIcon.Location = new System.Drawing.Point(0, 136);
            this.pictureBox_burgersIcon.Name = "pictureBox_burgersIcon";
            this.pictureBox_burgersIcon.Size = new System.Drawing.Size(200, 109);
            this.pictureBox_burgersIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_burgersIcon.TabIndex = 0;
            this.pictureBox_burgersIcon.TabStop = false;
            // 
            // pictureBox_dolarSignIcon
            // 
            this.pictureBox_dolarSignIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_dolarSignIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_dolarSignIcon.Image")));
            this.pictureBox_dolarSignIcon.Location = new System.Drawing.Point(0, 417);
            this.pictureBox_dolarSignIcon.Name = "pictureBox_dolarSignIcon";
            this.pictureBox_dolarSignIcon.Size = new System.Drawing.Size(200, 109);
            this.pictureBox_dolarSignIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_dolarSignIcon.TabIndex = 2;
            this.pictureBox_dolarSignIcon.TabStop = false;
            // 
            // pictureBox_refreshmentsIcon
            // 
            this.pictureBox_refreshmentsIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_refreshmentsIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_refreshmentsIcon.Image")));
            this.pictureBox_refreshmentsIcon.Location = new System.Drawing.Point(0, 278);
            this.pictureBox_refreshmentsIcon.Name = "pictureBox_refreshmentsIcon";
            this.pictureBox_refreshmentsIcon.Size = new System.Drawing.Size(200, 109);
            this.pictureBox_refreshmentsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_refreshmentsIcon.TabIndex = 1;
            this.pictureBox_refreshmentsIcon.TabStop = false;
            // 
            // pictureBox_YourOrder
            // 
            this.pictureBox_YourOrder.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_YourOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel.SetColumnSpan(this.pictureBox_YourOrder, 2);
            this.pictureBox_YourOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_YourOrder.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_YourOrder.Image")));
            this.pictureBox_YourOrder.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_YourOrder.MaximumSize = new System.Drawing.Size(8800, 4000);
            this.pictureBox_YourOrder.Name = "pictureBox_YourOrder";
            this.pictureBox_YourOrder.Size = new System.Drawing.Size(794, 116);
            this.pictureBox_YourOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_YourOrder.TabIndex = 1;
            this.pictureBox_YourOrder.TabStop = false;
            // 
            // panel_Right
            // 
            this.panel_Right.AutoScroll = true;
            this.panel_Right.BackColor = System.Drawing.Color.Transparent;
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Right.Location = new System.Drawing.Point(208, 125);
            this.panel_Right.Name = "panel_Right";
            this.tableLayoutPanel.SetRowSpan(this.panel_Right, 2);
            this.panel_Right.Size = new System.Drawing.Size(589, 523);
            this.panel_Right.TabIndex = 2;
            // 
            // Form_PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form_PlaceOrder";
            this.Text = "Here";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel.ResumeLayout(false);
            this.panel_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_burgerOfADay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_burgersIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dolarSignIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_refreshmentsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_YourOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBox_YourOrder;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.PictureBox pictureBox_dolarSignIcon;
        private System.Windows.Forms.PictureBox pictureBox_refreshmentsIcon;
        private System.Windows.Forms.PictureBox pictureBox_burgersIcon;
        private System.Windows.Forms.PictureBox pictureBox_burgerOfADay;
    }
}