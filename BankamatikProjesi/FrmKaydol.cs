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

namespace BankamatikProjesi
{
    public partial class FrmKaydol : Form
    {
        public FrmKaydol()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BOV3B8B\SQLEXPRESS;Initial Catalog=BankamatikProjesi;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into TblKisiler (ad,soyad,tc,telefon,sifre,hesapno) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn);
                cmd.Parameters.AddWithValue("@p1", txtAd.Text);
                cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@p3", mskTC.Text);
                cmd.Parameters.AddWithValue("@p4", mskTelefon.Text);
                cmd.Parameters.AddWithValue("@p5", txtSifre.Text);
                cmd.Parameters.AddWithValue("@p6", mskHesap.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("insert into TblHesap (hesapno) values (@p1)", conn);
                cmd2.Parameters.AddWithValue("@p1", mskHesap.Text);
                cmd2.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Hesabınız başarıyla oluşturuldu!");
                FrmAnaSayfa frm=new FrmAnaSayfa();
                frm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Kaydolma işlemi başarısız! Lütfen geçerli değerler giriniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int hesapno = random.Next(100000, 1000000);
            mskHesap.Text = hesapno.ToString();
        }
    }
}
