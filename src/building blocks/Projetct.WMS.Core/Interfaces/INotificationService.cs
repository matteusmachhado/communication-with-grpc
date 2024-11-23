using Projetct.WMS.Core.DomainObjects;

namespace Projetct.WMS.Core.Interfaces
{
    public interface INotificationService
    {
        bool Has();
        void Add(string message);
        IList<Notification> Notifications();
    }
}
