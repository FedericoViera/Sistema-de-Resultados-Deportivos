using System;
using System.Data.Odbc;

public class Consultas : Conexion
{

    OdbcDataAdapter consulta;
    string string_consulta;
    // las consultase se manejan con MySqlDataAdapter, y se define una variable string_consulta
    // para definir las mismas

    public Consultas() {
        consulta = new OdbcDataAdapter();
        string_consulta = "";
    }


    // valida si existe el usuario en base a un nombre y una contraseña
    // para proximas entregas, esta validacion se hará en base a roles y no se almacenará la contraseña en 
    // la base de datos

    public OdbcDataAdapter UsuarioLoguearse(string usuario, string contrasena)
    {
        try
        {
            string_consulta = "SELECT * FROM usuario WHERE nombre_usuario= '" + usuario + "' AND contrasena= '" + contrasena + "'";
            consulta = new OdbcDataAdapter(string_consulta, GetConexion());
            return consulta;
        }
        catch (Exception)
        {
            return consulta;
            throw;
        }
    }
    public OdbcDataAdapter BannersUsuariosPublicos() {
         try {
              string_consulta = "SELECT u.id_usuario,u.nombre_usuario,u.nombre,u.apellido,u.correo," + Convert.ToChar(34) + "Sin-banner" + Convert.ToChar(34) + "as nombre_banner " +
                                "FROM Usuario as u " +
                                "join rol_usuario as r on u.id_usuario = r.id_usuario " +
                                "join roles_usuario as ro on r.id_rol = ro.id_rol " +
                                "WHERE ro.nombre_rol =" + Convert.ToChar(34) + "Basico" + Convert.ToChar(34) + "AND u.id_usuario NOT IN ( " +
                                "select usuario.id_usuario from Usuario " +
                                "join visualiza as v on usuario.id_usuario = v.id_usuario) " +
                                "UNION " +
                                "select Usuario.id_usuario,Usuario.nombre_usuario,Usuario.nombre,Usuario.apellido,Usuario.correo,b.nombre_banner from Usuario " +
                                "join visualiza as v on usuario.id_usuario = v.id_usuario " +
                                "join banners as b on v.id_banner = b.id_banner " +
                                "join rol_usuario as r on Usuario.id_usuario = r.id_usuario " +
                                "join roles_usuario as ro on r.id_rol = ro.id_rol " +
                                "where ro.nombre_rol = "+ Convert.ToChar(34) + "Basico" + Convert.ToChar(34);
            consulta = new OdbcDataAdapter(string_consulta, GetConexion());
            return consulta;
        } catch (Exception) {
            return consulta;
            throw;
        }
    }
    public OdbcDataAdapter UsuariosPremium()
    {
        try
        {
            string_consulta = "select u.id_usuario,nombre_usuario,nombre,apellido,correo from usuario as u "+
                                "join rol_usuario as ro on u.id_usuario = ro.id_usuario "+
                                "join roles_usuario as r on ro.id_rol = r.id_rol "+
                                 "where r.nombre_rol = " + Convert.ToChar(34) + "Premium" + Convert.ToChar(34);
            consulta = new OdbcDataAdapter(string_consulta, GetConexion());
            return consulta;
        }
        catch (Exception)
        {
            return consulta;
            throw;
        }
    }

    // se obtienen todos los datos de un usuario de la base de datos
    public OdbcDataAdapter UsuarioObtenerDatosPorNombre(string usuario)
    {
        try
        {
            string_consulta= "SELECT usuario.id_usuario, nombre_usuario, nombre, apellido, correo," +
                              "string_imagen, nombre_rol as rol FROM usuario " +
                              "join rol_usuario as r on usuario.id_usuario=r.id_usuario "+
                              "join roles_usuario as ro on ro.id_rol=r.id_rol " +
                              "WHERE nombre_usuario= '" + usuario + "'";
            consulta = new OdbcDataAdapter(string_consulta, GetConexion());
            return consulta;
        }
        catch (Exception)
        {
            return consulta;
            throw;
        }
    }

    

