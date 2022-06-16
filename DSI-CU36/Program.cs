using DSI_CU36.Entidades;

namespace DSI_CU36
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //Las siguientes son datos de prueba para respetar 
            //no tener persistencia.

            
            //definimos el personal cientifico
            PersonalCientifico pc = new PersonalCientifico(1324,"a138", "Juan","Dias");

            //Definimos el usuario
            Usuario u = new Usuario(1, "Juan", "1234", pc);

            //definisiones de modelo y marca

            // definiremos la sesion activa
            Sesion activa= new Sesion(u);
            // Modelos con su marca
            Modelo m1 = new Modelo("M3", new Marca("Hitachi"));
            Modelo m2 = new Modelo("H322", new Marca("HP"));
            Modelo m3 = new Modelo("Aviator", new Marca("Sony"));
            Modelo m4 = new Modelo("Raft", new Marca("Oculus"));


            //Tipos de recursos
            TipoRecursoTecnologico t1 = new TipoRecursoTecnologico("microscopio");
            TipoRecursoTecnologico t2 = new TipoRecursoTecnologico("balanza");
            TipoRecursoTecnologico t3 = new TipoRecursoTecnologico("resonador magnético");
            TipoRecursoTecnologico t4 = new TipoRecursoTecnologico("supercomputadora");

            //Estados 

   


            //LISTA RECURSOS TECNOLOGICOS
            ListaRecursoTecnologico listR = new ListaRecursoTecnologico();
            


            //Estados 
            Estado e1 = new Estado("disponible", "RecursoTecnologico", true);
            Estado e2 = new Estado("confirmado", "turno", true);
            Estado e3 = new Estado("pendienteConfirmacion", "turno", true);
            Estado e4 = new Estado("cancelado", "turno", true);
            
            
 
            //Cambio estado Recurso 1
            CambioEstadoTurnoRT cambioEsTunort1RT1 = new CambioEstadoTurnoRT(new DateTime(2022, 6, 10, 10, 30, 00), new DateTime(2022, 6, 15, 11, 30, 00), e1);
            CambioEstadoTurnoRT cambioEsTunort1RT2 = new CambioEstadoTurnoRT(new DateTime(2022, 6, 15, 11, 30, 00), new DateTime(2022, 6, 25, 11, 30, 00), e2);
            CambioEstadoTurnoRT cambioEsTunort1RT3 = new CambioEstadoTurnoRT(new DateTime(2022, 6, 25, 11, 30, 00), default , e3);


            //lista cambio estado turno
            ListaCambioEstadoTurnoRT listacambioEsTunorRT1 = new ListaCambioEstadoTurnoRT();
            //Agegamos la lista de cambios de estado
            listacambioEsTunorRT1.agregar(cambioEsTunort1RT1);
            listacambioEsTunorRT1.agregar(cambioEsTunort1RT2);
            listacambioEsTunorRT1.agregar(cambioEsTunort1RT3);


            PersonalCientifico pc1 = new PersonalCientifico(2, "2", "Ana","Stalling");
            


            //Agergamos los cambios de estado al turno
            Turno turnoRT11 = new Turno(new DateTime(2022, 6, 25, 11, 30, 00), new DateTime(2022, 6, 25, 15, 30, 00), listacambioEsTunorRT1, pc1);
            //ListaCambio estado recurso tecnologico 1
            
            ListaCambioEstadoRT lcert1 = new ListaCambioEstadoRT();
           
            
            CambioEstadoRT cambioEs2RT1 = new CambioEstadoRT(new DateTime(2022, 6, 10, 10, 30, 00), default, e1);
           // CambioEstadoTurnoRT cambioEsTunort2RT2 = new CambioEstadoTurnoRT(new DateTime(2022, 6, 15, 11, 30, 00), new DateTime(2022, 6, 25, 11, 30, 00), e2);
           // CambioEstadoTurnoRT cambioEsTunort2RT3 = new CambioEstadoTurnoRT(new DateTime(2022, 6, 25, 11, 30, 00), default, e3);




            //ListaTurnos recurso  tecnologico 1
            ListaTurno ltrt1 = new ListaTurno();

            //Cambio estado Recurso 2
            CambioEstadoTurnoRT cambioEsTunort2RT1 = new CambioEstadoTurnoRT(new DateTime(2022, 6, 10, 10, 30, 00), new DateTime(2022, 6, 15, 11, 30, 00), e1);
            CambioEstadoTurnoRT cambioEsTunort2RT2 = new CambioEstadoTurnoRT(new DateTime(2022, 6, 15, 11, 30, 00), new DateTime(2022, 6, 25, 11, 30, 00), e2);
            CambioEstadoTurnoRT cambioEsTunort2RT3 = new CambioEstadoTurnoRT(new DateTime(2022, 6, 25, 11, 30, 00), default, e3);






            
            RecursoTecnologico rt1 = new RecursoTecnologico(1, m1,ltrt1, t1, lcert1);

            listR.agregar(rt1);

            ListaAsignacionResponsableTecnicoRT listaAsignacionRT = new ListaAsignacionResponsableTecnicoRT();

            AsignacionResponsableTecnicoRT art1 = new AsignacionResponsableTecnicoRT(u.obtenerCientifico(),DateTime.Now,listR);
            u.obtenerCientifico();
            /*
            //Lista de recursos tecnologicos
            ListaRecursoTecnologico listaRecTec = new ListaRecursoTecnologico;

            //Lista cambio de estado turno
            ListaCambioEstadoTurnoRT listaCET = new ListaCambioEstadoTurnoRT();
            
            listaCET.agregar(cambioEstRT1);

            /*
            //listaRecTec.agregar(cambioEstRT2);
            //listaRecTec.agregar(cambioEstRT3);
            

            ListaCambioEstadoTurno listaCET2 = new ListaCambioEstadoTurno();
            listaCET.agregar(cambioEstRT4);
            listaRecTec.agregar(cambioEstRT5);
            listaRecTec.agregar(cambioEstRT6);

            //Turnos
            Turno tur1 = new Turno((2022, 6, 25, 9, 30, 00), (2022, 6, 25, 10, 30, 00), listaCET, pc);
            Turno tur1 = new Turno((2022, 6, 25, 9, 30, 00), (2022, 6, 24, 10, 30, 00), listaCET2, pc);
            
            //Lista de turnos
            ListaTurno turnos = new ListaTurno();
            turnos.agregar(tur1);
            turnos.agregar(tur2);

            //Recursos tecnologicos
            RecursoTecnologico recTec1 = new RecursoTecnologico(1, m3, turnos, t1);
            */


            ApplicationConfiguration.Initialize();
            Application.Run(new FormBienvenida(u.obtenerCientifico()));


        }
    }
}