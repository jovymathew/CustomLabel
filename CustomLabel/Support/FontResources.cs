using System;
using Xamarin.Forms;

namespace CustomLabel.Support
{
    public class FontResources
    {
        public static readonly TextFont SplashFont = TextFont.Create(FormUtils.GetFontParameters("UPSBerlingskeSerifTx-Regular", "UPSBerlingskeSerifTx-Regular", ""), FormUtils.GetFontSize(50, 50, 50));
        public static readonly TextFont HeaderFont = TextFont.Create(FormUtils.GetFontParameters("UPSBerlingskeSerifTx-Regular", "UPSBerlingskeSerifTx-Regular", ""), FormUtils.GetFontSize(30, 30, 30));
        public static readonly TextFont SubHeaderBoldFont = TextFont.Create(FormUtils.GetFontParameters("UPSBerlingskeSerifTx-Bold", "UPSBerlingskeSerifTx-Bold", ""), FormUtils.GetFontSize(24, 24, 24));
        public static readonly TextFont SubHeaderFont = TextFont.Create(FormUtils.GetFontParameters("UPSBerlingskeSerifTx-Regular", "UPSBerlingskeSerifTx-Regular", ""), FormUtils.GetFontSize(28, 24, 24));
        public static readonly TextFont TertiaryHeaderFont = TextFont.Create(FormUtils.GetFontParameters("UPSBerlingskeSerifTx-Regular", "UPSBerlingskeSerifTx-Regular", ""), FormUtils.GetFontSize(17, 18, 17));
        public static readonly TextFont StandardFont = TextFont.Create(FormUtils.GetFontParameters("UPSBerlingskeSans-Regular", "UPSBerlingskeSans-Regular", ""), FormUtils.GetFontSize(16, 16, Device.GetNamedSize(NamedSize.Medium, typeof(Label))));
        public static readonly TextFont SubTextFont = TextFont.Create(FormUtils.GetFontParameters("UPSBerlingskeSans-Bold", "UPSBerlingskeSans-Bold", ""), FormUtils.GetFontSize(18, 18, Device.GetNamedSize(NamedSize.Small, typeof(Label))));
        public static readonly TextFont MenuFont = TextFont.Create(FormUtils.GetFontParameters("UPSBerlingskeSans-Regular", "UPSBerlingskeSans-Regular", ""), FormUtils.GetFontSize(22, 22, Device.GetNamedSize(NamedSize.Large, typeof(Label))));
        public static readonly TextFont SwitchFont = TextFont.Create(FormUtils.GetFontParameters("UPSBerlingskeSans-XLt", "UPSBerlingskeSans-XLt", ""), FormUtils.GetFontSize(18, 18, 18));
        public static readonly TextFont UpsellHeader1Font = TextFont.Create(FormUtils.GetFontParameters("UPSBerlingskeSerifTx-Regular", "UPSBerlingskeSerifTx-Regular", ""), FormUtils.GetFontSize(30, 28, 28));
        public static readonly TextFont UpsellHeader2Font = TextFont.Create(FormUtils.GetFontParameters("UPSBerlingskeSans-XLt", "UPSBerlingskeSans-XLt", ""), FormUtils.GetFontSize(14, 18, 18));
        public static readonly TextFont InfoNoticeFont = TextFont.Create(FormUtils.GetFontParameters("UPSBerlingskeSerifTx-BoldItalic", "UPSBerlingskeSerifTx-BoldItalic", ""), FormUtils.GetFontSize(24, 24, 18));
        public static readonly TextFont SectionHeaderPrimaryFont = TextFont.Create(FormUtils.GetFontParameters("UPSBerlingskeSerifTx-Regular", "UPSBerlingskeSerifTx-Rg", ""), FormUtils.GetFontSize(24, 35, Device.GetNamedSize(NamedSize.Medium, typeof(Label))));
        public static readonly TextFont SectionHeaderSecondaryFont = TextFont.Create(FormUtils.GetFontParameters("UPS Berlingske Sans", "UPS Berlingske Sans", ""), FormUtils.GetFontSize(18, 22, Device.GetNamedSize(NamedSize.Small, typeof(Label))));
        public static readonly TextFont ShipperPromoFont = TextFont.Create(FormUtils.GetFontParameters("UPS Berlingske Sans Italic", "UPS Berlingske Sans Italic", ""), FormUtils.GetFontSize(14, 15, 14));
        public static readonly TextFont ShipperPromoPrimaryFont = TextFont.Create(FormUtils.GetFontParameters("UPSBerlingskeSerifTx-Bold", "UPSBerlingskeSerifTx-Bold", ""), FormUtils.GetFontSize(12, 13, 12));
        public static readonly TextFont ShipperPromoSecondaryFont = TextFont.Create(FormUtils.GetFontParameters("UPSBerlingskeSerifTx-XLt", "UPSBerlingskeSerifTx-XLt", ""), FormUtils.GetFontSize(12, 13, 12));
        public static readonly TextFont PasswordHintFont = TextFont.Create(FormUtils.GetFontParameters("UPSBerlingskeSans-XLt", "UPSBerlingskeSans-XLt", ""), FormUtils.GetFontSize(14, 14, 14));
        public static readonly TextFont NetworkBannerPrimaryFont = TextFont.Create(FormUtils.GetFontParameters("UPSBerlingskeSans-Bold", "UPSBerlingskeSans-Bold", ""), FormUtils.GetFontSize(14, 13, 12));
        public static readonly TextFont NetworkBannerSecondaryFont = TextFont.Create(FormUtils.GetFontParameters("UPSBerlingskeSans-XLt", "UPSBerlingskeSans-XLt", ""), FormUtils.GetFontSize(14, 13, 12));

