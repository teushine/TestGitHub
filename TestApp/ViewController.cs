using System;

using AppKit;
using Foundation;

namespace TestApp
{
    public partial class ViewController : NSViewController
    {
        private int numberOfClicks = 0;


        partial void ClickedButton(Foundation.NSObject sender)
        {
            ClickedLabel.StringValue = string.Format("The button has been clicked {0} time{1}.",++numberOfClicks, (numberOfClicks < 2) ? "" : "s");
            //throw new NotImplementedException();
        }

        public ViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.

            ClickedLabel.StringValue = "Button hasn't been clicked yet.";
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
