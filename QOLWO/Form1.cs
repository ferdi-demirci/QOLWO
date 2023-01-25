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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VeritabaniBaglantisi _vt = new VeritabaniBaglantisi();
        public static string veri;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Ayarlar.Default.durum == "BETA Versiyonu")
            {
                if (Ayarlar.Default.kalan <= 0)
                {
                    btngiris.Enabled = false;
                    txtuser.Enabled = false;
                    txtpass.Enabled = false;

                }
                MessageBox.Show( "Beta Sürümde " + Ayarlar.Default.kalan.ToString() + " Hakkınız Kaldı.");
            }
            else
            {
                btnaktif.Visible = false;
            }

            _vt.baglan.Close();
        }

        private void btnaktif_Click(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sorgula = new SqlCommand("SELECT USERNAME,PASS FROM TBLUSERS WHERE USERNAME='" + txtuser.Text.ToString() + "'AND PASS='" + txtpass.Text.ToString() + "'", _vt.baglan);
                _vt.baglan.Open();
                SqlDataReader varmi = sorgula.ExecuteReader();
                if (varmi.Read())
                {
                    
                    Ayarlar.Default.kalan--;
                    Ayarlar.Default.Save();
                    varmi.Close();
                    _vt.baglan.Close();
                    veri = txtuser.Text;
                    FrmMain ac = new FrmMain();
                    ac.lblkullaniciadi.Text = txtuser.Text;
                    ac.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Oturum Açılmadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtuser.Text = "";
                    txtpass.Text = "";
                    _vt.baglan.Close();
                }


            }
            catch (Exception hata)
            {

                MessageBox.Show("Veritabanı Bağlantısı Bulunamadı. Sizi Bağlantı İçin Yönlendiriyoruz. " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                FrmBaglanti ac = new FrmBaglanti();
                ac.Show();
         
            }
        }

        private void btnbaglanti_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBaglanti ac = new FrmBaglanti();
            ac.Show();
           
        }

        private void btncikis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
