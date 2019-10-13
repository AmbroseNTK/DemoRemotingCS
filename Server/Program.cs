using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel tcpChannel = new TcpChannel(8888);
            ChannelServices.RegisterChannel(tcpChannel, true);

            Type theType = new Server().GetType();

            RemotingConfiguration.RegisterWellKnownServiceType(
              theType,
              "NoteServer",
              WellKnownObjectMode.Singleton);

            System.Console.WriteLine("Server is running\nPress ENTER to quit");
            System.Console.ReadLine();
        }
    }

    class Server : AbstractServer
    {
        public override List<Note> GetNote()
        {
            return new List<Note>()
            {
                new Note(){ Id="001",Title="Hello"},
                new Note(){Id="002",Title="World" }
            };
        }
    }
}
