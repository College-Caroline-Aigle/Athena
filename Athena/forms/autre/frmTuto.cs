using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartesAcces2024;

namespace Athena.forms.autre
{
    public partial class frmTuto : Form
    {
        public frmTuto(string nomForm)// format sans le .cs à la fin!!! avec this.GetType().Name;
        {
            InitializeComponent();
            string path = Chemin.DossierPhotosTutos + "photo_" + nomForm + ".png";
            pictureBox1.Image = Image.FromFile(path);
        }

        private void frmTuto_Load(object sender, EventArgs e)
        {

        }
    }
}
