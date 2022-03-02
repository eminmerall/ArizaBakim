using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KkpProje
{
    public partial class Preshane : Form
    {
        public Preshane()
        {
            InitializeComponent();
        }

        private void Preshane_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'grupOdeviDataSet11.Preshane' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.preshaneTableAdapter.Fill(this.grupOdeviDataSet11.Preshane);

        }
    }
}
