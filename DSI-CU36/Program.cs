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
            PersonalCientifico pc = new PersonalCientifico(1324,"a138", "Juan");

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

            Estado e1 = new Estado("disponible", "turno",true);
            Estado e2 = new Estado("confirmado", "turno", true);
            Estado e3 = new Estado("pendienteConfirmacion", "turno", true);
            Estado e4 = new Estado("cancelado", "turno", true);

            ListaRecursoTecnologico listR = new ListaRecursoTecnologico();
            //listR.agregar();


            u.obtenerCientifico();
            ApplicationConfiguration.Initialize();
            Application.Run(new FormBienvenida(u.obtenerCientifico()));


        }
    }
}