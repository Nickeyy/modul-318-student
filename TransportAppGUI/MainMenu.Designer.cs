namespace TransportAppGUI
{
    partial class MainMenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOption = new System.Windows.Forms.Label();
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.btnSearchStation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption.Location = new System.Drawing.Point(116, 23);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(450, 46);
            this.lblOption.TabIndex = 0;
            this.lblOption.Text = "Wählen Sie eine Option:";
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchConnection.Location = new System.Drawing.Point(124, 163);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(175, 72);
            this.btnSearchConnection.TabIndex = 1;
            this.btnSearchConnection.Text = "Verbindung Suchen";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.BtnSearchConnection_Click);
            // 
            // btnSearchStation
            // 
            this.btnSearchStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStation.Location = new System.Drawing.Point(391, 163);
            this.btnSearchStation.Name = "btnSearchStation";
            this.btnSearchStation.Size = new System.Drawing.Size(175, 72);
            this.btnSearchStation.TabIndex = 2;
            this.btnSearchStation.Text = "Stationstaffel";
            this.btnSearchStation.UseVisualStyleBackColor = true;
            this.btnSearchStation.Click += new System.EventHandler(this.BtnSearchStation_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 372);
            this.Controls.Add(this.btnSearchStation);
            this.Controls.Add(this.btnSearchConnection);
            this.Controls.Add(this.lblOption);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainMenu";
            this.Text = "TransportApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.Button btnSearchConnection;
        private System.Windows.Forms.Button btnSearchStation;
    }
}

