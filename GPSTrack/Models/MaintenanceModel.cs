namespace GPSTrack.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MaintenanceModel
    {
        #region Attributes
        private static MaintenanceModel _instance;
        private string hDR;
        private string dEV_ID;
        private string sW_VER;
        private string dATE;
        private string tIME;
        private string pROF_VER;
        private string pHONE;
        private string aNT;
        private string bAT;
        #endregion

        #region Properties
        /// <summary>
        /// Header of Maintenance Report.
        /// </summary>
        public string HDR
        {
            get { return hDR; }
            set { hDR = value; }
        }

        /// <summary>
        /// Device ID , BCD Format
        /// </summary>
        public string DEV_ID
        {
            get { return dEV_ID; }
            set { dEV_ID = value; }
        }

        /// <summary>
        /// Software Version.
        /// </summary>
        public string SW_VER
        {
            get { return sW_VER; }
            set { sW_VER = value; }
        }

        /// <summary>
        /// GPS Date (Year + Month + Day)
        /// </summary>
        public string DATE
        {
            get { return dATE; }
            set { dATE = value; }
        }

        /// <summary>
        /// Time (Hour + Minute + Second).
        /// </summary>
        public string TIME
        {
            get { return tIME; }
            set { tIME = value; }
        }

        /// <summary>
        /// This is the last downloaded profile version by OTA or SyncTrak.
        /// Factory default value is 001.
        /// </summary>
        public string PROF_VER
        {
            get { return pROF_VER; }
            set { pROF_VER = value; }
        }

        /// <summary>
        /// Current Phone Number.
        /// </summary>
        public string PHONE
        {
            get { return pHONE; }
            set { pHONE = value; }
        }

        /// <summary>
        /// GPS Antenna Check.
        /// </summary>
        public string ANT
        {
            get { return aNT; }
            set { aNT = value; }
        }

        /// <summary>
        /// Battery Check.
        /// </summary>
        public string BAT
        {
            get { return bAT; }
            set { bAT = value; }
        }

        #endregion

        public static MaintenanceModel GetReference()
        {
            if (_instance == null)
            {
                _instance = new MaintenanceModel();
            }

            return _instance;
        }
    }
}
