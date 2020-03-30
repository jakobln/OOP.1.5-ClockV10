namespace ClockV10
{
    public class Clock
    {
        #region Instance Fields
        private int _timeInMinutesSince0000;
        #endregion

        #region Constructor
        public void Settime(int Hours, int Minutes)
        {
            _timeInMinutesSince0000 = 60 * Hours + Minutes;
        }
        #endregion

        #region Properties
        public int Hours
        {
            get {return _timeInMinutesSince0000 / 60;}
        }
        public int Minutes
        {
            get {return _timeInMinutesSince0000 % 60;}
        }
        
        public int GetHours
        {
            get { return Hours;}
        }

        public int GetMinutes
        {
            get { return Minutes;}
        }        
        #endregion

        #region Methods
        public void AddTime()
        {
            GetMinutes
        }
        #endregion
    }
}