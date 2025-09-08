namespace DsApp.Observers
{
    public interface IObserver<T>
    {
        void Update(T data);
    }
}