        /// <summary>
        /// Gets the font.
        /// </summary>
        /// <returns>The font.</returns>
        /// <param name="textType">Text type.</param>
        public static TextFont GetFont(TextType textType)
        {
            TextFont font = null;
            switch (textType)
            {
                case TextType.HeaderText:
                    {
                        font = FontResources.HeaderFont;
                        break;
                    }

                case TextType.SubHeaderText:
                    {
                        font = FontResources.SubHeaderFont;
                        break;
                    }
                case TextType.InfoNotice:
                    {
                        font = FontResources.InfoNoticeFont;
                        break;
                    }
                case TextType.UpsellHeaderLine1:
                    {
                        font = FontResources.UpsellHeader1Font;
                        break;
                    }
                case TextType.UpsellHeaderLine2:
                    {
                        font = FontResources.UpsellHeader2Font;
                        break;
                    }
                case TextType.SectionHeaderPrimary:
                    {
                        font = FontResources.SectionHeaderPrimaryFont;
                        break;
                    }
                case TextType.SectionHeaderSecondary:
                    {
                        font = FontResources.SectionHeaderSecondaryFont;
                        break;
                    }
                case TextType.SplashText:
                    {
                        font = FontResources.SplashFont;
                        break;
                    }
                case TextType.MenuText:
                    {
                        font = FontResources.MenuFont;
                        break;
                    }
                case TextType.TertiaryHeaderText:
                    {
                        font = FontResources.TertiaryHeaderFont;
                        break;
                    }
                case TextType.SubText:
                    {
                        font = FontResources.SubTextFont;
                        break;
                    }
                case TextType.SwitchText:
                    {
                        font = FontResources.SwitchFont;
                        break;
                    }
                case TextType.ShipperPromoText:
                    {
                        font = FontResources.ShipperPromoFont;
                        break;
                    }
                case TextType.ShipperPromoPrimaryText:
                    {
                        font = FontResources.ShipperPromoPrimaryFont;
                        break;
                    }
                case TextType.ShipperPromoSecondaryText:
                    {
                        font = FontResources.ShipperPromoSecondaryFont;
                        break;
                    }
                case TextType.NetworkBannerPrimaryText:
                    {
                        font = FontResources.NetworkBannerPrimaryFont;
                        break;
                    }
                case TextType.NetworkBannerSecondaryText:
                    {
                        font = FontResources.NetworkBannerSecondaryFont;
                        break;
                    }
                case TextType.PasswordHintText:
                    {
                        font = FontResources.PasswordHintFont;
                        break;
                    }
                default:
                    {
                        font = FontResources.StandardFont;
                        break;
                    }
            }
            return font;
        }

