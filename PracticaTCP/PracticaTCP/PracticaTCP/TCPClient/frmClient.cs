using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;
using System.Xml;
using System.Threading;

namespace TCPClient
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        Dictionary<string, List<string>> infoProtocols = new Dictionary<string, List<string>>();
        string xmlPath = Application.StartupPath + "/TCPSettings.xml";
        Thread filComprovarXarxa;
        NetworkStream ns;
        TcpClient client;

        private void frmClient_Load(object sender, EventArgs e)
        {
            infoProtocols = GetInfoServer();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        //Botó per comprovar la nconnexió
        private void btn_comprovarXarxa_Click(object sender, EventArgs e)
        {
            filComprovarXarxa = new Thread(ComprovarXarxa);
            filComprovarXarxa.Start();
        }

        //Botó per desconectar o tancar fils i objectes
        private void btn_desconnect_Click(object sender, EventArgs e)
        {
            Tancar();
        }

        //Botó per enviar el missatge al servidor per TCP
        private void btn_sendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_message.Text != null)
                {
                    EnviarMissatge();
                }

            }
            catch (FormatException)
            {

                MessageBox.Show("No s'ha escrit cap missatge");
            }

        }

        //Botó per modificar i actualitzar dades del nostre XML de configuració
        private void btn_config_Click(object sender, EventArgs e)
        {

            UpdateInfoProtocols();
            UpdateXML();
            MessageBox.Show("Fitxer de configuració modificat correctament");

        }

        //Comprova i fa ping a la ip i segons el resultat canvia el color d'un panel, canvia el missatge i permet modificar IP i port
        private void ComprovarXarxa()
        {
            bool xarxa;
            int numComprovacio;
            pnl_status.BackColor = Color.Yellow;


            xarxa = VerificarXarxa();
            numComprovacio = FerPing("127.0.0.1");

            if (xarxa && numComprovacio >= 5)
            {
                label1.Text = "Connexió correcta";
                pnl_status.BackColor = Color.Green;

                txb_ip.Text = infoProtocols["TCP"][0];
                txb_port.Text = infoProtocols["TCP"][1];
            }
            else
            {
                pnl_status.BackColor = Color.Red;
                label1.Text = "Ping no contesta o Xarxa no disponible";
            }
        }

        //Verifica si hi ha alguna targeta de xarxa aixecada
        private bool VerificarXarxa()
        {
            bool tenimXarxa;
            tenimXarxa = NetworkInterface.GetIsNetworkAvailable();

            return tenimXarxa;
        }

        //En rentornarà un missatge depenen del resultat del ping a la IP establerta
        private string XarxaCorrecte(string ipAddress)
        {
            Ping myPing = new Ping();
            PingReply reply = myPing.Send(ipAddress, 1000);
            string status;
            if (reply.Address != null)
            {
                status = "OK";
            }
            else
            {
                status = "NOK";
            }
            return status;
        }

        //Fa Ping i utilitzant XarxaCorrecte() sabrem quin missatge haurem d'afegir en el listbox
        private int FerPing(string ipAddress)
        {
            string xarxaOk;
            int comptadorOK = 0;
            lbx_console.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                xarxaOk = XarxaCorrecte(ipAddress);
                if (xarxaOk == "OK")
                {
                    comptadorOK++;
                }
                lbx_console.Items.Add("Ping" + i + "-" + xarxaOk);
            }
            return comptadorOK;

        }

        //Donat un diccionari que la nostra key sera "TCP" o "UDP" i dins de cada clau els nostres values que es guarden en una llista
        //Amb aquest selecciona les dades del XML i les afegeix al diccionari. I l'utilitzem en el Load per carregar les dades globalment.
        private Dictionary<string, List<string>> GetInfoServer()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(this.xmlPath);

            Dictionary<string, List<string>> infoProtocols = new Dictionary<string, List<string>>();
            List<string> dades;
            XmlNodeList xmlValues = doc.SelectNodes("ConfigurationData/Protocol");

            foreach (XmlNode item in xmlValues.Item(0))
            {
                dades = new List<string>();
                foreach (XmlElement value in item)
                {
                    dades.Add(value.InnerText.Trim());
                }
                infoProtocols.Add(item.Name, dades);
            }
            return infoProtocols;
        }

        //Amb el diccionari especifiquem el index indicat correspon a la dada del textbox
        private void UpdateInfoProtocols()
        {

            infoProtocols["TCP"][0] = txb_ip.Text;
            infoProtocols["TCP"][1] = txb_port.Text;


        }

        //Amb el diccionari ja indicat la informació o dada que es escriurem amb el XmlWriter actualitzarem el XML 
        private void UpdateXML()
        {

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter textWriter = XmlWriter.Create("TCPSettings.xml", settings);
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("ConfigurationData");

            textWriter.WriteStartElement("Protocol");

            string[] protocols = { "TCP", "UDP" };

            foreach (var item in protocols)
            {
                textWriter.WriteStartElement(item);
                textWriter.WriteElementString("IP", infoProtocols[item][0]);
                textWriter.WriteElementString("Port", infoProtocols[item][1]);
            }

            textWriter.Close();
        }


        //Indicant IP i Port enviarem un missatge al servidor per TCP
        private void EnviarMissatge()
        {
            string server = txb_ip.Text;
            int port = int.Parse(txb_port.Text);
            try
            {
                client = new TcpClient(server, port);
                byte[] dades = Encoding.ASCII.GetBytes(txb_message.Text);
                ns = client.GetStream();

                ns.Write(dades, 0, dades.Length);
                ns.Close();
                client.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("No s'ha establert connexió amb el servidor"); ;
            }

        }

        private void Tancar()
        {
            if (filComprovarXarxa != null)
            {
                filComprovarXarxa.Abort();
            }


        }


        //Event que permet que encara que no es premi el botó desconectar, parant el programa o premem la creueta tancarem fils
        private void frmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tancar();
        }


    }
}
