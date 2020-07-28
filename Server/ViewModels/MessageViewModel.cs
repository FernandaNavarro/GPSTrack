﻿namespace Server.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Server.Models;

    public class MessageViewModel
    {
        #region Variables
        private static MessageViewModel _instance;

        public Dictionary<string, int> propertyLength = new Dictionary<string, int>()
        {
            {"HDR", 2 },
            {"PKT_LEN", 4 },
            {"DEV_ID", 10 },
            {"ACK_RPT", 2 },
            {"CHK_SUM", 2 }
        };
        private static string voidField = "#";
        #endregion

        #region Methods
        public static MessageViewModel GetReference()
        {
            if (_instance == null)
            {
                _instance = new MessageViewModel();
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

        public MessageModel GetObjZipFormat(string message)
        {
            var obj = new MessageModel();
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

        public MessageModel GetObjNormalFormat(string message)
        {
            var obj = new MessageModel();
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

        public void DisplayData(MessageModel status)
        {
            foreach (var property in status.GetType().GetProperties())
            {
                Console.WriteLine("Name: {0}\n      Value: {1}", property.Name, property.GetValue(status));
            }
        }

        public string GetMsgZipFormat(MessageModel message)
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

        public string GetMsgNormalFormat(MessageModel message)
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