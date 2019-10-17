using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace UITest.iOS.Views
{

    [Register("InitViewController")]
    public class InitViewController : UIViewController
    {
        private UIButton _button;
        private UILabel _label;

        private UIButton Button
        {
            get
            {
                if (_button == null)
                {
                    _button = UIButton.FromType(UIButtonType.Plain);
                    _button.BackgroundColor = UIColor.Red;
                    _button.SetTitle("Change Color", UIControlState.Normal);
                    _button.TouchDown += ButtonTouchedDown;
                    _button.AccessibilityIdentifier = "button";
                }

                return _button;
            }
        }

        private UILabel Label
        {
            get
            {
                if (_label == null)
                {
                    _label = new UILabel();
                    _label.Text = "BEFORE";
                    _label.Font = UIFont.SystemFontOfSize(25f);
                    _label.TextColor = UIColor.Black;
                    _label.AccessibilityIdentifier = "editor";
                }

                return _label;
            }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.White;
            View.Add(Button);
            View.Add(Label);

            Button.TranslatesAutoresizingMaskIntoConstraints = false;
            Button.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor).Active = true;
            Button.CenterYAnchor.ConstraintEqualTo(View.CenterYAnchor).Active = true;
            Button.HeightAnchor.ConstraintEqualTo(75f).Active = true;
            Button.WidthAnchor.ConstraintEqualTo(300f).Active = true;
            
            Label.TranslatesAutoresizingMaskIntoConstraints = false;
            Label.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor).Active = true;
            Label.BottomAnchor.ConstraintEqualTo(Button.TopAnchor).Active = true;
            Label.WidthAnchor.ConstraintEqualTo(Button.WidthAnchor).Active = true;
            Label.HeightAnchor.ConstraintEqualTo(Button.HeightAnchor).Active = true;
        }

        private void ButtonTouchedDown(object sender, EventArgs e)
        {
            Label.Text = "AFTER";
        }
    }
}