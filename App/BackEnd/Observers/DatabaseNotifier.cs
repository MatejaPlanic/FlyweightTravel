namespace BackEnd.Observers
{
    public class DatabaseNotifier : Subject
    {
        public void DataChanged()
        {
            Console.WriteLine("Promena u bazi podataka. Obaveštavanje posmatrača...");
            Notify();
        }
    }
}
