using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IwskSekcjaXMikroproj
{
    public class Config
    {
        public bool IsMaster { get; set; } //False for slave
        public int TransmissionSpeedBytes { get; set; } // 150-115000 bytes
        public int StopBitsNumber { get; set; } // 1 or 2
        public int DataBitsNumber { get; set; } // 7 or 8
        public char ControlLetter { get; set; } //E, O, N
        public FlowControl FlowControlType { get; set; } // 0 - None, 
        public TransmissionType TransmissionType { get; set; } // only textual is obligatory
        // buttons: Nadawanie, Odbiór and Ping

        #region master
        #endregion
        #region slave
        #endregion
    }
}
