namespace GPSTrack.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GPSTrack.Models;

    public class StatusViewModel
    {
        #region Variables
        private static StatusViewModel _instance;

        private Dictionary<string, int> propertyLength = new Dictionary<string, int>()
        {
            {"HDR", 2 },
            {"PKT_LEN", 4 },
            {"DEV_ID", 10 },
            {"STT_RPT_MAP", 6 },
            {"MODEL", 2 },
            {"SW_VER", 6 },
            {"MSG_TYPE", 2},
            {"DATE", 6},
            {"TIME", 6 },
            {"CELL_ID", 8 },
            {"MCC", 4 },
            {"MNC", 4 },
            {"LAC", 4 },
            {"RX_LVL", 2 },
            {"LAT", 8 },
            {"LON", 8 },
            {"SPD", 4 },
            {"CRS", 4 },
            {"SATT", 2 },
            {"FIX", 2 },
            {"IN_STATE", 2 },
            {"OUT_STATE", 2 },
            {"MODE", 2 },
            {"STT_RPT_TYPE", 2 },
            {"MSG_NUM", 4 },
            {"reserved", 2 },
            {"ASSIGN_MAP", 8 },
            {"S_ASSIGN1", 4},
            {"S_ASSIGN2", 4},
            {"S_ASSIGN3", 4},
            {"S_ASSIGN4", 4},
            {"S_ASSIGN5", 4},
            {"S_ASSIGN6", 4},
            {"S_ASSIGN7", 4},
            {"S_ASSIGN8", 4},
            {"S_ASSIGN9", 4},
            {"S_ASSIGN10", 4},
            {"S_ASSIGN11", 4},
            {"S_ASSIGN12", 4},
            {"S_ASSIGN13", 4},
            {"S_ASSIGN14", 4},
            {"S_ASSIGN15", 4},
            {"M_ASSIGN1", 8 },
            {"M_ASSIGN2", 8 },
            {"M_ASSIGN3", 8 },
            {"M_ASSIGN4", 8 },
            {"M_ASSIGN5", 8 },
            {"M_ASSIGN6", 8 },
            {"M_ASSIGN7", 8 },
            {"M_ASSIGN8", 8 },
            {"L_ASSIGN1", 16 },
            {"L_ASSIGN2", 16 },
            {"L_ASSIGN3", 16 },
            {"L_ASSIGN4", 16 },
            {"L_ASSIGN5", 16 },
            {"L_ASSIGN6", 16 },
            {"L_ASSIGN7", 16 },
            {"L_ASSIGN8", 16 },
        };
        private static string voidField = "#";
        #endregion

        #region Contructors

        #endregion

        #region Methods
        public static StatusViewModel GetReference()
        {
            if (_instance == null)
            {
                _instance = new StatusViewModel();
            }

            return _instance;
        }

        private string GetPart(string msg, string nameOfProperty, int began, ref int finish)
        {
            finish = propertyLength[nameOfProperty];
            if ((began + finish) <= msg.Length)
            {
                return msg.Substring(began, finish);
            }
            else
            {
                return voidField;
            }
        }

        public StatusModel GetObjZipFormat(string message)
        {
            var obj = new StatusModel();
            int propertyLength = 0;
            int sumLengths = 0;

            foreach (var property in obj.GetType().GetProperties())
            {
                if (sumLengths <= message.Length)
                {
                    property.SetValue(obj, GetPart(message, property.Name, sumLengths, ref propertyLength));
                    sumLengths += propertyLength;
                }
                else
                {
                    property.SetValue(obj, voidField);
                }
            }

            return obj;
        }

        public StatusModel GetObjNormalFormat(string message)
        {
            var obj = new StatusModel();
            var arrMsg = message.Split(';');
            int index = 0;
            foreach (var property in obj.GetType().GetProperties())
            {
                if (index < arrMsg.Length)
                {
                    property.SetValue(obj, arrMsg[index]);
                    index++;
                }
                else
                {
                    property.SetValue(obj, voidField);
                }
            }

            return obj;
        }

        public void DisplayData(StatusModel status)
        {
            foreach (var property in status.GetType().GetProperties())
            {
                Console.WriteLine("Name: {0}\n      Value: {1}", property.Name, property.GetValue(status));
            }
        }

        public string GetMsgZipFormat(StatusModel message)
        {
            StringBuilder msg = new StringBuilder();
            foreach (var property in message.GetType().GetProperties())
            {
                string xValue = Convert.ToString(property.GetValue(message));
                if (!xValue.Equals(voidField))
                {
                    msg.Append(xValue);
                }

            }

            return msg.ToString();
        }

        public string GetMsgNormalFormat(StatusModel message)
        {
            StringBuilder msg = new StringBuilder();
            foreach (var property in message.GetType().GetProperties())
            {
                string xValue = Convert.ToString(property.GetValue(message));
                if (!xValue.Equals(voidField))
                {
                    msg.Append(xValue);
                    msg.Append(";");
                }

            }
            var theMSG = msg.ToString();

            return theMSG.Substring(0, theMSG.Length - 1);
        }
        #endregion

    }
}
