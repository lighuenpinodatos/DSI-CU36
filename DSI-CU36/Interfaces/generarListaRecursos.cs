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
            ListViewItem item2 = new ListViewItem(new[] { "Balanza", "1", "Metric", "Tor", "Mint" });
            listView1.Items.Add(item2);
                        ListViewItem item3 = new ListViewItem(new[] { "Pc quantica", "1", "Quantum", "Tor", "Mint" });
listView1.Items.Add(item3);
            ListViewItem item4 = new ListViewItem(new[] { "Pc quantica", "1", "Quantum", "Tor", "Mint" });
            listView1.Items.Add(item4);

            ListViewItem item5 = new ListViewItem(new[] { "Microscopio", "1", "Ocular", "Tor", "Mint" });
            listView1.Items.Add(item5);
            ListViewItem item6 = new ListViewItem(new[] { "Balanza", "1", "Metric", "Tor", "Mint" });
            listView1.Items.Add(item6);
            ListViewItem item7 = new ListViewItem(new[] { "Pc quantica", "1", "Quantum", "Tor", "Mint" });
            listView1.Items.Add(item7);
            ListViewItem item8 = new ListViewItem(new[] { "Pc quantica", "1", "Quantum", "Tor", "Mint" });
            listView1.Items.Add(item8);

            ListViewItem item9 = new ListViewItem(new[] { "Microscopio", "1", "Ocular", "Tor", "Mint" });
            listView1.Items.Add(item9);
            ListViewItem item10 = new ListViewItem(new[] { "Balanza", "1", "Metric", "Tor", "Mint" });
            listView1.Items.Add(item10);
            ListViewItem item11 = new ListViewItem(new[] { "Pc quantica", "1", "Quantum", "Tor", "Mint" });
            listView1.Items.Add(item11);
            ListViewItem item12 = new ListViewItem(new[] { "Pc quantica", "1", "Quantum", "Tor", "Mint" });
            listView1.Items.Add(item12);


            ListViewItem item13 = new ListViewItem(new[] { "Microscopio", "1", "Ocular", "Tor", "Mint" });
            listView1.Items.Add(item13);
            ListViewItem item14 = new ListViewItem(new[] { "Balanza", "1", "Metric", "Tor", "Mint" });
            listView1.Items.Add(item14);
            ListViewItem item15 = new ListViewItem(new[] { "Pc quantica", "1", "Quantum", "Tor", "Mint" });
            listView1.Items.Add(item15);
            ListViewItem item16 = new ListViewItem(new[] { "Pc quantica", "1", "Quantum", "Tor", "Mint" });
            listView1.Items.Add(item16);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
