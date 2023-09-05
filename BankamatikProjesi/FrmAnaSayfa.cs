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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        public string hesapno;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BOV3B8B\SQLEXPRESS;Initial Catalog=BankamatikProjesi;Integrated Security=True");

        void gonderme()
        {
            SqlDataAdapter da = new SqlDataAdapter("select TblHareketler.id, alici=ad+' '+soyad, tutar from TblHareketler inner join TblKisiler on TblHareketler.alici=TblKisiler.hesapno where gonderen=" + hesapno + "", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void alma()
        {
            SqlDataAdapter da = new SqlDataAdapter("select TblHareketler.id, gonderen=ad+' '+soyad, tutar from TblHareketler inner join TblKisiler on TblHareketler.gonderen=TblKisiler.hesapno where alici=" + hesapno + "", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            try
            {
                lblHesapNo.Text = hesapno;
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from TblKisiler where hesapno=@p1", conn);
                cmd.Parameters.AddWithValue("@p1", hesapno);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblAdSoyad.Text = dr[1] + " " + dr[2];
                    lblTc.Text = dr[3].ToString();
                    lblTelefon.Text = dr[4].ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("select * from TblHesap where hesapno=@p1", conn);
                cmd2.Parameters.AddWithValue("@p1", hesapno);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    lblBakiye.Text = dr2[1]+" TL";
                }
                conn.Close();

                gonderme();
                alma();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                //Alıcı bakiyesini güncelleme
                conn.Open();
                SqlCommand cmd = new SqlCommand("update tblhesap set bakiye=bakiye+@p1 where hesapno=@p2", conn);
                cmd.Parameters.AddWithValue("@p1", decimal.Parse(txtTutar.Text));
                cmd.Parameters.AddWithValue("@p2", mskHesapNo.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Havale işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Gönderen bakiyesini güncelleme
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("update tblhesap set bakiye=bakiye-@p1 where hesapno=@p2", conn);
                cmd2.Parameters.AddWithValue("@p1", decimal.Parse(txtTutar.Text));
                cmd2.Parameters.AddWithValue("@p2", lblHesapNo.Text);
                cmd2.ExecuteNonQuery();
                conn.Close();

                //Hareketler tablosunu güncelleme
                conn.Open();
                SqlCommand cmd3 = new SqlCommand("insert into tblhareketler (gonderen,alici,tutar) values (@p1,@p2,@p3)", conn);
                cmd3.Parameters.AddWithValue("@p1",lblHesapNo.Text);
                cmd3.Parameters.AddWithValue("@p2", mskHesapNo.Text);
                cmd3.Parameters.AddWithValue("@p3", txtTutar.Text);
                cmd3.ExecuteNonQuery();
                conn.Close();

                alma();
                gonderme();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
