using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Week1Prova.MyExpenseModel;
using Week1Prova.MyChain;
using System.Threading;

namespace Week1Prova
{
    public static class Controller
    {
        public static void WatchMyFolder(object myFile, FileSystemEventArgs e)
        {
            MyExpense myExpense = new MyExpense();
            Console.WriteLine("***Un File di spesa è stato caricato***\n\n\n");
            myExpense.LoadFromFile("spese", myExpense);
            Console.WriteLine("Elaborazione in corso....");
            Thread.Sleep(3000);
            myExpense.SaveToFile("spese_elaborate", myExpense);
            Console.Clear();
            Console.WriteLine("L'elaborazione è avvenuta con successo,\n" +
                "puoi trovare il file elaborato nella stessa cartella\n" +
                "con il nome: 'spese_elaborate' .");
        }
    }
}
