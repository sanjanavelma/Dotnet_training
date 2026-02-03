using System;
class Program
{
    // static void DisplayNotification(string file)
    // {
    //     Console.WriteLine($"NOTIFICATION: You can now open {file}.");
    // }
    static void Main()
    {
        // PaymentService service=new PaymentService();
        // PaymentDelegate payment = service.ProcessPayment; //delegate assignment
        // decimal amount=5000;
        // if(amount.IsValidPayment())
        // {
        //     payment(amount);
        // }
        // else
        // {
        //     Console.WriteLine("Invalid Payment Amount");
        // }
        //====================================================================================//
        // NotificationServices service = new NotificationServices();
        // OrderDelegate notify = null;
        // notify += service.SendEmail;
        // notify += service.SendSMS;
        // notify("ORD1001");
        //====================================================================================//
        // Action<string> logActivity = message =>
        //     Console.WriteLine("Log Entry: " + message);
        // logActivity("User logged in at 10:30 AM");
        //===============================================================================================//
        // Func<decimal, decimal, decimal> calculateDiscount = (price, discount) => price - (price * discount / 100);
        // Console.WriteLine(calculateDiscount(1000, 10));
        //=============================================================================================================//
        // Predicate<int> isEligible = age => age >=18;
        // Console.WriteLine("The user is eligible");
        // ErrorDelegate errorHandler=delegate(string msg)
        // {
        //     Console.WriteLine("Error:"+msg);
        // };
        // errorHandler("File not found");
        //====================================================================//
        // Button bt = new Button();
        // bt.Clicked += () => Console.WriteLine("Botton is Clicked");
        // bt.Clicked += () => Console.WriteLine("Botton1 is Clicked");
        // bt.Clicked += () => Console.WriteLine("Botton2 is Clicked");
        // bt.Click();
        //====================================================================//
        // Downloader d = new Downloader();
        // d.DownloadCompleted += () => Console.WriteLine("Download Completed");
        // d.CompleteDownload();
        //====================================================================//
        // Objects Initialization
        // MotionSensor livingRoomSensor = new MotionSensor();
        // AlarmSystem siren = new AlarmSystem();
        // PoliceNotifier police = new PoliceNotifier();
        // // 2. INSTANTIATION & MULTICASTING
        // // We "Subscribe" different methods to the sensor's delegate
        // SecurityAction panicSequence = siren.SoundSiren; // Assignment of methods
        // panicSequence += police.CallDispatch;
        // // Linking the sequence to the sensor
        // livingRoomSensor.OnEmergency = panicSequence;
        // // class_object.delegate_instance = delegate_instance_multicast
        // // Simulation
        // livingRoomSensor.DetectIntruder("Main Lobby");
        // FileDownloader downloader = new FileDownloader();
        // // Pass the method 'DisplayNotification' as a callback
        // downloader.DownloadFile("Presentation.pdf", DisplayNotification);
        Comparison<int> sortDescending = (a, b) => b.CompareTo(a);
        Console.WriteLine(sortDescending(10, 10));
        Console.WriteLine(sortDescending(5, 10));
        Console.WriteLine(sortDescending(10, 5));
    }
}