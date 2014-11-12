using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LessonIVPartIFiles
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Directories

            if (!Directory.Exists("Saves"))
            {
                Directory.CreateDirectory("Saves");
               
            }

            // yeah
            var dialog = new SaveFileDialog();
            dialog.Filter = "Plik tekstowy | .txt";
            DialogResult result = dialog.ShowDialog();

            // react to dialog
            string fileName = dialog.FileName;
            if(File.Exists(fileName))
                File.Delete(fileName);
            
            using (var myNewFile = File.CreateText(fileName))
            {
                myNewFile.WriteLine("moj tekst");
            }

            using (var myFile = File.OpenText(fileName))
            {
                Console.WriteLine(myFile.ReadLine());
            }

            Console.Read();

            /*OpenFileDialog dialog = new OpenFileDialog();
            dialog.CheckFileExists = true;
            dialog*/
        }
    }
}
