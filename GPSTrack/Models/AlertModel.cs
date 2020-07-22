using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSTrack.ViewsModels;

namespace GPSTrack.Models
{
    public class AlertModel
    {
        #region Attributes
        private static AlertModel _instance;
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
        private string aLERT_ID;
        private string aLERT_MOD;
        private string aLERT_DATA;
        private string Reserved;
        private string aSSIGN_MAP;
        private string s_ASSIGN1;
        private string s_ASSIGN2;
        private string s_ASSIGN3;
        private string s_ASSIGN4;
        private string s_ASSIGN5;
        private string s_ASSIGN6;
        private string s_ASSIGN7;
        private string s_ASSIGN8;
        private string s_ASSIGN9;
        private string s_ASSIGN10;
        private string s_ASSIGN11;
        private string s_ASSIGN12;
        private string s_ASSIGN13;
        private string s_ASSIGN14;
        private string s_ASSIGN15;
        private string m_ASSIGN1;
        private string m_ASSIGN2;
        private string m_ASSIGN3;
        private string m_ASSIGN4;
        private string m_ASSIGN5;
        private string m_ASSIGN6;
        private string m_ASSIGN7;
        private string m_ASSIGN8;
        private string l_ASSIGN1;
        private string l_ASSIGN2;
        private string l_ASSIGN3;
        private string l_ASSIGN4;
        private string l_ASSIGN5;
        private string l_ASSIGN6;
        private string l_ASSIGN7;
        private string l_ASSIGN8;

        #endregion

        #region Properties
        /// <summary>
        /// Header of Alert Report.
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
        /// Alert ID Number
        /// </summary>
        public string ALERT_ID
        {
            get { return aLERT_ID; }
            set { aLERT_ID = value; }
        }

        /// <summary>
        /// Contains Modifier for certain Alert IDs
        /// Second Byte: Length of the ALERT_DATA
        /// </summary>
        public string ALERT_MOD
        {
            get { return aLERT_MOD; }
            set
            {
                var number = Convert.ToInt32(value.Substring(2, value.Length), 16) * 2;
                AlertViewModel.GetReference().SetPropertyLengthValue("ALERT_DATA",number);
                aLERT_MOD = value;
            }
        }

        /// <summary>
        /// Contains Data for certain Alert IDs
        /// </summary>
        public string ALERT_DATA
        {
            get { return aLERT_DATA; }
            set { aLERT_DATA = value; }
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
        /// Map of the custom assignable headers that can be
        /// included at the end of the standard report format.
        /// </summary>
        public string ASSIGN_MAP
        {
            get { return aSSIGN_MAP; }
            set { aSSIGN_MAP = value; }
        }

        /// <summary>
        /// Custom Small Assignable Header
        /// </summary>
        public string S_ASSIGN1
        {
            get { return s_ASSIGN1; }
            set { s_ASSIGN1 = value; }
        }
        public string S_ASSIGN2
        {
            get { return s_ASSIGN2; }
            set { s_ASSIGN2 = value; }
        }
        public string S_ASSIGN3
        {
            get { return s_ASSIGN3; }
            set { s_ASSIGN3 = value; }
        }
        public string S_ASSIGN4
        {
            get { return s_ASSIGN4; }
            set { s_ASSIGN4 = value; }
        }
        public string S_ASSIGN5
        {
            get { return s_ASSIGN5; }
            set { s_ASSIGN5 = value; }
        }
        public string S_ASSIGN6
        {
            get { return s_ASSIGN6; }
            set { s_ASSIGN6 = value; }
        }
        public string S_ASSIGN7
        {
            get { return s_ASSIGN7; }
            set { s_ASSIGN7 = value; }
        }
        public string S_ASSIGN8
        {
            get { return s_ASSIGN8; }
            set { s_ASSIGN8 = value; }
        }
        public string S_ASSIGN9
        {
            get { return s_ASSIGN9; }
            set { s_ASSIGN9 = value; }
        }
        public string S_ASSIGN10
        {
            get { return s_ASSIGN10; }
            set { s_ASSIGN10 = value; }
        }
        public string S_ASSIGN11
        {
            get { return s_ASSIGN11; }
            set { s_ASSIGN11 = value; }
        }
        public string S_ASSIGN12
        {
            get { return s_ASSIGN12; }
            set { s_ASSIGN12 = value; }
        }
        public string S_ASSIGN13
        {
            get { return s_ASSIGN13; }
            set { s_ASSIGN13 = value; }
        }
        public string S_ASSIGN14
        {
            get { return s_ASSIGN14; }
            set { s_ASSIGN14 = value; }
        }
        public string S_ASSIGN15
        {
            get { return s_ASSIGN15; }
            set { s_ASSIGN15 = value; }
        }

        /// <summary>
        /// Custom Medium Assignable Header
        /// </summary>
        public string M_ASSIGN1
        {
            get { return m_ASSIGN1; }
            set { m_ASSIGN1 = value; }
        }
        public string M_ASSIGN2
        {
            get { return m_ASSIGN2; }
            set { m_ASSIGN2 = value; }
        }
        public string M_ASSIGN3
        {
            get { return m_ASSIGN3; }
            set { m_ASSIGN3 = value; }
        }
        public string M_ASSIGN4
        {
            get { return m_ASSIGN4; }
            set { m_ASSIGN4 = value; }
        }
        public string M_ASSIGN5
        {
            get { return m_ASSIGN5; }
            set { m_ASSIGN5 = value; }
        }
        public string M_ASSIGN6
        {
            get { return m_ASSIGN6; }
            set { m_ASSIGN6 = value; }
        }
        public string M_ASSIGN7
        {
            get { return m_ASSIGN7; }
            set { m_ASSIGN7 = value; }
        }
        public string M_ASSIGN8
        {
            get { return m_ASSIGN8; }
            set { m_ASSIGN8 = value; }
        }

        /// <summary>
        /// Custom Large Assignable Header
        /// </summary>
        public string L_ASSIGN1
        {
            get { return l_ASSIGN1; }
            set { l_ASSIGN1 = value; }
        }
        public string L_ASSIGN2
        {
            get { return l_ASSIGN2; }
            set { l_ASSIGN2 = value; }
        }
        public string L_ASSIGN3
        {
            get { return l_ASSIGN3; }
            set { l_ASSIGN3 = value; }
        }
        public string L_ASSIGN4
        {
            get { return l_ASSIGN4; }
            set { l_ASSIGN4 = value; }
        }
        public string L_ASSIGN5
        {
            get { return l_ASSIGN5; }
            set { l_ASSIGN5 = value; }
        }
        public string L_ASSIGN6
        {
            get { return l_ASSIGN6; }
            set { l_ASSIGN6 = value; }
        }
        public string L_ASSIGN7
        {
            get { return l_ASSIGN7; }
            set { l_ASSIGN7 = value; }
        }
        public string L_ASSIGN8
        {
            get { return l_ASSIGN8; }
            set { l_ASSIGN8 = value; }
        }
        #endregion

        public static AlertModel GetReference()
        {
            if (_instance == null)
            {
                _instance = new AlertModel();
            }

            return _instance;
        }
    }
}
