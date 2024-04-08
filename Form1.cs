using System.Net;
using System.Net.Sockets;
using System.Text;


namespace UdpClientApp
{
    public partial class Form1 : Form
    {
        private static IPEndPoint ep = new IPEndPoint(IPAddress.Parse("192.168.220.223"), 35487);
        private static UdpClient udpClient = new UdpClient(34205);
        private static string ipFrom;
        public Form1()
        {
            InitializeComponent();
            String strHostName = string.Empty;
           
            strHostName = Dns.GetHostName();
           
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            ipFrom = addr[1].ToString();
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            Message message = new Message(Command.Text, Text.Text, IpTo.Text, "192");
            string messageJson = message.ToJSON();

            byte[] messageData = Encoding.UTF8.GetBytes(messageJson);

            udpClient.Send(messageData, ep);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
