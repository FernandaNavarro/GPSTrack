namespace Server.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CrashViewModel
    {
        #region Variables
        private static CrashViewModel _instance;
        private static string voidField = "#";
        #endregion

        #region Methods
        public static CrashViewModel GetReference()
        {
            if (_instance == null)
            {
                _instance = new CrashViewModel();
            }

            return _instance;
        }

        public string GetMsg(CrashViewModel message)
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
