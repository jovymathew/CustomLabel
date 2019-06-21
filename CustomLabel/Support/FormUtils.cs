using System;
using Xamarin.Forms;

namespace CustomLabel.Support
{
    public static class FormUtils
    {
        public static readonly double DEFAULT_FONT_SIZE = 16;

        public static T GetFontParameters<T>(T valueForIOS, T valueForAndroid, T valueForWindows)
        {
            T data = default(T);
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    data = valueForIOS;
                    break;
                case Device.Android:
                    data = valueForAndroid;
                    break;
            }
            return data;

        }

        public static double GetFontSize(double valueForIOS, double valueForAndroid, double valueForWindows)
        {
            double fontSizePoint = DEFAULT_FONT_SIZE;
            try
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.iOS:
                        var point = 0;// (double)DeviceInfoService.GetiOSAccessibilityFont();
                        fontSizePoint = point > 0 ? point : valueForIOS;
                        break;
                    case Device.Android:
                        fontSizePoint = valueForAndroid;
                        break;
                }
                return fontSizePoint;
            }
            catch (Exception ex)
            {
                //ExceptionHandler.Handle(ex);
                return fontSizePoint;
            }

        }
    }
}
