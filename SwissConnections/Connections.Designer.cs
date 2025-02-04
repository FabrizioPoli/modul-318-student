﻿namespace SwissConnections
{
    partial class swissConnections
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
            this.btnSearchStations = new System.Windows.Forms.Button();
            this.cmbSearchDepartures = new System.Windows.Forms.ComboBox();
            this.dgvStationBoard = new System.Windows.Forms.DataGridView();
            this.fromStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabConnections = new System.Windows.Forms.TabPage();
            this.btnSwitchLocations = new System.Windows.Forms.Button();
            this.dtpTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dtpConnectionDate = new System.Windows.Forms.DateTimePicker();
            this.cmbFromLocation = new System.Windows.Forms.ComboBox();
            this.cmbToLocation = new System.Windows.Forms.ComboBox();
            this.dgvConnections = new System.Windows.Forms.DataGridView();
            this.fromLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchConnections = new System.Windows.Forms.Button();
            this.stationBoardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShareConnections = new System.Windows.Forms.Button();
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
            this.tabDepartureBoard.Controls.Add(this.btnSearchStations);
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
            // btnSearchStations
            // 
            this.btnSearchStations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchStations.Location = new System.Drawing.Point(187, 14);
            this.btnSearchStations.Name = "btnSearchStations";
            this.btnSearchStations.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStations.TabIndex = 4;
            this.btnSearchStations.Text = "Search";
            this.btnSearchStations.UseVisualStyleBackColor = true;
            this.btnSearchStations.Click += new System.EventHandler(this.btnSearchStations_Click);
            // 
            // cmbSearchDepartures
            // 
            this.cmbSearchDepartures.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSearchDepartures.CausesValidation = false;
            this.cmbSearchDepartures.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSearchDepartures.FormattingEnabled = true;
            this.cmbSearchDepartures.Location = new System.Drawing.Point(16, 14);
            this.cmbSearchDepartures.Name = "cmbSearchDepartures";
            this.cmbSearchDepartures.Size = new System.Drawing.Size(156, 23);
            this.cmbSearchDepartures.TabIndex = 3;
            this.cmbSearchDepartures.Text = "From";
            this.cmbSearchDepartures.Click += new System.EventHandler(this.cmbSearchDepartures_Click);
            // 
            // dgvStationBoard
            // 
            this.dgvStationBoard.AllowUserToOrderColumns = true;
            this.dgvStationBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStationBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromStation,
            this.toStation,
            this.dataGridViewTextBoxColumn1});
            this.dgvStationBoard.Location = new System.Drawing.Point(16, 55);
            this.dgvStationBoard.Name = "dgvStationBoard";
            this.dgvStationBoard.RowTemplate.Height = 25;
            this.dgvStationBoard.Size = new System.Drawing.Size(424, 395);
            this.dgvStationBoard.TabIndex = 2;
            // 
            // fromStation
            // 
            this.fromStation.HeaderText = "From";
            this.fromStation.Name = "fromStation";
            this.fromStation.Width = 140;
            // 
            // toStation
            // 
            this.toStation.HeaderText = "To";
            this.toStation.Name = "toStation";
            this.toStation.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Departure";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // tabConnections
            // 
            this.tabConnections.Controls.Add(this.btnShareConnections);
            this.tabConnections.Controls.Add(this.btnSwitchLocations);
            this.tabConnections.Controls.Add(this.dtpTimePicker);
            this.tabConnections.Controls.Add(this.dtpConnectionDate);
            this.tabConnections.Controls.Add(this.cmbFromLocation);
            this.tabConnections.Controls.Add(this.cmbToLocation);
            this.tabConnections.Controls.Add(this.dgvConnections);
            this.tabConnections.Controls.Add(this.btnSearchConnections);
            this.tabConnections.Location = new System.Drawing.Point(4, 24);
            this.tabConnections.Name = "tabConnections";
            this.tabConnections.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnections.Size = new System.Drawing.Size(647, 466);
            this.tabConnections.TabIndex = 1;
            this.tabConnections.Text = "Connections";
            this.tabConnections.UseVisualStyleBackColor = true;
            // 
            // btnSwitchLocations
            // 
            this.btnSwitchLocations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSwitchLocations.Location = new System.Drawing.Point(167, 13);
            this.btnSwitchLocations.Name = "btnSwitchLocations";
            this.btnSwitchLocations.Size = new System.Drawing.Size(47, 23);
            this.btnSwitchLocations.TabIndex = 9;
            this.btnSwitchLocations.Text = "<-->";
            this.btnSwitchLocations.UseVisualStyleBackColor = true;
            this.btnSwitchLocations.Click += new System.EventHandler(this.btnSwitchLocations_Click);
            // 
            // dtpTimePicker
            // 
            this.dtpTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimePicker.Location = new System.Drawing.Point(131, 53);
            this.dtpTimePicker.Name = "dtpTimePicker";
            this.dtpTimePicker.Size = new System.Drawing.Size(81, 23);
            this.dtpTimePicker.TabIndex = 8;
            // 
            // dtpConnectionDate
            // 
            this.dtpConnectionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpConnectionDate.Location = new System.Drawing.Point(16, 53);
            this.dtpConnectionDate.Name = "dtpConnectionDate";
            this.dtpConnectionDate.Size = new System.Drawing.Size(97, 23);
            this.dtpConnectionDate.TabIndex = 6;
            // 
            // cmbFromLocation
            // 
            this.cmbFromLocation.FormattingEnabled = true;
            this.cmbFromLocation.Location = new System.Drawing.Point(16, 13);
            this.cmbFromLocation.Name = "cmbFromLocation";
            this.cmbFromLocation.Size = new System.Drawing.Size(145, 23);
            this.cmbFromLocation.TabIndex = 5;
            this.cmbFromLocation.Text = "From";
            this.cmbFromLocation.Click += new System.EventHandler(this.cmbFromLocation_Click);
            // 
            // cmbToLocation
            // 
            this.cmbToLocation.FormattingEnabled = true;
            this.cmbToLocation.Location = new System.Drawing.Point(220, 14);
            this.cmbToLocation.Name = "cmbToLocation";
            this.cmbToLocation.Size = new System.Drawing.Size(161, 23);
            this.cmbToLocation.TabIndex = 4;
            this.cmbToLocation.Text = "To";
            this.cmbToLocation.Click += new System.EventHandler(this.cmbToLocation_Click);
            // 
            // dgvConnections
            // 
            this.dgvConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromLocation,
            this.toLocation,
            this.departure,
            this.arrival});
            this.dgvConnections.Location = new System.Drawing.Point(16, 114);
            this.dgvConnections.Name = "dgvConnections";
            this.dgvConnections.RowTemplate.Height = 25;
            this.dgvConnections.Size = new System.Drawing.Size(524, 151);
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
            this.btnSearchConnections.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchConnections.Location = new System.Drawing.Point(387, 13);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(75, 23);
            this.btnSearchConnections.TabIndex = 2;
            this.btnSearchConnections.Text = "Search";
            this.btnSearchConnections.UseVisualStyleBackColor = true;
            this.btnSearchConnections.Click += new System.EventHandler(this.btnSearchConnections_Click);
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
            // btnShareConnections
            // 
            this.btnShareConnections.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShareConnections.Location = new System.Drawing.Point(556, 14);
            this.btnShareConnections.Name = "btnShareConnections";
            this.btnShareConnections.Size = new System.Drawing.Size(75, 23);
            this.btnShareConnections.TabIndex = 10;
            this.btnShareConnections.Text = "Share";
            this.btnShareConnections.UseVisualStyleBackColor = true;
            this.btnShareConnections.Click += new System.EventHandler(this.btnShareConnections_Click);
            // 
            // swissConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 572);
            this.Controls.Add(this.tabNavigation);
            this.Controls.Add(this.landingPageTitle);
            this.Name = "swissConnections";
            this.Text = "Swiss Connections";
            this.tabNavigation.ResumeLayout(false);
            this.tabDepartureBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationBoard)).EndInit();
            this.tabConnections.ResumeLayout(false);
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
        private DataGridView dgvConnections;
        private ComboBox cmbSearchDepartures;
        private DataGridViewTextBoxColumn fromLocation;
        private DataGridViewTextBoxColumn toLocation;
        private DataGridViewTextBoxColumn departure;
        private DataGridViewTextBoxColumn arrival;
        private ComboBox cmbFromLocation;
        private ComboBox cmbToLocation;
        private DateTimePicker dtpConnectionDate;
        private DateTimePicker dtpTimePicker;
        private Button btnSearchStations;
        private Button btnSwitchLocations;
        private DataGridViewTextBoxColumn fromStation;
        private DataGridViewTextBoxColumn toStation;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btnShareConnections;
    }

}