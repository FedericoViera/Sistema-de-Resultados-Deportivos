using Presentacion._1__Acceso_a_datos;
using Proyecto._2__Logica.Datos;
using Proyecto._2__Logica.Dominio.Entidades;
using Reestructuracion_Proyecto._2__Logica.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

public static class Controlador
{
    private static ClienteNotificativo clienteNotificativo;
    private static Consultas consulta;
    private static Sentencias sentencia;
    private static List<string> lista;
    private static string[,] array;
    private static Dominio dominio;
    private static Convertir_A_DataTable convertir_a_datatable;
    private static Obtener_Id_Objeto id_objeto;
    static Controlador() {
        consulta = new Consultas();
        sentencia = new Sentencias();
        dominio = new Dominio();
        lista = new List<string>();
        convertir_a_datatable = new Convertir_A_DataTable();
        id_objeto = new Obtener_Id_Objeto();
        array = new string[3, 6];
    }

    public static string[,] CargarInformacion(string Clase)
    {
        string[,] manejadorArray = new string[0,0];
        DataTable manejadorTabla = new DataTable();
        try
        {
            consulta.CargarInformacion(Clase).Fill(manejadorTabla);

            manejadorArray = new string[manejadorTabla.Rows.Count, manejadorTabla.Columns.Count];
            for (int j = 0; j < manejadorTabla.Rows.Count; j++)
            {
                for (int i = 0; i < manejadorTabla.Columns.Count; i++)
                {
                    manejadorArray[j, i] = manejadorTabla.Rows[j][i].ToString();
                }
            }
            return manejadorArray;
        }
        catch (Exception)
        {
            return manejadorArray;
        }
       
    }
    public static void mandarData()
    {
        clienteNotificativo.mandarData();
    }
    public static Dominio getDominio()
    {
        return dominio;
    }

    public static Convertir_A_DataTable Lista_A_DataTable()
    {
        return convertir_a_datatable;
    }
    public static Obtener_Id_Objeto Id_Objeto()
    {
        return id_objeto;
    }
    public static DataTable Eventos_Estado(string estado)
    {
        DataTable tabla = new DataTable();
        DataTable tabla_eventos = convertir_a_datatable.Convertir<Eventos>(dominio.eventos);
        for (int i = 0; i < tabla_eventos.Columns.Count; i++)
        {
            tabla.Columns.Add(tabla_eventos.Columns[i].ToString());
        }
        for (int i = 0; i < tabla_eventos.Rows.Count; i++)
        {
            if (tabla_eventos.Rows[i][8].ToString() == estado)
            {
                tabla.ImportRow(tabla_eventos.Rows[i]);
            }
        }
        return tabla;
    }

    public static bool verificarConexionNotificativo()
    {
        return clienteNotificativo.conectar();
    }

