using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Week1Prova.MyChain;

namespace Week1Prova.MyExpenseModel
{
    public class MyExpense
    {
        public DateTime Data { get; set; }
        public string Categoria { get; set; }
        public string Descrizione { get; set; }
        public string Approvazione { get; set; }
        public string LvlApprovazione { get; set; }
        public int ImportoSpesa { get; set; }
        public string ImportoRimborso { get; set; }

        public void LoadFromFile(string fileName, MyExpense myExpense)
        {
            var manager = new Manager();
            var operationalManager = new OperationalManager();
            var CEO = new CEO();

            try
            {
                using (StreamReader reader = File.OpenText($"C:\\Users\\WORK\\Desktop\\MyFolder\\{fileName}"))
                {
                    string myLine = Console.ReadLine();
                    string[] data = myLine.Split(';');

                    myExpense.Data = Convert.ToDateTime(data[0]);
                    myExpense.Categoria = data[1];
                    myExpense.Descrizione = data[2];
                    myExpense.ImportoSpesa = Convert.ToInt32(data[3]);
                    reader.Close();

                    manager.SetNextInLine(operationalManager).SetNextInLine(CEO);
                    string result = manager.Approve(myExpense.ImportoSpesa);
                    if (result.Equals("RESPINTA;-;-"))
                    {
                        string[] denial = result.Split(';');
                        myExpense.Approvazione = denial[0];
                        myExpense.LvlApprovazione = denial[1];
                        myExpense.ImportoRimborso = denial[2];
                    }
                    else
                    {
                        string[] approved = result.Split(';');
                        myExpense.Approvazione = approved[0];
                        myExpense.LvlApprovazione = approved[1];
                        myExpense.ImportoRimborso = Convert.ToString(MyFactory.ExpenseFactory(myExpense.Categoria, myExpense.ImportoSpesa));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SaveToFile(string fileName, MyExpense myExpense)
        {
            try
            {
                using (StreamWriter writer = File.CreateText($"C:\\Users\\WORK\\Desktop\\TEST.IO\\Saves\\{fileName}.txt"))
                {
                    
                    writer.WriteLine($"{myExpense.Data.ToShortDateString()};{myExpense.Categoria};{myExpense.Descrizione};{myExpense.Approvazione};{myExpense.LvlApprovazione};{myExpense.ImportoRimborso}");
                    writer.Close();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
