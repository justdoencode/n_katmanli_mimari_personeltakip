using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity_layer;
using System.Data.SqlClient;
using System.Data;

namespace dataaccesslayer
{
    public class DALPersonel
    {
        public static List<entitypersonel> personellistesi()
        {
            List<entitypersonel> degerler = new List<entitypersonel>();
            SqlCommand cmd = new SqlCommand("select * from tbl_personel", baglanti.bag);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                entitypersonel ent = new entitypersonel();
                ent.Id = int.Parse(dr[0].ToString());
                ent.Ad = dr[1].ToString();
                ent.Soyad = dr[2].ToString();
                ent.Sehir = dr[3].ToString();
                ent.Gorev = dr[4].ToString();
                ent.Maas = short.Parse(dr[5].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        
        
        public static int personelekle(entitypersonel p)
        {
            SqlCommand cmd2 = new SqlCommand("insert into tbl_personel (personel_ad,personel_soyad,personel_sehir,personel_gorev,personel_maas) values (@ad,@soyad,@sehir,@gorev,@maas)", baglanti.bag);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            cmd2.Parameters.AddWithValue("@ad", p.Ad);
            cmd2.Parameters.AddWithValue("@soyad", p.Soyad);
            cmd2.Parameters.AddWithValue("@sehir", p.Sehir);
            cmd2.Parameters.AddWithValue("@gorev", p.Gorev);
            cmd2.Parameters.AddWithValue("@maas", p.Maas);
            return cmd2.ExecuteNonQuery();
        }
        public static bool personelsil(int p)
        {
            SqlCommand cmd3 = new SqlCommand("delete from tbl_personel where personel_id=@id", baglanti.bag);
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            cmd3.Parameters.AddWithValue("@id", p);
            return cmd3.ExecuteNonQuery() > 0;
        }
        public static bool personelguncelle(entitypersonel ent)
        {
            SqlCommand cmd4 = new SqlCommand("update tbl_personel set personel_ad=@ad,personel_soyad=@soyad,personel_sehir=@sehir,personel_gorev=@gorev,personel_maas=@maas where personel_id=@id", baglanti.bag);
            if (cmd4.Connection.State != ConnectionState.Open)
                cmd4.Connection.Open();
            cmd4.Parameters.AddWithValue("@ad", ent.Ad);
            cmd4.Parameters.AddWithValue("@soyad", ent.Soyad);
            cmd4.Parameters.AddWithValue("@sehir", ent.Sehir);
            cmd4.Parameters.AddWithValue("@gorev", ent.Gorev);
            cmd4.Parameters.AddWithValue("@maas", ent.Maas);
            cmd4.Parameters.AddWithValue("@id", ent.Id);
            return cmd4.ExecuteNonQuery() > 0;
        }
    }
}
