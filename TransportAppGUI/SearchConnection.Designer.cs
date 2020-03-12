namespace TransportAppGUI
{
    partial class fSearchConnection
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvConnections = new System.Windows.Forms.ListView();
            this.cDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAbfahrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cArriveTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTravelTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnSwitchStation = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbStationEnd = new TransportAppGUI.DropDownComboBox();
            this.cbStationFrom = new TransportAppGUI.DropDownComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verbindungen suchen";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(285, 165);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(204, 58);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lvConnections
            // 
            this.lvConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cDateTime,
            this.cAbfahrt,
            this.cFrom,
            this.cTo,
            this.cArriveTime,
            this.cTravelTime,
            this.cLine});
            this.lvConnections.HideSelection = false;
            this.lvConnections.Location = new System.Drawing.Point(12, 275);
            this.lvConnections.Name = "lvConnections";
            this.lvConnections.Size = new System.Drawing.Size(760, 274);
            this.lvConnections.TabIndex = 8;
            this.lvConnections.UseCompatibleStateImageBehavior = false;
            this.lvConnections.View = System.Windows.Forms.View.Details;
            // 
            // cDateTime
            // 
            this.cDateTime.Text = "Datum/Uhrzeit";
            this.cDateTime.Width = 110;
            // 
            // cAbfahrt
            // 
            this.cAbfahrt.Text = "Abfahrt";
            this.cAbfahrt.Width = 80;
            // 
            // cFrom
            // 
            this.cFrom.Text = "Von";
            this.cFrom.Width = 80;
            // 
            // cTo
            // 
            this.cTo.Text = "To";
            this.cTo.Width = 80;
            // 
            // cArriveTime
            // 
            this.cArriveTime.Text = "Ankunft";
            this.cArriveTime.Width = 80;
            // 
            // cTravelTime
            // 
            this.cTravelTime.Text = "Reisezeit";
            this.cTravelTime.Width = 80;
            // 
            // cLine
            // 
            this.cLine.Text = "Linie";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(184, 229);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(104, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(483, 229);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(54, 20);
            this.dtpTime.TabIndex = 6;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(89, 65);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(29, 13);
            this.lblFrom.TabIndex = 11;
            this.lblFrom.Text = "Von:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(480, 65);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(36, 13);
            this.lblTo.TabIndex = 12;
            this.lblTo.Text = "Nach:";
            // 
            // btnSendMail
            // 
            this.btnSendMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMail.Location = new System.Drawing.Point(579, 214);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(193, 55);
            this.btnSendMail.TabIndex = 7;
            this.btnSendMail.Text = "Mail senden";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.BtnSendMail_Click);
            // 
            // btnSwitchStation
            // 
            this.btnSwitchStation.Location = new System.Drawing.Point(336, 73);
            this.btnSwitchStation.Name = "btnSwitchStation";
            this.btnSwitchStation.Size = new System.Drawing.Size(105, 40);
            this.btnSwitchStation.TabIndex = 3;
            this.btnSwitchStation.Text = "-->\r\n<--";
            this.btnSwitchStation.UseVisualStyleBackColor = true;
            this.btnSwitchStation.Click += new System.EventHandler(this.BtnSwitchStation_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "abbrechen";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // cbStationEnd
            // 
            this.cbStationEnd.FormattingEnabled = true;
            this.cbStationEnd.Location = new System.Drawing.Point(480, 84);
            this.cbStationEnd.Name = "cbStationEnd";
            this.cbStationEnd.Size = new System.Drawing.Size(199, 21);
            this.cbStationEnd.TabIndex = 2;
            this.cbStationEnd.TextUpdate += new System.EventHandler(this.CbStationEnd_TextUpdate);
            // 
            // cbStationFrom
            // 
            this.cbStationFrom.FormattingEnabled = true;
            this.cbStationFrom.Location = new System.Drawing.Point(89, 84);
            this.cbStationFrom.Name = "cbStationFrom";
            this.cbStationFrom.Size = new System.Drawing.Size(199, 21);
            this.cbStationFrom.TabIndex = 1;
            this.cbStationFrom.TextUpdate += new System.EventHandler(this.CbStationFrom_TextUpdate);
            // 
            // fSearchConnection
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSwitchStation);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.cbStationEnd);
            this.Controls.Add(this.cbStationFrom);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lvConnections);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "fSearchConnection";
            this.Text = "SearchConnection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvConnections;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.ColumnHeader cDateTime;
        private System.Windows.Forms.ColumnHeader cAbfahrt;
        private System.Windows.Forms.ColumnHeader cFrom;
        private System.Windows.Forms.ColumnHeader cTo;
        private System.Windows.Forms.ColumnHeader cArriveTime;
        private System.Windows.Forms.ColumnHeader cTravelTime;
        private System.Windows.Forms.ColumnHeader cLine;
        private DropDownComboBox cbStationFrom;
        private DropDownComboBox cbStationEnd;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnSwitchStation;
        private System.Windows.Forms.Button btnBack;
    }
}