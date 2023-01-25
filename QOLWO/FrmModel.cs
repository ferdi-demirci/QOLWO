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
    public partial class FrmModel : Form
    {
        public FrmModel()
        {
            InitializeComponent();
        }
        
        VeritabaniBaglantisi _vt = new VeritabaniBaglantisi();
        fonksiyonlar fnk = new fonksiyonlar();
        public void getir()
        {
            try
            {
                SqlCommand getir = new SqlCommand(@"SELECT * FROM TBLMODELLER", _vt.baglan);
                _vt.baglan.Open();
                SqlDataReader rd = getir.ExecuteReader();               
                gridControl1.DataSource = rd;
                rd.Close();
                _vt.baglan.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Veri getirilmedi." + hata, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _vt.baglan.Close();
            }
        }
        public void paneltemizle()
        {
            Pnldis1.BackColor = Color.Wheat;
            Pnldis2.BackColor = Color.Wheat;
            Pnldis3.BackColor = Color.Wheat;
            Pnldis4.BackColor = Color.Wheat;
            Pnldis5.BackColor = Color.Wheat;
            Pnldis6.BackColor = Color.Wheat;
            Pnldis7.BackColor = Color.Wheat;
            Pnldis8.BackColor = Color.Wheat;
            Pnldis9.BackColor = Color.Wheat;
            Pnldis10.BackColor = Color.Wheat;
            Pnldis11.BackColor = Color.Wheat;
            Pnlic1.BackColor = Color.Wheat;
            Pnlic2.BackColor = Color.Wheat;
            Pnlic3.BackColor = Color.Wheat;
            Pnlic4.BackColor = Color.Wheat;
            Pnlic5.BackColor = Color.Wheat;
            Pnlic6.BackColor = Color.Wheat;
            Pnlic7.BackColor = Color.Wheat;
            Pnlic8.BackColor = Color.Wheat;
            Pnlic9.BackColor = Color.Wheat;
            Pnlic10.BackColor = Color.Wheat;
            Pnlic11.BackColor = Color.Wheat;
        }
        public void ickalipsorgula()
        {

            var cmd1 = "SELECT * FROM TBLICKALIP WHERE MODEL=@P1";
            var cmd2 = "SELECT * FROM TBLICKALIP WHERE MODEL=@P2";
            var cmd3 = "SELECT * FROM TBLICKALIP WHERE MODEL=@P3";
            var cmd4 = "SELECT * FROM TBLICKALIP WHERE MODEL=@P4";
            var cmd5 = "SELECT * FROM TBLICKALIP WHERE MODEL=@P5";
            var cmd6 = "SELECT * FROM TBLICKALIP WHERE MODEL=@P6";
            var cmd7 = "SELECT * FROM TBLICKALIP WHERE MODEL=@P7";
            var cmd8 = "SELECT * FROM TBLICKALIP WHERE MODEL=@P8";
            var cmd9 = "SELECT * FROM TBLICKALIP WHERE MODEL=@P9";
            var cmd10 = "SELECT * FROM TBLICKALIP WHERE MODEL=@P10";
            var cmd11 = "SELECT * FROM TBLICKALIP WHERE MODEL=@P11";

            SqlCommand giris = new SqlCommand(cmd1, _vt.baglan);
            _vt.baglan.Open();
            giris.Parameters.AddWithValue("@P1", lblic1.Text);
            SqlDataReader okuyucu = giris.ExecuteReader();
            if (okuyucu.HasRows)
            {
                Pnlic1.BackColor = Color.Green;
                _vt.baglan.Close();
            }
            else
            {
                Pnlic1.BackColor = Color.Red;
                _vt.baglan.Close();

            }

            SqlCommand giris2 = new SqlCommand(cmd2, _vt.baglan);
            _vt.baglan.Open();
            giris2.Parameters.AddWithValue("@P2", lblic2.Text);
            SqlDataReader okuyucu2 = giris2.ExecuteReader();
            if (okuyucu2.HasRows)
            {
                Pnlic2.BackColor = Color.Green;
                _vt.baglan.Close();

            }
            else
            {
                Pnlic2.BackColor = Color.Red;
                _vt.baglan.Close();

            }

            SqlCommand giris3 = new SqlCommand(cmd3, _vt.baglan);
            _vt.baglan.Open();
            giris3.Parameters.AddWithValue("@P3", lblic3.Text);
            SqlDataReader okuyucu3 = giris3.ExecuteReader();
            if (okuyucu3.HasRows)
            {
                Pnlic3.BackColor = Color.Green;
                _vt.baglan.Close();

            }
            else
            {
                Pnlic3.BackColor = Color.Red;
                _vt.baglan.Close();

            }

            SqlCommand giris4 = new SqlCommand(cmd4, _vt.baglan);
            _vt.baglan.Open();
            giris4.Parameters.AddWithValue("@P4", lblic4.Text);
            SqlDataReader okuyucu4 = giris4.ExecuteReader();
            if (okuyucu4.HasRows)
            {
                Pnlic4.BackColor = Color.Green;
                _vt.baglan.Close();

            }
            else
            {
                Pnlic4.BackColor = Color.Red;
                _vt.baglan.Close();

            }

            SqlCommand giris5 = new SqlCommand(cmd5, _vt.baglan);
            _vt.baglan.Open();
            giris5.Parameters.AddWithValue("@P5", lblic5.Text);
            SqlDataReader okuyucu5 = giris5.ExecuteReader();
            if (okuyucu5.HasRows)
            {
                Pnlic5.BackColor = Color.Green;
                _vt.baglan.Close();
            }
            else
            {
                Pnlic5.BackColor = Color.Red;
                _vt.baglan.Close();

            }



            SqlCommand giris6 = new SqlCommand(cmd6, _vt.baglan);
            _vt.baglan.Open();
            giris6.Parameters.AddWithValue("@P6", lblic6.Text);
            SqlDataReader okuyucu6 = giris6.ExecuteReader();
            if (okuyucu6.HasRows)
            {
                Pnlic6.BackColor = Color.Green;
                _vt.baglan.Close();
            }
            else
            {
                Pnlic6.BackColor = Color.Red;
                _vt.baglan.Close();

            }


            SqlCommand giris7 = new SqlCommand(cmd7, _vt.baglan);
            _vt.baglan.Open();
            giris7.Parameters.AddWithValue("@P7", lblic7.Text);
            SqlDataReader okuyucu7 = giris7.ExecuteReader();
            if (okuyucu7.HasRows)
            {
                Pnlic7.BackColor = Color.Green;
                _vt.baglan.Close();
            }
            else
            {
                Pnlic7.BackColor = Color.Red;
                _vt.baglan.Close();

            }


            SqlCommand giris8 = new SqlCommand(cmd8, _vt.baglan);
            _vt.baglan.Open();
            giris8.Parameters.AddWithValue("@P8", lblic8.Text);
            SqlDataReader okuyucu8 = giris8.ExecuteReader();
            if (okuyucu8.HasRows)
            {
                Pnlic8.BackColor = Color.Green;
                _vt.baglan.Close();
            }
            else
            {
                Pnlic8.BackColor = Color.Red;
                _vt.baglan.Close();

            }


            SqlCommand giris9 = new SqlCommand(cmd9, _vt.baglan);
            _vt.baglan.Open();
            giris9.Parameters.AddWithValue("@P9", lblic9.Text);
            SqlDataReader okuyucu9 = giris9.ExecuteReader();
            if (okuyucu9.HasRows)
            {
                Pnlic9.BackColor = Color.Green;
                _vt.baglan.Close();
            }
            else
            {
                Pnlic9.BackColor = Color.Red;
                _vt.baglan.Close();

            }


            SqlCommand giris10 = new SqlCommand(cmd10, _vt.baglan);
            _vt.baglan.Open();
            giris10.Parameters.AddWithValue("@P10", lblic10.Text);
            SqlDataReader okuyucu10 = giris10.ExecuteReader();
            if (okuyucu10.HasRows)
            {
                Pnlic10.BackColor = Color.Green;
                _vt.baglan.Close();
            }
            else
            {
                Pnlic10.BackColor = Color.Red;
                _vt.baglan.Close();

            }


            SqlCommand giris11 = new SqlCommand(cmd11, _vt.baglan);
            _vt.baglan.Open();
            giris11.Parameters.AddWithValue("@P11", lblic11.Text);
            SqlDataReader okuyucu11 = giris11.ExecuteReader();
            if (okuyucu11.HasRows)
            {
                Pnlic11.BackColor = Color.Green;
                _vt.baglan.Close();
            }
            else
            {
                Pnlic11.BackColor = Color.Red;
                _vt.baglan.Close();

            }
        }
        public void diskalipsorgula()
        {

            var cmd1 = "SELECT * FROM TBLDISKALIP WHERE MODEL=@P1";
            var cmd2 = "SELECT * FROM TBLDISKALIP WHERE MODEL=@P2";
            var cmd3 = "SELECT * FROM TBLDISKALIP WHERE MODEL=@P3";
            var cmd4 = "SELECT * FROM TBLDISKALIP WHERE MODEL=@P4";
            var cmd5 = "SELECT * FROM TBLDISKALIP WHERE MODEL=@P5";
            var cmd6 = "SELECT * FROM TBLDISKALIP WHERE MODEL=@P6";
            var cmd7 = "SELECT * FROM TBLDISKALIP WHERE MODEL=@P7";
            var cmd8 = "SELECT * FROM TBLDISKALIP WHERE MODEL=@P8";
            var cmd9 = "SELECT * FROM TBLDISKALIP WHERE MODEL=@P9";
            var cmd10 = "SELECT * FROM TBLDISKALIP WHERE MODEL=@P10";
            var cmd11 = "SELECT * FROM TBLDISKALIP WHERE MODEL=@P11";

            SqlCommand giris = new SqlCommand(cmd1, _vt.baglan);
                _vt.baglan.Open();
                giris.Parameters.AddWithValue("@P1", lbldis1.Text);               
                SqlDataReader okuyucu = giris.ExecuteReader();
            if (okuyucu.HasRows)
            {
                Pnldis1.BackColor = Color.Green;
                _vt.baglan.Close();
            }
            else
            {
                Pnldis1.BackColor = Color.Red;
                _vt.baglan.Close();

            }

            SqlCommand giris2 = new SqlCommand(cmd2, _vt.baglan);
            _vt.baglan.Open();
            giris2.Parameters.AddWithValue("@P2", lbldis2.Text);
            SqlDataReader okuyucu2 = giris2.ExecuteReader();
            if (okuyucu2.HasRows)
            {
                Pnldis2.BackColor = Color.Green;
                _vt.baglan.Close();

            }
            else
            {
                Pnldis2.BackColor = Color.Red;
                _vt.baglan.Close();

            }

            SqlCommand giris3 = new SqlCommand(cmd3, _vt.baglan);
            _vt.baglan.Open();
            giris3.Parameters.AddWithValue("@P3", lbldis3.Text);
            SqlDataReader okuyucu3 = giris3.ExecuteReader();
            if (okuyucu3.HasRows)
            {
                Pnldis3.BackColor = Color.Green;
                _vt.baglan.Close();

            }
            else
            {
                Pnldis3.BackColor = Color.Red;
                _vt.baglan.Close();

            }

            SqlCommand giris4 = new SqlCommand(cmd4, _vt.baglan);
            _vt.baglan.Open();
            giris4.Parameters.AddWithValue("@P4", lbldis4.Text);
            SqlDataReader okuyucu4 = giris4.ExecuteReader();
            if (okuyucu4.HasRows)
            {
                Pnldis4.BackColor = Color.Green;
                _vt.baglan.Close();

            }
            else
            {
                Pnldis4.BackColor = Color.Red;
                _vt.baglan.Close();

            }

            SqlCommand giris5 = new SqlCommand(cmd5, _vt.baglan);
            _vt.baglan.Open();
            giris5.Parameters.AddWithValue("@P5", lbldis5.Text);
            SqlDataReader okuyucu5 = giris5.ExecuteReader();
            if (okuyucu5.HasRows)
            {
                Pnldis5.BackColor = Color.Green;
                _vt.baglan.Close();
            }
            else
            {
                Pnldis5.BackColor = Color.Red;
                _vt.baglan.Close();

            }



            SqlCommand giris6 = new SqlCommand(cmd6, _vt.baglan);
            _vt.baglan.Open();
            giris6.Parameters.AddWithValue("@P6", lbldis6.Text);
            SqlDataReader okuyucu6 = giris6.ExecuteReader();
            if (okuyucu6.HasRows)
            {
                Pnldis6.BackColor = Color.Green;
                _vt.baglan.Close();
            }
            else
            {
                Pnldis6.BackColor = Color.Red;
                _vt.baglan.Close();

            }


            SqlCommand giris7 = new SqlCommand(cmd7, _vt.baglan);
            _vt.baglan.Open();
            giris7.Parameters.AddWithValue("@P7", lbldis7.Text);
            SqlDataReader okuyucu7 = giris7.ExecuteReader();
            if (okuyucu7.HasRows)
            {
                Pnldis7.BackColor = Color.Green;
                _vt.baglan.Close();
            }
            else
            {
                Pnldis7.BackColor = Color.Red;
                _vt.baglan.Close();

            }


            SqlCommand giris8 = new SqlCommand(cmd8, _vt.baglan);
            _vt.baglan.Open();
            giris8.Parameters.AddWithValue("@P8", lbldis8.Text);
            SqlDataReader okuyucu8 = giris8.ExecuteReader();
            if (okuyucu8.HasRows)
            {
                Pnldis8.BackColor = Color.Green;
                _vt.baglan.Close();
            }
            else
            {
                Pnldis8.BackColor = Color.Red;
                _vt.baglan.Close();

            }


            SqlCommand giris9 = new SqlCommand(cmd9, _vt.baglan);
            _vt.baglan.Open();
            giris9.Parameters.AddWithValue("@P9", lbldis9.Text);
            SqlDataReader okuyucu9 = giris9.ExecuteReader();
            if (okuyucu9.HasRows)
            {
                Pnldis9.BackColor = Color.Green;
                _vt.baglan.Close();
            }
            else
            {
                Pnldis9.BackColor = Color.Red;
                _vt.baglan.Close();

            }


            SqlCommand giris10 = new SqlCommand(cmd10, _vt.baglan);
            _vt.baglan.Open();
            giris10.Parameters.AddWithValue("@P10", lbldis10.Text);
            SqlDataReader okuyucu10 = giris10.ExecuteReader();
            if (okuyucu10.HasRows)
            {
                Pnldis10.BackColor = Color.Green;
                _vt.baglan.Close();
            }
            else
            {
                Pnldis10.BackColor = Color.Red;
                _vt.baglan.Close();

            }


            SqlCommand giris11 = new SqlCommand(cmd11, _vt.baglan);
            _vt.baglan.Open();
            giris11.Parameters.AddWithValue("@P11", lbldis11.Text);
            SqlDataReader okuyucu11 = giris11.ExecuteReader();
            if (okuyucu11.HasRows)
            {
                Pnldis11.BackColor = Color.Green;
                _vt.baglan.Close();
            }
            else
            {
                Pnldis11.BackColor = Color.Red;
                _vt.baglan.Close();

            }
        }
        private void FrmModel_Load(object sender, EventArgs e)
        {
            getir();
            
        }
        public void IDTEMIZLE()
        {
            ID1 = "";
            ID2 = "";
            ID3 = "";
            ID4 = "";
            ID5 = "";
            ID6 = "";
            ID7 = "";
            ID8 = "";
            ID9 = "";
            ID10 = "";
            ID11 = "";
        }
        public void textleriac()
        {
            txtdis1.Enabled = true;
            txtdis2.Enabled = true;
            txtdis3.Enabled = true;
            txtdis4.Enabled = true;
            txtdis5.Enabled = true;
            txtdis6.Enabled = true;
            txtdis7.Enabled = true;
            txtdis8.Enabled = true;
            txtdis9.Enabled = true;
            txtdis10.Enabled = true;
            txtdis11.Enabled = true;

            txtic1.Enabled = true;
            txtic2.Enabled = true;
            txtic3.Enabled = true;
            txtic4.Enabled = true;
            txtic5.Enabled = true;
            txtic6.Enabled = true;
            txtic7.Enabled = true;
            txtic8.Enabled = true;
            txtic9.Enabled = true;
            txtic10.Enabled = true;
            txtic11.Enabled = true;
        }
        public void Rbkapat()
        {
            rb1.Checked = false;
            rb1.Enabled = false;
            rb2.Checked = false;
            rb2.Enabled = false;
            rb3.Checked = false;
            rb3.Enabled = false;
            rb4.Checked = false;
            rb4.Enabled = false;
            rb5.Checked = false;
            rb5.Enabled = false;
            rb6.Checked = false;
            rb6.Enabled = false;
            rb7.Checked = false;
            rb7.Enabled = false;
            rb8.Checked = false;
            rb8.Enabled = false;
            rb9.Checked = false;
            rb9.Enabled = false;
            rb10.Checked = false;
            rb10.Enabled = false;
            rb11.Checked = false;
            rb11.Enabled = false;
      
        }
        public void radiobutonlariac()
        {
            rb1.Checked = false;
            rb1.Enabled = true;
            rb2.Checked = false;
            rb2.Enabled = false;
            rb3.Checked = false;
            rb3.Enabled = false;
            rb4.Checked = false;
            rb4.Enabled = false;
            rb5.Checked = false;
            rb5.Enabled = false;
            rb6.Checked = false;
            rb6.Enabled = false;
            rb7.Checked = false;
            rb7.Enabled = false;
            rb8.Checked = false;
            rb8.Enabled = false;
            rb9.Checked = false;
            rb9.Enabled = false;
            rb10.Checked = false;
            rb10.Enabled = false;
            rb11.Checked = false;
            rb11.Enabled = false;

        }
    
        public string IDSEC;
        private void gridView1_Click(object sender, EventArgs e)
        {

            if (gridView1.SelectedRowsCount > 0)
            {
                fnk.texleridoldur(txtmodeladi, gridView1, "MODELNAME");
                fnk.texleridoldur(lblmodeladi, gridView1, "MODELNAME");
                IDSEC = gridView1.GetFocusedRowCellValue("ID").ToString();
                lblID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            }
        }

        public void panel2temizle()
        {
            txtic1.Text = "";
            txtic2.Text = "";
            txtic3.Text = "";
            txtic4.Text = "";
            txtic5.Text = "";
            txtic6.Text = "";
            txtic7.Text = "";
            txtic8.Text = "";
            txtic9.Text = "";
            txtic10.Text = "";
            txtic11.Text = "";
            txtdis1.Text = "";
            txtdis2.Text = "";
            txtdis3.Text = "";
            txtdis4.Text = "";
            txtdis5.Text = "";
            txtdis6.Text = "";
            txtdis7.Text = "";
            txtdis8.Text = "";
            txtdis9.Text = "";
            txtdis10.Text = "";
            txtdis11.Text = "";


        }
        public void panel1temizle()
        {
            lbldis1.Text = "";
            lbldis2.Text = "";
            lbldis3.Text = "";
            lbldis4.Text = "";
            lbldis5.Text = "";
            lbldis6.Text = "";
            lbldis7.Text = "";
            lbldis8.Text = "";
            lbldis9.Text = "";
            lbldis10.Text = "";
            lbldis11.Text = "";
            lblic1.Text = "";
            lblic2.Text = "";
            lblic3.Text = "";
            lblic4.Text = "";
            lblic5.Text = "";
            lblic6.Text = "";
            lblic7.Text = "";
            lblic8.Text = "";
            lblic9.Text = "";
            lblic10.Text = "";
            lblic11.Text = "";
        }

        public string MODELID,ID1, ID2, ID3, ID4, ID5, ID6, ID7, ID8, ID9, ID10, ID11;
        public void calistir()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT DIS,IC,ETAP,ID FROM TBLMODELDETAY WHERE MODELID='" + lblID.Text + "'", _vt.baglan);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            int toplamKayit = datatable.Rows.Count;
            switch (toplamKayit)
            {
                case 1:
                    lbldis1.Text = datatable.Rows[0][0].ToString();

                    lblic1.Text = datatable.Rows[0][1].ToString();

                    lblsira1.Text = datatable.Rows[0][2].ToString();

                    ID1 = datatable.Rows[0][3].ToString();
                    break;
                case 2:
                    lblic1.Text = datatable.Rows[0][1].ToString();
                    lblic2.Text = datatable.Rows[1][1].ToString();

                    lbldis1.Text = datatable.Rows[0][0].ToString();
                    lbldis2.Text = datatable.Rows[1][0].ToString();

                    lblsira1.Text = datatable.Rows[0][2].ToString();
                    lblsira2.Text = datatable.Rows[1][2].ToString();

                    ID1 = datatable.Rows[0][3].ToString();
                    ID2 = datatable.Rows[1][3].ToString();

                    break;
                case 3:
                    lblic1.Text = datatable.Rows[0][1].ToString();
                    lblic2.Text = datatable.Rows[1][1].ToString();
                    lblic3.Text = datatable.Rows[2][1].ToString();

                    lbldis1.Text = datatable.Rows[0][0].ToString();
                    lbldis2.Text = datatable.Rows[1][0].ToString();
                    lbldis3.Text = datatable.Rows[2][0].ToString();

                    lblsira1.Text = datatable.Rows[0][2].ToString();
                    lblsira2.Text = datatable.Rows[1][2].ToString();
                    lblsira3.Text = datatable.Rows[2][2].ToString();

                    ID1 = datatable.Rows[0][3].ToString();
                    ID2 = datatable.Rows[1][3].ToString();
                    ID3 = datatable.Rows[2][3].ToString();

                    break;
                case 4:
                    lblic1.Text = datatable.Rows[0][1].ToString();
                    lblic2.Text = datatable.Rows[1][1].ToString();
                    lblic3.Text = datatable.Rows[2][1].ToString();
                    lblic4.Text = datatable.Rows[3][1].ToString();

                    lbldis1.Text = datatable.Rows[0][0].ToString();
                    lbldis2.Text = datatable.Rows[1][0].ToString();
                    lbldis3.Text = datatable.Rows[2][0].ToString();
                    lbldis4.Text = datatable.Rows[3][0].ToString();

                    lblsira1.Text = datatable.Rows[0][2].ToString();
                    lblsira2.Text = datatable.Rows[1][2].ToString();
                    lblsira3.Text = datatable.Rows[2][2].ToString();
                    lblsira4.Text = datatable.Rows[3][2].ToString();

                    ID1 = datatable.Rows[0][3].ToString();
                    ID2 = datatable.Rows[1][3].ToString();
                    ID3 = datatable.Rows[2][3].ToString();
                    ID4 = datatable.Rows[3][3].ToString();

                    break;
                case 5:
                    lblic1.Text = datatable.Rows[0][1].ToString();
                    lblic2.Text = datatable.Rows[1][1].ToString();
                    lblic3.Text = datatable.Rows[2][1].ToString();
                    lblic4.Text = datatable.Rows[3][1].ToString();
                    lblic5.Text = datatable.Rows[4][1].ToString();

                    lbldis1.Text = datatable.Rows[0][0].ToString();
                    lbldis2.Text = datatable.Rows[1][0].ToString();
                    lbldis3.Text = datatable.Rows[2][0].ToString();
                    lbldis4.Text = datatable.Rows[3][0].ToString();
                    lbldis5.Text = datatable.Rows[4][0].ToString();

                    lblsira1.Text = datatable.Rows[0][2].ToString();
                    lblsira2.Text = datatable.Rows[1][2].ToString();
                    lblsira3.Text = datatable.Rows[2][2].ToString();
                    lblsira4.Text = datatable.Rows[3][2].ToString();
                    lblsira5.Text = datatable.Rows[4][2].ToString();

                    ID1 = datatable.Rows[0][3].ToString();
                    ID2 = datatable.Rows[1][3].ToString();
                    ID3 = datatable.Rows[2][3].ToString();
                    ID4 = datatable.Rows[3][3].ToString();
                    ID5 = datatable.Rows[4][3].ToString();

                    break;
                case 6:
                    lblic1.Text = datatable.Rows[0][1].ToString();
                    lblic2.Text = datatable.Rows[1][1].ToString();
                    lblic3.Text = datatable.Rows[2][1].ToString();
                    lblic4.Text = datatable.Rows[3][1].ToString();
                    lblic5.Text = datatable.Rows[4][1].ToString();
                    lblic6.Text = datatable.Rows[5][1].ToString();

                    lbldis1.Text = datatable.Rows[0][0].ToString();
                    lbldis2.Text = datatable.Rows[1][0].ToString();
                    lbldis3.Text = datatable.Rows[2][0].ToString();
                    lbldis4.Text = datatable.Rows[3][0].ToString();
                    lbldis5.Text = datatable.Rows[4][0].ToString();
                    lbldis6.Text = datatable.Rows[5][0].ToString();

                    lblsira1.Text = datatable.Rows[0][2].ToString();
                    lblsira2.Text = datatable.Rows[1][2].ToString();
                    lblsira3.Text = datatable.Rows[2][2].ToString();
                    lblsira4.Text = datatable.Rows[3][2].ToString();
                    lblsira5.Text = datatable.Rows[4][2].ToString();
                    lblsira6.Text = datatable.Rows[5][2].ToString();

                    ID1 = datatable.Rows[0][3].ToString();
                    ID2 = datatable.Rows[1][3].ToString();
                    ID3 = datatable.Rows[2][3].ToString();
                    ID4 = datatable.Rows[3][3].ToString();
                    ID5 = datatable.Rows[4][3].ToString();
                    ID6 = datatable.Rows[5][3].ToString();

                    break;
                case 7:
                    lblic1.Text = datatable.Rows[0][1].ToString();
                    lblic2.Text = datatable.Rows[1][1].ToString();
                    lblic3.Text = datatable.Rows[2][1].ToString();
                    lblic4.Text = datatable.Rows[3][1].ToString();
                    lblic5.Text = datatable.Rows[4][1].ToString();
                    lblic6.Text = datatable.Rows[5][1].ToString();
                    lblic7.Text = datatable.Rows[6][1].ToString();

                    lbldis1.Text = datatable.Rows[0][0].ToString();
                    lbldis2.Text = datatable.Rows[1][0].ToString();
                    lbldis3.Text = datatable.Rows[2][0].ToString();
                    lbldis4.Text = datatable.Rows[3][0].ToString();
                    lbldis5.Text = datatable.Rows[4][0].ToString();
                    lbldis6.Text = datatable.Rows[5][0].ToString();
                    lbldis7.Text = datatable.Rows[6][0].ToString();

                    lblsira1.Text = datatable.Rows[0][2].ToString();
                    lblsira2.Text = datatable.Rows[1][2].ToString();
                    lblsira3.Text = datatable.Rows[2][2].ToString();
                    lblsira4.Text = datatable.Rows[3][2].ToString();
                    lblsira5.Text = datatable.Rows[4][2].ToString();
                    lblsira6.Text = datatable.Rows[5][2].ToString();
                    lblsira7.Text = datatable.Rows[6][2].ToString();

                    ID1 = datatable.Rows[0][3].ToString();
                    ID2 = datatable.Rows[1][3].ToString();
                    ID3 = datatable.Rows[2][3].ToString();
                    ID4 = datatable.Rows[3][3].ToString();
                    ID5 = datatable.Rows[4][3].ToString();
                    ID6 = datatable.Rows[5][3].ToString();
                    ID7 = datatable.Rows[6][3].ToString();

                    break;
                case 8:
                    lblic1.Text = datatable.Rows[0][1].ToString();
                    lblic2.Text = datatable.Rows[1][1].ToString();
                    lblic3.Text = datatable.Rows[2][1].ToString();
                    lblic4.Text = datatable.Rows[3][1].ToString();
                    lblic5.Text = datatable.Rows[4][1].ToString();
                    lblic6.Text = datatable.Rows[5][1].ToString();
                    lblic7.Text = datatable.Rows[6][1].ToString();
                    lblic8.Text = datatable.Rows[7][1].ToString();

                    lbldis1.Text = datatable.Rows[0][0].ToString();
                    lbldis2.Text = datatable.Rows[1][0].ToString();
                    lbldis3.Text = datatable.Rows[2][0].ToString();
                    lbldis4.Text = datatable.Rows[3][0].ToString();
                    lbldis5.Text = datatable.Rows[4][0].ToString();
                    lbldis6.Text = datatable.Rows[5][0].ToString();
                    lbldis7.Text = datatable.Rows[6][0].ToString();
                    lbldis8.Text = datatable.Rows[7][0].ToString();

                    lblsira1.Text = datatable.Rows[0][2].ToString();
                    lblsira2.Text = datatable.Rows[1][2].ToString();
                    lblsira3.Text = datatable.Rows[2][2].ToString();
                    lblsira4.Text = datatable.Rows[3][2].ToString();
                    lblsira5.Text = datatable.Rows[4][2].ToString();
                    lblsira6.Text = datatable.Rows[5][2].ToString();
                    lblsira7.Text = datatable.Rows[6][2].ToString();
                    lblsira8.Text = datatable.Rows[7][2].ToString();


                    ID1 = datatable.Rows[0][3].ToString();
                    ID2 = datatable.Rows[1][3].ToString();
                    ID3 = datatable.Rows[2][3].ToString();
                    ID4 = datatable.Rows[3][3].ToString();
                    ID5 = datatable.Rows[4][3].ToString();
                    ID6 = datatable.Rows[5][3].ToString();
                    ID7 = datatable.Rows[6][3].ToString();
                    ID8 = datatable.Rows[7][3].ToString();

                    break;
                case 9:
                    lblic1.Text = datatable.Rows[0][1].ToString();
                    lblic2.Text = datatable.Rows[1][1].ToString();
                    lblic3.Text = datatable.Rows[2][1].ToString();
                    lblic4.Text = datatable.Rows[3][1].ToString();
                    lblic5.Text = datatable.Rows[4][1].ToString();
                    lblic6.Text = datatable.Rows[5][1].ToString();
                    lblic7.Text = datatable.Rows[6][1].ToString();
                    lblic8.Text = datatable.Rows[7][1].ToString();
                    lblic9.Text = datatable.Rows[8][1].ToString();

                    lbldis1.Text = datatable.Rows[0][0].ToString();
                    lbldis2.Text = datatable.Rows[1][0].ToString();
                    lbldis3.Text = datatable.Rows[2][0].ToString();
                    lbldis4.Text = datatable.Rows[3][0].ToString();
                    lbldis5.Text = datatable.Rows[4][0].ToString();
                    lbldis6.Text = datatable.Rows[5][0].ToString();
                    lbldis7.Text = datatable.Rows[6][0].ToString();
                    lbldis8.Text = datatable.Rows[7][0].ToString();
                    lbldis9.Text = datatable.Rows[8][0].ToString();

                    lblsira1.Text = datatable.Rows[0][2].ToString();
                    lblsira2.Text = datatable.Rows[1][2].ToString();
                    lblsira3.Text = datatable.Rows[2][2].ToString();
                    lblsira4.Text = datatable.Rows[3][2].ToString();
                    lblsira5.Text = datatable.Rows[4][2].ToString();
                    lblsira6.Text = datatable.Rows[5][2].ToString();
                    lblsira7.Text = datatable.Rows[6][2].ToString();
                    lblsira8.Text = datatable.Rows[7][2].ToString();
                    lblsira9.Text = datatable.Rows[8][2].ToString();

                    ID1 = datatable.Rows[0][3].ToString();
                    ID2 = datatable.Rows[1][3].ToString();
                    ID3 = datatable.Rows[2][3].ToString();
                    ID4 = datatable.Rows[3][3].ToString();
                    ID5 = datatable.Rows[4][3].ToString();
                    ID6 = datatable.Rows[5][3].ToString();
                    ID7 = datatable.Rows[6][3].ToString();
                    ID8 = datatable.Rows[7][3].ToString();
                    ID9 = datatable.Rows[8][3].ToString();

                    break;
                case 10:
                    lblic1.Text = datatable.Rows[0][1].ToString();
                    lblic2.Text = datatable.Rows[1][1].ToString();
                    lblic3.Text = datatable.Rows[2][1].ToString();
                    lblic4.Text = datatable.Rows[3][1].ToString();
                    lblic5.Text = datatable.Rows[4][1].ToString();
                    lblic6.Text = datatable.Rows[5][1].ToString();
                    lblic7.Text = datatable.Rows[6][1].ToString();
                    lblic8.Text = datatable.Rows[7][1].ToString();
                    lblic9.Text = datatable.Rows[8][1].ToString();
                    lblic10.Text = datatable.Rows[9][1].ToString();

                    lbldis1.Text = datatable.Rows[0][0].ToString();
                    lbldis2.Text = datatable.Rows[1][0].ToString();
                    lbldis3.Text = datatable.Rows[2][0].ToString();
                    lbldis4.Text = datatable.Rows[3][0].ToString();
                    lbldis5.Text = datatable.Rows[4][0].ToString();
                    lbldis6.Text = datatable.Rows[5][0].ToString();
                    lbldis7.Text = datatable.Rows[6][0].ToString();
                    lbldis8.Text = datatable.Rows[7][0].ToString();
                    lbldis9.Text = datatable.Rows[8][0].ToString();
                    lbldis10.Text = datatable.Rows[9][0].ToString();

                    lblsira1.Text = datatable.Rows[0][2].ToString();
                    lblsira2.Text = datatable.Rows[1][2].ToString();
                    lblsira3.Text = datatable.Rows[2][2].ToString();
                    lblsira4.Text = datatable.Rows[3][2].ToString();
                    lblsira5.Text = datatable.Rows[4][2].ToString();
                    lblsira6.Text = datatable.Rows[5][2].ToString();
                    lblsira7.Text = datatable.Rows[6][2].ToString();
                    lblsira8.Text = datatable.Rows[7][2].ToString();
                    lblsira9.Text = datatable.Rows[8][2].ToString();
                    lblsira10.Text = datatable.Rows[9][2].ToString();


                    ID1 = datatable.Rows[0][3].ToString();
                    ID2 = datatable.Rows[1][3].ToString();
                    ID3 = datatable.Rows[2][3].ToString();
                    ID4 = datatable.Rows[3][3].ToString();
                    ID5 = datatable.Rows[4][3].ToString();
                    ID6 = datatable.Rows[5][3].ToString();
                    ID7 = datatable.Rows[6][3].ToString();
                    ID8 = datatable.Rows[7][3].ToString();
                    ID9 = datatable.Rows[8][3].ToString();
                    ID10 = datatable.Rows[9][3].ToString();

                    break;


                default:
                    lblic1.Text = datatable.Rows[0][1].ToString();
                    lblic2.Text = datatable.Rows[1][1].ToString();
                    lblic3.Text = datatable.Rows[2][1].ToString();
                    lblic4.Text = datatable.Rows[3][1].ToString();
                    lblic5.Text = datatable.Rows[4][1].ToString();
                    lblic6.Text = datatable.Rows[5][1].ToString();
                    lblic7.Text = datatable.Rows[6][1].ToString();
                    lblic8.Text = datatable.Rows[7][1].ToString();
                    lblic9.Text = datatable.Rows[8][1].ToString();
                    lblic10.Text = datatable.Rows[9][1].ToString();
                    lblic11.Text = datatable.Rows[10][1].ToString();

                    lbldis1.Text = datatable.Rows[0][0].ToString();
                    lbldis2.Text = datatable.Rows[1][0].ToString();
                    lbldis3.Text = datatable.Rows[2][0].ToString();
                    lbldis4.Text = datatable.Rows[3][0].ToString();
                    lbldis5.Text = datatable.Rows[4][0].ToString();
                    lbldis6.Text = datatable.Rows[5][0].ToString();
                    lbldis7.Text = datatable.Rows[6][0].ToString();
                    lbldis8.Text = datatable.Rows[7][0].ToString();
                    lbldis9.Text = datatable.Rows[8][0].ToString();
                    lbldis10.Text = datatable.Rows[9][0].ToString();
                    lbldis11.Text = datatable.Rows[10][0].ToString();

                    lblsira1.Text = datatable.Rows[0][2].ToString();
                    lblsira2.Text = datatable.Rows[1][2].ToString();
                    lblsira3.Text = datatable.Rows[2][2].ToString();
                    lblsira4.Text = datatable.Rows[3][2].ToString();
                    lblsira5.Text = datatable.Rows[4][2].ToString();
                    lblsira6.Text = datatable.Rows[5][2].ToString();
                    lblsira7.Text = datatable.Rows[6][2].ToString();
                    lblsira8.Text = datatable.Rows[7][2].ToString();
                    lblsira9.Text = datatable.Rows[8][2].ToString();
                    lblsira10.Text = datatable.Rows[9][2].ToString();
                    lblsira11.Text = datatable.Rows[10][2].ToString();


                    ID1 = datatable.Rows[0][3].ToString();
                    ID2 = datatable.Rows[1][3].ToString();
                    ID3 = datatable.Rows[2][3].ToString();
                    ID4 = datatable.Rows[3][3].ToString();
                    ID5 = datatable.Rows[4][3].ToString();
                    ID6 = datatable.Rows[5][3].ToString();
                    ID7 = datatable.Rows[6][3].ToString();
                    ID8 = datatable.Rows[7][3].ToString();
                    ID9 = datatable.Rows[8][3].ToString();
                    ID10 = datatable.Rows[9][3].ToString();
                    ID11 = datatable.Rows[10][3].ToString();

                    break;
            }

            diskalipsorgula();
            ickalipsorgula();
            rbduzelt.Checked = true;
        }
        private void lblID_TextChanged(object sender, EventArgs e)
        {

            //calistir();
        }

        private void lbldis1_TextChanged(object sender, EventArgs e)
        {
            txtdis1.Text = lbldis1.Text;
        }

        private void lbldis2_TextChanged(object sender, EventArgs e)
        {
            txtdis2.Text = lbldis2.Text;
        }

        private void lbldis3_TextChanged(object sender, EventArgs e)
        {
            txtdis3.Text = lbldis3.Text;
        }

        private void lbldis4_TextChanged(object sender, EventArgs e)
        {
            txtdis4.Text = lbldis4.Text;
        }

        private void lbldis5_TextChanged(object sender, EventArgs e)
        {
            txtdis5.Text = lbldis5.Text;
        }

        private void lbldis6_TextChanged(object sender, EventArgs e)
        {
            txtdis6.Text = lbldis6.Text;
        }

        private void lbldis7_TextChanged(object sender, EventArgs e)
        {
            txtdis7.Text = lbldis7.Text;
        }

        private void lbldis8_TextChanged(object sender, EventArgs e)
        {
            txtdis8.Text = lbldis8.Text;
        }

        private void lbldis9_TextChanged(object sender, EventArgs e)
        {
            txtdis9.Text = lbldis9.Text;
        }

        private void lbldis10_TextChanged(object sender, EventArgs e)
        {
            txtdis10.Text = lbldis10.Text;
        }

        private void lbldis11_TextChanged(object sender, EventArgs e)
        {
            txtdis11.Text = lbldis11.Text;
        }

        private void lblic1_TextChanged(object sender, EventArgs e)
        {
            txtic1.Text = lblic1.Text;
        }

        private void lblic2_TextChanged(object sender, EventArgs e)
        {
            txtic2.Text = lblic2.Text;
        }

        private void lblic3_TextChanged(object sender, EventArgs e)
        {
            txtic3.Text = lblic3.Text;
        }

        private void lblic4_TextChanged(object sender, EventArgs e)
        {
            txtic4.Text = lblic4.Text;
        }

        private void lblic5_TextChanged(object sender, EventArgs e)
        {
            txtic5.Text = lblic5.Text;
        }

        private void lblic6_TextChanged(object sender, EventArgs e)
        {
            txtic6.Text = lblic6.Text;
        }

        private void lblic7_TextChanged(object sender, EventArgs e)
        {
            txtic7.Text = lblic7.Text;
        }

        private void lblic8_TextChanged(object sender, EventArgs e)
        {
            txtic8.Text = lblic8.Text;
        }

        private void lblic9_TextChanged(object sender, EventArgs e)
        {
            txtic9.Text = lblic9.Text;
        }

        private void lblic10_TextChanged(object sender, EventArgs e)
        {
            txtic10.Text = lblic10.Text;
        }

        private void lblic11_TextChanged(object sender, EventArgs e)
        {
            txtic11.Text = lblic11.Text;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            //    if (IDSEC == "" || lblID.Text == "")
            //    {
            //        MessageBox.Show("Güncelleme yapabilmek için model seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            //    }
            //    else
            //    {
            //        try
            //        {


            //            SqlCommand guncelle = new SqlCommand("UPDATE TBLMODELDETAY SET ID,MODELID,DIS,IC WHERE ID=@ID AND MODELID=@MODELID", _vt.baglan);
            //            guncelle.Parameters.AddWithValue("@ID", MODELDETAYID);
            //            guncelle.Parameters.AddWithValue("@MODELID", IDSEC);
            //            if (label1.Text == "1")
            //            {
            //                guncelle.Parameters.AddWithValue("@P3", label1.Text);
            //                guncelle.Parameters.AddWithValue("@P4", label1.Text);
            //                guncelle.Parameters.AddWithValue("@P5", label1.Text);
            //            }
            //            else
            //            {
            //                guncelle.Parameters.AddWithValue("@P3", label1.Text);
            //                guncelle.Parameters.AddWithValue("@P4", label2.Text);
            //                guncelle.Parameters.AddWithValue("@P5", label3.Text);
            //            }

            //            guncelle.Parameters.AddWithValue("@ID", IDSEC);
            //            _vt.baglan.Open();
            //            guncelle.ExecuteNonQuery();
            //            _vt.baglan.Close();
            //            veriler();
            //            temizle();
            //            MessageBox.Show("Muvaffaqiyatli Yangilash Uchun Qilingan", "Yangilanish Muvaffaqiyatli", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        }
            //        catch (Exception hata)
            //        {
            //            MessageBox.Show(hata.Message, "Userni yangilab bo'lmadi !", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            //        }

            //    }
        }

        private void lblsira8_Click(object sender, EventArgs e)
        {

        }

        private void lblsira1_TextChanged(object sender, EventArgs e)
        {
            lblsiram1.Text = lblsira1.Text;
        }
        public void textlerikapat()
        {
            txtdis1.Enabled = false;
            txtdis2.Enabled = false;
            txtdis3.Enabled = false;
            txtdis4.Enabled = false;
            txtdis5.Enabled = false;
            txtdis6.Enabled = false;
            txtdis7.Enabled = false;
            txtdis8.Enabled = false;
            txtdis9.Enabled = false;
            txtdis10.Enabled = false;
            txtdis11.Enabled = false;

            txtic1.Enabled = false;
            txtic2.Enabled = false;
            txtic3.Enabled = false;
            txtic4.Enabled = false;
            txtic5.Enabled = false;
            txtic6.Enabled = false;
            txtic7.Enabled = false;
            txtic8.Enabled = false;
            txtic9.Enabled = false;
            txtic10.Enabled = false;
            txtic11.Enabled = false;
        }
        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            textlerikapat();
            txtdis1.Enabled = true;
            txtic1.Enabled = true;
            MODELID = "";
            MODELID = ID1;
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            textlerikapat();
            txtdis2.Enabled = true;
            txtic2.Enabled = true;
            MODELID = "";
            MODELID = ID2;
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            textlerikapat();
            txtdis3.Enabled = true;
            txtic3.Enabled = true;
            MODELID = "";
            MODELID = ID3;
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            textlerikapat();
            txtdis4.Enabled = true;
            txtic4.Enabled = true;
            MODELID = "";
            MODELID = ID4;
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            textlerikapat();
            txtdis5.Enabled = true;
            txtic5.Enabled = true;
            MODELID = "";
            MODELID = ID5;
        }

        private void rb6_CheckedChanged(object sender, EventArgs e)
        {
            textlerikapat();
            txtdis6.Enabled = true;
            txtic6.Enabled = true;
            MODELID = "";
            MODELID = ID6;
        }

        private void rb7_CheckedChanged(object sender, EventArgs e)
        {
            textlerikapat();
            txtdis7.Enabled = true;
            txtic7.Enabled = true;
            MODELID = "";
            MODELID = ID7;
        }

        private void rb8_CheckedChanged(object sender, EventArgs e)
        {
            textlerikapat();
            txtdis8.Enabled = true;
            txtic8.Enabled = true;
            MODELID = "";
            MODELID = ID8;
        }

        private void rb9_CheckedChanged(object sender, EventArgs e)
        {
            textlerikapat();
            txtdis9.Enabled = true;
            txtic9.Enabled = true;
            MODELID = "";
            MODELID = ID9;
        }

        private void rb10_CheckedChanged(object sender, EventArgs e)
        {
            textlerikapat();
            txtdis10.Enabled = true;
            txtic10.Enabled = true;
            MODELID = "";
            MODELID = ID10;
        }

        private void rb11_CheckedChanged(object sender, EventArgs e)
        {
            textlerikapat();
            txtdis11.Enabled = true;
            txtic11.Enabled = true;
            MODELID = "";
            MODELID = ID11;
        }

        private void txtdis1_TextChanged(object sender, EventArgs e)
        {
            rb1.Enabled = true;
        }

        private void txtdis2_TextChanged(object sender, EventArgs e)
        {
            rb2.Enabled = true;

        }

        private void txtdis3_TextChanged(object sender, EventArgs e)
        {
            rb3.Enabled = true;

        }

        private void txtdis4_TextChanged(object sender, EventArgs e)
        {
            rb4.Enabled = true;

        }

        private void txtdis5_TextChanged(object sender, EventArgs e)
        {
            rb5.Enabled = true;

        }

        private void txtdis6_TextChanged(object sender, EventArgs e)
        {
            rb6.Enabled = true;

        }

        private void txtdis7_TextChanged(object sender, EventArgs e)
        {
            rb7.Enabled = true;

        }

        private void txtdis8_TextChanged(object sender, EventArgs e)
        {
            rb8.Enabled = true;

        }

        private void txtdis9_TextChanged(object sender, EventArgs e)
        {
            rb9.Enabled = true;

        }

        private void txtdis10_TextChanged(object sender, EventArgs e)
        {
            rb10.Enabled = true;

        }

        private void txtdis11_TextChanged(object sender, EventArgs e)
        {
            rb11.Enabled = true;

        }

        private void btnyenimodel_Click(object sender, EventArgs e)
        {
            //Kaydet kodları gelecek
        }

      


        private void rbduzelt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbduzelt.Checked == true)
            {
                //IDSEC = "";
                //IDTEMIZLE();
                panel2.Enabled = true;
                textlerikapat();
                panel2temizle();
                txtmodeladi.Text = "";
                txtmodeladi.Enabled = false;
                panel1.Enabled = true;
                btnsil.Enabled = true;
                gridControl1.Enabled = true;
                Rbkapat();
                btnguncelle.Enabled = true;
                btnyenimodel.Enabled = false;
                lblID.Text = "";
                
            }
         
        }

        private void rbsecim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbsecim.Checked == true)
            {
                gridControl1.Enabled = true;
                paneltemizle();
                panel2temizle();
                IDTEMIZLE();
                IDSEC = "";
                lblID.Text = "";
                Rbkapat();
                panel1temizle();
                btnsil.Enabled = true;
                textlerikapat();
                
            }
        }

        private void rbyeni_CheckedChanged(object sender, EventArgs e)
        {
            if (rbyeni.Checked == true)
            {
                Rbkapat();
                textleriac();
                panel2temizle();
                panel1temizle();
                Rbkapat();
                IDTEMIZLE();
                paneltemizle();
                btnsil.Enabled = false;
                panel1.Enabled = false;
                lblmodeladi.Text = "";
                IDSEC = "";
                gridControl1.Enabled = false;
                txtmodeladi.Text = "";
                btnyenimodel.Enabled = true;
                btnguncelle.Enabled = false;
                txtmodeladi.Enabled = true;

            }
            //else if (rbyeni.Checked == false)
            //{
            //    textlerikapat();
            //    txtmodeladi.Enabled = false;
            //    btnyenimodel.Enabled = false;
            //}
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            _vt.baglan.Close();
            if (gridView1.SelectedRowsCount > 0)
            {
                fnk.texleridoldur(txtmodeladi, gridView1, "MODELNAME");
                fnk.texleridoldur(lblmodeladi, gridView1, "MODELNAME");
                IDSEC = gridView1.GetFocusedRowCellValue("ID").ToString();
                lblID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                calistir();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void lblsira2_TextChanged(object sender, EventArgs e)
        {
            lblsiram2.Text = lblsira2.Text;
        }

        private void lblsira3_TextChanged(object sender, EventArgs e)
        {
            lblsiram3.Text = lblsira3.Text;
        }

        private void lblsira4_TextChanged(object sender, EventArgs e)
        {
            lblsiram4.Text = lblsira4.Text;
        }

        private void lblsira5_TextChanged(object sender, EventArgs e)
        {
            lblsiram5.Text = lblsira5.Text;
        }

        private void lblsira6_TextChanged(object sender, EventArgs e)
        {
            lblsiram6.Text = lblsira6.Text;
        }

        private void lblsira7_TextChanged(object sender, EventArgs e)
        {
            lblsiram7.Text = lblsira7.Text;
        }

        private void lblsira8_TextChanged(object sender, EventArgs e)
        {
            lblsiram8.Text = lblsira8.Text;
        }

        private void lblsira9_TextChanged(object sender, EventArgs e)
        {
            lblsiram9.Text = lblsira9.Text;
        }

        private void lblsira10_TextChanged(object sender, EventArgs e)
        {
            lblsiram10.Text = lblsira10.Text;
        }

        private void lblsira11_TextChanged(object sender, EventArgs e)
        {
            lblsiram11.Text = lblsira11.Text;
        }

        private void lblsiram1_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}

      




         





