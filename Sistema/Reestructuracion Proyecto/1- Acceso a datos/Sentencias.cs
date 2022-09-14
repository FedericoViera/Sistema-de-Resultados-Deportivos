using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion._1__Acceso_a_datos
{
    public class Sentencias : Conexion
    {
        OdbcCommand sentencia;

        public int UltimaIdInsertada()
        {
            sentencia.CommandText = "SELECT LAST_INSERT_ID()";
            return Int16.Parse(sentencia.ExecuteScalar().ToString());
        }
        // sentencia para agregar un usuario, se pasan todos los parametros pertinentes y se asignan los valores
        // a los parametros sql definidos, como @nombre_u, @email, etc.
        public bool agregarUsuario(String nombre_u, String nombre, String apellido,String email, String contra)
        {
            try {
                sentencia = new OdbcCommand("INSERT INTO `usuario`(`nombre_usuario`, `nombre`, `apellido`, `correo`, `contrasena`) " +
                "VALUES (?,?,?,?,?)", GetConexion());
                sentencia.Parameters.AddWithValue("@nombre_u", nombre_u);
                sentencia.Parameters.AddWithValue("@nombre", nombre);
                sentencia.Parameters.AddWithValue("@apellido", apellido);
                sentencia.Parameters.AddWithValue("@email", email);
                sentencia.Parameters.AddWithValue("@contrasena", contra);
                sentencia.ExecuteNonQuery();
                return true;
            } catch(Exception) {
                return false;
            }
        }
        public bool agregarRolUsuario(int id_usuario, String rol)
        {
            int id_rol = 0;
            switch (rol)
            {
                case "Superusuario":
                    id_rol = 1;
                    break;
                case "Publicitario":
                    id_rol = 2;
                    break;
                case "Notificativo":
                    id_rol = 3;
                    break;
                case "Basico":
                    id_rol = 4;
                    break;
                case "Premium":
                    id_rol = 5;
                    break;
                default:
                    break;
            }
            try
            {
                sentencia = new OdbcCommand("INSERT INTO `rol_usuario` (`id_usuario`, `id_rol`) VALUES (?,?)", GetConexion());
                sentencia.Parameters.AddWithValue("@1", id_usuario); 
                sentencia.Parameters.AddWithValue("@2", id_rol);
                sentencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool actualizarRolUsuario(int id_usuario,String rol)
        {
            int id_rol = 0;
            switch (rol)
            {
                case "Superusuario":
                    id_rol = 1;
                    break;
                case "Publicitario":
                    id_rol = 2;
                    break;
                case "Notificativo":
                    id_rol = 3;
                    break;
                case "Basico":
                    id_rol = 4;
                    break;
                case "Premium":
                    id_rol = 5;
                    break;
                default:
                    break;
            }
            try
            {
                sentencia = new OdbcCommand("UPDATE rol_usuario SET `id_rol` = ? WHERE (`id_Usuario` = ?)", GetConexion());
                sentencia.Parameters.AddWithValue("@1", id_rol); 
                sentencia.Parameters.AddWithValue("@2", id_usuario);
                sentencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // Sentencia para editar los datos de un usuario
        public bool editarUsuario(String nombre_u, String nuevoNombre,
             String nuevoApellido, String nuevoEmail, String nuevaContraseña,bool cambioContraseña)
        {
            try
            {
                switch (cambioContraseña)
                {
                    case true:
                        sentencia = new OdbcCommand("UPDATE `usuario` SET nombre=?," +
                              "apellido=?, correo=?, contrasena=? " +
                              "WHERE (nombre_usuario=?)", GetConexion());
                        sentencia.Parameters.AddWithValue("@nuevoNombre", nuevoNombre);
                        sentencia.Parameters.AddWithValue("@nuevoApellido", nuevoApellido);
                        sentencia.Parameters.AddWithValue("@nuevoEmail", nuevoEmail);
                        sentencia.Parameters.AddWithValue("@nuevaContrasena", nuevaContraseña);
                        sentencia.Parameters.AddWithValue("@nombre_u", nombre_u);
                        break;
                    case false:
                        sentencia = new OdbcCommand("UPDATE `usuario` SET nombre=?," +
                             "apellido=?, correo=? " +
                             "WHERE (nombre_usuario=?)", GetConexion());
                        sentencia.Parameters.AddWithValue("@nuevoNombre", nuevoNombre);
                        sentencia.Parameters.AddWithValue("@nuevoApellido", nuevoApellido);
                        sentencia.Parameters.AddWithValue("@nuevoEmail", nuevoEmail);
                        sentencia.Parameters.AddWithValue("@nombre_u", nombre_u);
                        break;
                }
               
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }


        }
        public bool AprobarSolicitud(int id_usuario)
        {
            try
            {
                sentencia = new OdbcCommand("UPDATE `rol_usuario` SET id_rol='5' " +
                               "WHERE (id_usuario=?)", GetConexion());
                sentencia.Parameters.AddWithValue("id_usuario", id_usuario);
                sentencia.ExecuteNonQuery();
                sentencia = new OdbcCommand("DELETE FROM `solicitudes_premium` WHERE (`id_usuario` = ?)", GetConexion());
                sentencia.Parameters.AddWithValue("id_user", id_usuario);
                sentencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }

        }
        public bool RebocarCuenta(int id_usuario)
        {
            try
            {
                sentencia = new OdbcCommand("UPDATE `rol_usuario` SET id_rol='4' " +
                               "WHERE (id_usuario=?)", GetConexion());
                sentencia.Parameters.AddWithValue("id_usuario", id_usuario);
                sentencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }

        }
        public bool CulminarEvento(int id_evento,string fecha_culmnacion)
        {
            try
            {
                sentencia = new OdbcCommand("UPDATE `eventos` SET `culminado` = '1',`fecha_fin` = ? WHERE (`id_evento` = ?)", GetConexion());
                sentencia.Parameters.AddWithValue("fecha_fin", fecha_culmnacion);
                sentencia.Parameters.AddWithValue("id_evento", id_evento);
                sentencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }

        }
        public bool ReAbrirEvento(int id_evento)
        {
            try
            {
                sentencia = new OdbcCommand("UPDATE `eventos` SET `culminado` = '0' WHERE (`id_evento` = ?)", GetConexion());
                sentencia.Parameters.AddWithValue("id_evento", id_evento);
                sentencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }

        }
        public bool EliminarSolicitud(int id_usuario)
        {
            try
            {
                sentencia = new OdbcCommand("DELETE FROM `solicitudes_premium` WHERE (`id_usuario` = ?)", GetConexion());
                sentencia.Parameters.AddWithValue("id_user", id_usuario);
                sentencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }

        }
        public bool ActualizarResultadoEquipo(int id_partido, int numero_ordinal,int score1,int score2, string detalle1,string detalle2)
        {
            try
            {
                sentencia = new OdbcCommand("Update `tiempos` SET `score_eq_1` = ?, `score_eq_2` = ?, `detalle_a_destacar` = ?, `detalle_a_destacar2` = ? WHERE (`id_partido` = ?) and (`numero_ordinal` = ?)", GetConexion());
                sentencia.Parameters.AddWithValue("score_eq_1", score1);
                sentencia.Parameters.AddWithValue("score_eq_2", score2);
                sentencia.Parameters.AddWithValue("detalle_a_destacar", detalle1);
                sentencia.Parameters.AddWithValue("detalle_a_destacar2", detalle2);
                sentencia.Parameters.AddWithValue("id_partido", id_partido);
                sentencia.Parameters.AddWithValue("numero_ordinal", numero_ordinal);
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }

        }
        public bool Integrante_Equipo(int id_equipo, int id_deportista)
        {
            try
            {
                sentencia = new OdbcCommand("UPDATE `integra` SET id_equipo=? " +
                               "WHERE (id_deportista=?)", GetConexion());
                sentencia.Parameters.AddWithValue("id_equipo", id_equipo);
                sentencia.Parameters.AddWithValue("id_deportista", id_deportista);
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }

        }
        
        public bool editarEquipo(int id,string nombre, int id_pais, int id_disciplina)
        {
            try
            {
                sentencia = new OdbcCommand("UPDATE `equipos` SET nombre_equipo=?," +
                               "id_pais=?, id_disciplina=? " +
                               "WHERE (id_equipo=?)", GetConexion());
                sentencia.Parameters.AddWithValue(nombre, nombre);
                sentencia.Parameters.AddWithValue("pais", id_pais);
                sentencia.Parameters.AddWithValue("deporte", id_disciplina);
                sentencia.Parameters.AddWithValue("id", id);
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
        public bool editarDeportista(int id, string nombre, string apellido, int id_pais, int id_disciplina)
        {
            try
            {
                sentencia = new OdbcCommand("UPDATE `deportistas` SET nombre_deportista=?, " +
                               "apellido_deportista=?, id_pais=?, id_disciplina=? " +
                               "WHERE (id_deportista=?)", GetConexion());
                sentencia.Parameters.AddWithValue(nombre, nombre);
                sentencia.Parameters.AddWithValue(apellido, apellido);
                sentencia.Parameters.AddWithValue("pais", id_pais);
                sentencia.Parameters.AddWithValue("deporte", id_disciplina);
                sentencia.Parameters.AddWithValue("id", id);
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        //Se elimina un usuario según su ID.
        public bool eliminarUsuario(String id_u)
        {
            try {
                sentencia = new OdbcCommand("DELETE FROM `Usuario` WHERE (id_usuario=?)", GetConexion());
                sentencia.Parameters.AddWithValue("@id_u", id_u);
                sentencia.ExecuteNonQuery();

                return true;
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }

        public bool eliminarEquipo(int id)
        {
            try
            {
                sentencia = new OdbcCommand("DELETE FROM `Equipos` WHERE (id_equipo=?)", GetConexion());
                sentencia.Parameters.AddWithValue("id",id);
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }
        public bool eliminarDeportista(int id)
        {
            try
            {
                sentencia = new OdbcCommand("DELETE FROM `Deportistas` WHERE (id_deportista=?)", GetConexion());
                sentencia.Parameters.AddWithValue("id", id);
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }
        public bool crearCatDep(String nombre)
        {
            try
            {
                sentencia = new OdbcCommand("INSERT INTO `categoria_disciplina` (nombre_categoria_disciplina) VALUES (?)", GetConexion());
                sentencia.Parameters.AddWithValue("@nombre", nombre);
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }

        public bool eliminarCatDep(String nombre)
        {
            try
            {
                sentencia = new OdbcCommand("DELETE FROM `categoria_disciplina` WHERE nombre_categoria_disciplina =?", GetConexion());
                sentencia.Parameters.AddWithValue("@nombre", nombre);
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }
        public bool eliminarPais(String nombre)
        {
            try
            {
                sentencia = new OdbcCommand("DELETE FROM `paises` WHERE nombre_pais =?", GetConexion());
                sentencia.Parameters.AddWithValue("@nombre", nombre);
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }
        public bool eliminarEmpresa(String nombre)
        {
            try
            {
                sentencia = new OdbcCommand("DELETE FROM `empresa` WHERE nombre_empresa =?", GetConexion());
                sentencia.Parameters.AddWithValue("@nombre", nombre);
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }
        public bool crearEquipo(string nombre_equipo,int id_pais,int id_disciplina)
        {
            try
            {
                sentencia = new OdbcCommand("INSERT INTO equipos (nombre_equipo,id_pais,id_disciplina) VALUES (?,?,?)", GetConexion());
                sentencia.Parameters.AddWithValue("@1", nombre_equipo);
                sentencia.Parameters.AddWithValue("@2", id_pais);
                sentencia.Parameters.AddWithValue("@3", id_disciplina);
                sentencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool crearDeportista(string nombre,string apellido, int id_pais, int id_disciplina)
        {
            try
            {
                sentencia = new OdbcCommand("INSERT INTO deportistas (nombre_deportista,apellido_deportista,id_pais,id_disciplina) VALUES (?,?,?,?)", GetConexion());
                sentencia.Parameters.AddWithValue("@1", nombre);
                sentencia.Parameters.AddWithValue("@2", apellido);
                sentencia.Parameters.AddWithValue("@3", id_pais);
                sentencia.Parameters.AddWithValue("@4", id_disciplina);
                sentencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        
            public bool editarIpServidor(string ip_servidor, string nombre_servidor)
        {
            try
            {
                sentencia = new OdbcCommand("UPDATE servidores SET `ip_servidor` = ? WHERE (`nombre_servidor` = ?)", GetConexion());
                sentencia.Parameters.AddWithValue("@1", ip_servidor);
                sentencia.Parameters.AddWithValue("@2", nombre_servidor);
                sentencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        // Se crea un deporte.
        public bool crearDeporte(String nombre_dep)
        {
            try {
                sentencia = new OdbcCommand("INSERT INTO disciplinas (nombre_disciplina) VALUES (?)", GetConexion());
                sentencia.Parameters.AddWithValue("@1", nombre_dep);
                sentencia.ExecuteNonQuery();
                return true;
            } catch(Exception) {
                return false;
                throw;
            }
        }

        public bool crearPais(String nombre)
        {
            try
            {
                sentencia = new OdbcCommand("INSERT INTO paises (nombre_pais) VALUES (?)", GetConexion());
                sentencia.Parameters.AddWithValue("@1", nombre);
                sentencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool crearEmpresa(String nombre)
        {
            try
            {
                sentencia = new OdbcCommand("INSERT INTO empresa (nombre_empresa) VALUES (?)", GetConexion());
                sentencia.Parameters.AddWithValue("@1", nombre);
                sentencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool GuardarEvento(string accion,int id_evento,string nombre, int campeonato, int deporte, int pais, int modalidad, string inicio)
        {
            switch (accion)
            {
                case "Guardar":
                    sentencia = new OdbcCommand("UPDATE `eventos` SET `nombre_evento` = ?, `fecha_inicio` = ?,`id_pais` = ?, `id_disciplina` =  ?, `id_modalidad` = ?, `id_campeonato` = ? WHERE (`id_evento` = ?)", GetConexion());
                    break;
                case "Crear evento":
                    sentencia = new OdbcCommand("INSERT INTO `eventos` (`nombre_evento`, `fecha_inicio`, `fecha_fin`,`id_pais`, `id_disciplina`, `id_modalidad`, `id_campeonato`) VALUES (?,?," + "'1900/01/01'" + ",?,?,?,?)", GetConexion());                   
                    break;
                default:
                    break;
            }
            try
            {
                sentencia.Parameters.AddWithValue("@nombre_evento", nombre);
                sentencia.Parameters.AddWithValue("@fecha_inicio", inicio);
                sentencia.Parameters.AddWithValue("@id_pais", pais);
                sentencia.Parameters.AddWithValue("@id_disciplina", deporte);
                sentencia.Parameters.AddWithValue("@id_modalidad", modalidad);
                sentencia.Parameters.AddWithValue("@id_campeonato", campeonato);
                sentencia.Parameters.AddWithValue("@id_evento", id_evento);
                sentencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool subirImagen(string nombre, string origen, int id_empresa)
        {
            try
            {
                sentencia = new OdbcCommand("INSERT INTO `imagenes` (`nombre_imagen`, `origen`, `id_empresa`) VALUES (?,?,?)",
                    GetConexion());
                sentencia.Parameters.AddWithValue("@nombre", nombre);
                sentencia.Parameters.AddWithValue("@origen", origen);
                sentencia.Parameters.AddWithValue("@id_empresa", id_empresa);
                sentencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool eliminarBanner(int id)
        {
            try
            {
                sentencia = new OdbcCommand("DELETE FROM `banners` WHERE id_banner =?", GetConexion());
                sentencia.Parameters.AddWithValue("@1", id);
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }
        public bool eliminarTiempo(int id_partido,int numero_ordinal)
        {
            try
            {
                sentencia = new OdbcCommand("DELETE FROM `tiempos` WHERE id_partido =? and numero_ordinal=?", GetConexion());
                sentencia.Parameters.AddWithValue("@1", id_partido);
                sentencia.Parameters.AddWithValue("@2", numero_ordinal);
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }
        public bool AsociarDesasociarImagenBanner(string modo,int id_banner,int id_imagen)
        {
            switch (modo)
            {
                case "Desasociar":
                    sentencia = new OdbcCommand("DELETE FROM `agrupa` WHERE id_banner =? and id_imagen=?", GetConexion());
                    break;
                case "Asociar":
                    sentencia = new OdbcCommand("INSERT INTO `agrupa` (`id_banner`, `id_imagen`) VALUES (?, ?)", GetConexion());
                    break;
                default:
                    break;
            }
            try
            {                
                sentencia.Parameters.AddWithValue("@1", id_banner);
                sentencia.Parameters.AddWithValue("@2", id_imagen);
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }
        public bool AsociarBannerUsuario(string tieneBanerAsociado, int id_usuario, int id_banner)
        {
            if ("Sin-banner" == tieneBanerAsociado)
            {
              sentencia = new OdbcCommand("INSERT INTO `visualiza` (`id_banner`, `id_usuario`) VALUES (?, ?)", GetConexion());

            } else
            {
              sentencia = new OdbcCommand("UPDATE `visualiza` SET `id_banner` = ? WHERE (`id_usuario` = ?)", GetConexion());
            }
            try
            {                
                sentencia.Parameters.AddWithValue("@1", id_banner);
                sentencia.Parameters.AddWithValue("@2", id_usuario);
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }
        public bool eliminarDeporte(String nombre)
        {
            try
            {
                sentencia = new OdbcCommand("DELETE FROM `disciplinas` WHERE nombre_disciplina =?", GetConexion());
                sentencia.Parameters.AddWithValue("@1", nombre);
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }
        public bool crearPartido(int id_evento,string fecha_partido, int id_equipo_1, int id_equipo_2)
        {
            try
            {
                sentencia = new OdbcCommand("INSERT INTO `partidos` (`id_evento`, `fecha_partido`,`id_equipo_1`,`id_equipo_2`) VALUES (?,?,?,?)", GetConexion());
                sentencia.Parameters.AddWithValue("@id_evento", id_evento);
                sentencia.Parameters.AddWithValue("@fecha_partido", fecha_partido);
                sentencia.Parameters.AddWithValue("@id_equipo_1", id_equipo_1);
                sentencia.Parameters.AddWithValue("@id_equipo_2", id_equipo_2);
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }
        public bool crearTiempo(int id_partido,int numero_ordinal)
        {
            try
            {
                sentencia = new OdbcCommand("INSERT INTO `tiempos` (`id_partido`, `numero_ordinal`) VALUES (?,?)", GetConexion());
                sentencia.Parameters.AddWithValue("@id_partido", id_partido);
                sentencia.Parameters.AddWithValue("@numero_ordinal", numero_ordinal);
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }
        public bool asociarDisicplinaCategoria(int id_disc,int id_cat)
        {
            try
            {
                sentencia = new OdbcCommand("UPDATE disciplinas SET `id_categoria_disciplina` = ? WHERE (`id_disciplina` = ?)", GetConexion());
                sentencia.Parameters.AddWithValue("@1", id_cat);
                sentencia.Parameters.AddWithValue("@2", id_disc);
                sentencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool guardarBanner(string modo, int id_banner, string nombre, int id_posicion)
        {
            switch (modo)
            {
                case "Crear":
                    sentencia = new OdbcCommand("INSERT INTO `banners` (`nombre_banner`, `id_posicion`) VALUES (?,?)", GetConexion());
                    break;
                case "Editar":
                    sentencia = new OdbcCommand("UPDATE `banners` SET `nombre_banner` = ?, `id_posicion` = ? WHERE (`id_banner` = ?)", GetConexion());
                    break;
                default:
                    break;
            }
            try
            {                
                sentencia.Parameters.AddWithValue("@1", nombre);
                sentencia.Parameters.AddWithValue("@2", id_posicion);
                sentencia.Parameters.AddWithValue("@3", id_banner);
                sentencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

    }
}

  




