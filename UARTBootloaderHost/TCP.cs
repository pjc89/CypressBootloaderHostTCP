using System.Net.Sockets;
using System.Runtime.InteropServices;

/// <summary>
/// A simple class that wraps a TCP Client and 
/// </summary>
public class Client
{
    private TcpClient _tcpClient;
    private NetworkStream _networkStream;

    /// <summary>
    /// Creates a new TCP client and opens a the connection
    /// </summary>
    /// <param name="ip"></param>
    /// <param name="port"></param>
    public void Connect(string ip, int port)
    {
        _tcpClient = new TcpClient();
        _tcpClient.Connect(ip, port);
        _networkStream = _tcpClient.GetStream();
    }

    public void Close()
    {
        _tcpClient.Close();
    }



    public void TryClose()
    {
        try
        {
            Dispose();
        } catch
        {

        }
    }

    /// <summary>
    /// Sets the value 1 on register 245 via TCP 
    /// </summary>
    public void SendReset()
    {
        var resetMessage = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, 0xF5, 0x00, 0x01 };
        _networkStream.Write(resetMessage, 0, resetMessage.Length);
    }

    /// <summary>
    /// Reads <paramref name="bufferSize"/> into <paramref name="buffer"/>
    /// </summary>
    /// <param name="buffer">A byte array that will contain the bytes read from the TCP Stream</param>
    /// <param name="bufferSize">The buffer size</param>
    public void ReadBytes(byte[] buffer, int bufferSize)
    {
        var bytesRead = 0; 
        while(bytesRead < bufferSize)
        {
            // NetworkStream.Read returns the number of bytes that where consumed. 
            bytesRead += _networkStream.Read(buffer, bytesRead, bufferSize - bytesRead);
        }
    }

    /// <summary>
    /// Write <paramref name="bytes"/> over the network stream
    /// </summary>
    /// <param name="bytes">The data to be sent</param>
    public void WriteBytes(byte[] bytes)
    {
        _networkStream.Write(bytes, 0, bytes.Length);
    }

    public void Dispose()
    {
        try
        {
            _tcpClient.Dispose();
        }
        catch { 
        }
    }
}/*
public class clnt
{
    public static void TCP_Connection()
    {

        try
        {
            TcpClient tcpclnt = new TcpClient();
            Console.WriteLine("Connecting.....");

            tcpclnt.Connect("192.168.4.99", 9000);
            // use the ipaddress as in the server program

            Console.WriteLine("Connected");
            Console.Write("Enter the string to be transmitted : ");

            String str = Console.ReadLine();
            Stream stm = tcpclnt.GetStream();

            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] ba = asen.GetBytes(str);
            Console.WriteLine("Transmitting.....");

            stm.Write(ba, 0, ba.Length);

            byte[] bb = new byte[100];
            int k = stm.Read(bb, 0, 100);

            for (int i = 0; i < k; i++)
                Console.Write(Convert.ToChar(bb[i]));

            tcpclnt.Close();
        }

        catch (Exception e)
        {
            Console.WriteLine("Error..... " + e.StackTrace);
        }
    }

    public static void TCP_Open()
    {

        
        String IpAddress = "192.168.4.1";
        //IpAddress = comPortComboBox.Contains;
        int IpPort = 9000;


        TcpClient tcpclnt = new TcpClient();
        Console.WriteLine("Connecting.....");


        //tcpclnt.Connect("192.168.4.1", 9000);
        tcpclnt.Connect(IpAddress, IpPort);

        Stream stm = tcpclnt.GetStream();

    }

    public void TCP_SendReset()
    {

        TcpClient tcpclnt = new TcpClient();
        Stream stm = tcpclnt.GetStream();

        // send bytes from reset board TCPI
        // 00,00,00,00,00,06,01,06,00,F5,00,01
        byte[] bytestosend = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x06, 0x01, 0x06, 0x00, 0xF5, 0x00, 0x01 };

        // wait for connection
        Thread.Sleep(5000);

        //serialPort.Write(bytestosend, 0, 8);
        stm.Write(bytestosend, 0, 12);

        //serialPort.Flush();

        // wait for start boootloader
        Thread.Sleep(3000);

    }

    public void TCP_Close()
    {

        //
        TcpClient tcpclnt = new TcpClient();
        tcpclnt.Close();

    }

    public void TCP_Write(byte[] buffer, int zero, int size)
    {

        //
        TcpClient tcpclnt = new TcpClient();
        Stream stm = tcpclnt.GetStream();

        stm.Write(buffer, 0, size);

    }

    public void TCP_Read()
    {

        //
        TcpClient tcpclnt = new TcpClient();
        Stream stm = tcpclnt.GetStream();

    }
}*/