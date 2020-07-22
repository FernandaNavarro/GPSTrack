namespace GPSTrack.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TravelModel
    {
        #region Attributes
        private static TravelModel _instance;
        private string hDR;
        private string pKT_LEN;
        private string dEV_ID;
        private string sTT_RPT_MAP;
        private string mODEL;
        private string sW_VER;
        private string mSG_TYPE;
        private string dATE;
        private string tIME;
        private string lAT_TRV_ST;
        private string lON_TRV_ST;
        private string lAT_TRV_FI;
        private string lON_TRV_FI;
        private string dRIVER_ID;
        private string tRV_DIST;
        private string tRV_H_METER;
        private string iDLE_TIME;
        private string iDLE_EVENTS;
        private string sPD_TIME;
        private string sPD_EVENTS;
        private string mAX_SPD;
        private string aVG_SPD;
        private string gPS_ODOM;

        #endregion

        #region Properties
        /// <summary>
        /// Header of Travel Report.
        /// </summary>
        public string HDR
        {
            get { return hDR; }
            set { hDR = value; }
        }

        /// <summary>
        /// Length of zip data excluding HDR and PKT_LEN
        /// </summary>
        public string PKT_LEN
        {
            get { return pKT_LEN; }
            set { pKT_LEN = value; }
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
        /// Map of the headers that are included in the report
        /// </summary>
        public string STT_RPT_MAP
        {
            get { return sTT_RPT_MAP; }
            set { sTT_RPT_MAP = value; }
        }

        /// <summary>
        /// Device Model (According to table model).
        /// </summary>
        public string MODEL
        {
            get { return mODEL; }
            set { mODEL = value; }
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
        /// Real Time (1) Or Stored (0) Message
        /// </summary>
        public string MSG_TYPE
        {
            get { return mSG_TYPE; }
            set { mSG_TYPE = value; }
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
        /// Latitude of location where the trip started (Ignition On)
        /// </summary>
        public string LAT_TRV_ST
        {
            get { return lAT_TRV_ST; }
            set { lAT_TRV_ST = value; }
        }

        /// <summary>
        /// Longitude of location where the trip started (Ignition On)
        /// </summary>
        public string LON_TRV_ST
        {
            get { return lON_TRV_ST; }
            set { lON_TRV_ST = value; }
        }

        /// <summary>
        /// Latitude of location where the trip finished (Ignition Off)
        /// </summary>
        public string LAT_TRV_FI
        {
            get { return lAT_TRV_FI; }
            set { lAT_TRV_FI = value; }
        }

        /// <summary>
        /// Longitude of location where the trip finished (Ignition Off)
        /// </summary>
        public string LON_TRV_FI
        {
            get { return lON_TRV_FI; }
            set { lON_TRV_FI = value; }
        }

        /// <summary>
        /// Driver ID
        /// </summary>
        public string DRIVER_ID
        {
            get { return dRIVER_ID; }
            set { dRIVER_ID = value; }
        }

        /// <summary>
        /// Distance traveled in meters
        /// </summary>
        public string TRV_DIST
        {
            get { return tRV_DIST; }
            set { tRV_DIST = value; }
        }

        /// <summary>
        /// Driving Time meter in seconds for current trip
        /// </summary>
        public string TRV_H_METER
        {
            get { return tRV_H_METER; }
            set { tRV_H_METER = value; }
        }

        /// <summary>
        /// Time spent in Idle Mode for the entire trip 
        /// in seconds (Ignition On to Ignition Off)
        /// </summary>
        public string IDLE_TIME
        {
            get { return iDLE_TIME; }
            set { iDLE_TIME = value; }
        }

        /// <summary>
        /// Number of Idle events during 1 trip (Ignition On to Ignition Off)
        /// </summary>
        public string IDLE_EVENTS
        {
            get { return iDLE_EVENTS; }
            set { iDLE_EVENTS = value; }
        }

        /// <summary>
        /// Time spent in Speed Mode in seconds
        /// </summary>
        public string SPD_TIME
        {
            get { return sPD_TIME; }
            set { sPD_TIME = value; }
        }

        /// <summary>
        /// Number of times Speed Mode was entered from Drive Mode
        /// </summary>
        public string SPD_EVENTS
        {
            get { return sPD_EVENTS; }
            set { sPD_EVENTS = value; }
        }

        /// <summary>
        /// Maximum Speed as calculated from GPS data
        /// Take the decimal value and divide by 100
        /// </summary>
        public string MAX_SPD
        {
            get { return mAX_SPD; }
            set { mAX_SPD = value; }
        }

        /// <summary>
        /// Average Speed as calculated from GPS data
        /// Take the decimal value and divide by 100
        /// </summary>
        public string AVG_SPD
        {
            get { return aVG_SPD; }
            set { aVG_SPD = value; }
        }

        /// <summary>
        /// Odometer as calculated from GPS data
        /// </summary>
        public string GPS_ODOM
        {
            get { return gPS_ODOM; }
            set { gPS_ODOM = value; }
        }

        #endregion

        public static TravelModel GetReference()
        {
            if (_instance == null)
            {
                _instance = new TravelModel();
            }

            return _instance;
        }
    }
}
