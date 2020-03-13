using AdventureGenerator.Utility;
using System;
using System.Windows.Forms;

namespace AdventureGenerator.Forms
{
    public partial class MainForm : Form
    {
        #region Constants

        private const float EarthRadiusMetres = 6371000;

        private const float FeetToMetresConversion = 0.3048f;
        private const float MilesToMetresConversion = 1609.34f;

        #endregion

        #region Fields

        private Random _random;

        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Private methods

        private InputValues GetInputValues()
        {
            InputValues result = new InputValues();

            float homeLatitude;
            if (float.TryParse(textBoxHomeLatitude.Text, out homeLatitude) && homeLatitude >= -90 && homeLatitude <= 90)
            {
                result.HomeLatitude = homeLatitude;
            }

            float homeLongitude;
            if (float.TryParse(textBoxHomeLongitude.Text, out homeLongitude) && homeLongitude >= -180 && homeLongitude <= 180)
            {
                result.HomeLongitude = homeLongitude;
            }

            float rangeMin;
            if (float.TryParse(textBoxRangeMin.Text, out rangeMin) && rangeMin > 0)
            {
                result.RangeMin = rangeMin;
            }

            float rangeMax;
            if (float.TryParse(textBoxRangeMax.Text, out rangeMax) && rangeMax > rangeMin)
            {
                result.RangeMax = rangeMax;
            }

            result.RangeUnitIndex = comboBoxRangeUnits.SelectedIndex;

            return result;
        }

        #endregion

        #region Event handlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            _random = new Random();

            textBoxHomeLatitude.Text = Properties.Settings.Default.HomeLatitude.ToString();
            textBoxHomeLongitude.Text = Properties.Settings.Default.HomeLongitude.ToString();
            textBoxRangeMin.Text = Properties.Settings.Default.RangeMin.ToString();
            textBoxRangeMax.Text = Properties.Settings.Default.RangeMax.ToString();
            comboBoxRangeUnits.SelectedIndex = Properties.Settings.Default.RangeUnitIndex;
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            InputValues inputValues = GetInputValues();
            if (inputValues.AllValid())
            {
                float rangeConversionFactor = inputValues.RangeUnitIndex.Value == 0 ? 1 : inputValues.RangeUnitIndex.Value == 1 ? 1000 : inputValues.RangeUnitIndex.Value == 2 ? FeetToMetresConversion : MilesToMetresConversion;
                float rangeMetres = (float)((inputValues.RangeMin.Value + _random.NextDouble()*(inputValues.RangeMax.Value - inputValues.RangeMin.Value))*rangeConversionFactor);
                float bearingRadians = (float)(_random.NextDouble()*2*Math.PI);

                float homeLatitudeRadians = Globals.DegreesToRadians(inputValues.HomeLatitude.Value);
                float angularDistanceRadians = rangeMetres/EarthRadiusMetres;

                float resultLatitudeRadians = (float)(Math.Asin(Math.Sin(homeLatitudeRadians)*Math.Cos(angularDistanceRadians) + Math.Cos(homeLatitudeRadians)*Math.Sin(angularDistanceRadians)*Math.Cos(bearingRadians)));
                float resultLongitudeRadians = (float)(Globals.DegreesToRadians(inputValues.HomeLongitude.Value) + Math.Atan2(Math.Sin(bearingRadians)*Math.Sin(angularDistanceRadians)*Math.Cos(homeLatitudeRadians), Math.Cos(angularDistanceRadians) - Math.Sin(homeLatitudeRadians)*Math.Sin(resultLatitudeRadians)));

                textBoxResultsLatitude.Text = Globals.RadiansToDegrees(resultLatitudeRadians).ToString();
                textBoxResultsLongitude.Text = ((Globals.RadiansToDegrees(resultLongitudeRadians) + 540) % 360 - 180).ToString();
            }
            else
            {
                MessageBox.Show("Please check that all form entries are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonResultsMap_Click(object sender, EventArgs e)
        {
            float mapLatitude = 0;
            if (textBoxResultsLatitude.Text.Length > 0)
            {
                float resultLatitude;
                if (float.TryParse(textBoxResultsLatitude.Text, out resultLatitude))
                {
                    mapLatitude = resultLatitude;
                }
            }

            float mapLongitude = 0;
            if (textBoxResultsLongitude.Text.Length > 0)
            {
                float resultLongitude;
                if (float.TryParse(textBoxResultsLongitude.Text, out resultLongitude))
                {
                    mapLongitude = resultLongitude;
                }
            }

            MapParametersForm mapParametersForm = new MapParametersForm()
            {
                MapLatitude = mapLatitude,
                MapLongitude = mapLongitude
            };
            mapParametersForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            InputValues inputValues = GetInputValues();

            if (inputValues.HomeLatitude.HasValue)
            {
                Properties.Settings.Default.HomeLatitude = inputValues.HomeLatitude.Value;
            }
            if (inputValues.HomeLongitude.HasValue)
            {
                Properties.Settings.Default.HomeLongitude = inputValues.HomeLongitude.Value;
            }
            if (inputValues.RangeMin.HasValue)
            {
                Properties.Settings.Default.RangeMin = inputValues.RangeMin.Value;
            }
            if (inputValues.RangeMax.HasValue)
            {
                Properties.Settings.Default.RangeMax = inputValues.RangeMax.Value;
            }
            if (inputValues.RangeUnitIndex.HasValue)
            {
                Properties.Settings.Default.RangeUnitIndex = inputValues.RangeUnitIndex.Value;
            }

            Properties.Settings.Default.Save();
        }

        #endregion
    }
}
