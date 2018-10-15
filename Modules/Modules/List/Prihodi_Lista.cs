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
using DevExpress.XtraReports.UI;

namespace Modules
{
    public partial class Prihodi_Lista : UserControl
    {
        public Prihodi_Lista()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            PrihodiListBindingSource.DataSource = new Library.PrihodiList().GetData(null);
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int iFocus = gridView1.FocusedRowHandle;
            if (iFocus < 0) return;
            int id = (int)gridView1.GetFocusedRowCellValue("Id");
            using (Editors.Prihod f = new Editors.Prihod(id))
            {
                f.ShowDialog();
            }
        }

        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                Editors.Prihod prihod = new Editors.Prihod();
                prihod.Show();
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                int iFocus = gridView1.FocusedRowHandle;
                if (iFocus < 0) return;
                int id = (int)gridView1.GetFocusedRowCellValue("Id");
                if (MessageBox.Show("Dali ste sigurni za brisanje označenog zapisa?", "Upozorenje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Library.Prihodi item = new Library.Prihodi();
                    item.DeleteData(id);
                }
            }
        }

        private void gridControl1_MouseMove(object sender, MouseEventArgs e)
        {
            LoadData();
        }

        private void btnKpr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraReport tempReport = Reports.Utils.KnjigaPrometa.ShowKnjigaPrometa();
            tempReport.ShowRibbonPreviewDialog();
        }

        private void btnPoSd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraReport tempReport = Reports.Utils.IzvjesceOpausalnomDohodku.ShowIzvjesceOpausalnomDohodku();
            tempReport.ShowRibbonPreviewDialog();
        }
    }
}
