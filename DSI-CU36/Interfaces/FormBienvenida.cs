using DSI_CU36.Entidades;

namespace DSI_CU36
{
    public partial class FormBienvenida : Form
    {
        private PersonalCientifico _pc;
        public FormBienvenida(PersonalCientifico pc)
        {
            _pc = pc;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblBienvenido.Text ="Bienvenido usuario "+ _pc.getNombre();
           


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var r =new generarListaRecursos();
            r.ShowDialog(this);


        }
    }
}