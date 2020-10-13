using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PPE3_CodeMatters_Github
{
    public static class Modele
    {
        private static Visiteur visiteurConnecte;
        private static bool connexionValide;
        public static string identite;


        private static CodeMattersDBEntities maConnexion;

        public static Visiteur VisiteurConnecte { get => visiteurConnecte; set => visiteurConnecte = value; }
        public static bool ConnexionValide { get => connexionValide; set => connexionValide = value; }
        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new CodeMattersDBEntities();
        }

        public static void Connexion(string id, string mdp)
        {
            Visiteur vi = ListeID(id);
            if (vi != null)
            {
                if(GetMd5Hash(mdp)==vi.password)
                {
                    connexionValide = true;
                }
            }
        }

        public static Visiteur ListeID(string id)
        {
            identite = id;
            Visiteur vretour = null;
            var LQuery = listeVisiteur()
                .Where(x => x.identifiant == id);
            if(LQuery.ToList().Count==1)
            {
                vretour = (Visiteur)LQuery.ToList()[0];
            }
            return vretour;
        }

        public static bool validConnexion()
        {
            return connexionValide;
        }

        private static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public static List<Visiteur> listeVisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }



    }
}
