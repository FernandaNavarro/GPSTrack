namespace Server.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Server.Models;

    public class TravelViewModel
    {
        #region Variables
        private static TravelViewModel _instance;

        public Dictionary<string, int> propertyLength = new Dictionary<string, int>()
        {
            {"HDR", 2 },
            {"PKT_LEN", 4 },
            {"DEV_ID", 10 },
            {"STT_RPT_MAP", 10 },
            {"MODEL", 2 },
            {"SW_VER", 6 },
            {"MSG_TYPE", 2},
            {"DATE", 6},
            {"TIME", 6 },
            {"LAT_TRV_ST", 8 },
            {"LON_TRV_ST", 8 },
            {"LAT_TRV_FI", 8 },
            {"LON_TRV_FI", 8 },
            {"DRIVER_ID", 16 },
            {"TRV_DIST", 8 },
            {"TRV_H_METER", 8 },
            {"IDLE_TIME", 8 },
            {"IDLE_EVENTS", 4 },
            {"SPD_TIME", 8 },
            {"SPD_EVENTS", 4 },
            {"MAX_SPD", 4 },
            {"AVG_SPD", 4 },
            {"GPS_ODOM", 8 }

        };
        private static string voidField = "#";
        #endregion

        #region Methods
        public static TravelViewModel GetReference()
        {
            if (_instance == null)
            {
                _instance = new TravelViewModel();
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

        public TravelModel GetObjZipFormat(string message)
        {
            var obj = new TravelModel();
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

        public TravelModel GetObjNormalFormat(string message)
        {
            var obj = new TravelModel();
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

        public void DisplayData(TravelModel status)
        {
            foreach (var property in status.GetType().GetProperties())
            {
                Console.WriteLine("Name: {0}\n      Value: {1}", property.Name, property.GetValue(status));
            }
        }

        public string GetMsgZipFormat(TravelModel message)
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

        public string GetMsgNormalFormat(TravelModel message)
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
