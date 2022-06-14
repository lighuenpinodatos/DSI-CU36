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

            // definiremos la sesion activa
            Sesion activa= new Sesion(u);
            //Lista de recursos tecnologicos
            u.obtenerCientifico();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}