    // se obtienen todos los datos de todos los usuarios de la base de datos
    public OdbcDataAdapter UsuariosLista()
    {
        try
        {
            string_consulta = "SELECT usuario.id_usuario, nombre_usuario, nombre, apellido, correo," +
                              "string_imagen, nombre_rol as rol FROM usuario " +
                              "join rol_usuario as r on usuario.id_usuario=r.id_usuario " +
                              "join roles_usuario as ro on ro.id_rol=r.id_rol";
            consulta = new OdbcDataAdapter(string_consulta, GetConexion());
            return consulta;
        }
        catch (Exception)
        {
            return consulta;
            throw;
        }
    }

    //Se obtiene un evento especifico.
    public OdbcDataAdapter EventoPorNombre(String nombre_ev)
    {
        try {
            string_consulta = "SELECT * FROM partidos WHERE nombre_evento= '" + nombre_ev + "'";
            consulta = new OdbcDataAdapter(string_consulta, GetConexion());

            return consulta;
        } catch (Exception) {
            return consulta;
            throw;
        }
    }

    // Se obtiene un resultado especifico segun la id del partido.
    public OdbcDataAdapter obtenerResultados(String id_partido)
    {
        try {
            string_consulta = "SELECT partidos.equipo_1, tiempos.score_eq_1, tiempos.score_eq_2, " +
            "partidos.equipo_2 FROM partidos JOIN tiempos ON partidos.id_partido = tiempos.id_tiempo " +
            "WHERE tiempos.id_tiempos = '" + id_partido + "'";
            consulta = new OdbcDataAdapter(string_consulta, GetConexion());

            return consulta;
        } catch (Exception) {
            return consulta;
            throw;
        }
    }


    //Se obtiene un deporte especifico.
    public OdbcDataAdapter obtenerUnDeporte(String nombre_deporte)
    {
        try {
            string_consulta = "SELECT * FROM deporte WHERE nombre_d= '" + nombre_deporte + "'";
            consulta = new OdbcDataAdapter(string_consulta, GetConexion());

            return consulta;
        } catch (Exception) {
            return consulta;
            throw;
        }
    }

    

    public OdbcDataAdapter NoticiasListaUsuariosPublicos()
    {
        try
        {
            string_consulta = "SELECT * FROM vista_noticias";
            consulta = new OdbcDataAdapter(string_consulta, GetConexion());
            return consulta;
        }
        catch (Exception)
        {
            return consulta;
            throw;
        }
    }
    public OdbcDataAdapter ResultadosEquiposListaUsuariosPublicos()
    {
        try
        {
            string_consulta = "SELECT * FROM vista_resultados_eventos_por_equipo";
            consulta = new OdbcDataAdapter(string_consulta, GetConexion());
            return consulta;
        }
        catch (Exception)
        {
            return consulta;
            throw;
        }
    }
    public OdbcDataAdapter UsuariosListaPorAproximacion(string busqueda)
    {
        try
        {
            string_consulta = "SELECT usuario.id_usuario, nombre_usuario, nombre, apellido, correo," +
                              "string_imagen, nombre_rol as rol FROM usuario " +
                              "join rol_usuario as r on usuario.id_usuario=r.id_usuario " +
                              "join roles_usuario as ro on ro.id_rol=r.id_rol " +
                              "WHERE nombre_usuario LIKE '" + busqueda + "%' or nombre LIKE '" + busqueda + "%'";
            consulta = new OdbcDataAdapter(string_consulta, GetConexion());
            return consulta;
        }
        catch (Exception)
        {
            return consulta;
            throw;

        }

    }
    public OdbcDataAdapter SolicitudesPremium()
    {
        try
        {
            string_consulta = "SELECT u.id_usuario,nombre_usuario,correo,numeroTarjeta,caducidad,ccv FROM solicitudes_premium as sol " +
                               "join Usuario as u on sol.id_usuario = u.id_usuario";
            consulta = new OdbcDataAdapter(string_consulta, GetConexion());
            return consulta;
        }
        catch (Exception)
        {
            return consulta;
            throw;

        }

    }

