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
    public partial class PeriyodikBakim : Form
    {
        public PeriyodikBakim()
        {
            InitializeComponent();
        }

        private void PeriyodikBakim_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'grupOdeviDataSet14.PeriyodikBakim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.periyodikBakimTableAdapter1.Fill(this.grupOdeviDataSet14.PeriyodikBakim);
            // TODO: Bu kod satırı 'grupOdeviDataSet10.PeriyodikBakim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.periyodikBakimTableAdapter.Fill(this.grupOdeviDataSet10.PeriyodikBakim);

        }
    }
}