    public static void crearConexionClienteNotificativo()
    {
        clienteNotificativo = new ClienteNotificativo();
    }
    public static DataTable DeportistasDeEquipo(string equipo)
    {
        DataTable tabla = new DataTable();
        DataTable tabla_deportistas = convertir_a_datatable.Convertir<Deportistas>(dominio.deportistas);
        for (int i = 0; i < tabla_deportistas.Columns.Count; i++)
        {
            tabla.Columns.Add(tabla_deportistas.Columns[i].ToString());
        }
        for (int i = 0; i < tabla_deportistas.Rows.Count; i++)
        {
            if (tabla_deportistas.Rows[i][5].ToString() == equipo)
            {
                tabla.ImportRow(tabla_deportistas.Rows[i]);
            }            
        }
        return tabla;
    }
    public static List<string> DeportistasDeEquipoNombreApellido(string equipo)
    {
        List<string> lista_deportistas = new List<string>();
        string nombre = "";
        foreach (Deportistas deportista in dominio.deportistas)
        {
            if (deportista.equipo == equipo)
            {
                nombre = deportista.nombre + " " + deportista.apellido;
                lista_deportistas.Add(nombre);
            }
        }
        return lista_deportistas;
    }
    public static List<string> DeportistasDeDeporte(string deporte)
    {
        List<string> lista_deportistas = new List<string>();
        string nombre = "";
        foreach (Deportistas deportista in dominio.deportistas)
        {
            if (deportista.deporte == deporte)
            {
                nombre = deportista.nombre + " " + deportista.apellido;
                lista_deportistas.Add(nombre);
            }
        }
        return lista_deportistas;
    }
    public static DataTable PartidosDeEquipo(int evento)
    {
        DataTable tabla = new DataTable();
        DataTable tablaPartidos = convertir_a_datatable.Convertir<Partidos>(dominio.partidos);
        for (int i = 0; i < tablaPartidos.Columns.Count; i++)
        {
            tabla.Columns.Add(tablaPartidos.Columns[i].ToString());
        }
        for (int i = 0; i < tablaPartidos.Rows.Count; i++)
        {
            if (Int16.Parse(tablaPartidos.Rows[i][4].ToString()) == evento)
            {
                tabla.ImportRow(tablaPartidos.Rows[i]);
            }
        }
        return tabla;
    }
    public static DataTable EncuentrosDeIndividuales(int evento)
    {
        DataTable tabla = new DataTable();
        DataTable tablaEncuentros = convertir_a_datatable.Convertir<Encuentros>(dominio.encuentros);
        for (int i = 0; i < tablaEncuentros.Columns.Count; i++)
        {
            tabla.Columns.Add(tablaEncuentros.Columns[i].ToString());
        }
        for (int i = 0; i < tablaEncuentros.Rows.Count; i++)
        {
            if (Int16.Parse(tablaEncuentros.Rows[i][2].ToString()) == evento)
            {
                tabla.ImportRow(tablaEncuentros.Rows[i]);
            }
        }
        return tabla;
    }
    public static DataTable obtenerResultadosIndividualesPorTiempo(int id_encuentro,int numero_ordinal)
    {
        DataTable tabla = new DataTable();
        DataTable tablaResultados = convertir_a_datatable.Convertir<Puntua>(dominio.puntajes);
        for (int i = 0; i < tablaResultados.Columns.Count; i++)
        {
            tabla.Columns.Add(tablaResultados.Columns[i].ToString());
        }
        for (int i = 0; i < tablaResultados.Rows.Count; i++)
        {
            if (Int16.Parse(tablaResultados.Rows[i][0].ToString()) == id_encuentro && Int16.Parse(tablaResultados.Rows[i][1].ToString())==numero_ordinal)
            {
                tabla.ImportRow(tablaResultados.Rows[i]);
            }
        }
        return tabla;
    }
    public static int SetsEncuentroCantiddad(int id_encuentro)
    {
        int contador = 0;
        List<int> lista = new List<int>();
        foreach (Sets_Rounds item in dominio.sets_rounds)
        {
            if (item.id_encuentro == id_encuentro)
            {
                if (!(lista.Contains(item.numero_ordinal)))
                {
                    lista.Add(item.numero_ordinal);
                    contador++;
                }
            }
        }
        return contador;
    }
    public static List<string> DeportistasParticipantesEncuentro(int id_encuentro)
    {
        List<int> lista_id = new List<int>();
        List<string> lista_nombres = new List<string>();
        foreach (Puntua item in dominio.puntajes)
        {
            if (item.id_encuentro == id_encuentro)
            {
                if (!(lista_id.Contains(item.id_deportista)))
                {
                    lista_id.Add(item.id_deportista);
                }
            }
        }
        foreach (int item in lista_id)
        {
            foreach (Deportistas deportistas in dominio.deportistas)
            {
                if (deportistas.id==item)
                {
                    lista_nombres.Add(deportistas.nombre + " " + deportistas.apellido);
                }
            }
        }
        return lista_nombres;
    }
    public static DataTable obtenerResultadosEquipos(int id_partido)
    {
        DataTable tabla = new DataTable();
        DataTable tablaResultados = convertir_a_datatable.Convertir<Tiempos>(dominio.tiempos);
        for (int i = 0; i < tablaResultados.Columns.Count; i++)
        {
            tabla.Columns.Add(tablaResultados.Columns[i].ToString());
        }
        for (int i = 0; i < tablaResultados.Rows.Count; i++)
        {
            if (Int16.Parse(tablaResultados.Rows[i][0].ToString()) == id_partido)
            {
                tabla.ImportRow(tablaResultados.Rows[i]);
            }
        }
        return tabla;
    }
    public static bool crearPartido(int id_evento, DateTime fecha, string eq1, string eq2)
    {
        int id_eq_1 = id_objeto.Obtener_Id<Equipos>(dominio.equipos, eq1);
        int id_eq_2 = id_objeto.Obtener_Id<Equipos>(dominio.equipos, eq2);
        if (sentencia.crearPartido(id_evento, fecha.ToString("yyyy/MM/dd"),id_eq_1,id_eq_2))
        {
            int id_partido = sentencia.UltimaIdInsertada();
            Partidos partido = new Partidos(id_partido, fecha, eq1,eq2,id_evento);
            dominio.partidos.Add(partido);
            return true;
        }
        return false;
    }
    public static bool adicionarTiempo(int id_partido,string eq1,string eq2)
    {
        int numero_ordinal = 1;
        foreach (Tiempos tiempo in dominio.tiempos)
        {
           if (tiempo.id_partido == id_partido)
           {
                numero_ordinal++;
           }
        }        
        if (sentencia.crearTiempo(id_partido, numero_ordinal))
        {            
            Tiempos tiempo = new Tiempos(id_partido, numero_ordinal, eq1,0,0, eq2, "", "");
            dominio.tiempos.Add(tiempo);
            return true;
        }
        return false;
    }
    public static bool eliminarTiempo(int id_partido,int numero_ordinal)
    {
        int tiempo_eliminar = 0;
        if (sentencia.eliminarTiempo(id_partido,numero_ordinal)==true)
        {
            foreach (Tiempos item in dominio.tiempos)
            {
                if (item.id_partido==id_partido && item.tiempo==numero_ordinal)
                {
                    tiempo_eliminar = dominio.tiempos.IndexOf(item);
                }
            }
            dominio.tiempos.RemoveAt(tiempo_eliminar);
            return true;
        }
        return false;
    }
    public static void Asociar_Desasociar_Imagen(string modo,int id_banner,int id_imagen)
    {
        switch (modo)
        {
            case "Asociar":
                if (sentencia.AsociarDesasociarImagenBanner(modo, id_banner, id_imagen)==true){
                    ImagenesAsociadas asociar_imagen = new ImagenesAsociadas(id_imagen, id_banner);
                    dominio.imagenesAsociadas.Add(asociar_imagen);
                }
                break;
            case "Desasociar":
                if (sentencia.AsociarDesasociarImagenBanner(modo, id_banner, id_imagen) == true)
                {
                    for (int i = dominio.imagenesAsociadas.Count - 1; i >= 0; i--)
                    {
                        if (dominio.imagenesAsociadas.ElementAt(i).id_banner == id_banner && dominio.imagenesAsociadas.ElementAt(i).id_imagen == id_imagen)
                        {
                            dominio.imagenesAsociadas.Remove(dominio.imagenesAsociadas.ElementAt(i));
                        }
                    }
                }
                
                break;
            default:
                break;
        }
    }
    public static bool AsociarBannerUsuario(string tieneBannerAsociado, int id_usuario, int id_banner)
    {
        return sentencia.AsociarBannerUsuario(tieneBannerAsociado, id_usuario, id_banner);
    }
    public static void Integrante_Equipo(string equipo, int id_deportista)
    {
        int id_equipo = id_objeto.Obtener_Id<Equipos>(dominio.equipos, equipo);
        if (sentencia.Integrante_Equipo(id_equipo, id_deportista) == true)
        {
            foreach (Deportistas item in dominio.deportistas)
            {
                if (item.id == id_deportista)
                {
                    item.equipo = equipo;
                }
            }
        }
    }
    public static DataTable ImagenesNoDeBanner(int id_banner)
    {
        List<Imagenes> listaImagenes = new List<Imagenes>();
        List<int> a_remover = new List<int>();
        foreach (Imagenes imagen in dominio.imagenes)
        {
            listaImagenes.Add(imagen);
        }
        for (int i = 0; i < listaImagenes.Count; i++)
        {
            foreach (var asociacion in dominio.imagenesAsociadas)
            {
                if (listaImagenes.ElementAt(i).id == asociacion.id_imagen && asociacion.id_banner == id_banner)
                {
                    a_remover.Add(i);
                }
            }
        }
        for (int i = a_remover.Count-1; i >= 0; i--)
        {
            listaImagenes.RemoveAt(a_remover.ElementAt(i));
        }        
        return convertir_a_datatable.Convertir<Imagenes>(listaImagenes);
    }
    public static DataTable ImagenesDeBanner(int id_banner)
    {
        List<Imagenes> lista = new List<Imagenes>();
        foreach (Imagenes imagen in dominio.imagenes)
        {
            foreach (var asociacion in dominio.imagenesAsociadas)
            {
                if (imagen.id == asociacion.id_imagen && asociacion.id_banner==id_banner)
                {
                    lista.Add(imagen);
                }
            }
            
        }
        return convertir_a_datatable.Convertir<Imagenes>(lista);        
    }

