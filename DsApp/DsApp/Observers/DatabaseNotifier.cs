using DsApp.Observers;
using System.Data;

namespace DsApp.Observers
{
    public class DatabaseNotifier : Subject<string>
    {
        private static DatabaseNotifier? instance;
        private static readonly object padlock = new object();

        private string _changeMessage;

        public static DatabaseNotifier GetInstance()
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new DatabaseNotifier();
                }
                return instance;
            }
        }

        private DatabaseNotifier() { }

        public void NotifyClientsChanged()
        {
            this._changeMessage = "client_added";
            base.Notify(this._changeMessage);
        }

        public void NotifyPackagesChanged()
        {
            this._changeMessage = "package_added";
            base.Notify(this._changeMessage);
        }

        public void NotifyResChanged()
        {
            this._changeMessage = "res_change";
            base.Notify(this._changeMessage);
        }
    }
}