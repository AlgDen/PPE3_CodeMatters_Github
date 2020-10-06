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


        private static CodeMattersDBEntities maConnexion;

        public static Visiteur VisiteurConnecte { get => visiteurConnecte; set => visiteurConnecte = value; }
        public static bool ConnexionValide { get => connexionValide; set => connexionValide = value; }

        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new CodeMattersDBEntities();
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


        public static string validConnexion(string id, string mp)
        {
            string message = "";
            // Ecrire le code qui renvoie le message à afficher et mets à jour les variables visiteurConnecte et connexionValide, la comparaison des mots de passes se fera via visiteurConnecte.passwd.Substring(2).Equals(GetMd5Hash(mp))
            return message;
        }

        public static List<Visiteur> listeVisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }



    }
}
