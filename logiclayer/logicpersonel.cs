using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dataaccesslayer;
using entity_layer;

namespace logiclayer
{
    public class logicpersonel
    {
        public static List<entitypersonel> llpersonellistesi()
        {
            return DALPersonel.personellistesi();
        }
        public static int llpersonelekle(entitypersonel p)
        {
            if(p.Ad!=""&&p.Soyad!=""&&p.Maas>=3500&&p.Ad.Length>=3)
            {
                return DALPersonel.personelekle(p);
            }
            else
            {
                return -1;
            }
        }
        public static bool llpersonelsil(int per)
        {
            if (per >= 1)
            {
                return DALPersonel.personelsil(per);
            }
            else
            {
                return false;
            }
        }
        public static bool llpersonelguncelle(entitypersonel ent)
        {
            if (ent.Ad.Length >= 3 && ent.Ad != "" && ent.Maas >= 4500)
                return DALPersonel.personelguncelle(ent);
            else
                return false;
        }
    }
}
