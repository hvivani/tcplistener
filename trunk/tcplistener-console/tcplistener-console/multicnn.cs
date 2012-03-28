using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace tcplistener_console
{
    class multicnn
    {

        public static void iniciar(string puerto, string addr)
        {
            TcpListener server = null;
            Int32 port = int.Parse(puerto);
            IPAddress localAddr = IPAddress.Parse(addr);

            server = new TcpListener(localAddr, port);
            server.Start();
            DoBeginAcceptSocket(server);
        }

        // Thread signal.
        public static ManualResetEvent clientConnected = new ManualResetEvent(false);


        // Accept one client connection asynchronously.
        public static void DoBeginAcceptSocket(TcpListener listener)
        {
            // Set the event to nonsignaled state.
            clientConnected.Reset();

            // Start to listen for connections from a client.
            Console.WriteLine("Waiting for a connection...");

            // Accept the connection.
            // BeginAcceptSocket() creates the accepted socket.
            listener.BeginAcceptSocket(
            new AsyncCallback(DoAcceptSocketCallback), listener);
            // Wait until a connection is made and processed before
            // continuing.
            clientConnected.WaitOne();
        }

        // Process the client connection.
        public static void DoAcceptSocketCallback(IAsyncResult ar)
        {
            // Get the listener that handles the client request.
            TcpListener listener = (TcpListener)ar.AsyncState;

            // End the operation and display the received data on the
            //console.
            Socket clientSocket = listener.EndAcceptSocket(ar);

            // Process the connection here. (Add the client to a
            // server table, read data, etc.)
            Console.WriteLine("Client connected completed");

            // Signal the calling thread to continue.
            clientConnected.Set();
        }
    }
}
