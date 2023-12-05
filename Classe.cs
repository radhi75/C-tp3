using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Classe
    {
        public string NomClasse {  get; set; }
        public Etudiant[] Etudiants { get; set; }
        public Module[] Modules { get; set; }
        public double[] MoyenGenerals { get; set; }
    
        public Classe(int ne,string Nom,int nm) {
            NomClasse = Nom;

            Etudiants = new Etudiant[ne];

            Modules=new Module[nm];

            MoyenGenerals=new double[ne];

        }
        public void Ajouteretudiants(Etudiant etudiant, int index)
        {
            Etudiants[index] = etudiant;
        }
        public void AjouterModules(Module module, int index)
        {
            Modules[index] = module;
        }
        public void CalculerMoyenGenerals()
        {
            float sc = 0;
           
            for(int i = 0;i<Modules.Length;i++)
            {
                sc += Modules[i].CModule;
            }
            for(int i = 0; i < Etudiants.Length; i++)
            {
                MoyenGenerals[i] = MoyenGeneral(Etudiants[i],sc);
            }
        }
        public double MoyenGeneral(Etudiant etudiant,double sc)
        {
            double s = 0;
            for(int i = 0;i< etudiant.MoyenModule.Length; i++)
            {
                s += etudiant.MoyenModule[i] * Modules[i].CModule;
            }
            return s/sc;   
        }

        public string ToString()
        { string ch="les moyennes  general sont\n";
            for(int i = 0;i<MoyenGenerals.Length;i++)
            {
                ch += Etudiants[i].NomEtudiant+":"+ MoyenGenerals[i] + "\n";
            }
            return ch;
        }

    }
}
