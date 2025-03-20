using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABDfix
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnTambah(object sender, EventArgs e) // fungsi untuk menambah kian data (create)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    if (txtNIM.text)
                }
            }

        }

        private void btnHapus(object sender, EventArgs e)
        {
           
        }

        private void btnRefresh(object sender, EventArgs e)
        {

        }

        private void dgvMahasiswa(object sender, EventArgs e)
        {

        }
    }
}
