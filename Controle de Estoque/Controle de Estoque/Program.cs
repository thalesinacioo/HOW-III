using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Controle_de_Estoque
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new F_Menu());

            string ArquivoDB = @"D:\Users\Andrei Luiz\Documents\GitHub\HOW-III\Controle de Estoque\Controle de Estoque\bin\Debug\db.txt";
            List<string> lines = File.ReadAllLines(ArquivoDB).ToList();
        }
    }
}
