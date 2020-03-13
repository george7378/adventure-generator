using System;
using System.Windows.Forms;

namespace AdventureGenerator.Forms
{
    public partial class MapParametersForm : Form
    {
        #region Properties

        public float MapLatitude { get; set; }

        public float MapLongitude { get; set; }

        #endregion

        #region Constructors

        public MapParametersForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Event handlers

        private void MapParametersForm_Load(object sender, EventArgs e)
        {
            textBoxURLSuffix.Text = Properties.Settings.Default.URLSuffix;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Format("http://maps.google.com/maps?q={0},{1}{2}", MapLatitude, MapLongitude, textBoxURLSuffix.Text));

            Close();
        }

        private void MapParametersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.URLSuffix = textBoxURLSuffix.Text;

            Properties.Settings.Default.Save();
        }

        #endregion
    }
}
