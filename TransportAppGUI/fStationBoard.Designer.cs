namespace TransportAppGUI
{
    partial class fStationBoard
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
            this.lblStationBoard = new System.Windows.Forms.Label();
            this.btnSearchStation = new System.Windows.Forms.Button();
            this.lvStationBoard = new System.Windows.Forms.ListView();
            this.cDepatureTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cToStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbStation = new TransportAppGUI.DropDownComboBox();
            this.lblStation = new System.Windows.Forms.Label();
            this.btnShowMap = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStationBoard
            // 
            this.lblStationBoard.AutoSize = true;
            this.lblStationBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationBoard.Location = new System.Drawing.Point(164, 32);
            this.lblStationBoard.Name = "lblStationBoard";
            this.lblStationBoard.Size = new System.Drawing.Size(503, 42);
            this.lblStationBoard.TabIndex = 0;
            this.lblStationBoard.Text = "Verbindungen ab ihrem Ort:";
            // 
            // btnSearchStation
            // 
            this.btnSearchStation.Location = new System.Drawing.Point(317, 159);
            this.btnSearchStation.Name = "btnSearchStation";
            this.btnSearchStation.Size = new System.Drawing.Size(178, 52);
            this.btnSearchStation.TabIndex = 3;
            this.btnSearchStation.Text = "Suchen";
            this.btnSearchStation.UseVisualStyleBackColor = true;
            this.btnSearchStation.Click += new System.EventHandler(this.BtnSearchStation_Click);
            // 
            // lvStationBoard
            // 
            this.lvStationBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvStationBoard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cDepatureTime,
            this.cToStation,
            this.cLine});
            this.lvStationBoard.HideSelection = false;
            this.lvStationBoard.Location = new System.Drawing.Point(13, 261);
            this.lvStationBoard.Name = "lvStationBoard";
            this.lvStationBoard.Size = new System.Drawing.Size(775, 288);
            this.lvStationBoard.TabIndex = 4;
            this.lvStationBoard.UseCompatibleStateImageBehavior = false;
            this.lvStationBoard.View = System.Windows.Forms.View.Details;
            // 
            // cDepatureTime
            // 
            this.cDepatureTime.Text = "Abfahrtszeit";
            this.cDepatureTime.Width = 120;
            // 
            // cToStation
            // 
            this.cToStation.Text = "Nach";
            this.cToStation.Width = 150;
            // 
            // cLine
            // 
            this.cLine.Text = "Linie";
            this.cLine.Width = 100;
            // 
            // cbStation
            // 
            this.cbStation.FormattingEnabled = true;
            this.cbStation.Location = new System.Drawing.Point(247, 111);
            this.cbStation.Name = "cbStation";
            this.cbStation.Size = new System.Drawing.Size(320, 21);
            this.cbStation.TabIndex = 1;
            this.cbStation.TextUpdate += new System.EventHandler(this.CbStation_TextUpdate);
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(247, 92);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(106, 13);
            this.lblStation.TabIndex = 5;
            this.lblStation.Text = "Gewünschte Station:";
            // 
            // btnShowMap
            // 
            this.btnShowMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowMap.Location = new System.Drawing.Point(599, 101);
            this.btnShowMap.Name = "btnShowMap";
            this.btnShowMap.Size = new System.Drawing.Size(116, 39);
            this.btnShowMap.TabIndex = 2;
            this.btnShowMap.Text = "Auf Karte zeigen";
            this.btnShowMap.UseVisualStyleBackColor = true;
            this.btnShowMap.Click += new System.EventHandler(this.BtnShowMap_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "abbrechen";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // fStationBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnShowMap);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.cbStation);
            this.Controls.Add(this.lvStationBoard);
            this.Controls.Add(this.btnSearchStation);
            this.Controls.Add(this.lblStationBoard);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "fStationBoard";
            this.Text = "StationBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStationBoard;
        private System.Windows.Forms.Button btnSearchStation;
        private System.Windows.Forms.ListView lvStationBoard;
        private System.Windows.Forms.ColumnHeader cDepatureTime;
        private System.Windows.Forms.ColumnHeader cToStation;
        private System.Windows.Forms.ColumnHeader cLine;
        private DropDownComboBox cbStation;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Button btnShowMap;
        private System.Windows.Forms.Button btnBack;
    }
}