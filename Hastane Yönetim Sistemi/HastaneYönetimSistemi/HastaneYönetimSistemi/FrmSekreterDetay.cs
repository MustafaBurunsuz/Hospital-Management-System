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
namespace HastaneYönetimSistemi
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TcNumara;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TcNumara;

            ////AD sOYAD
            ///
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From TBL_SEKRETERLER Where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            ///Branşları aktarma
            ///
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_BRANSLAR", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;


            ////DOKTORLARI LİSTELEME
            ///
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd +' '+ DoktorSoyad) as Doktorlarlar,DoktorBrans from TBL_DOKTORLAR", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            ////////////Bramşı comboboca aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From TBL_BRANSLAR", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);


            }bgl.baglanti().Close();
         
      
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into TBL_RANDEVULAR (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values(@r1,@r2,@r3,@r4)",bgl.baglanti());

            komutkaydet.Parameters.AddWithValue("@r1", MskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", CmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", CmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from TBL_DOKTORLAR Where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbDoktor.Items.Add(dr[0] + " " + dr[1]);

            }bgl.baglanti().Close();
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_DUYURULAR (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", RchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("DUYURU OLUŞTURULDU");
        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli dr = new FrmDoktorPaneli();
            dr.Show();
        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBrans frb = new FrmBrans();
            frb.Show();
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frl = new FrmRandevuListesi();
            frl.Show();
        }

        private void BtnDuyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }
    }
}