    public static bool ActualizarResultadoEquipo(int id_partido,int numero_ordinal,int score1,int score2,string detalle1,string detalle2)
    {
        if (sentencia.ActualizarResultadoEquipo(id_partido, numero_ordinal, score1, score2, detalle1, detalle2))
        {
            foreach (Tiempos tiempo in dominio.tiempos)
            {
                if (tiempo.id_partido==id_partido && tiempo.tiempo == numero_ordinal)
                {
                    tiempo.score_eq_1 = score1;
                    tiempo.score_eq_2 = score2;
                    tiempo.detalle1 = detalle1;
                    tiempo.detalle2 = detalle2;
                    return true;
                }
            }
        }
        return false;
    }
    // Listas

    // Se obtiene el resultado de la consulta del login en base al nombre de usuario y la contraseña.
    // Se transforma de MySqlDataAdapter a un DataTable, y se recorren sus elementos para asignarlos a cada variable
    // Luego de esto, se crea una nueva instancia de la clase CacheUsuario con todos estos datos
    // Por ultimo, se asignan estos datos de manera secuencial a una lista de strings, y esto sera el Return
    // de la funcion
    public static List<string> loginUsuario(string user, string pass)
    {
        DataTable tabla = new DataTable();
        List<string> datos = new List<string>();
        consulta.UsuarioLoguearse(user, pass).Fill(tabla);
        if (!(tabla.Rows.Count == 0))
        {
            tabla.Dispose();
            tabla = new DataTable();
            consulta.UsuarioObtenerDatosPorNombre(user).Fill(tabla);

            CacheUsuario.id_usuario = Int16.Parse(tabla.Rows[0][0].ToString());
            CacheUsuario.nombre_usuario = tabla.Rows[0][1].ToString();
            CacheUsuario.nombre = tabla.Rows[0][2].ToString();
            CacheUsuario.apellido = tabla.Rows[0][3].ToString();
            CacheUsuario.correo = tabla.Rows[0][4].ToString();
            if (!(tabla.Rows[0][5].ToString()==null))
            {
                CacheUsuario.string_imagen = tabla.Rows[0][5].ToString();
            }
            CacheUsuario.rol = tabla.Rows[0][6].ToString();

            for (int j = 0; j < tabla.Columns.Count; j++)
            {
                datos.Add(tabla.Rows[0].ItemArray[j].ToString());
            }

        } else
        {
            datos.Add("false");
        }

        return datos;
    }

