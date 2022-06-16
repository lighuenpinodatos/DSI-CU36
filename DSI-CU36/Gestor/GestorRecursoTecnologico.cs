using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_CU36.Gestor
{
    public class GestorRecursoTecnologico
    {
        /*

        // Base de datos virtual
        //definimos el personal cientifico
        public PersonalCientifico pc = new PersonalCientifico(1324, "a138", "Juan", "Dias");
        public PersonalCientifico pc;
        //Definimos el usuario
        public Usuario u = new Usuario(1, "Juan", "1234", pc);

        //definisiones de modelo y marca

        // definiremos la sesion activa
        public Sesion activa = new Sesion(u);
        // Modelos con su marca
        public Modelo m1 = new Modelo("M3", new Marca("Hitachi"));
        public Modelo m2 = new Modelo("H322", new Marca("HP"));
        public Modelo m3 = new Modelo("Aviator", new Marca("Sony"));
        public Modelo m4 = new Modelo("Raft", new Marca("Oculus"));


        //Tipos de recursos
        public TipoRecursoTecnologico t1 = new TipoRecursoTecnologico("microscopio");
        public TipoRecursoTecnologico t2 = new TipoRecursoTecnologico("balanza");
        public TipoRecursoTecnologico t3 = new TipoRecursoTecnologico("resonador magnético");
        public TipoRecursoTecnologico t4 = new TipoRecursoTecnologico("supercomputadora");

        //Estados 




        //LISTA RECURSOS TECNOLOGICOS
        public ListaRecursoTecnologico listR = new ListaRecursoTecnologico();



        //Estados 
        public Estado e1 = new Estado("disponible", "RecursoTecnologico", true);
        public Estado e2 = new Estado("confirmado", "turno", true);
        public Estado e3 = new Estado("pendienteConfirmacion", "turno", true);
        public Estado e4 = new Estado("cancelado", "turno", true);



        //Cambio estado Recurso 1
        public CambioEstadoTurnoRT cambioEsTunort1RT1 = new CambioEstadoTurnoRT(new DateTime(2022, 6, 10, 10, 30, 00), new DateTime(2022, 6, 15, 11, 30, 00), e1);
        public CambioEstadoTurnoRT cambioEsTunort1RT2 = new CambioEstadoTurnoRT(new DateTime(2022, 6, 15, 11, 30, 00), new DateTime(2022, 6, 25, 11, 30, 00), e2);
        public CambioEstadoTurnoRT cambioEsTunort1RT3 = new CambioEstadoTurnoRT(new DateTime(2022, 6, 25, 11, 30, 00), default, e3);


        //lista cambio estado turno
        public ListaCambioEstadoTurnoRT listacambioEsTunorRT1 = new ListaCambioEstadoTurnoRT();
        //Agegamos la lista de cambios de estado
       

        public PersonalCientifico pc1 = new PersonalCientifico(2, "2", "Ana", "Stalling");

        public void instanciar()
        {
            listacambioEsTunorRT1.agregar(cambioEsTunort1RT1);
            listacambioEsTunorRT1.agregar(cambioEsTunort1RT2);
            listacambioEsTunorRT1.agregar(cambioEsTunort1RT3);

        }

        //Agergamos los cambios de estado al turno
        public Turno turnoRT11 = new Turno(new DateTime(2022, 6, 25, 11, 30, 00), new DateTime(2022, 6, 25, 15, 30, 00), listacambioEsTunorRT1, pc1);
        //ListaCambio estado recurso tecnologico 1

        public ListaCambioEstadoRT lcert1 = new ListaCambioEstadoRT();


        public CambioEstadoRT cambioEs2RT1 = new CambioEstadoRT(new DateTime(2022, 6, 10, 10, 30, 00), default, e1);
        // CambioEstadoTurnoRT cambioEsTunort2RT2 = new CambioEstadoTurnoRT(new DateTime(2022, 6, 15, 11, 30, 00), new DateTime(2022, 6, 25, 11, 30, 00), e2);
        // CambioEstadoTurnoRT cambioEsTunort2RT3 = new CambioEstadoTurnoRT(new DateTime(2022, 6, 25, 11, 30, 00), default, e3);




        //ListaTurnos recurso  tecnologico 1
        public ListaTurno ltrt1 = new ListaTurno();

        //Cambio estado Recurso 2
        public CambioEstadoTurnoRT cambioEsTunort2RT1 = new CambioEstadoTurnoRT(new DateTime(2022, 6, 10, 10, 30, 00), new DateTime(2022, 6, 15, 11, 30, 00), e1);
        public CambioEstadoTurnoRT cambioEsTunort2RT2 = new CambioEstadoTurnoRT(new DateTime(2022, 6, 15, 11, 30, 00), new DateTime(2022, 6, 25, 11, 30, 00), e2);
        public CambioEstadoTurnoRT cambioEsTunort2RT3 = new CambioEstadoTurnoRT(new DateTime(2022, 6, 25, 11, 30, 00), default, e3);







        public RecursoTecnologico rt1 = new RecursoTecnologico(1, m1, ltrt1, t1, lcert1);

        public listR.agregar(rt1);

            public ListaAsignacionResponsableTecnicoRT listaAsignacionRT = new ListaAsignacionResponsableTecnicoRT();

        public AsignacionResponsableTecnicoRT art1 = new AsignacionResponsableTecnicoRT(u.obtenerCientifico(), DateTime.Now, listR);
        //u.obtenerCientifico();
        */
    }
}
