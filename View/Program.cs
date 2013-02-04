using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace View
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Mediatheque m = new Mediatheque();

            
            Mediatheque test = new Mediatheque();
            Document test1 = new Audio("titre1", "path", false);
            Document test2 = new Video("titre2", "path2", false);
            Document test3 = new Video("titre3", "path3", false);
            Document test4 = new Article("titre3", "path3", false, "lol", "lol");
            test.Ajouter(test1);
            test.Ajouter(test2);
            test.Ajouter(test3);
            test.Ajouter(test4);
            test.Sauvegarder();
            Mediatheque testCharger = Mediatheque.Charger();
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(test));

            

//Audio test = new Audio("title", "D:\\Musique\\Can - Ege Bamyasi\1972 Can - Ege Bamyasi (remaster)\lol.mp3"); 
        }
    }
}
