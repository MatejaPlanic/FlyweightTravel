namespace BackEnd.Observers
{
    public class ClientListForm : IObserver
    {
        public void Update()
        {
            // Ažuriranje liste klijenata na formi
            Console.WriteLine("Forma liste klijenata je ažurirana.");
        }
    }
}
