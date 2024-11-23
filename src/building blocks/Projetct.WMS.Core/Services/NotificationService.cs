using Projetct.WMS.Core.DomainObjects;
using Projetct.WMS.Core.Interfaces;

namespace Projetct.WMS.Core.Services
{
    public class NotificationService : INotificationService
    {
        private List<Notification> _notifications;

        public NotificationService()
        {
            _notifications = new List<Notification>();
        }

        public void Add(string message)
        {
            _notifications.Add(new Notification(message));
        }

        public bool Has()
        {
            return _notifications.Any();
        }

        public IList<Notification> Notifications()
        {
            return _notifications;
        }
    }
}
