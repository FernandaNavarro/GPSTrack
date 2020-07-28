namespace Server.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Server.Models;

    public class TransferViewModel
    {
        #region Variables
        private static TransferViewModel _instance;
        private static string voidField = "#";
        #endregion

        #region Methods
        public static TransferViewModel GetReference()
        {
            if (_instance == null)
            {
                _instance = new TransferViewModel();
            }

            return _instance;
        }

        public string GetMsg(TransferModel message)
        {
            StringBuilder msg = new StringBuilder();
            foreach (var property in message.GetType().GetProperties())
            {
                string xValue = Convert.ToString(property.GetValue(message));
                if (!xValue.Equals(voidField) && !property.Name.Equals("RES"))
                {
                    msg.Append(xValue);
                    msg.Append(";");
                }

            }
            var theMSG = msg.ToString();

            return theMSG.Substring(0, theMSG.Length - 1);
        }

        public string GetResponse(TransferModel message)
        {
            StringBuilder msg = new StringBuilder();
            foreach (var property in message.GetType().GetProperties())
            {
                string xValue = Convert.ToString(property.GetValue(message));
                if (!xValue.Equals(voidField) && !property.Name.Equals("LEN") && !property.Name.Equals("DATA"))
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
