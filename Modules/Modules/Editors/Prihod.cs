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
    public partial class Prihod : Form
    {
        public Prihod()
        {
            InitializeComponent();
        }

        public Prihod(int id)
        {
            InitializeComponent();
            LoadData(id);
        }
        public void LoadData(int id)
        {
            PrihodiBindingSource.DataSource = new Library.Prihodi().GetData(id);
        }
    }
}
