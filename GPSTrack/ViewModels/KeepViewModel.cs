namespace GPSTrack.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GPSTrack.Models;

    public class KeepViewModel
    {
        #region Variables
        private static KeepViewModel _instance;

        public Dictionary<string, int> propertyLength = new Dictionary<string, int>()
        {
            {"HDR", 2 },
            {"PKT_LEN", 4 },
            {"DEV_ID", 10 }
        };
        private static string voidField = "#";
        #endregion

        #region Methods
        public static KeepViewModel GetReference()
        {
            if (_instance == null)
            {
                _instance = new KeepViewModel();
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

        public KeepModel GetObjZipFormat(string message)
        {
            var obj = new KeepModel();
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

        public KeepModel GetObjNormalFormat(string message)
        {
            var obj = new KeepModel();
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

        public void DisplayData(KeepModel status)
        {
            foreach (var property in status.GetType().GetProperties())
            {
                Console.WriteLine("Name: {0}\n      Value: {1}", property.Name, property.GetValue(status));
            }
        }

        public string GetMsgZipFormat(KeepModel message)
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

        public string GetMsgNormalFormat(KeepModel message)
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
