namespace Server.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CrashModel
    {
        #region Attributes
        private static CrashModel _instance;
        #endregion

        #region Properties
        /// <summary>
        /// Header of Transfer Data to External Serial Message
        /// </summary>
        private string HDR { get; set; }
        /// <summary>
        /// Device ID , BCD Format.
        /// </summary>
        private string DEV_ID { get; set; }
        /// <summary>
        /// Length of the data being sent to the external serial device.
        /// </summary>
        private string LEN { get; set; }
        /// <summary>
        /// Crash Reconstruction Data.
        /// </summary>
        private string DATA { get; set; }
        /// <summary>
        /// Check Sum to be used by the device to verify the data was correctly received.
        /// </summary>
        private string CHK_SUM { get; set; }
        /// <summary>
        /// Message number: “main number – sub number”
        /// Main number is same as collision alert message number.
        /// Sub number is series number of crash report packet.
        /// </summary>
        private string MSG_NO { get; set; }
        #endregion

        #region Contructors
        public CrashModel()
        {
            HDR = "DEX";
        }
        #endregion

        public static CrashModel GetReference()
        {
            if (_instance == null)
            {
                _instance = new CrashModel();
            }

            return _instance;
        }
    }
}
