using System.Net;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace ChatApp
{
    public partial class Form1 : Form
    {
        Socket sck; //used for some tools
        EndPoint epLocal, epRemote;
        byte[] buffer; //used for receving and sending message

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress,true);

            //get user ip

            textlocalip.Text = GetLocalip();
            textremoteip.Text = GetLocalip();
        }
        private string GetLocalip()
        {
            IPHostEntry Host;
            Host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in Host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();

            }
            return "127.0.0.1";
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //binding Socket
            epLocal = new IPEndPoint(IPAddress.Parse(textlocalip.Text), Convert.ToInt32(textlocalport.Text));
            sck.Bind(epLocal);

            //connecting to remote ip
            epRemote = new IPEndPoint(IPAddress.Parse(textremoteip.Text), Convert.ToInt32(textremoteport.Text));
            sck.Connect(epRemote);

            // liseting the specific port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                //converting byte[] to string 
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                //adding this message into listbox
                listMessage.Items.Add("Frd: " + receivedMessage);
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void buttonsend_Click(object sender, EventArgs e)
        {
            //convert string message to byte
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(textMessage.Text);

            //sending the Encoded message
            sck.Send(sendingMessage);

            //adding to listbox
            listMessage.Items.Add("Me:" + textMessage.Text);
            textMessage.Text = "";

        }
    }
}
