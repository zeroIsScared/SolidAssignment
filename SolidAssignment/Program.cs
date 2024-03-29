using SolidAssignment;

internal class Program
{
    private static void Main(string[] args)
    {
        Notification emailNotification = new Notification(NotificationType.Email);
        Notification smsNotification = new Notification(NotificationType.SMS);

        NotificationService notificationService = new NotificationService();

        notificationService.AddNotificationType(NotificationType.SMS, new SMSNotificationSender());
        notificationService.AddNotificationType(NotificationType.Email, new EmailNotificationSender());

        notificationService.SendNotification(smsNotification, "me", "You have a new project.");
        notificationService.SendNotification(emailNotification, "boss", "Please review this contract.");

    }
}