    public OdbcDataAdapter CargarInformacion(string Tabla)
    {
        switch (Tabla)
        {
            case "Equipos":
     string_consulta = "select id_equipo,nombre_equipo,nombre_disciplina,nombre_pais from equipos as e " +
                             "join paises as p on e.id_pais = p.id_pais " +
                             "join disciplinas as d on e.id_disciplina = d.id_disciplina " +
                             "order by nombre_equipo";
                break;
            case "Modalidades":
                string_consulta = "select * from Modalidades order by modo";
                break;
            case "Campeonatos":
                string_consulta = "select * from campeonatos order by nombre_campeonato";
                break;
            case "Categoria_disciplina":
                string_consulta = "select * from categoria_disciplina order by nombre_categoria_disciplina";
                break;
            case "Empresas":
                string_consulta = "select * from empresa order by nombre_empresa";
                break;
            case "Deportistas":
                string_consulta = "select d.id_deportista,nombre_deportista,apellido_deportista,nombre_pais,nombre_disciplina,nombre_equipo from deportistas as d " +
                             "join paises as p on d.id_pais = p.id_pais " +
                             "join disciplinas as dis on d.id_disciplina = dis.id_disciplina " +
                             "join integra as i on d.id_deportista = i.id_deportista " +
                             "join equipos as eq on i.id_equipo = eq.id_equipo " +
                             "order by nombre_deportista";
                break;
            case "Imagenes":
                string_consulta = "select id_imagen,nombre_imagen,origen,nombre_empresa from imagenes as i join empresa as e on i.id_empresa=e.id_empresa order by nombre_imagen";
                break;
            case "Deportes":
                string_consulta = "select * from disciplinas order by nombre_disciplina";
                break;
            case "Paises":                
                string_consulta = "SELECT * FROM paises order by nombre_pais";
                break;
            case "Posicion":
                string_consulta = "SELECT * FROM posicion_banner";
                break;
            case "Servidores":
                string_consulta = "SELECT * FROM servidores order by nombre_servidor";
                break;
            case "Eventos":
                string_consulta = "SELECT e.id_evento,nombre_evento,fecha_inicio,fecha_fin,nombre_pais,nombre_disciplina,nombre_campeonato,modo,culminado FROM eventos as e " +
                                   "join paises as p on e.id_pais = p.id_pais " +
                                   "join disciplinas as d on e.id_disciplina = d.id_disciplina " +
                                   "join modalidades as m on e.id_modalidad = m.id_modalidad " +
                                   "join campeonatos as c on e.id_campeonato = c.id_campeonato " +
                                   "order by fecha_inicio";
                break;
            case "Partidos":
                string_consulta = "SELECT p.id_partido, p.fecha_partido, eq1.nombre_equipo,eq2.nombre_equipo,e.id_evento FROM partidos as p " +
                                    "join equipos as eq1 on p.id_equipo_1 = eq1.id_equipo " +
                                    "join equipos as eq2 on p.id_equipo_2 = eq2.id_equipo " +
                                    "join eventos as e on p.id_evento = e.id_evento";
                break;
            case "Tiempos":
                string_consulta = "select * from Tiempos";
                break;
            case "Encuentros":
                string_consulta = "select * from Encuentros";
                break;
            case "Sets_Rounds":
                string_consulta = "select * from sets_rounds";
                break;
            case "Banners":
                string_consulta = "SELECT id_banner, nombre_banner, ub_pantalla from banners as b " +
                                  "join posicion_banner as p on b.id_posicion = p.id_posicion";
                break;
            case "ImagenesAsociadas":
                string_consulta = "SELECT * from agrupa";
                break;
            case "Puntajes":
                string_consulta = "SELECT * from puntua";
                break;
            default:
                break;
        }
        try
        {            
            consulta = new OdbcDataAdapter(string_consulta, GetConexion());
            return consulta;
        }
        catch (Exception)
        {
            return consulta;
        }
    }



}
