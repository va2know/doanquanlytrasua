using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class frm_InHoaDon : Form
    {
        public DataTable GridData
        {
            set { dt_gridInHoaDon.DataSource = value; }
        }
        public frm_InHoaDon()
        {
            InitializeComponent();
        }
    }
}
