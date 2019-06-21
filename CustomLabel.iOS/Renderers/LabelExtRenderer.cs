using System;
using CoreGraphics;
using CustomLabel.Controls;
using CustomLabel.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(LabelExt), typeof(LabelExtRenderer))]
namespace CustomLabel.iOS.Renderers
{
    public class LabelExtRenderer: ViewRenderer<LabelExt, UIView>
    {
        private UILabel _buttonTitleLabel;
        private UIButton _rootView;
        protected override void OnElementChanged(ElementChangedEventArgs<LabelExt> e)
        {
            base.OnElementChanged(e);
        
            _rootView = CreateLayout();

            AddTouchBehavior(_rootView);

            // Tell Xamarin to user our layout for the control
            SetNativeControl(_rootView);
            //var dim = _buttonTitleLabel.Text.StringSize(_buttonTitleLabel.Font);

            //rootView.Frame = new CoreGraphics.CGRect(0, 0, dim.Width, dim.Height);

        }

        private UIButton CreateLayout()
        {
            var rootView = new UIButton (UIButtonType.Plain)
            {

                UserInteractionEnabled = true,
                TranslatesAutoresizingMaskIntoConstraints = false,
                BackgroundColor = Color.Wheat.ToUIColor(),
                //TitleLabel.Text = Element.Text,
               // TextColor = Element.TextColor.ToUIColor(),
            };

            // Create button title label
            _buttonTitleLabel = rootView.TitleLabel;

            _buttonTitleLabel.Text = Element.Text;
            _buttonTitleLabel.TextColor = Element.TextColor.ToUIColor();
            //    UserInteractionEnabled = false,
            //    Text = Element.Text,
            //    TextColor = Element.TextColor.ToUIColor(),
            //    TranslatesAutoresizingMaskIntoConstraints = false,
            //    LineBreakMode = UILineBreakMode.WordWrap,
            //    Lines = 0,
                
            //};

            

            //rootView.AddSubview(_buttonTitleLabel);

          

          
            return rootView;
        }
        private void AddTouchBehavior(UIButton rootView)
        {
            rootView.TouchDown += AddTouchBackgroundColor;
            rootView.TouchDragEnter += AddTouchBackgroundColor;
            rootView.TouchUpInside += RemoveTouchBackgroundColor;
            rootView.TouchCancel += RemoveTouchBackgroundColor;
            rootView.TouchDragExit += RemoveTouchBackgroundColor;
        }

        private void AddTouchBackgroundColor(object sender, EventArgs e)    
        {
            (sender as UIView).BackgroundColor = Element.BackgroundColor.ToUIColor().ColorWithAlpha(.5f);
        }

        private void RemoveTouchBackgroundColor(object sender, EventArgs e)
        {
            (sender as UIView).BackgroundColor = Element.BackgroundColor.ToUIColor();
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            var lblConstraints = new[]
          {
                _rootView.TopAnchor.ConstraintEqualTo (_buttonTitleLabel.TopAnchor, -2),
                _rootView.LeftAnchor.ConstraintEqualTo (_buttonTitleLabel.LeftAnchor),
                _rootView.RightAnchor.ConstraintEqualTo (_buttonTitleLabel.RightAnchor, 2),
                _rootView.HeightAnchor.ConstraintEqualTo (_buttonTitleLabel.HeightAnchor),
                _rootView.TrailingAnchor.ConstraintEqualTo (_buttonTitleLabel.TrailingAnchor),

            };
            NSLayoutConstraint.ActivateConstraints(lblConstraints);

        }

    }
}
