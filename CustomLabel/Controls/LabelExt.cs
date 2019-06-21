using Xamarin.Forms;

namespace CustomLabel.Controls
{
    public class LabelExt: View
    {
        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(LabelExt), "Text goes here");

        public static readonly BindableProperty TextColorProperty = BindableProperty.Create("TextColor", typeof(Color), typeof(LabelExt));

        public static readonly BindableProperty FontFamilyProperty = BindableProperty.Create("FontFamily", typeof(string), typeof(LabelExt));

        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(double), typeof(LabelExt));

        public static readonly BindableProperty FontAttributesProperty = BindableProperty.Create("FontAttributes", typeof(Xamarin.Forms.FontAttributes), typeof(LabelExt));


        //public static readonly BindableProperty ClickableProperty = BindableProperty.Create("Clickable", typeof(bool), typeof(LabelExt), false, BindingMode.Default);

        //public static readonly BindableProperty SelectableProperty = BindableProperty.Create("Selectable", typeof(bool), typeof(LabelExt), false, BindingMode.Default);

        //public static readonly BindableProperty UnderlineProperty = BindableProperty.Create("Underline", typeof(bool), typeof(LabelExt), false, BindingMode.Default);

        //public static readonly BindableProperty BindableFormattedTextProperty = BindableProperty.Create(nameof(BindableFormattedText), typeof(BindableFormattedString), typeof(LabelExt), null, BindingMode.Default, propertyChanged: Instace_BindableFormattedTextPropertyChanged);

        //public static readonly BindableProperty ContentDescriptionProperty = BindableProperty.Create("ContentDescription", typeof(String), typeof(LabelExt), String.Empty, BindingMode.Default);

        //public static readonly BindableProperty MutableAutomationIdProperty = BindableProperty.Create(nameof(MutableAutomationId), typeof(string), typeof(LabelExt), default(string));

        //public static readonly BindableProperty ShowMaxLinesProperty = BindableProperty.Create("ShowMaxLines", typeof(bool), typeof(LabelExt), false, BindingMode.Default);

        //public static readonly BindableProperty AccessibleProperty = BindableProperty.Create("Accessible", typeof(bool), typeof(LabelExt), true, BindingMode.Default);



        public string Text
        {
            set { SetValue(TextProperty, value); }
            get { return (string)GetValue(TextProperty); }
        }

        public Color TextColor
        {
            set { SetValue(TextColorProperty, value); }
            get { return (Color)GetValue(TextColorProperty); }
        }

        public double FontSize
        {
            set { SetValue(FontSizeProperty, value); }
            get { return (double)GetValue(FontSizeProperty); }
        }

        public Xamarin.Forms.FontAttributes FontAttributes
        {
            set { SetValue(FontAttributesProperty, value); }
            get { return (Xamarin.Forms.FontAttributes)GetValue(FontAttributesProperty); }
        }

        public string FontFamily
{
            set { SetValue(FontFamilyProperty, value); }
            get { return (string)GetValue(FontFamilyProperty); }
        }

        //public String ContentDescription
        //{
        //    get { return GetValue(ContentDescriptionProperty).ToString(); }
        //    set { SetValue(ContentDescriptionProperty, value); }
        //}

        //public string MutableAutomationId
        //{
        //    get => (string)GetValue(MutableAutomationIdProperty);
        //    set => SetValue(MutableAutomationIdProperty, value);
        //}

        //static void Instace_BindableFormattedTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    var instance = bindable as LabelExt;
        //    if (oldValue != null)
        //    {
        //        (oldValue as BindableFormattedString).ParentView = null;
        //    }
        //    if (newValue != null)
        //    {
        //        (newValue as BindableFormattedString).ParentView = instance;
        //    }
        //}


        //private TextFont fontType = null;



        //public TextFont FontType
        //{
        //    get
        //    {
        //        return fontType;
        //    }
        //    set
        //    {
        //        fontType = value;
        //        if (value != null)
        //        {
        //            if (!string.IsNullOrEmpty(value.FontName))
        //            {
        //                FontFamily = value.FontName;
        //            }
        //            FontSize = value.FontSize;
        //            FontAttributes = value.FontStyle;
        //        }
        //    }
        //}


        //private LabelType type = LabelType.SubText;
        //public LabelType Type
        //{
        //    get
        //    {
        //        return type;
        //    }

        //    set
        //    {
        //        type = value;
        //        FontType = FontResources.GetFont(type);


        //    }
        //}
        ///// <summary>
        ///// The type of the text.
        ///// </summary>
        //private TextType textType = TextType.SubText;
        ///// <summary>
        ///// Gets or sets the type of the text.
        ///// </summary>
        ///// <value>The type of the text.</value>
        //public TextType TextType
        //{
        //    get
        //    {
        //        return textType;
        //    }

        //    set
        //    {
        //        textType = value;
        //        FontType = FontResources.GetFont(textType);

        //    }
        //}


        //public bool Underline
        //{
        //    get
        //    {
        //        return (bool)GetValue(UnderlineProperty);
        //    }
        //    set
        //    {
        //        SetValue(UnderlineProperty, value);
        //        OnPropertyChanged();
        //    }
        //}


        //public bool Clickable
        //{
        //    get
        //    {
        //        return (bool)GetValue(ClickableProperty);
        //    }
        //    set
        //    {
        //        SetValue(ClickableProperty, value);
        //        OnPropertyChanged();
        //    }
        //}

        //public bool Selectable
        //{
        //    get
        //    {
        //        return (bool)GetValue(SelectableProperty);
        //    }
        //    set
        //    {
        //        SetValue(SelectableProperty, value);
        //        OnPropertyChanged();
        //    }
        //}

        //public bool ShowMaxLines
        //{
        //    get
        //    {
        //        return (bool)GetValue(ShowMaxLinesProperty);
        //    }
        //    set
        //    {
        //        SetValue(ShowMaxLinesProperty, value);
        //        OnPropertyChanged();
        //    }
        //}

        //public BindableFormattedString BindableFormattedText
        //{
        //    get
        //    {
        //        return (BindableFormattedString)GetValue(BindableFormattedTextProperty);
        //    }
        //    set
        //    {
        //        SetValue(BindableFormattedTextProperty, value);
        //    }
        //}

        //public bool Accessible
        //{
        //    get
        //    {
        //        return (bool)GetValue(AccessibleProperty);
        //    }
        //    set
        //    {
        //        SetValue(AccessibleProperty, value);
        //        OnPropertyChanged();
        //        AutomationProperties.SetIsInAccessibleTree(this, value);
        //    }
        //}


    }
}
