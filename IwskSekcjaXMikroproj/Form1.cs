namespace IwskSekcjaXMikroproj
{
    public partial class Form1 : Form
    {
        private int[] speedRate = { 150, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000 };
        private int[] stopBitsNumbers = { 1, 2 };
        private int[] dataBitsNumbers = { 7, 8 };
        private char[] controlLetters = { 'E', 'O', 'N' };
        private enum StationType
        {
            Master,
            Slave
        }
        
        private Transmit transmit;

        public Form1()
        {
            transmit = new Transmit();

            InitializeComponent();

            stationTypeCB.DataSource = Enum.GetValues(typeof(StationType));
            flowControlTypeCB.DataSource = Enum.GetValues(typeof(FlowControl));
            transmissionSpeedBytesCB.DataSource = speedRate;
            stopBitsNumberCB.DataSource = stopBitsNumbers;
            dataBitsNumberCB.DataSource = dataBitsNumbers;
            controlLetterCB.DataSource = controlLetters;
        }

        private void sendBT_Click(object sender, EventArgs e)
        {
            var config = SetupConfig();
            transmit.TransmitData(config);
        }

        private void receiveBT_Click(object sender, EventArgs e)
        {
            var config = SetupConfig();
            transmit.RecieveData(config);
        }

        private void pingBT_Click(object sender, EventArgs e)
        {
            var config = SetupConfig();
            transmit.PingYourSlave(config);
        }

        private Config SetupConfig()
        {
            var config = new Config();

            config.IsMaster = (StationType)Enum.Parse(typeof(StationType), stationTypeCB.SelectedValue.ToString()!) == StationType.Master;
            config.TransmissionSpeedBytes = int.Parse(transmissionSpeedBytesCB.SelectedValue.ToString()!);
            config.StopBitsNumber = int.Parse(stopBitsNumberCB.SelectedValue.ToString()!);
            config.DataBitsNumber = int.Parse(dataBitsNumberCB.SelectedValue.ToString()!);
            config.ControlLetter = char.Parse(controlLetterCB.SelectedValue.ToString()!);
            config.FlowControlType = (FlowControl)Enum.Parse(typeof(FlowControl), flowControlTypeCB.SelectedValue.ToString()!);
            config.TransmissionType = TransmissionType.Textual;

            config.Validate();
            
            return config;
        }
    }
}