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
            this.components = new System.ComponentModel.Container();
            this.landingPageTitle = new System.Windows.Forms.Label();
            this.tabNavigation = new System.Windows.Forms.TabControl();
            this.tabDepartureBoard = new System.Windows.Forms.TabPage();
            this.cmbSearchDepartures = new System.Windows.Forms.ComboBox();
            this.dgvStationBoard = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabConnections = new System.Windows.Forms.TabPage();
            this.dgvConnections = new System.Windows.Forms.DataGridView();
            this.fromLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchConnections = new System.Windows.Forms.Button();
            this.tbxToLocation = new System.Windows.Forms.TextBox();
            this.tbxFromLocation = new System.Windows.Forms.TextBox();
            this.stationBoardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNavigation.SuspendLayout();
            this.tabDepartureBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationBoard)).BeginInit();
            this.tabConnections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBoardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource1)).BeginInit();
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
            // tabNavigation
            // 
            this.tabNavigation.Controls.Add(this.tabDepartureBoard);
            this.tabNavigation.Controls.Add(this.tabConnections);
            this.tabNavigation.Location = new System.Drawing.Point(12, 66);
            this.tabNavigation.Name = "tabNavigation";
            this.tabNavigation.SelectedIndex = 0;
            this.tabNavigation.Size = new System.Drawing.Size(655, 494);
            this.tabNavigation.TabIndex = 2;
            // 
            // tabDepartureBoard
            // 
            this.tabDepartureBoard.Controls.Add(this.cmbSearchDepartures);
            this.tabDepartureBoard.Controls.Add(this.dgvStationBoard);
            this.tabDepartureBoard.Location = new System.Drawing.Point(4, 24);
            this.tabDepartureBoard.Name = "tabDepartureBoard";
            this.tabDepartureBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepartureBoard.Size = new System.Drawing.Size(647, 466);
            this.tabDepartureBoard.TabIndex = 0;
            this.tabDepartureBoard.Text = "Stationboard";
            this.tabDepartureBoard.UseVisualStyleBackColor = true;
            // 
            // cmbSearchDepartures
            // 
            this.cmbSearchDepartures.FormattingEnabled = true;
            this.cmbSearchDepartures.Location = new System.Drawing.Point(16, 14);
            this.cmbSearchDepartures.Name = "cmbSearchDepartures";
            this.cmbSearchDepartures.Size = new System.Drawing.Size(156, 23);
            this.cmbSearchDepartures.TabIndex = 3;
            this.cmbSearchDepartures.SelectedValueChanged += new System.EventHandler(this.cmbSearchDepartures_SelectedValueChanged);
            this.cmbSearchDepartures.TextChanged += new System.EventHandler(this.cmbSearchDepartures_TextChanged);
            // 
            // dgvStationBoard
            // 
            this.dgvStationBoard.AllowUserToOrderColumns = true;
            this.dgvStationBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStationBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.name1});
            this.dgvStationBoard.Location = new System.Drawing.Point(16, 43);
            this.dgvStationBoard.Name = "dgvStationBoard";
            this.dgvStationBoard.RowTemplate.Height = 25;
            this.dgvStationBoard.Size = new System.Drawing.Size(625, 417);
            this.dgvStationBoard.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "From";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // name1
            // 
            this.name1.HeaderText = "Name";
            this.name1.Name = "name1";
            // 
            // tabConnections
            // 
            this.tabConnections.Controls.Add(this.dgvConnections);
            this.tabConnections.Controls.Add(this.btnSearchConnections);
            this.tabConnections.Controls.Add(this.tbxToLocation);
            this.tabConnections.Controls.Add(this.tbxFromLocation);
            this.tabConnections.Location = new System.Drawing.Point(4, 24);
            this.tabConnections.Name = "tabConnections";
            this.tabConnections.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnections.Size = new System.Drawing.Size(647, 466);
            this.tabConnections.TabIndex = 1;
            this.tabConnections.Text = "Connections";
            this.tabConnections.UseVisualStyleBackColor = true;
            // 
            // dgvConnections
            // 
            this.dgvConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromLocation,
            this.toLocation,
            this.departure,
            this.arrival});
            this.dgvConnections.Location = new System.Drawing.Point(16, 42);
            this.dgvConnections.Name = "dgvConnections";
            this.dgvConnections.RowTemplate.Height = 25;
            this.dgvConnections.Size = new System.Drawing.Size(524, 418);
            this.dgvConnections.TabIndex = 3;
            // 
            // fromLocation
            // 
            this.fromLocation.HeaderText = "From";
            this.fromLocation.Name = "fromLocation";
            this.fromLocation.Width = 120;
            // 
            // toLocation
            // 
            this.toLocation.HeaderText = "To";
            this.toLocation.Name = "toLocation";
            this.toLocation.Width = 120;
            // 
            // departure
            // 
            this.departure.HeaderText = "Departure";
            this.departure.Name = "departure";
            this.departure.Width = 120;
            // 
            // arrival
            // 
            this.arrival.HeaderText = "Arrival";
            this.arrival.Name = "arrival";
            this.arrival.Width = 120;
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.Location = new System.Drawing.Point(334, 13);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(75, 23);
            this.btnSearchConnections.TabIndex = 2;
            this.btnSearchConnections.Text = "Search";
            this.btnSearchConnections.UseVisualStyleBackColor = true;
            this.btnSearchConnections.Click += new System.EventHandler(this.btnSearchConnections_Click);
            // 
            // tbxToLocation
            // 
            this.tbxToLocation.Location = new System.Drawing.Point(165, 13);
            this.tbxToLocation.Name = "tbxToLocation";
            this.tbxToLocation.Size = new System.Drawing.Size(145, 23);
            this.tbxToLocation.TabIndex = 1;
            // 
            // tbxFromLocation
            // 
            this.tbxFromLocation.Location = new System.Drawing.Point(16, 13);
            this.tbxFromLocation.Name = "tbxFromLocation";
            this.tbxFromLocation.Size = new System.Drawing.Size(143, 23);
            this.tbxFromLocation.TabIndex = 0;
            // 
            // stationBoardBindingSource
            // 
            this.stationBoardBindingSource.DataSource = typeof(SwissTransport.Models.StationBoard);
            // 
            // stationListBindingSource
            // 
            this.stationListBindingSource.DataMember = "StationList";
            this.stationListBindingSource.DataSource = this.stationsBindingSource;
            // 
            // stationsBindingSource
            // 
            this.stationsBindingSource.DataSource = typeof(SwissTransport.Models.Stations);
            // 
            // stationsBindingSource1
            // 
            this.stationsBindingSource1.DataSource = typeof(SwissTransport.Models.Stations);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            // 
            // number
            // 
            this.number.HeaderText = "Number";
            this.number.Name = "number";
            // 
            // to
            // 
            this.to.HeaderText = "To";
            this.to.Name = "to";
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 572);
            this.Controls.Add(this.tabNavigation);
            this.Controls.Add(this.landingPageTitle);
            this.Name = "LandingPage";
            this.Text = "Swiss Connections";
            this.tabNavigation.ResumeLayout(false);
            this.tabDepartureBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationBoard)).EndInit();
            this.tabConnections.ResumeLayout(false);
            this.tabConnections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBoardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label landingPageTitle;
        private TabControl tabNavigation;
        private TabPage tabDepartureBoard;
        private TabPage tabConnections;
        private BindingSource stationsBindingSource;
        private BindingSource stationListBindingSource;
        private DataGridView dgvStationBoard;
        private BindingSource stationBoardBindingSource;
        private BindingSource stationsBindingSource1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn to;
        private Button btnSearchConnections;
        private TextBox tbxToLocation;
        private TextBox tbxFromLocation;
        private DataGridView dgvConnections;
        private ComboBox cmbSearchDepartures;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn name1;
        private DataGridViewTextBoxColumn fromLocation;
        private DataGridViewTextBoxColumn toLocation;
        private DataGridViewTextBoxColumn departure;
        private DataGridViewTextBoxColumn arrival;
    }

}