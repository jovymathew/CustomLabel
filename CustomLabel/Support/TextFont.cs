using System;
using Xamarin.Forms;

namespace CustomLabel.Support
{
    public class TextFont
    {
        public TextFont(string name, double size, FontAttributes style = FontAttributes.None)
        {
            FontName = name;
            FontSize = size;
            FontStyle = style;
        }

        public string FontName
        {
            get; set;
        }

        public double FontSize
        {
            get; set;
        }

        public FontAttributes FontStyle
        {
            get; set;
        }
        public static TextFont Create(string name = "", double size = 16, FontAttributes style = FontAttributes.None)
        {
            return new TextFont(name, size, style);
        }
    }
}
