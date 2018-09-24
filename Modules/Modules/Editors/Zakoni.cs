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
    public partial class Zakoni : Form
    {       

        public Zakoni()
        {
            InitializeComponent();
        }

        public Zakoni(int id)
        {
            InitializeComponent();
            LoadData(id);
        }

        private void LoadData(int id)
        {
            ZakoniBindingSource.DataSource = new Library.Zakoni().GetData(id);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            Library.Zakoni usluge = new Library.Zakoni();
            if (!usluge.CheckIfExist(txtNaziv.Text))
            {
                usluge.Naziv = txtNaziv.Text;
                usluge.Napomena = txtNapomena.Text;
                usluge.InsertData();
            }
            else
            {
                usluge.Naziv = txtNaziv.Text;
                usluge.Napomena = txtNapomena.Text;
                usluge.UpdateData();
            }
            this.Close();
        }
    }
}
