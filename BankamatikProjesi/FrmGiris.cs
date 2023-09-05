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
    public partial class FmGiris : Form
    {
        public FmGiris()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BOV3B8B\SQLEXPRESS;Initial Catalog=BankamatikProjesi;Integrated Security=True");

        private void linkKaydol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKaydol frm = new FrmKaydol();
            frm.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from TblKisiler where hesapno=@p1 and sifre=@p2", conn);
                cmd.Parameters.AddWithValue("@p1", mskHesapNo.Text);
                cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    FrmAnaSayfa frm = new FrmAnaSayfa();
                    frm.hesapno = mskHesapNo.Text;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş yapma işlemi başarısız! Lütfen girdiğiniz değerleri kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Giriş yapma işlemi başarısız! Lütfen girdiğiniz değerleri kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
