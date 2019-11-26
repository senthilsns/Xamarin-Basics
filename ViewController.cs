using Foundation;
using System;
using UIKit;


namespace DemoApp
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            // Singleton Usage
            Singleton.Instance.DemoAction();

            // Calling Method
            SampleMethod();


        }

        #region UserDefaults
        public void SampleMethod()
        {

            // Store Value in Defaults
            var storeVsl = NSUserDefaults.StandardUserDefaults;
            storeVsl.SetBool(true, "checkStatus");
            storeVsl.SetString("senthil", "Name");

            // Read Values in Defaults
            var storedVal = storeVsl.BoolForKey("checkStatus");
            var storedStr = storeVsl.StringForKey("Name");

            // Printing Stored Values
            Console.WriteLine(storedVal);
            Console.WriteLine(storedStr);
        }

        #endregion
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void showAlertAction(Foundation.NSObject sender)
        {
            //Create Alert
            var okAlertController = UIAlertController.Create("Demo Alert", "sample Msg", UIAlertControllerStyle.Alert);

            //Add Action
            okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            okAlertController.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, alert => Console.WriteLine("Cancel was clicked")));

            // Present Alert
            PresentViewController(okAlertController, true, null);
        }

    }
}
