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
    public partial class Operatorler : Form
    {
        public Operatorler()
        {
            InitializeComponent();
        }

        private void Operatorler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'grupOdeviDataSet7.Operatorler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.operatorlerTableAdapter.Fill(this.grupOdeviDataSet7.Operatorler);

        }
    }
}
