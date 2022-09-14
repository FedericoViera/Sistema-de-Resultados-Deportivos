using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetComm;


    class ClientePresentacion
    {

    protected NetComm.Client cliente;
    protected string servidor_notificaciones;
    protected string id_premium;

    public ClientePresentacion()
    {
        cliente = new NetComm.Client(); 
        servidor_notificaciones = Controlador.getDominio().servidores.ElementAt(1).ip;
        id_premium = "Premium-" + CacheUsuarioPresentacion.id_usuario;
        cliente.DataReceived += new NetComm.Client.DataReceivedEventHandler(client_DataReceived);
        cliente.SendBufferSize = 400;
        cliente.ReceiveBufferSize = 50;
        cliente.NoDelay = true;
        //Se realiza la conexion con el servidor de notificaciones
        cliente.Connect(servidor_notificaciones, 9991, id_premium);
    }

    public bool conectar()
    {
        if (cliente.isConnected == false)
        { //si el cliente no esta conectado
            //Se realiza la conexion con el servidor de notificaciones
            cliente.Connect(servidor_notificaciones, 9991, id_premium);
        }
        //se devuelve si se logro la conexion o si el cliente está desconectado
        return cliente.isConnected;
    }
    void client_DataReceived(byte[] Data, string ID)
    {
        System.Windows.Forms.MessageBox.Show(UTF8Encoding.ASCII.GetString(Data));
    }
}

