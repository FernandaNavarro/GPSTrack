namespace GPSTrack.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MessageModel
    {
        #region Attributes
        private static MessageModel _instance;
        private string hDR;
        private string pKT_LEN;
        private string dEV_ID;
        private string aCK_RPT;
        private string cHK_SUM;

        #endregion

        #region Propeties
        /// <summary>
        /// Header of Acknowledge Message.
        /// </summary>
        public string HDR
        {
            get { return hDR; }
            set { hDR = value; }
        }

        /// <summary>
        /// Length of zip data excluding HDR and PKT_LEN.
        /// </summary>
        public string PKT_LEN
        {
            get { return pKT_LEN; }
            set { pKT_LEN = value; }
        }

        /// <summary>
        /// Device ID , BCD Format.
        /// </summary>
        public string DEV_ID
        {
            get { return dEV_ID; }
            set { dEV_ID = value; }
        }

        /// <summary>
        /// Report in which the platform is Acknowledging.
        /// </summary>
        public string ACK_RPT
        {
            get { return aCK_RPT; }
            set { aCK_RPT = value; }
        }

        /// <summary>
        /// Check Sum to be used by the device to verify the data was correctly received.
        /// </summary>
        public string CHK_SUM
        {
            get { return cHK_SUM; }
            set { cHK_SUM = value; }
        }

        #endregion

        public static MessageModel GetReference()
        {
            if (_instance == null)
            {
                _instance = new MessageModel();
            }

            return _instance;
        }
    }
}
