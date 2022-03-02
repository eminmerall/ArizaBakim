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
    public partial class YedekParcalar : Form
    {
        public YedekParcalar()
        {
            InitializeComponent();
        }

        private void YedekParcalar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'grupOdeviDataSet12.YedekParcalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yedekParcalarTableAdapter.Fill(this.grupOdeviDataSet12.YedekParcalar);

        }
    }
}
