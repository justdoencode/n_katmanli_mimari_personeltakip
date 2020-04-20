using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entity_layer;
using logiclayer;
using dataaccesslayer;

namespace n_katmanli_mimari_personeltakip
{
    public partial class frm_anasayfa : Form
    {
        public frm_anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<entitypersonel> perlist = DALPersonel.personellistesi();
            dataGridView1.DataSource = perlist;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            entitypersonel ent = new entitypersonel();
            ent.Ad = txt_ad.Text;
            ent.Soyad = txt_soyad.Text;
            ent.Sehir = txt_sehir.Text;
            ent.Gorev = txt_gorev.Text;
            ent.Maas = short.Parse(txt_maas.Text);
            logicpersonel.llpersonelekle(ent);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            entitypersonel ent = new entitypersonel();
            ent.Id = int.Parse(txt_id.Text);
            logicpersonel.llpersonelsil(ent.Id);
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            entitypersonel ent = new entitypersonel();
            ent.Id = int.Parse(txt_id.Text);
            ent.Ad = txt_ad.Text;
            ent.Soyad = txt_soyad.Text;
            ent.Sehir = txt_sehir.Text;
            ent.Gorev = txt_gorev.Text;
            ent.Maas = short.Parse(txt_maas.Text);
            logicpersonel.llpersonelguncelle(ent);
        }
    }
}
