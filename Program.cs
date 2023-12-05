namespace ConsoleApp5
{
    internal class Program
    {
        static void RemplireTab(float[] T,int nm)
        {
            for(int i = 0; i < nm; i++)
            {
                string note;
                Console.WriteLine("T[" + i + "]=");
                note = Console.ReadLine();
                T[i]=float.Parse(note);
            }
        }
        static void AjouterModules(Classe c1,int nm)
        {
            string nommodule;
            float cmodule;
            for(int i = 0;i < nm;i++)
            {
                Console.WriteLine("donner le nom de module " + i);
                nommodule = Console.ReadLine();
                Console.WriteLine("donner le coef de module " + i);
                cmodule = float.Parse(Console.ReadLine());
                Module m1 = new Module(nommodule, cmodule);
                c1.AjouterModules(m1, i);
            }
        }
        static void AjouterEtudiants(Classe c1,int ne,int nm)
        {
            string nom;
            for (int i = 0;i < ne;i++)
            {
                Console.WriteLine("donner le nom d'etudiant "+i);
                nom= Console.ReadLine();
                Etudiant e1 = new Etudiant(nom,nm);
                Console.WriteLine("Donner le note de dc "+i);
                RemplireTab(e1.NoteDc,nm);
                Console.WriteLine("Donner le note de ds " + i);
                RemplireTab(e1.NoteDs, nm);
                e1.CalculerMoyenneModule();
                c1.Ajouteretudiants(e1, i);
            }
        }
        static void Main(string[] args)
        {
            string note;
            Console.WriteLine("nbr module =");
            note = Console.ReadLine();
            int nm=int.Parse(note);
            Console.WriteLine("donner nbr etudiants");
            note=Console.ReadLine();
            int ne=int.Parse(note);
            Console.WriteLine("donner le nom de class");
            string nomclasse=Console.ReadLine();

            Classe c1 = new Classe(ne,nomclasse,nm);
            AjouterModules(c1, nm);
            AjouterEtudiants(c1,ne,nm);
           
            c1.CalculerMoyenGenerals();
            Console.WriteLine(c1.ToString());
        }
    }
}
