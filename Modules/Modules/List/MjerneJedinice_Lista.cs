using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Modules
{
    public partial class MjerneJedinice_Lista : UserControl
    {
        public MjerneJedinice_Lista()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            MjerneJediniceListBindingSource.DataSource = new Library.MjerneJediniceList().GetData(null);
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int iFocus = gridView1.FocusedRowHandle;
            if (iFocus < 0) return;
            int id = (int)gridView1.GetFocusedRowCellValue("Id");
            using (Editors.MjerneJedinice f = new Editors.MjerneJedinice(id))
            {
                f.ShowDialog();
            }
        }

        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                Editors.MjerneJedinice usluge = new Editors.MjerneJedinice();
                usluge.Show();
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                int iFocus = gridView1.FocusedRowHandle;
                if (iFocus < 0) return;
                int id = (int)gridView1.GetFocusedRowCellValue("Id");
                if (MessageBox.Show("Dali ste sigurni za brisanje označenog zapisa?", "Upozorenje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Library.MjerneJedinice item = new Library.MjerneJedinice();
                    item.DeleteData(id);
                }
            }
        }

        private void gridControl1_MouseMove(object sender, MouseEventArgs e)
        {
            LoadData();
        }
    }
}
