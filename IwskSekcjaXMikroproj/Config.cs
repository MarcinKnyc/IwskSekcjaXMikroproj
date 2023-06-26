using System.IO.Ports;

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
        public TransmissionType TransmissionType { get; set; } // only textual is obligator

        // buttons: Nadawanie, Odbiór and Ping
        // powinno być okienko z tekstem wysłanej / odebranej ramki w dwóch formach: hexadecymalna i tekstowa
        
        public void Validate()
        {
            if (!(TransmissionSpeedBytes >= 150 && TransmissionSpeedBytes <= 115000))
                throw new Exception("TransmissionSpeed must be between 150 and 115000");

            //continue this validation
        }

        #region master
        public string MasterTransmittedTextualData { get; set; } = null!;
        public int MasterTimeoutMiliseconds { get; set; } // 0-10s
        public int MasterRetriesNumber { get; set; } // 0-5
        public int MasterTimeLimit { get; set; } // 0-1s

        #endregion
        #region slave
        public int SlaveAddress { get; set; }
        public int SlaveTimeLimit { get; set; } // 0-1s
        #endregion
    }
}