    // se utiliza desde el backoffice para obtener la informacion de un usuario a la hora de buscarlo por su nombre de usuario
    // esto ocurre en la inferfaz de edicion de usuario
    public static List<string> obtenerDatosUsuario(string nombre_u)
    {
        DataTable tabla = new DataTable();
        List<string> datos = new List<string>();
        consulta.UsuarioObtenerDatosPorNombre(nombre_u).Fill(tabla);
        if (!(tabla.Rows.Count == 0)) {
            for (int j = 0; j < tabla.Columns.Count; j++) {
                datos.Add(tabla.Rows[0].ItemArray[j].ToString());
            }
        } else {
            datos.Add("false");
        }
        return datos;
    }

    public static DataTable BannersUsuariosPublicos()
    {
        DataTable tabla = new DataTable();
        consulta.BannersUsuariosPublicos().Fill(tabla);
        return tabla;
        
    }
    public static DataTable UsuariosPremium()
    {
        DataTable tabla = new DataTable();
        consulta.UsuariosPremium().Fill(tabla);
        return tabla;

    }

    //Fin de Listas

    // Comienzo de DataTables

    // se llama a esta funcion cuando el formulario de backoffice principal es instanciado
    // por defecto, se muestra una lista con todos los usuarios de la base de datos
    public static bool RebocarCuenta(int id_usuario)
    {
        return sentencia.RebocarCuenta(id_usuario);
    }
    public static bool AprobarSolicitud(int id_usuario)
    {
        return sentencia.AprobarSolicitud(id_usuario);
    }
    public static bool EliminarSolicitud(int id_usuario)
    {
        return sentencia.EliminarSolicitud(id_usuario);
    }
    public static bool CulminarEvento(int id_evento,DateTime fecha_culminacion)
    {
        if (sentencia.CulminarEvento(id_evento,fecha_culminacion.ToString("yyyy-MM-dd"))==true)
        {
            foreach (Eventos evento in dominio.eventos)
            {
                if (evento.id==id_evento)
                {
                    evento.culminado = "Culminados";
                    evento.fecha_fin = fecha_culminacion.ToString("yyyy-MM-dd");
                }
            }
            return true;
        } 
        return false;
    }
    public static bool ReAbrirEvento(int id_evento)
    {
        if (sentencia.ReAbrirEvento(id_evento) == true)
        {
            foreach (Eventos evento in dominio.eventos)
            {
                if (evento.id == id_evento)
                {
                    evento.culminado = "En curso";
                }
            }
            return true;
        }
        return false;
    }
    public static DataTable ListaSolicitudes()
    {
        DataTable tabla = new DataTable();
        consulta.SolicitudesPremium().Fill(tabla);
        return tabla;
    }
    

