namespace GPSTrack.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class KeepModel
    {
        #region Attributes
        private static KeepModel _instance;
        private string hDR;
        private string pKT_LEN;
        private string dEV_ID;

        #endregion

        #region Properties
        /// <summary>
        /// Header of Keep Alive Report.
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

        #endregion

        public static KeepModel GetReference()
        {
            if (_instance == null)
            {
                _instance = new KeepModel();
            }

            return _instance;
        }
    }
}
