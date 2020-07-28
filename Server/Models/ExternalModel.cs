namespace Server.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Server.ViewModels;

    public class ExternalModel
    {
        #region Attrbutes
        private static ExternalModel _instance;
        private string hDR;
        private string pKT_LEN;
        private string dEV_ID;
        private string sTT_RPT_MAP;
        private string mODEL;
        private string sW_VER;
        private string mSG_TYPE;
        private string dATE;
        private string tIME;
        private string cELL_ID;
        private string mCC;
        private string mNC;
        private string lAC;
        private string rX_LVL;
        private string lAT;
        private string lON;
        private string sPD;
        private string cRS;
        private string sATT;
        private string fIX;
        private string iN_STATE;
        private string oUT_STATE;
        private string lEN;
        private string dATA;
        private string cHK_SUM;
        private string Reserved;
        private string Reserved2;

        #endregion

        #region Properties
        /// <summary>
        /// Header of External Serial Report.
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
        /// Unique Id of Serving Cell.
        /// </summary>
        public string CELL_ID
        {
            get { return cELL_ID; }
            set { cELL_ID = value; }
        }

        /// <summary>
        /// Mobile Country Code
        /// </summary>
        public string MCC
        {
            get { return mCC; }
            set { mCC = value; }
        }

        /// <summary>
        /// Mobile Network Code
        /// </summary>
        public string MNC
        {
            get { return mNC; }
            set { mNC = value; }
        }

        /// <summary>
        /// Location Area Code
        /// </summary>
        public string LAC
        {
            get { return lAC; }
            set { lAC = value; }
        }

        /// <summary>
        /// Signal Strength (See table in Normal report above)
        /// </summary>
        public string RX_LVL
        {
            get { return rX_LVL; }
            set { rX_LVL = value; }
        }

        /// <summary>
        /// To convert take HEX and convert to Decimal value then divide by 1,000,000
        /// </summary>
        public string LAT
        {
            get { return lAT; }
            set { lAT = value; }
        }

        /// <summary>
        /// To convert take HEX and convert to Decimal value then divide by 1,000,000
        /// </summary>
        public string LON
        {
            get { return lON; }
            set { lON = value; }
        }

        /// <summary>
        /// Take the decimal value and divide by 100
        /// </summary>
        public string SPD
        {
            get { return sPD; }
            set { sPD = value; }
        }

        /// <summary>
        /// Take the decimal value and divide by 100
        /// </summary>
        public string CRS
        {
            get { return cRS; }
            set { cRS = value; }
        }

        /// <summary>
        /// Number of GPS Satellites
        /// </summary>
        public string SATT
        {
            get { return sATT; }
            set { sATT = value; }
        }

        /// <summary>
        /// Fix Status
        /// </summary>
        public string FIX
        {
            get { return fIX; }
            set { fIX = value; }
        }

        /// <summary>
        /// Ignition: 1 (ON), 0 (OFF).
        /// </summary>
        public string IN_STATE
        {
            get { return iN_STATE; }
            set { iN_STATE = value; }
        }

        /// <summary>
        /// Out: 1 (Active), 0 (Inactive).
        /// </summary>
        public string OUT_STATE
        {
            get { return oUT_STATE; }
            set { oUT_STATE = value; }
        }

        /// <summary>
        /// Length of Data.
        /// </summary>
        public string LEN
        {
            get { return lEN; }
            set
            {
                var number = Convert.ToInt32(value, 16) * 2;
                ExternalViewModel.GetReference().SetPropertyLengthValue("DATA",number);
                lEN = value;
            }
        }

        /// <summary>
        /// Data from external device.
        /// </summary>
        public string DATA
        {
            get { return dATA; }
            set { dATA = value; }
        }

        /// <summary>
        /// 8bit Checksum. Lower than8 bit of the summation of DATA field.
        /// </summary>
        public string CHK_SUM
        {
            get { return cHK_SUM; }
            set { cHK_SUM = value; }
        }

        /// <summary>
        /// Reserved field (reports with FF if enabled)
        /// </summary>
        public string reserved
        {
            get { return Reserved; }
            set { Reserved = value; }
        }

        /// <summary>
        /// Reserved field (reports with FF if enabled)
        /// </summary>
        public string reserved2
        {
            get { return Reserved2; }
            set { Reserved2 = value; }
        }

        #endregion

        public static ExternalModel GetReference()
        {
            if (_instance == null)
            {
                _instance = new ExternalModel();
            }

            return _instance;
        }
    }
}
