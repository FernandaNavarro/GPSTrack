namespace GPSTrack.ViewsModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GPSTrack.Models;

    public class MaintenanceViewModel
    {
        #region Variables
        private static MaintenanceViewModel _instance;
        private static string voidField = "#";
        #endregion

        #region Methods
        public static MaintenanceViewModel GetReference()
        {
            if (_instance == null)
            {
                _instance = new MaintenanceViewModel();
            }

            return _instance;
        }

        public string GetMsgNormalFormat(MaintenanceModel message)
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
