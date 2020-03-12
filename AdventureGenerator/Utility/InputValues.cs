namespace AdventureGenerator.Utility
{
    public class InputValues
    {
        #region Properties

        public float? HomeLatitude { get; set; }

        public float? HomeLongitude { get; set; }

        public float? RangeMin { get; set; }

        public float? RangeMax { get; set; }

        public int? RangeUnitIndex { get; set; }

        #endregion

        #region Methods

        public bool AllValid()
        {
            return HomeLatitude.HasValue && HomeLongitude.HasValue && RangeMin.HasValue && RangeMax.HasValue && RangeUnitIndex.HasValue;
        }

        #endregion
    }
}
