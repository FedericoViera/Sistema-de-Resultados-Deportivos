using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetComm;
using Proyecto._2__Logica.Datos;

class ClienteNotificativo
{

    protected NetComm.Client cliente;
    protected string servidor_notificaciones;
    protected string id_notificativo;

    public ClienteNotificativo()
    {
        cliente = new NetComm.Client(); 
        servidor_notificaciones = Controlador.getDominio().servidores.ElementAt(1).ip;
        id_notificativo = "Notificativo-" + CacheUsuario.id_usuario;

        cliente.Connected += new NetComm.Client.ConnectedEventHandler(client_Connected);
        cliente.Disconnected += new NetComm.Client.DisconnectedEventHandler(client_Disconnected);
        cliente.DataReceived += new NetComm.Client.DataReceivedEventHandler(client_DataReceived);
        cliente.SendBufferSize = 400;
        cliente.ReceiveBufferSize = 50;
        cliente.NoDelay = true;
    }

    public bool conectar()
    {
        if (cliente.isConnected == false){ //si el cliente no esta conectado
            //Se realiza la conexion con el servidor de notificaciones
            cliente.Connect(servidor_notificaciones, 9991, id_notificativo);
        }
        //se devuelve si se logro la conexion o si el cliente está desconectado
        return cliente.isConnected;
    }
    public void mandarData()
    {
        cliente.SendData(UTF8Encoding.ASCII.GetBytes("hola santi"), "Premium-8");

    }
    void client_DataReceived(byte[] Data, string ID)
    {
        System.Windows.Forms.MessageBox.Show(UTF8Encoding.ASCII.GetString(Data));
    }

    void client_Disconnected()
    {
    }

    void client_Connected()
    {
        
    }
}

