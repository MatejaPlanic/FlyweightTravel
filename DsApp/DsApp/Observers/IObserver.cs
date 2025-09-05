namespace DsApp.Observers
{
    // Generički interfejs za Observere
    public interface IObserver<T>
    {
        void Update(T data);
    }
}