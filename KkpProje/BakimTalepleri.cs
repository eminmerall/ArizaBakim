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
    public partial class BakimTalepleri : Form
    {
        public BakimTalepleri()
        {
            InitializeComponent();
        }

        private void BakimTalepleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'grupOdeviDataSet9.BakimTalebi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bakimTalebiTableAdapter.Fill(this.grupOdeviDataSet9.BakimTalebi);

        }
    }
}
