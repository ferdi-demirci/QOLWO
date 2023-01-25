using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QOLWO
{
    public partial class FrmDisKalip : Form
    {
        public FrmDisKalip()
        {
            InitializeComponent();
        }
        VeritabaniBaglantisi _vt = new VeritabaniBaglantisi();
        void Populatedatagridview()
        {
            if (_vt.baglan.State != ConnectionState.Open)
            {
                _vt.baglan.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(@"SELECT * FROM TBLDISKALIP", _vt.baglan);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                gridControl1.DataSource = dtbl;
                _vt.baglan.Close();
            }

        }
        //void uretimyeri()
        //{
        //    if (_vt.baglan.State != ConnectionState.Open)
        //    {
        //        _vt.baglan.Open();
        //        SqlDataAdapter sqlDa = new SqlDataAdapter(@"SELECT * FROM TBLURETIMYERI", _vt.baglan);
        //        DataTable dtbl = new DataTable();
        //        sqlDa.Fill(dtbl);
        //        repositoryItemComboBox1.ValueMember = "URETIMYERIID";
        //        repositoryItemComboBox1.DisplayMember = "URETIMYERI";
        //        DataRow topItem = dtbl.NewRow();
        //        topItem[0] = 0;
        //        topItem[1] = "-Select-";
        //        dtbl.Rows.InsertAt(topItem, 0);
        //        cbxURETIMYERI.DataSource = dtbl;
        //        _vt.baglan.Close();
        //    }
        //}
        //void kaliptur()
        //{
        //    if (_vt.baglan.State != ConnectionState.Open)
        //    {
        //        _vt.baglan.Open();
        //        SqlDataAdapter sqlDa = new SqlDataAdapter(@"SELECT * FROM TBLTYPELIST", _vt.baglan);
        //        DataTable dtbl = new DataTable();
        //        sqlDa.Fill(dtbl);
        //        cbxTYPE.ValueMember = "TYPEID";
        //        cbxTYPE.DisplayMember = "TYPENAME";
        //        DataRow topItem = dtbl.NewRow();
        //        topItem[0] = 0;
        //        topItem[1] = "-Select-";
        //        dtbl.Rows.InsertAt(topItem, 0);
        //        cbxTYPE.DataSource = dtbl;
        //        _vt.baglan.Close();
        //    }
            
        //}
        private void FrmDisKalip_Load(object sender, EventArgs e)
        {
          
            //kaliptur();
            //uretimyeri();
            Populatedatagridview();
        }

     

      
        private void AllowNumberOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
