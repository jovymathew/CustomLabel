using System.ComponentModel;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Views;
using Android.Widget;
using CustomLabel.Controls;
using CustomLabel.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(LabelExt), typeof(LabelExtRenderer))]
namespace CustomLabel.Droid.Renderers
{
    public class LabelExtRenderer : ViewRenderer<LabelExt, Android.Views.View>
    {
        private Context _context;
        private TextView _textView;
        private LabelExt _element;
        private Android.Views.View _rootLayout;
        public LabelExtRenderer(Context context) : base(context)
        {
            _context = context;
        }
        protected override void OnElementChanged(ElementChangedEventArgs<LabelExt> e)
        {
            base.OnElementChanged(e);
            _element = Element as LabelExt;
            if (Control == null)
            {
                // Inflate the IncrementingButton layout
                var inflater = _context.GetSystemService(Context.LayoutInflaterService) as LayoutInflater;
                _rootLayout = inflater.Inflate(Resource.Layout.label_view, null, false);
                _textView = _rootLayout.FindViewById<TextView>(Resource.Id.textView1);

                // Tell Xamarin to user our layout for the control
                SetNativeControl(_rootLayout);
                SetBackground(_rootLayout);
            }

            SetControlProperties();

        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (_textView != null)
            {
                if (e.PropertyName == "Text")
                {
                    _textView.Text = _element.Text;
                }
            }
        }

        private void SetControlProperties()
        {
            _textView.Text = _element.Text;
            _textView.SetTextColor(_element.TextColor.ToAndroid());
            if (_element.FontSize > 0)
                _textView.TextSize = (float)_element.FontSize;
           
             
        }

        private void SetBackground(Android.Views.View rootLayout)
        {
            // Get the background color from Forms element
            var backgroundColor = Element.BackgroundColor.ToAndroid();

            // Create statelist to handle ripple effect
            var enabledBackground = new GradientDrawable(GradientDrawable.Orientation.LeftRight, new int[] { backgroundColor, backgroundColor });
            var stateList = new StateListDrawable();
            var rippleItem = new RippleDrawable(ColorStateList.ValueOf(Android.Graphics.Color.White),
                                                enabledBackground,
                                                null);
            stateList.AddState(new[] { Android.Resource.Attribute.StateEnabled }, rippleItem);

            // Assign background
            rootLayout.Background = stateList;
            rootLayout.Clickable = true;
        }
    }
}
