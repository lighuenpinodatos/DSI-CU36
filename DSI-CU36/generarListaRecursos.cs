using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSI_CU36
{
    public partial class generarListaRecursos : Form
    {
        public generarListaRecursos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void generarListaRecursos_Load(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(new[] { "Microscopio", "1", "Ocular", "Tor", "Mint" });
            listView1.Items.Add(item);
            ListViewItem item2 = new ListViewItem(new[] { "Microscopio", "1", "Ocular", "Tor", "Mint" });
            listView1.Items.Add(item2);
            ListViewItem item3 = new ListViewItem(new[] { "Microscopio", "1", "Ocular", "Tor", "Mint" });
            listView1.Items.Add(item3);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