    public static DataTable ListaUsuarios()
    {
        DataTable tabla = new DataTable();
        consulta.UsuariosLista().Fill(tabla);
        tabla.Columns.RemoveAt(5);
        return tabla;
    }

    public static DataTable ListaUsuariosPorAproximacion(string busqueda)
    {
        DataTable tabla = new DataTable();
        consulta.UsuariosListaPorAproximacion(busqueda).Fill(tabla);
        return tabla;
    }

    //Fin de DataTables

    // Bool

    // se ejecuta una sentencia para eliminar un usuario, el metodo devuelve true o false
    public static bool eliminarUsuario(string id_u)
    {
        sentencia.eliminarUsuario(id_u);

        return true;
    }

    public static DateTime InicioEvento(int id_evento)
    {
        DateTime fecha_inicio = DateTime.Now;
        foreach (Eventos item in dominio.eventos)
        {
            if (item.id == id_evento)
                fecha_inicio = Convert.ToDateTime(item.fecha_inicio);
        }
        return fecha_inicio;
    }

    //comprueba si existe un usuario
    public static bool comprobarExisteUsuario(String nombre_u)
    {
        DataTable tabla = new DataTable();
        consulta.UsuarioObtenerDatosPorNombre(nombre_u).Fill(tabla);
        if ((tabla.Rows.Count == 0))
        {
            return false;
        }
        else
        {
            return true;
        }
    }


    // se ejecuta una sentencia para agregar un usuario desde la interfaz de backoffice de agregar un usuario
    public static bool agregarUsuario(String nombre_u, String nombre, String apellido, String rol, String email, String contraseña)
    {
        DataTable tabla = new DataTable();

        if (sentencia.agregarUsuario(nombre_u, nombre, apellido, email, contraseña))
        {
            int id_usuario = sentencia.UltimaIdInsertada();
            return sentencia.agregarRolUsuario(id_usuario, rol);
        } else
        {
            return false;
        }
    }

    // se ejecuta una sentencia para editar la informacion de un usuario, devuelve true o false, desde la interfaz de backoffice de editar un usuario
    public static bool actualizarIpServidor(string ip, string nombre_servidor)
    {
       if (sentencia.editarIpServidor(ip, nombre_servidor))
        {
            foreach (var item in dominio.servidores)
            {
                if (item.nombre==nombre_servidor)
                {
                    item.ip = ip;
                    return true;
                }
            }
        }
        return false;

    }
    // se ejecuta una sentencia para editar la informacion de un usuario, devuelve true o false, desde la interfaz de backoffice de editar un usuario
    public static bool editarUsuario(String nombre_u, String nuevoNombre,
        String nuevoApellido, String nuevoEmail, String nuevaContrasena, string nuevo_rol,bool cambioContraseña)
    {
        DataTable manejador = new DataTable();
        int id_usuario = 0;
        if (sentencia.editarUsuario(nombre_u, nuevoNombre, nuevoApellido, nuevoEmail, nuevaContrasena,cambioContraseña)){

            consulta.UsuarioObtenerDatosPorNombre(nombre_u).Fill(manejador);

            id_usuario = Int16.Parse(manejador.Rows[0].ItemArray[0].ToString());
        }
        return sentencia.actualizarRolUsuario(id_usuario, nuevo_rol);

    }

