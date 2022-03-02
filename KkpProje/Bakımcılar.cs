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
    public partial class Bakımcılar : Form
    {
        public Bakımcılar()
        {
            InitializeComponent();
        }

        private void Bakımcılar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'grupOdeviDataSet8.BakiciKisiler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bakiciKisilerTableAdapter.Fill(this.grupOdeviDataSet8.BakiciKisiler);

        }
    }
}
