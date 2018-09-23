using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modules.Editors
{
    public partial class Proizvodi : Form
    {
        public Proizvodi()
        {
            InitializeComponent();
        }

        public Proizvodi(int id)
        {
            InitializeComponent();
            LoadData(id);
        }

        private void LoadData(int id)
        {
            ProizvodiBindingSource.DataSource = new Library.Usluge().GetData(id);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Library.Proizvodi proizvodi = new Library.Proizvodi();
            if (!proizvodi.CheckIfExist(txtNaziv.Text))
            {
                proizvodi.Naziv = txtNaziv.Text;
                proizvodi.InsertData();
            }
            else
            {
                proizvodi.Naziv = txtNaziv.Text;
                proizvodi.UpdateData();
            }

            this.Close();
        }
    }
}
