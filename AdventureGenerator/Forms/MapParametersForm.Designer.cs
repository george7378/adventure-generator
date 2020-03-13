namespace AdventureGenerator.Forms
{
    partial class MapParametersForm
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
            this.groupBoxURLSuffix = new System.Windows.Forms.GroupBox();
            this.textBoxURLSuffix = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxURLSuffix.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxURLSuffix
            // 
            this.groupBoxURLSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxURLSuffix.Controls.Add(this.textBoxURLSuffix);
            this.groupBoxURLSuffix.Location = new System.Drawing.Point(12, 12);
            this.groupBoxURLSuffix.Name = "groupBoxURLSuffix";
            this.groupBoxURLSuffix.Padding = new System.Windows.Forms.Padding(10, 10, 10, 12);
            this.groupBoxURLSuffix.Size = new System.Drawing.Size(160, 61);
            this.groupBoxURLSuffix.TabIndex = 1;
            this.groupBoxURLSuffix.TabStop = false;
            this.groupBoxURLSuffix.Text = "URL Suffix";
            // 
            // textBoxURLSuffix
            // 
            this.textBoxURLSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxURLSuffix.Location = new System.Drawing.Point(13, 26);
            this.textBoxURLSuffix.Name = "textBoxURLSuffix";
            this.textBoxURLSuffix.Size = new System.Drawing.Size(134, 20);
            this.textBoxURLSuffix.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonOK.Location = new System.Drawing.Point(62, 79);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(76, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // MapParametersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 114);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxURLSuffix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapParametersForm";
            this.Text = "Map Parameters";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MapParametersForm_FormClosing);
            this.Load += new System.EventHandler(this.MapParametersForm_Load);
            this.groupBoxURLSuffix.ResumeLayout(false);
            this.groupBoxURLSuffix.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxURLSuffix;
        private System.Windows.Forms.TextBox textBoxURLSuffix;
        private System.Windows.Forms.Button buttonOK;
    }
}