    public static string[,] obtenerListaNoticiasUsuariosPublicos()
    {
        DataTable tabla = new DataTable();
        consulta.NoticiasListaUsuariosPublicos().Fill(tabla);
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                array[i, j] = tabla.Rows[i][j].ToString();
            }
        }

        return array;

    }
    public static string[,] obtenerListaResulatadosEquiposUsuariosPublicos()
    {
        string[,] resultadosEquipos = new string[3, 7];
        DataTable tabla = new DataTable();
        consulta.ResultadosEquiposListaUsuariosPublicos().Fill(tabla);
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                resultadosEquipos[i, j] = tabla.Rows[i][j].ToString();
            }
        }
        return resultadosEquipos;
    }

    public static bool guardarCatDeportes(string catDep)
    {
        bool e = false;
        for (int i = 0; i < dominio.categorias_deportes.Count; i++)
        {
            if (dominio.categorias_deportes.ElementAt(i).getNombre() == catDep)
            {
                e = true;
            }
        }
        if (e == false)
        {
            if (sentencia.crearCatDep(catDep) == true)
            {
                Categoria_disciplina cat_disc = new Categoria_disciplina(sentencia.UltimaIdInsertada(), catDep);
                dominio.categorias_deportes.Add(cat_disc);
            }

        }
        return e;

    }



    public static bool guardarDeportes(string dep)
    {
        bool e = false;
        for (int i = 0; i < dominio.deportes.Count; i++)
        {
            if (dominio.deportes.ElementAt(i).nombre == dep)
            {
                e = true;
            }
        }
        if (e == false)
        {
            if (sentencia.crearDeporte(dep) == true)
            {
                Disciplinas deporte = new Disciplinas(sentencia.UltimaIdInsertada(), dep);
                dominio.deportes.Add(deporte);
            }

        }
        return e;

    }
    public static string IpServidor(string nombre_servidor)
    {
        string ip = "";
        foreach (Servidores item in dominio.servidores)
        {
            if (item.nombre == nombre_servidor)
            {
                ip = item.ip;
            }
        }
        return ip;

    }
    public static bool guardarPais(string pais)
    {
        bool e = false;
        for (int i = 0; i < dominio.paises.Count; i++)
        {
            if (dominio.paises.ElementAt(i).nombre == pais)
            {
                e = true;
            }
        }
        if (e == false)
        {
            if (sentencia.crearPais(pais) == true)
            {
                Paises objeto = new Paises(sentencia.UltimaIdInsertada(), pais);
                dominio.paises.Add(objeto);
            }

        }
        return e;

    }

    public static bool guardarEmpresa(string empresa)
    {
        bool e = false;
        for (int i = 0; i < dominio.empresas.Count; i++)
        {
            if (dominio.empresas.ElementAt(i).nombre == empresa)
            {
                e = true;
            }
        }
        if (e == false)
        {
            if (sentencia.crearEmpresa(empresa) == true)
            {
                Empresas objeto = new Empresas(sentencia.UltimaIdInsertada(), empresa);
                dominio.empresas.Add(objeto);
            }

        }
        return e;

    }
    public static bool guardarBanner(string modo,int id_banner, string nombre, string posicion)
    {
        bool correcto = false;
        int id_posicion = id_objeto.Obtener_Id<Posiciones_pantalla>(dominio.posiciones, posicion);

        if (sentencia.guardarBanner(modo, id_banner,nombre, id_posicion))
        {
            switch (modo)
            {
                case "Crear":
                    int id = sentencia.UltimaIdInsertada();
                    Banners banner = new Banners(id, nombre, posicion);
                    dominio.banners.Add(banner);
                    correcto = true;
                    break;
                case "Editar":
                    foreach (Banners item in dominio.banners)
                    {
                        if (item.id==id_banner)
                        {
                            item.nombre = nombre;
                            item.posicion = posicion;
                            correcto = true;
                        }
                    }
                    break;
                default:
                    break;
            }
        }
       
        return correcto;
    }
    public static bool guardarDeportista(string nombre, string apellido, string pais, string deporte)
    {
        int id_pais = id_objeto.Obtener_Id<Paises>(dominio.paises, pais);
        int id_deporte = id_objeto.Obtener_Id<Disciplinas>(dominio.deportes, deporte);
        if (sentencia.crearDeportista(nombre,apellido, id_pais, id_deporte) == true)
        {
            Deportistas deportista = new Deportistas(sentencia.UltimaIdInsertada(), nombre, apellido, deporte, pais,"-Sin_equipo-");
            dominio.deportistas.Add(deportista);
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool editarDeportista(int id, string nombre,string apellido, string pais, string deporte)
    {
        int id_pais = id_objeto.Obtener_Id<Paises>(dominio.paises, pais);
        int id_deporte = id_objeto.Obtener_Id<Disciplinas>(dominio.deportes, deporte);
        if (sentencia.editarDeportista(id, nombre,apellido, id_pais, id_deporte) == true)
        {
            foreach (Deportistas item in dominio.deportistas)
            {
                if (item.id == id)
                {
                    item.nombre = nombre;
                    item.apellido = apellido;
                    item.pais = pais;
                    item.deporte = deporte;
                }
            }
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool guardarEquipos(string nombre, string pais, string deporte)
    {
        int id_pais = id_objeto.Obtener_Id<Paises>(dominio.paises, pais);
        int id_deporte = id_objeto.Obtener_Id<Disciplinas>(dominio.deportes, deporte);
        if (sentencia.crearEquipo(nombre, id_pais, id_deporte) == true)
        {
            Equipos equipo = new Equipos(sentencia.UltimaIdInsertada(),nombre, deporte, pais);
            dominio.equipos.Add(equipo);
            return true;
        } else
        {
            return false;
        }
    }
    public static bool editarEquipo(int id, string nombre_nuevo,string pais, string deporte)
    {
        int id_pais = id_objeto.Obtener_Id<Paises>(dominio.paises, pais);
        int id_deporte = id_objeto.Obtener_Id<Disciplinas>(dominio.deportes, deporte);
        if (sentencia.editarEquipo(id, nombre_nuevo, id_pais, id_deporte) == true)
        {
            foreach (Equipos item in dominio.equipos)
            {
                if (item.id == id)
                {
                    item.nombre= nombre_nuevo;
                    item.pais = pais;
                    item.disciplina= deporte;
                }
            }
            return true;
        }
        else
        {
            return false;
        }
    }



    public static bool eliminarCatDeportes(string catDep)
    {
        for (int i = 0; i < dominio.categorias_deportes.Count; i++)
        {
            if (dominio.categorias_deportes.ElementAt(i).getNombre() == catDep)
            {
                if (sentencia.eliminarCatDep(catDep) == true)
                {
                    dominio.categorias_deportes.Remove(dominio.categorias_deportes.ElementAt(i));
                    return true;
                }
                else
                {
                    return false;
                }


            }
        }
        return false;
    }
    public static bool eliminarBanner(int id)
    {
        if (sentencia.eliminarBanner(id) == true)
        {
            for (int i = dominio.banners.Count-1; i >=0; i--)
            {
                if (dominio.banners.ElementAt(i).id == id){
                    dominio.banners.RemoveAt(i);
                }
            }
            return true;
        }
        return false;
    }

    public static bool eliminarDeporte(string dep)
    {
        for (int i = 0; i < dominio.deportes.Count; i++)
        {
            if (dominio.deportes.ElementAt(i).nombre == dep)
            {
                if (sentencia.eliminarDeporte(dep) == true)
                {
                    dominio.deportes.Remove(dominio.deportes.ElementAt(i));
                    return true;
                }
                else
                {
                    return false;
                }


            }
        }
        return false;
    }
    public static bool eliminarPais(string pais)
    {
        for (int i = 0; i < dominio.paises.Count; i++)
        {
            if (dominio.paises.ElementAt(i).nombre == pais)
            {
                if (sentencia.eliminarPais(pais) == true)
                {
                    dominio.paises.Remove(dominio.paises.ElementAt(i));
                    return true;
                }
                else
                {
                    return false;
                }


            }
        }
        return false;
    }
    public static bool eliminarEmpresa(string empresa)
    {
        for (int i = 0; i < dominio.empresas.Count; i++)
        {
            if (dominio.empresas.ElementAt(i).nombre == empresa)
            {
                if (sentencia.eliminarEmpresa(empresa) == true)
                {
                    dominio.empresas.Remove(dominio.empresas.ElementAt(i));
                    return true;
                }
                else
                {
                    return false;
                }


            }
        }
        return false;
    }

    public static bool eliminarEquipo(int id)
    {
        foreach (Equipos item in dominio.equipos)
        {
            if (item.id == id)
            {
                sentencia.eliminarEquipo(id);
                dominio.equipos.Remove(item);
                return true;
            }
        }
        return false;
    }
    public static bool eliminarDeportista(int id)
    {
        foreach (Deportistas item in dominio.deportistas)
        {
            if (item.id == id)
            {
                sentencia.eliminarDeportista(id);
                dominio.deportistas.Remove(item);
                return true;
            }
        }
        return false;
    }
    public static string obtenerCategoriaDeDeporte(string deporte)
    {
        int id_Catdisciplina = 0;

        string nombre_cat_disc = "";
        for (int i = 0; i < dominio.deportes.Count; i++)
        {
            if (dominio.deportes.ElementAt(i).nombre == deporte)
            {
                id_Catdisciplina = dominio.deportes.ElementAt(i).id_categoria;
            }
        }

        for (int i = 0; i < dominio.categorias_deportes.Count; i++)
        {
            if (dominio.categorias_deportes.ElementAt(i).getId() == id_Catdisciplina)
            {
                nombre_cat_disc = dominio.categorias_deportes.ElementAt(i).getNombre();
            }
        }
        return nombre_cat_disc;
    }

    public static bool asociarDeporteConCategoria(string deporte, string categoria) {

        int id_cat =0;
        int id_dep = 0;

        for (int i = 0; i < dominio.categorias_deportes.Count; i++)
        {
            if (dominio.categorias_deportes.ElementAt(i).getNombre() == categoria)
            {
                id_cat = dominio.categorias_deportes.ElementAt(i).getId();
            }
        }

        for (int i = 0; i < dominio.deportes.Count; i++)
        {
            if (dominio.deportes.ElementAt(i).nombre == deporte)
            {
                dominio.deportes.ElementAt(i).id_categoria =id_cat;
                id_dep = dominio.deportes.ElementAt(i).id;
            }
        }
        return sentencia.asociarDisicplinaCategoria(id_dep, id_cat);

    }    


    public static bool GuardarEvento(string accion,string nombre, string campeonato, string deporte, string pais, string modalidad, string inicio)
    {
        int id_campeonato = id_objeto.Obtener_Id<Campeonatos>(dominio.campeonatos, campeonato);
        int id_disciplina = id_objeto.Obtener_Id<Disciplinas>(dominio.deportes, deporte);
        int id_pais = id_objeto.Obtener_Id<Paises>(dominio.paises, pais);
        int id_modalidad= id_objeto.Obtener_Id<Modalidades>(dominio.modalidades, modalidad);
        switch (accion)
        {
            case "Guardar":
                int id_evento = id_objeto.Obtener_Id<Campeonatos>(dominio.campeonatos, campeonato);
                if (sentencia.GuardarEvento(accion, id_evento, nombre, id_campeonato, id_disciplina, id_pais, id_modalidad, inicio))
                {
                    foreach (Eventos item in dominio.eventos)
                    {
                        if (item.id == id_evento)
                        {
                            item.anio = nombre;
                            item.campeonato = campeonato;
                            item.disciplina = deporte;
                            item.pais = pais;
                            item.modalidad = modalidad;
                            item.fecha_inicio = inicio;
                            return true;
                        }

                    }
                }
                break;
            case "Crear evento":
                sentencia.GuardarEvento(accion, 0, nombre, id_campeonato, id_disciplina, id_pais, id_modalidad, inicio);
                int id = sentencia.UltimaIdInsertada();
                Eventos evento = new Eventos(id, nombre, Convert.ToDateTime(inicio), Convert.ToDateTime("1900/01/01"), pais, deporte, campeonato, modalidad,"En Curso");
                dominio.eventos.Add(evento);
                return true;
        }
        return false;
    }

    public static bool crearImagenPublicitaria(string nombre,string origen, string empresa)
    {

        int id_empresa = 0;
        foreach (Empresas objeto in dominio.empresas)
        {
            if (objeto.nombre == empresa)
            {
                id_empresa = objeto.id;
            }
        }
        if (sentencia.subirImagen(nombre, origen, id_empresa) == true)
        {
            int id = sentencia.UltimaIdInsertada();
            Imagenes imagen = new Imagenes(id, nombre, origen, empresa);
            dominio.imagenes.Add(imagen);
            return true;
        }
        return false;
    }
}
