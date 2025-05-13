interface INotification {
    void Send(string message);
}

class EmailNotification : INotification {
    public void Send(string message) {
        Console.WriteLine($"This is a {GetType()} And I send {message}");
    }

}


class SMSNotification : INotification {
    public void Send(string message) {
        Console.WriteLine($"This is a {GetType()} And I send {message}");
    }

}

class PushNotification : INotification {
    public void Send(string message) {
        Console.WriteLine($"This is a {GetType()} And I send {message}");
    }

}


class Creator {

    public static INotification? CreateNotification(string type) {
        
        if (string.IsNullOrEmpty(type)) {
            return null;
        }

        switch (type.ToLower()) {
            
            case "email":
            Console.WriteLine("Created email notification");
            return new EmailNotification();

            case "sms":
            Console.WriteLine("Created sms notification");
            return new SMSNotification();

            case "push":
            Console.WriteLine("Created push notification");
            return new PushNotification();

            default:
                throw new ArgumentException("The type is not exist");
        }
    } 
}