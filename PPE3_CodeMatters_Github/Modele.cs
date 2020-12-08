using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_CodeMatters_Github
{
    public static class Modele
    {
        public static void init()
        {
            maConnexion = new CodeMattersDBEntities();
        }
        private static CodeMattersDBEntities maConnexion;

        public static List<fichefrais> listefichefrais()
        {
            return maConnexion.fichefrais.ToList();
        }
        
        public static List<Visiteur> listeVisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }
        public static List<LigneFraisForfait> listelignefraisforfait()
        {
            List < LigneFraisForfait > vretour=new List<LigneFraisForfait>();
            vretour= maConnexion.LigneFraisForfait.ToList();
            return vretour;
        }

        public static List<FraisForfait> listefraisforfait()
        {
            List<FraisForfait> vretour = new List<FraisForfait>();
            vretour = maConnexion.FraisForfait.ToList();
            return vretour;
            //return maConnexion.FraisForfait.ToList();
        }

        public static FraisForfait recherchefraisforfait(string vid)
        {
            var LQuery = maConnexion.FraisForfait.ToList()
                .Where(x => x.id == vid);
            return LQuery.ToList()[0];
        }

        public static Object recherchefraiskilometrique()
        {
            var LQuery = maConnexion.FraisForfait.ToList()

                .Where(x => x.deplacement == true);

            return LQuery.ToList();
        }
        
    }
}


    
