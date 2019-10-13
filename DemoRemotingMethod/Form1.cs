using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Shared;

namespace DemoRemotingMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AbstractServer server;
        private void BtConnect_Click(object sender, EventArgs e)
        {
            TcpChannel tcpChannel = new TcpChannel(8889);
            ChannelServices.RegisterChannel(tcpChannel,true);
            server = (AbstractServer) Activator.GetObject(
                typeof(AbstractServer),
                "tcp://127.0.0.1:8888/NoteServer");

                
        }

        private void BtGetNotes_Click(object sender, EventArgs e)
        {
            try
            {
                List<Note> notes = server.GetNote();
                string result = "";
                foreach (Note note in notes)
                {
                    result += note.Id + ": " + note.Title + "\n";
                }
                MessageBox.Show(result, "Result");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
