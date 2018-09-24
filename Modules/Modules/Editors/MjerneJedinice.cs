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
    public partial class MjerneJedinice : Form
    {       

        public MjerneJedinice()
        {
            InitializeComponent();
        }

        public MjerneJedinice(int id)
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
            Library.MjerneJedinice mjerneJedinice = new Library.MjerneJedinice();
            if (!mjerneJedinice.CheckIfExist(txtNaziv.Text))
            {
                mjerneJedinice.Naziv = txtNaziv.Text;
                mjerneJedinice.InsertData();
            }
            else
            {
                mjerneJedinice.Naziv = txtNaziv.Text;
                mjerneJedinice.UpdateData();
            }
            this.Close();
        }
    }
}
