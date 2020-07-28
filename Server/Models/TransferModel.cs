namespace Server.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TransferModel
    {
        #region Attributes
        private static TransferModel _instance;
        #endregion

        #region Properties
        /// <summary>
        /// Response Header for command sent to Suntech device
        /// </summary>
        public string RES { get; set; }
        /// <summary>
        /// Header of Transfer Data to External Serial Message
        /// </summary>
        public string HDR { get; set; }
        /// <summary>
        /// Device ID , BCD Format.
        /// </summary>
        public string DEV_ID { get; set; }
        /// <summary>
        /// Length of the data being sent to the external serial device.
        /// </summary>
        public string LEN { get; set; }
        /// <summary>
        /// Serial data to send to the device.
        /// </summary>
        public string DATA { get; set; }
        /// <summary>
        /// Check Sum to be used by the device to verify the data was correctly received.
        /// </summary>
        public string CHK_SUM { get; set; }
        #endregion

        #region Contructors
        public TransferModel()
        {
            RES = "RES";
            HDR = "DEX";
        }
        #endregion

        public static TransferModel GetReference()
        {
            if (_instance == null)
            {
                _instance = new TransferModel();
            }

            return _instance;
        }
    }
}
