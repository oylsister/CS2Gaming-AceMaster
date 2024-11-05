namespace AceMaster
{
    public class PlayerAceCount
    {
        public PlayerAceCount(int kill = 0, int ace = 0, bool aceDone = false, bool complete = false)
        {
            _killCount = kill;
            _ace = ace;
            _complete = complete;
        }

        private int _killCount;
        private int _ace;
        private bool _aceDone;
        private bool _complete;

        public int KillCount
        {
            get { return _killCount; }
            set { _killCount = value; }
        }

        public int Ace
        { 
            get { return _ace; } 
            set { _ace = value; }
        }

        public bool AceDone
        { 
            get { return _aceDone; } 
            set { _aceDone = value; }
        }

        public bool Complete
        {
            get { return _complete; }
            set { _complete = value; }
        }
    }

    public class PlayerData
    {
        public PlayerData(string achieve, string reset, int ace, bool complete = true)
        {
            _timeAcheived = achieve;
            _timeReset = reset;

            Ace = ace;
            Complete = complete;
        }

        private string _timeAcheived;
        private string _timeReset;
        private int _ace;
        private bool _complete;

        public string TimeAcheived
        {
            get { return _timeAcheived; }
            set { _timeAcheived = value; }
        }

        public string TimeReset
        {
            get { return _timeReset; }
            set { _timeReset = value; }
        }

        public int Ace
        {
            get { return _ace; }
            set { _ace = value; }
        }

        public bool Complete
        {
            get { return _complete; }
            set { _complete = value; }
        }
    }
}
