using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CustomLabel.Support;
using Xamarin.Forms;

namespace CustomLabel.Support
{
    [ContentProperty("Spans")]
    public class BindableFormattedString : BindableObject
    {
        public static BindableProperty SpansProperty = BindableProperty.Create("Spans", typeof(IList<Span>),
            typeof(BindableFormattedString), null, BindingMode.OneWay, propertyChanged: Instance_SpansPropertyChanged);

        public static BindableProperty ParentViewProperty = BindableProperty.Create("ParentView", typeof(View),
            typeof(BindableFormattedString), null, BindingMode.OneWay, propertyChanged: Instance_ParentViewPropertyChanged);

        static void Instance_SpansPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = bindable as BindableFormattedString;
            instance._formattedString.Spans.Clear();
            ObservableCollection<Span> oldCollection = null;
            if (oldValue != null && oldValue.TryCastAs(out oldCollection))
            {
                oldCollection.CollectionChanged -= instance.Spans_CollectionChanged;
                instance.DetachHandlersOnSpans(oldCollection);
            }
            ObservableCollection<Span> newCollection = null;
            if (newValue != null && newValue.TryCastAs(out newCollection))
            {
                newCollection.CollectionChanged += instance.Spans_CollectionChanged;
                instance.AttachHandlersOnSpans(newCollection);
            }
            if (newCollection == null)
            {
                return;
            }
            foreach (var span in newCollection)
            {
                instance._formattedString.Spans.Add(span);
            }
        }

        private void AttachHandlersOnSpans(IEnumerable<Span> spans)
        {
            foreach (var s in spans)
            {
                s.PropertyChanged += SpanElement_PropertyChanged;
            }
        }

        private void DetachHandlersOnSpans(IEnumerable<Span> spans)
        {
            foreach (var s in spans)
            {
                s.PropertyChanged -= SpanElement_PropertyChanged;
            }
        }

        private void SpanElement_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            //if the property name is not among these
            if (!new string[]{
                nameof(Span.Text),
                nameof(Span.FontSize),
                nameof(Span.FontFamily),
                nameof(Span.FontAttributes),
                nameof(Span.FontFamily)}.Contains(e.PropertyName))
            {
                return;
            }
            Layout<View> ParentViewParent = null;
            if (ParentView == null || ParentView.Parent == null || !ParentView.Parent.TryCastAs(out ParentViewParent)) { return; }
            //update the parent view parent layout, since the change in any of the above properties may lead to changes in the layout of the ParentView's parent.
            //remove and reinsert the child to update
            var removeIndex = ParentViewParent.Children.IndexOf(ParentView);
            ParentViewParent.Children.RemoveAt(removeIndex);
            ParentViewParent.Children.Insert(removeIndex, ParentView);
        }

        static void Instance_ParentViewPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (newValue == null)
            {
                return;
            }
            var instance = bindable as BindableFormattedString;
            var parentView = newValue as View;
            instance.BindingContext = parentView.BindingContext;
        }

        private void Spans_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.OldItems != null)
            {
                foreach (var oldSpan in e.OldItems)
                {
                    _formattedString.Spans.Remove((Span)oldSpan);
                }
                DetachHandlersOnSpans(e.OldItems.Cast<Span>());
            }
            if (e.NewItems != null)
            {
                foreach (var newSpan in e.NewItems)
                {
                    _formattedString.Spans.Add((Span)newSpan);
                }
                AttachHandlersOnSpans(e.NewItems.Cast<Span>());
            }
        }

        private readonly FormattedString _formattedString;
        public BindableFormattedString()
        {
            _formattedString = new FormattedString() { Wrapper = this };
            Spans = new ObservableCollection<Span>();
            this.BindingContextChanged += (sender, e) =>
            {
                foreach (var span in Spans)
                {
                    span.BindingContext = this.BindingContext;
                }
            };
        }

        public static implicit operator Xamarin.Forms.FormattedString(BindableFormattedString bindableFormattedString)
        {
            return bindableFormattedString._formattedString;
        }

        public IList<Span> Spans
        {
            get { return (IList<Span>)GetValue(SpansProperty); }
            set { SetValue(SpansProperty, value); }
        }

        /// <summary>
        /// The parent view for this instance which is typically a label.
        /// </summary>
        /// <value>The parent view.</value>
        public View ParentView
        {
            get { return (View)GetValue(ParentViewProperty); }
            set { SetValue(ParentViewProperty, value); }
        }
    }

    public class FormattedString : Xamarin.Forms.FormattedString
    {
        public BindableFormattedString Wrapper { get; set; }
    }

    public class Span : BindableObject
    {

        public static BindableProperty BackgroundColorProperty = BindableProperty.Create("BackgroundColor", typeof(Color), typeof(Span), Color.Default, propertyChanged: Instance_BackgroundColorPropertyChanged);
        public static BindableProperty ForegroundColorProperty = BindableProperty.Create("ForegroundColor", typeof(Color), typeof(Span), Color.Default, propertyChanged: Instance_ForegroundColorPropertyChanged);
        public static BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(Span), null, propertyChanged: Instance_TextPropertyChanged);
        public static BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(double), typeof(Span), Label.FontSizeProperty.DefaultValue, propertyChanged: Instance_FontSizePropertyChanged);
        public static BindableProperty FontFamilyProperty = BindableProperty.Create("FontFamily", typeof(string), typeof(Span), Label.FontFamilyProperty.DefaultValue, propertyChanged: Instance_FontFamilyPropertyChanged);
        public static BindableProperty FontAttributesProperty = BindableProperty.Create("FontAttributes", typeof(FontAttributes), typeof(Span), Label.FontAttributesProperty.DefaultValue, propertyChanged: Instance_FontAttributesPropertyChanged);

        private static void Instance_TextPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            var instance = bindable as Span;
            instance._span.Text = (string)newvalue;
        }

        static void Instance_FontSizePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = bindable as Span;
            instance._span.FontSize = (double)newValue;
        }

        static void Instance_BackgroundColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = bindable as Span;
            instance._span.BackgroundColor = (Color)newValue;
        }

        static void Instance_ForegroundColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = bindable as Span;
            instance._span.ForegroundColor = (Color)newValue;
        }

        static void Instance_FontFamilyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = bindable as Span;
            instance._span.FontFamily = (string)newValue;
        }

        static void Instance_FontAttributesPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = bindable as Span;
            instance._span.FontAttributes = (FontAttributes)newValue;
        }

        private Xamarin.Forms.Span _span;
        public Span()
        {
            _span = new Xamarin.Forms.Span();
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public Color BackgroundColor
        {
            get { return (Color)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }

        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        public string FontFamily
        {
            get { return (string)GetValue(FontFamilyProperty); }
            set { SetValue(FontFamilyProperty, value); }
        }

        public string FontAttributes
        {
            get { return (string)GetValue(FontAttributesProperty); }
            set { SetValue(FontAttributesProperty, value); }
        }

        public string ForegroundColor
        {
            get { return (string)GetValue(ForegroundColorProperty); }
            set { SetValue(ForegroundColorProperty, value); }
        }

        public static implicit operator Xamarin.Forms.Span(Span span)
        {
            return span._span;
        }


    }
}