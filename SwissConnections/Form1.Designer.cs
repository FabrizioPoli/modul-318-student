namespace SwissConnections
{
    partial class LandingPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.landingPageTitle = new System.Windows.Forms.Label();
            this.tbxSearchStations = new System.Windows.Forms.TextBox();
            this.tabNavigation = new System.Windows.Forms.TabControl();
            this.tabDepartureBoard = new System.Windows.Forms.TabPage();
            this.tabConnections = new System.Windows.Forms.TabPage();
            this.btnSearchStations = new System.Windows.Forms.Button();
            this.tabNavigation.SuspendLayout();
            this.tabDepartureBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // landingPageTitle
            // 
            this.landingPageTitle.AutoSize = true;
            this.landingPageTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.landingPageTitle.Location = new System.Drawing.Point(12, 9);
            this.landingPageTitle.Name = "landingPageTitle";
            this.landingPageTitle.Size = new System.Drawing.Size(251, 37);
            this.landingPageTitle.TabIndex = 0;
            this.landingPageTitle.Text = "Swiss Connections";
            // 
            // tbxSearchStations
            // 
            this.tbxSearchStations.Location = new System.Drawing.Point(6, 6);
            this.tbxSearchStations.Name = "tbxSearchStations";
            this.tbxSearchStations.Size = new System.Drawing.Size(195, 23);
            this.tbxSearchStations.TabIndex = 1;
            this.tbxSearchStations.Text = "search stations..";
            this.tbxSearchStations.TextChanged += new System.EventHandler(this.tbxSearchField_TextChanged);
            // 
            // tabNavigation
            // 
            this.tabNavigation.Controls.Add(this.tabDepartureBoard);
            this.tabNavigation.Controls.Add(this.tabConnections);
            this.tabNavigation.Location = new System.Drawing.Point(12, 66);
            this.tabNavigation.Name = "tabNavigation";
            this.tabNavigation.SelectedIndex = 0;
            this.tabNavigation.Size = new System.Drawing.Size(580, 372);
            this.tabNavigation.TabIndex = 2;
            // 
            // tabDepartureBoard
            // 
            this.tabDepartureBoard.Controls.Add(this.btnSearchStations);
            this.tabDepartureBoard.Controls.Add(this.tbxSearchStations);
            this.tabDepartureBoard.Location = new System.Drawing.Point(4, 24);
            this.tabDepartureBoard.Name = "tabDepartureBoard";
            this.tabDepartureBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepartureBoard.Size = new System.Drawing.Size(572, 344);
            this.tabDepartureBoard.TabIndex = 0;
            this.tabDepartureBoard.Text = "Departure board";
            this.tabDepartureBoard.UseVisualStyleBackColor = true;
            // 
            // tabConnections
            // 
            this.tabConnections.Location = new System.Drawing.Point(4, 24);
            this.tabConnections.Name = "tabConnections";
            this.tabConnections.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnections.Size = new System.Drawing.Size(572, 344);
            this.tabConnections.TabIndex = 1;
            this.tabConnections.Text = "Connections";
            this.tabConnections.UseVisualStyleBackColor = true;
            // 
            // btnSearchStations
            // 
            this.btnSearchStations.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchStations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchStations.Location = new System.Drawing.Point(207, 6);
            this.btnSearchStations.Name = "btnSearchStations";
            this.btnSearchStations.Size = new System.Drawing.Size(29, 23);
            this.btnSearchStations.TabIndex = 2;
            this.btnSearchStations.UseVisualStyleBackColor = false;
            this.btnSearchStations.Click += new System.EventHandler(this.btnSearchStations_Click);
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.tabNavigation);
            this.Controls.Add(this.landingPageTitle);
            this.Name = "LandingPage";
            this.Text = "Swiss Connections";
            this.tabNavigation.ResumeLayout(false);
            this.tabDepartureBoard.ResumeLayout(false);
            this.tabDepartureBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label landingPageTitle;
        private TextBox tbxSearchStations;
        private TabControl tabNavigation;
        private TabPage tabDepartureBoard;
        private TabPage tabConnections;
        private Button btnSearchStations;
    }
}