        /// <summary>
        /// Gets the font.
        /// </summary>
        /// <returns>The font.</returns>
        /// <param name="type">Type.</param>
        public static TextFont GetFont(LabelType type)
        {
            TextFont font = null;
            switch (type)
            {
                case LabelType.HeaderText:
                    {
                        font = FontResources.HeaderFont;
                        break;
                    }

                case LabelType.SubHeaderText:
                    {
                        font = FontResources.SubHeaderFont;
                        break;
                    }
                case LabelType.InfoNotice:
                    {
                        font = FontResources.InfoNoticeFont;
                        break;
                    }
                case LabelType.UpsellHeaderLine1:
                    {
                        font = FontResources.UpsellHeader1Font;
                        break;
                    }
                case LabelType.UpsellHeaderLine2:
                    {
                        font = FontResources.UpsellHeader2Font;
                        break;
                    }
                case LabelType.SectionHeaderPrimary:
                    {
                        font = FontResources.SectionHeaderPrimaryFont;
                        break;
                    }
                case LabelType.SectionHeaderSecondary:
                    {
                        font = FontResources.SectionHeaderSecondaryFont;
                        break;
                    }
                case LabelType.SplashText:
                    {
                        font = FontResources.SplashFont;
                        break;
                    }
                case LabelType.MenuText:
                    {
                        font = FontResources.MenuFont;
                        break;
                    }
                case LabelType.TertiaryHeaderText:
                    {
                        font = FontResources.TertiaryHeaderFont;
                        break;
                    }
                case LabelType.SubText:
                    {
                        font = FontResources.SubTextFont;
                        break;
                    }
                case LabelType.SwitchText:
                    {
                        font = FontResources.SwitchFont;
                        break;
                    }
                case LabelType.ShipperPromoText:
                    {
                        font = FontResources.ShipperPromoFont;
                        break;
                    }
                case LabelType.ShipperPromoPrimaryText:
                    {
                        font = FontResources.ShipperPromoPrimaryFont;
                        break;
                    }
                case LabelType.ShipperPromoSecondaryText:
                    {
                        font = FontResources.ShipperPromoSecondaryFont;
                        break;
                    }
                case LabelType.NetworkBannerPrimaryText:
                    {
                        font = FontResources.NetworkBannerPrimaryFont;
                        break;
                    }
                case LabelType.NetworkBannerSecondaryText:
                    {
                        font = FontResources.NetworkBannerSecondaryFont;
                        break;
                    }
                case LabelType.PasswordHintText:
                    {
                        font = FontResources.PasswordHintFont;
                        break;
                    }
                default:
                    {
                        font = FontResources.StandardFont;
                        break;
                    }
            }
            return font;
        }

    }

    /// <summary>
    /// Text type.
    /// </summary>
    public enum TextType
    {
        SplashText,
        HeaderText,
        SubHeaderText,
        TertiaryHeaderText,
        StandardText,
        SubText,
        MenuText,
        SwitchText,
        UpsellHeaderLine1,
        UpsellHeaderLine2,
        SectionHeaderPrimary,
        SectionHeaderSecondary,
        InfoNotice,
        ShipperPromoText,
        ShipperPromoPrimaryText,
        ShipperPromoSecondaryText,
        NetworkBannerPrimaryText,
        NetworkBannerSecondaryText,
        PasswordHintText
    }

    /// <summary>
    /// Label type.
    /// </summary>
    public enum LabelType
    {
        SplashText,
        HeaderText,
        SubHeaderText,
        TertiaryHeaderText,
        StandardText,
        SubText,
        MenuText,
        SwitchText,
        UpsellHeaderLine1,
        UpsellHeaderLine2,
        SectionHeaderPrimary,
        SectionHeaderSecondary,
        InfoNotice,
        ShipperPromoText,
        ShipperPromoPrimaryText,
        ShipperPromoSecondaryText,
        NetworkBannerPrimaryText,
        NetworkBannerSecondaryText,
        PasswordHintText
    }

}

