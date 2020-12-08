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
            VisiteurConnecte = ListeID(id);
            if (VisiteurConnecte != null)
            {
                if(GetMd5Hash(mdp)==VisiteurConnecte.password)
                {
                    connexionValide = true;
                }
            }
        }

        public static Visiteur ViConnecte()
        {
            return VisiteurConnecte;
        }

        public static bool ModifVisiteur(string nom, string prenom, string rue, string cp, string ville, string dateEmbauche)
        {
            bool vretour = true;
            try
            {
                VisiteurConnecte.nom = nom;
                VisiteurConnecte.prenom = prenom;
                VisiteurConnecte.rue = rue;
                VisiteurConnecte.cp = cp;
                VisiteurConnecte.ville = ville;
                VisiteurConnecte.dateEmbauche = dateEmbauche;
                maConnexion.SaveChanges();
            }
            catch (Exception e)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool ModifMDP(string mdp)
        {
            bool vretour = true;
            try
            {
                mdp = GetMd5Hash(mdp);
                VisiteurConnecte.password = mdp;
                maConnexion.SaveChanges();
            }
            catch(Exception e)
            {
                vretour = false;
            }
            return vretour;
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

        public static Visiteur VisiteurParID(int id)
        {
            Visiteur v = maConnexion.Visiteur.Find(id);
            return v;
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
       
        public static List<Region> listeRegion()
        {
            return maConnexion.Region.ToList();
        }


    }
}
