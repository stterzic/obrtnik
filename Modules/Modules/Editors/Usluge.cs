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
    public partial class Usluge : Form
    {       

        public Usluge()
        {
            InitializeComponent();
        }

        public Usluge(int id)
        {
            InitializeComponent();
            LoadData(id);
        }

        private void LoadData(int id)
        {
            UslugeBindingSource.DataSource = new Library.Usluge().GetData(id);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            Library.Usluge usluge = new Library.Usluge();
            if (!usluge.CheckIfExist(txtNaziv.Text))
            {
                usluge.Naziv = txtNaziv.Text;
                usluge.InsertData();
            }
            else
            {
                usluge.Naziv = txtNaziv.Text;
                usluge.UpdateData();
            }
            this.Close();
        }
    }
}
