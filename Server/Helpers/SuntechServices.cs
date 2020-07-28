namespace Server.Helpers
{
    using Server.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading.Tasks;
    using Server.ViewModels;

    //Don't delete the models those are necesaries.
    using Server.Models;

    enum HDRZip : int
    {
        StatusReport = 81,
        AlertReport = 82,
        KeepAliveReport = 83,
        ExternSDevDataReport = 84,
        TravelReport = 85,
        AcknowledgmentMessage = 90
    }
    
    public class SuntechServices
    {
        #region Variables
        private static Dictionary<string, string> HDRNormal = new Dictionary<string, string>()
        {
            {"StatusReport", "STT" },
            {"AlertReport", "ALT" },
            {"KeepAliveReport", "ALV" },
            {"ExternSDevDataReport", "UEX" },
            {"TravelReport", "TRV" },
            {"AcknowledgmentMessage", "ACK" },
            {"MaintenanceReport", "MNT" }            
        };
        #endregion

        #region Methods        
        public void DeserializeZip(string data)
        {
            var HDR = Convert.ToInt32(data.Substring(0, 2));
            var myObj = new Object();
            switch (HDR)
            {       
                case (int)HDRZip.StatusReport:

                    var status = new StatusViewModel();
                    myObj = status.GetObjZipFormat(data);
                    status.DisplayData((StatusModel)myObj);
                    break;
                case (int)HDRZip.AlertReport:

                    break;
                case (int)HDRZip.KeepAliveReport:

                    break;
                case (int)HDRZip.ExternSDevDataReport:

                    break;
                case (int)HDRZip.TravelReport:

                    break;
                case (int)HDRZip.AcknowledgmentMessage:

                    break;
                default:

                    break;
            }
        }

        public void DeserializeNormal(string data)
        {
            

        }
        #endregion
    }
}
