namespace AdventureGenerator.Forms
{
    partial class MainForm
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
            this.groupBoxHome = new System.Windows.Forms.GroupBox();
            this.textBoxHomeLongitude = new System.Windows.Forms.TextBox();
            this.labelHomeLongitude = new System.Windows.Forms.Label();
            this.textBoxHomeLatitude = new System.Windows.Forms.TextBox();
            this.labelHomeLatitude = new System.Windows.Forms.Label();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelRange = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxRangeMin = new System.Windows.Forms.TextBox();
            this.labelRangeDash = new System.Windows.Forms.Label();
            this.textBoxRangeMax = new System.Windows.Forms.TextBox();
            this.comboBoxRangeUnits = new System.Windows.Forms.ComboBox();
            this.labelRange = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.buttonResultsMap = new System.Windows.Forms.Button();
            this.textBoxResultsLongitude = new System.Windows.Forms.TextBox();
            this.labelResultsLongitude = new System.Windows.Forms.Label();
            this.textBoxResultsLatitude = new System.Windows.Forms.TextBox();
            this.labelResultsLatitude = new System.Windows.Forms.Label();
            this.groupBoxHome.SuspendLayout();
            this.groupBoxParameters.SuspendLayout();
            this.tableLayoutPanelRange.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHome
            // 
            this.groupBoxHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxHome.Controls.Add(this.textBoxHomeLongitude);
            this.groupBoxHome.Controls.Add(this.labelHomeLongitude);
            this.groupBoxHome.Controls.Add(this.textBoxHomeLatitude);
            this.groupBoxHome.Controls.Add(this.labelHomeLatitude);
            this.groupBoxHome.Location = new System.Drawing.Point(12, 12);
            this.groupBoxHome.Name = "groupBoxHome";
            this.groupBoxHome.Padding = new System.Windows.Forms.Padding(10, 10, 10, 12);
            this.groupBoxHome.Size = new System.Drawing.Size(260, 87);
            this.groupBoxHome.TabIndex = 0;
            this.groupBoxHome.TabStop = false;
            this.groupBoxHome.Text = "Home";
            // 
            // textBoxHomeLongitude
            // 
            this.textBoxHomeLongitude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHomeLongitude.Location = new System.Drawing.Point(76, 52);
            this.textBoxHomeLongitude.Name = "textBoxHomeLongitude";
            this.textBoxHomeLongitude.Size = new System.Drawing.Size(171, 20);
            this.textBoxHomeLongitude.TabIndex = 3;
            // 
            // labelHomeLongitude
            // 
            this.labelHomeLongitude.AutoSize = true;
            this.labelHomeLongitude.Location = new System.Drawing.Point(13, 55);
            this.labelHomeLongitude.Name = "labelHomeLongitude";
            this.labelHomeLongitude.Size = new System.Drawing.Size(57, 13);
            this.labelHomeLongitude.TabIndex = 2;
            this.labelHomeLongitude.Text = "Longitude:";
            // 
            // textBoxHomeLatitude
            // 
            this.textBoxHomeLatitude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHomeLatitude.Location = new System.Drawing.Point(76, 26);
            this.textBoxHomeLatitude.Name = "textBoxHomeLatitude";
            this.textBoxHomeLatitude.Size = new System.Drawing.Size(171, 20);
            this.textBoxHomeLatitude.TabIndex = 1;
            // 
            // labelHomeLatitude
            // 
            this.labelHomeLatitude.AutoSize = true;
            this.labelHomeLatitude.Location = new System.Drawing.Point(13, 29);
            this.labelHomeLatitude.Name = "labelHomeLatitude";
            this.labelHomeLatitude.Size = new System.Drawing.Size(48, 13);
            this.labelHomeLatitude.TabIndex = 0;
            this.labelHomeLatitude.Text = "Latitude:";
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxParameters.Controls.Add(this.tableLayoutPanelRange);
            this.groupBoxParameters.Controls.Add(this.comboBoxRangeUnits);
            this.groupBoxParameters.Controls.Add(this.labelRange);
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 105);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Padding = new System.Windows.Forms.Padding(10, 10, 10, 12);
            this.groupBoxParameters.Size = new System.Drawing.Size(260, 61);
            this.groupBoxParameters.TabIndex = 1;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Parameters";
            // 
            // tableLayoutPanelRange
            // 
            this.tableLayoutPanelRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelRange.ColumnCount = 3;
            this.tableLayoutPanelRange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRange.Controls.Add(this.textBoxRangeMin, 0, 0);
            this.tableLayoutPanelRange.Controls.Add(this.labelRangeDash, 1, 0);
            this.tableLayoutPanelRange.Controls.Add(this.textBoxRangeMax, 2, 0);
            this.tableLayoutPanelRange.Location = new System.Drawing.Point(61, 26);
            this.tableLayoutPanelRange.Name = "tableLayoutPanelRange";
            this.tableLayoutPanelRange.RowCount = 1;
            this.tableLayoutPanelRange.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRange.Size = new System.Drawing.Size(130, 20);
            this.tableLayoutPanelRange.TabIndex = 1;
            // 
            // textBoxRangeMin
            // 
            this.textBoxRangeMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRangeMin.Location = new System.Drawing.Point(0, 0);
            this.textBoxRangeMin.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxRangeMin.Name = "textBoxRangeMin";
            this.textBoxRangeMin.Size = new System.Drawing.Size(55, 20);
            this.textBoxRangeMin.TabIndex = 0;
            // 
            // labelRangeDash
            // 
            this.labelRangeDash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRangeDash.AutoSize = true;
            this.labelRangeDash.Location = new System.Drawing.Point(60, 3);
            this.labelRangeDash.Margin = new System.Windows.Forms.Padding(0);
            this.labelRangeDash.Name = "labelRangeDash";
            this.labelRangeDash.Size = new System.Drawing.Size(10, 13);
            this.labelRangeDash.TabIndex = 1;
            this.labelRangeDash.Text = "-";
            this.labelRangeDash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRangeMax
            // 
            this.textBoxRangeMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRangeMax.Location = new System.Drawing.Point(75, 0);
            this.textBoxRangeMax.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxRangeMax.Name = "textBoxRangeMax";
            this.textBoxRangeMax.Size = new System.Drawing.Size(55, 20);
            this.textBoxRangeMax.TabIndex = 2;
            // 
            // comboBoxRangeUnits
            // 
            this.comboBoxRangeUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRangeUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRangeUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRangeUnits.FormattingEnabled = true;
            this.comboBoxRangeUnits.Items.AddRange(new object[] {
            "m",
            "km",
            "ft",
            "mi"});
            this.comboBoxRangeUnits.Location = new System.Drawing.Point(197, 26);
            this.comboBoxRangeUnits.Name = "comboBoxRangeUnits";
            this.comboBoxRangeUnits.Size = new System.Drawing.Size(50, 20);
            this.comboBoxRangeUnits.TabIndex = 2;
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(13, 29);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(42, 13);
            this.labelRange.TabIndex = 0;
            this.labelRange.Text = "Range:";
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGo.Location = new System.Drawing.Point(110, 172);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(80, 35);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Go!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResults.Controls.Add(this.buttonResultsMap);
            this.groupBoxResults.Controls.Add(this.textBoxResultsLongitude);
            this.groupBoxResults.Controls.Add(this.labelResultsLongitude);
            this.groupBoxResults.Controls.Add(this.textBoxResultsLatitude);
            this.groupBoxResults.Controls.Add(this.labelResultsLatitude);
            this.groupBoxResults.Location = new System.Drawing.Point(12, 213);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Padding = new System.Windows.Forms.Padding(10, 10, 10, 12);
            this.groupBoxResults.Size = new System.Drawing.Size(260, 87);
            this.groupBoxResults.TabIndex = 3;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results";
            // 
            // buttonResultsMap
            // 
            this.buttonResultsMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResultsMap.Location = new System.Drawing.Point(197, 26);
            this.buttonResultsMap.Name = "buttonResultsMap";
            this.buttonResultsMap.Size = new System.Drawing.Size(50, 46);
            this.buttonResultsMap.TabIndex = 4;
            this.buttonResultsMap.Text = "Map";
            this.buttonResultsMap.UseVisualStyleBackColor = true;
            this.buttonResultsMap.Click += new System.EventHandler(this.buttonResultsMap_Click);
            // 
            // textBoxResultsLongitude
            // 
            this.textBoxResultsLongitude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResultsLongitude.Location = new System.Drawing.Point(76, 52);
            this.textBoxResultsLongitude.Name = "textBoxResultsLongitude";
            this.textBoxResultsLongitude.ReadOnly = true;
            this.textBoxResultsLongitude.Size = new System.Drawing.Size(115, 20);
            this.textBoxResultsLongitude.TabIndex = 3;
            // 
            // labelResultsLongitude
            // 
            this.labelResultsLongitude.AutoSize = true;
            this.labelResultsLongitude.Location = new System.Drawing.Point(13, 55);
            this.labelResultsLongitude.Name = "labelResultsLongitude";
            this.labelResultsLongitude.Size = new System.Drawing.Size(57, 13);
            this.labelResultsLongitude.TabIndex = 2;
            this.labelResultsLongitude.Text = "Longitude:";
            // 
            // textBoxResultsLatitude
            // 
            this.textBoxResultsLatitude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResultsLatitude.Location = new System.Drawing.Point(76, 26);
            this.textBoxResultsLatitude.Name = "textBoxResultsLatitude";
            this.textBoxResultsLatitude.ReadOnly = true;
            this.textBoxResultsLatitude.Size = new System.Drawing.Size(115, 20);
            this.textBoxResultsLatitude.TabIndex = 1;
            // 
            // labelResultsLatitude
            // 
            this.labelResultsLatitude.AutoSize = true;
            this.labelResultsLatitude.Location = new System.Drawing.Point(13, 29);
            this.labelResultsLatitude.Name = "labelResultsLatitude";
            this.labelResultsLatitude.Size = new System.Drawing.Size(48, 13);
            this.labelResultsLatitude.TabIndex = 0;
            this.labelResultsLatitude.Text = "Latitude:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 312);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.groupBoxParameters);
            this.Controls.Add(this.groupBoxHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Adventure Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxHome.ResumeLayout(false);
            this.groupBoxHome.PerformLayout();
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            this.tableLayoutPanelRange.ResumeLayout(false);
            this.tableLayoutPanelRange.PerformLayout();
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHome;
        private System.Windows.Forms.TextBox textBoxHomeLongitude;
        private System.Windows.Forms.Label labelHomeLongitude;
        private System.Windows.Forms.TextBox textBoxHomeLatitude;
        private System.Windows.Forms.Label labelHomeLatitude;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.TextBox textBoxRangeMin;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.ComboBox comboBoxRangeUnits;
        private System.Windows.Forms.TextBox textBoxRangeMax;
        private System.Windows.Forms.Label labelRangeDash;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRange;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.TextBox textBoxResultsLongitude;
        private System.Windows.Forms.Label labelResultsLongitude;
        private System.Windows.Forms.TextBox textBoxResultsLatitude;
        private System.Windows.Forms.Label labelResultsLatitude;
        private System.Windows.Forms.Button buttonResultsMap;
    }
}

