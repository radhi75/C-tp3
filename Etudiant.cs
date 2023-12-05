using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp5
{
    internal class Etudiant
    {
        public string NomEtudiant { get; set; }
        public float[] NoteDs { get; set; }
        public float[] NoteDc { get; set; }
        public double[] MoyenModule { get; set; }

        public Etudiant( string Nom,int NombreModules) {
            NomEtudiant = Nom;
            NoteDc= new float[NombreModules];
            NoteDs = new float[NombreModules];
            MoyenModule=new double[NombreModules];
        }
        public void CalculerMoyenneModule()
        {
            for(int i = 0; i < NoteDs.Length; i++)
            {
                MoyenModule[i]= (NoteDs[i] * 2 + NoteDc[i])/3.0;
            }
        }
        public string ToString()
        {
            int i;
            string ch = "DS:[";
            for(i = 0;i < NoteDs.Length-1;i++)
            {
                ch += NoteDs[i].ToString() + ",";
            }
            ch += NoteDs[i].ToString();
            ch += "]\nDC:[";
            for(i = 0; i < NoteDs.Length-1; i++)
            {
                ch += NoteDc[i].ToString() + ",";
            }
            ch += NoteDc[i].ToString();
            ch += "]\nMoyenne :[";
            for (i = 0; i < NoteDs.Length-1; i++)
            {
                ch += MoyenModule[i].ToString() + ",";
            }
            ch += MoyenModule[i].ToString();
            ch += "]";
            return ch;
        }
    }
}
