using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
namespace QOLWO
{
    public partial class FrmBaglanti : Form
    {
        public FrmBaglanti()
        {
            InitializeComponent();
        }

        private void FrmBaglanti_Load(object sender, EventArgs e)
        {
            txtipadres.Text = Ayarlar.Default.server.ToString();
            txtkullaniciadi.Text = Ayarlar.Default.kullaniciadi.ToString();
            txtsifre.Text = Ayarlar.Default.sifre.ToString();
            txtdatabese.Text = Ayarlar.Default.database.ToString();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(FrmYukleniyor));
            SplashScreenManager.Default.SetWaitFormCaption("Lütfen Bekle...");
            SplashScreenManager.Default.SetWaitFormDescription("Veri kaydediliyor Bağlantı kuruluyor...");
            // System.Threading.Thread.Sleep(3000);
            SplashScreenManager.Default.SendCommand(FrmYukleniyor.WaitFormCommand.SetProgressBarVisible, true);
            SplashScreenManager.Default.SendCommand(FrmYukleniyor.WaitFormCommand.SetProgressBarMaximum, 5);
            Ayarlar.Default.server = txtipadres.Text;
            Ayarlar.Default.kullaniciadi = txtkullaniciadi.Text;
            Ayarlar.Default.sifre = txtsifre.Text;
            Ayarlar.Default.database = txtdatabese.Text;
            Ayarlar.Default.Save();
            SplashScreenManager.Default.SendCommand(FrmYukleniyor.WaitFormCommand.SetProgressBarPosition, 1);
            VeritabaniBaglantisi baglanti = new VeritabaniBaglantisi();
            SplashScreenManager.Default.SendCommand(FrmYukleniyor.WaitFormCommand.SetProgressBarPosition, 2);
            //try
            //{
                baglanti.baglan.Open();
                SplashScreenManager.Default.SendCommand(FrmYukleniyor.WaitFormCommand.SetProgressBarPosition, 3);
                MessageBox.Show("Veritabanına başarılı bir şekilde bağlantı yapıldı. Program kapatılıyor yeniden giriş yapın.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SplashScreenManager.Default.SendCommand(FrmYukleniyor.WaitFormCommand.SetProgressBarPosition, 4);
                baglanti.baglan.Close();
                SplashScreenManager.Default.SendCommand(FrmYukleniyor.WaitFormCommand.SetProgressBarPosition, 5);
                System.Threading.Thread.Sleep(15);
                SplashScreenManager.CloseForm();
                Application.Exit();
            //}
            //catch (Exception)
            //{
            //    SplashScreenManager.Default.SendCommand(FrmYukleniyor.WaitFormCommand.SetProgressBarPosition, 5);
            //    SplashScreenManager.CloseForm();
            //    MessageBox.Show("Veritabanı Bilgileri Geçersiz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            //}
        }

        private void lblkullaniciadi_Click(object sender, EventArgs e)
        {

        }
    }
}
