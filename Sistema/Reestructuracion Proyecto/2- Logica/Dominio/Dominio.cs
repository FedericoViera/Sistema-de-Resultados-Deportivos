using Proyecto._2__Logica.Dominio.Entidades;
using Reestructuracion_Proyecto._2__Logica.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Dominio
    {
    public List<Categoria_disciplina> categorias_deportes;
    public List<Disciplinas> deportes;
    public List<Paises> paises;
    public List<Servidores> servidores;
    public List<Campeonatos> campeonatos;
    public List<Modalidades> modalidades;
    public List<Deportistas> deportistas;
    public List<Equipos> equipos;
    public List<Empresas> empresas;
    public List<Imagenes> imagenes;
    public List<Eventos> eventos;
    public List<Partidos> partidos;
    public List<Tiempos> tiempos;
    public List<Encuentros> encuentros;
    public List<Sets_Rounds> sets_rounds;
    public List<Banners> banners;
    public List<Posiciones_pantalla> posiciones;
    public List<ImagenesAsociadas> imagenesAsociadas;
    public List<Puntua> puntajes;
    public Dominio()
        {
        categorias_deportes = new List<Categoria_disciplina>();
        deportes = new List<Disciplinas>();
        paises = new List<Paises>();
        partidos = new List<Partidos>();
        servidores = new List<Servidores>();
        campeonatos = new List<Campeonatos>();
        modalidades = new List<Modalidades>();
        deportistas = new List<Deportistas>();
        equipos = new List<Equipos>();
        empresas = new List<Empresas>();
        imagenes = new List<Imagenes>();
        eventos = new List<Eventos>();
        tiempos = new List<Tiempos>();
        encuentros = new List<Encuentros>();
        sets_rounds = new List<Sets_Rounds>();
        banners = new List<Banners>();
        posiciones = new List<Posiciones_pantalla>();
        imagenesAsociadas = new List<ImagenesAsociadas>();
        puntajes = new List<Puntua>();
        cargarInformacion();
    }
        public void cargarInformacion()
        {
        try
        {
            cargarCategoriasDisciplinas();
            cargarDisciplinas();
            cargarPaises();
            cargarServidores();
            cargarCampeonatos();
            cargarModalidades();
            cargarEmpresas();
            cargarDeportistas();
            cargarEquipos();
            cargarImagenes();
            cargarBanners();
            cargarImagenesAsociadas();
            cargarEventos();
            cargarPosiciones();
            cargarPartidos();
            cargarTiempos();
            cargarEncuentros();
            cargarSets_Rounds();
            cargarPuntajes();
        }
        catch (Exception)
        {

            throw;
        }
       
        }

    protected void cargarPuntajes()
    {
        String[,] arrayDatos = Controlador.CargarInformacion("Puntajes");
        string nombre = "";
        string apellido = "";
        for (int j = 0; j < arrayDatos.GetLength(0); j++)
        {
            foreach (Deportistas deportista in deportistas)
            {
                if (Int16.Parse(arrayDatos[j, 2])==deportista.id)
                {
                    nombre = deportista.nombre;
                    apellido = deportista.apellido;
                }
            }
            Puntua objeto = new Puntua(Int16.Parse(arrayDatos[j, 0]), Int16.Parse(arrayDatos[j, 1]), Int16.Parse(arrayDatos[j, 2]),nombre,apellido, Int16.Parse(arrayDatos[j, 3]));
            puntajes.Add(objeto);
        }
    }
    protected void cargarEncuentros()
    {
        String[,] arrayDatos = Controlador.CargarInformacion("Encuentros");
        for (int j = 0; j < arrayDatos.GetLength(0); j++)
        {
            Encuentros objeto = new Encuentros(Int16.Parse(arrayDatos[j, 0]), Convert.ToDateTime(arrayDatos[j, 1]), Int16.Parse(arrayDatos[j, 2]));
            encuentros.Add(objeto);
        }
    }
    protected void cargarSets_Rounds()
    {
        String[,] arrayDatos = Controlador.CargarInformacion("Sets_Rounds");
        for (int j = 0; j < arrayDatos.GetLength(0); j++)
        {
            Sets_Rounds objeto = new Sets_Rounds(Int16.Parse(arrayDatos[j, 0]), Int16.Parse(arrayDatos[j, 1]), arrayDatos[j, 2]);
            sets_rounds.Add(objeto);
        }
    }
    protected void cargarPartidos()
    {
        String[,] arrayDatos = Controlador.CargarInformacion("Partidos");
        for (int j = 0; j < arrayDatos.GetLength(0); j++)
        {
            Partidos objeto = new Partidos(Int16.Parse(arrayDatos[j, 0]), Convert.ToDateTime(arrayDatos[j, 1]), arrayDatos[j, 2], arrayDatos[j, 3], Int16.Parse(arrayDatos[j, 4]));
            partidos.Add(objeto);
        }
    }
    protected void cargarTiempos()
    {
        String[,] arrayDatos = Controlador.CargarInformacion("Tiempos");
        string eq1 = "";
        string eq2 = "";
        for (int j = 0; j < arrayDatos.GetLength(0); j++)
        {
            foreach (Partidos partido in partidos)
            {
                if (Int16.Parse(arrayDatos[j, 0])==partido.id)
                {
                    eq1 = partido.equipo_1;
                    eq2 = partido.equipo_2;
                }
            }
            Tiempos objeto = new Tiempos(Int16.Parse(arrayDatos[j, 0]), Int16.Parse(arrayDatos[j, 1]), eq1, Int16.Parse(arrayDatos[j, 2]), Int16.Parse(arrayDatos[j, 3]),eq2, arrayDatos[j, 4], arrayDatos[j, 5]);
            tiempos.Add(objeto);
        }
    }
    protected void cargarPosiciones()
    {
        String[,] arrayDatos = Controlador.CargarInformacion("Posicion");
        for (int j = 0; j < arrayDatos.GetLength(0); j++)
        {
            Posiciones_pantalla objeto = new Posiciones_pantalla(Int16.Parse(arrayDatos[j, 0]), arrayDatos[j, 1]);
            posiciones.Add(objeto);
        }
    }
    protected void cargarEventos()
    {
        String[,] arrayDatos = Controlador.CargarInformacion("Eventos");
        string culminado = "";
        for (int j = 0; j < arrayDatos.GetLength(0); j++)
        {
            if (Int16.Parse(arrayDatos[j, 8])==0)
            {
                culminado = "En curso";
            }else
            {
                culminado = "Culminados";
            }
            Eventos objeto = new Eventos(Int16.Parse(arrayDatos[j, 0]), arrayDatos[j, 1], Convert.ToDateTime(arrayDatos[j, 2]), Convert.ToDateTime(arrayDatos[j, 3]),
                                            arrayDatos[j, 4], arrayDatos[j, 5], arrayDatos[j, 6], arrayDatos[j, 7],culminado);
            eventos.Add(objeto);
        }
    }
    protected void cargarImagenesAsociadas()
    {
        String[,] arrayDatos = Controlador.CargarInformacion("ImagenesAsociadas");
        for (int j = 0; j < arrayDatos.GetLength(0); j++)
        {
            ImagenesAsociadas objeto = new ImagenesAsociadas(Int16.Parse(arrayDatos[j, 0]), Int16.Parse(arrayDatos[j, 1]));
            imagenesAsociadas.Add(objeto);
        }
    }
    protected void cargarBanners()
    {
        String[,] arrayDatos = Controlador.CargarInformacion("Banners");
        for (int j = 0; j < arrayDatos.GetLength(0); j++)
        {
            Banners objeto = new Banners(Int16.Parse(arrayDatos[j, 0]), arrayDatos[j, 1], arrayDatos[j, 2]);
            banners.Add(objeto);
        }
    }
    protected void cargarImagenes()
        {
            String[,] arrayDatos = Controlador.CargarInformacion("Imagenes");
            for (int j = 0; j < arrayDatos.GetLength(0); j++)
            {
                Imagenes objeto = new Imagenes(Int16.Parse(arrayDatos[j, 0]), arrayDatos[j, 1], arrayDatos[j, 2],arrayDatos[j, 3]);
                imagenes.Add(objeto);
            }
        }
        protected void cargarEquipos()
        {
        String[,] arrayDatos = Controlador.CargarInformacion("Equipos");
        for (int j = 0; j < arrayDatos.GetLength(0); j++)
            {
                Equipos objeto = new Equipos(Int16.Parse(arrayDatos[j, 0]), arrayDatos[j, 1],arrayDatos[j, 2], (arrayDatos[j, 3]));
                equipos.Add(objeto);
            }
        }
        protected void cargarDeportistas()
        {
        String[,] arrayDatos = Controlador.CargarInformacion("Deportistas");
        for (int j = 0; j < arrayDatos.GetLength(0); j++)
            {
                Deportistas objeto = new Deportistas(Int16.Parse(arrayDatos[j, 0]), arrayDatos[j, 1], arrayDatos[j, 2], arrayDatos[j, 3], arrayDatos[j, 4], arrayDatos[j, 5]);
                deportistas.Add(objeto);
            }
        }
        protected void cargarEmpresas()
        {
        String[,] arrayDatos = Controlador.CargarInformacion("Empresas");
        for (int j = 0; j < arrayDatos.GetLength(0); j++)
            {
                Empresas objeto = new Empresas(Int16.Parse(arrayDatos[j, 0]), arrayDatos[j, 1]);
                empresas.Add(objeto);
            }
        }

        protected void cargarCategoriasDisciplinas()
        {

        String[,] arrayDatos = Controlador.CargarInformacion("Categoria_disciplina");
        for (int j = 0; j < arrayDatos.GetLength(0); j++)
            {
              Categoria_disciplina objeto = new Categoria_disciplina(Int16.Parse(arrayDatos[j, 0]), arrayDatos[j,1]);
                categorias_deportes.Add(objeto);
            }
        }


        protected void cargarCampeonatos()
        {
        String[,] arrayDatos = Controlador.CargarInformacion("Campeonatos");
        for (int j = 0; j < arrayDatos.GetLength(0); j++)
            {
                Campeonatos objeto = new Campeonatos(Int16.Parse(arrayDatos[j, 0]), arrayDatos[j, 1]);
                campeonatos.Add(objeto);
            }
        }

        protected void cargarDisciplinas()
        {
        String[,] arrayDatos = Controlador.CargarInformacion("Deportes");
        for (int j = 0; j < arrayDatos.GetLength(0); j++)
            {
                Disciplinas objeto = new Disciplinas(Int16.Parse(arrayDatos[j, 0]), arrayDatos[j, 1], Int16.Parse(arrayDatos[j, 2]));
                deportes.Add(objeto);
            }
        }

        protected void cargarPaises()
        {
        String[,] arrayDatos = Controlador.CargarInformacion("Paises");
        for (int j = 0; j < arrayDatos.GetLength(0); j++)
            {
                Paises objeto = new Paises(Int16.Parse(arrayDatos[j, 0]), arrayDatos[j, 1]);
                paises.Add(objeto);
            }
        }
    protected void cargarServidores()
    {
        String[,] arrayDatos = Controlador.CargarInformacion("Servidores");
        for (int j = 0; j < arrayDatos.GetLength(0); j++)
        {
            Servidores objeto = new Servidores(arrayDatos[j, 0], arrayDatos[j, 1]);
            servidores.Add(objeto);
        }
    }
    protected void cargarModalidades()
        {
        String[,] arrayDatos = Controlador.CargarInformacion("Modalidades");
        for (int j = 0; j < arrayDatos.GetLength(0); j++)
            {
                Modalidades objeto = new Modalidades(Int16.Parse(arrayDatos[j, 0]), arrayDatos[j, 1]);
                modalidades.Add(objeto);
            }
        }       

}