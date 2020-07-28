namespace GPSTrack.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GPSTrack.Models;

    public class ExternalViewModel
    {
        #region Variables
        private static ExternalViewModel _instance;

        public Dictionary<string, int> propertyLength = new Dictionary<string, int>()
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
            {"LEN", 4 },
            {"DATA", 0 },
            {"CHK_SUM", 4 },
            {"reserved", 2 },
            {"reserved2", 2 },
        };
        private static string voidField = "#";
        #endregion

        #region Methosds
        public static ExternalViewModel GetReference()
        {
            if (_instance == null)
            {
                _instance = new ExternalViewModel();
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

        public ExternalModel GetObjZipFormat(string message)
        {
            var obj = new ExternalModel();
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

        public ExternalModel GetObjNormalFormat(string message)
        {
            var obj = new ExternalModel();
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

        public void DisplayData(ExternalModel status)
        {
            foreach (var property in status.GetType().GetProperties())
            {
                Console.WriteLine("Name: {0}\n      Value: {1}", property.Name, property.GetValue(status));
            }
        }

        public string GetMsgZipFormat(ExternalModel message)
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

        public string GetMsgNormalFormat(ExternalModel message)
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

        public void SetPropertyLengthValue(string key, int value)
        {
            propertyLength[key] = value;
        }
        #endregion

    }
}
