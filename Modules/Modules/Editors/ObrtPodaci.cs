using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modules.Editors
{
    public partial class ObrtPodaci : Form
    {
        public ObrtPodaci()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            Library.Obrt obrt = new Library.Obrt();
            obrt.GetData(null);

            obrtBindingSource.DataSource = obrt;
        }              

        private void btnSave_Click(object sender, EventArgs e)
        {
            Library.Obrt obrt = new Library.Obrt();
            if (!obrt.CheckIfExist())
            {
                obrt = new Library.Obrt();
                obrt.Adresa = txtAdresa.Text;
                obrt.Banka = txtBanka.Text;
                obrt.Djelatnost = txtDjelatnost.Text;
                obrt.Iban = txtIban.Text;
                obrt.NazivObrta = txtNazivObrta.Text;
                obrt.Oib = txtOib.Text;
                obrt.Vlasnik = txtVlasnik.Text;
                MemoryStream ms = new MemoryStream();
                logoPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] Pic_arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(Pic_arr, 0, Pic_arr.Length);

                obrt.Logo = Pic_arr;

                obrt.InsertData();

                this.Close();
            }
            else
            {
                obrt = new Library.Obrt();
                obrt.Adresa = txtAdresa.Text;
                obrt.Banka = txtBanka.Text;
                obrt.Djelatnost = txtDjelatnost.Text;
                obrt.Iban = txtIban.Text;
                obrt.NazivObrta = txtNazivObrta.Text;
                obrt.Oib = txtOib.Text;
                obrt.Vlasnik = txtVlasnik.Text;
                MemoryStream ms = new MemoryStream();
                logoPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] Pic_arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(Pic_arr, 0, Pic_arr.Length);

                obrt.Logo = Pic_arr;

                obrt.UpdateData();

                this.Close();
            }
        }


        private void btnPickImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
            DialogResult dr = dialog.ShowDialog();

            if (dr == DialogResult.Cancel)
                return;

            logoPictureBox.Image = Image.FromFile(dialog.FileName);
            txtImagePath.Text = dialog.FileName;
        }
    }
}
