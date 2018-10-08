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
    public partial class Usluge_Lista : UserControl
    {
        public Usluge_Lista()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            UslugeListBindingSource.DataSource = new Library.UslugeList().GetData("Kategorija='Usluge'");
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int iFocus = gridView1.FocusedRowHandle;
            if (iFocus < 0) return;
            int id = (int)gridView1.GetFocusedRowCellValue("Id");
            using (Editors.Usluge f = new Editors.Usluge(id))
            {
                f.ShowDialog();
            }
        }

        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                Editors.Usluge usluge = new Editors.Usluge();
                usluge.Show();
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                int iFocus = gridView1.FocusedRowHandle;
                if (iFocus < 0) return;
                int id = (int)gridView1.GetFocusedRowCellValue("Id");
                if (MessageBox.Show("Dali ste sigurni za brisanje označenog zapisa?", "Upozorenje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Library.Usluge item = new Library.Usluge();
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
