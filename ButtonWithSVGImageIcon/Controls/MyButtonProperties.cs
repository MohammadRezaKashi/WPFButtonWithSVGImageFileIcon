using System;
using System.Windows;
using System.Windows.Media;

namespace WpfControls.Controls
{
    public class MyButtonProperties
    {
        public static readonly DependencyProperty TextColorProperty = DependencyProperty.RegisterAttached(
            "TextColor", typeof(Brush), typeof(MyButtonProperties), new PropertyMetadata(Brushes.White));

        public static void SetTextColor(DependencyObject element, Brush value)
            => element.SetValue(TextColorProperty, value);

        public static Brush GetTextColor(DependencyObject element)
            => (Brush)element.GetValue(TextColorProperty);

        public static readonly DependencyProperty HoverTextColorProperty = DependencyProperty.RegisterAttached(
            "HoverTextColor", typeof(Brush), typeof(MyButtonProperties), new PropertyMetadata(Brushes.AliceBlue));

        public static void SetHoverTextColor(DependencyObject element, Brush value)
            => element.SetValue(HoverTextColorProperty, value);

        public static Brush GetHoverTextColor(DependencyObject element)
            => (Brush)element.GetValue(HoverTextColorProperty);

        public static readonly DependencyProperty ButtonImageProperty = DependencyProperty.RegisterAttached(
            "ButtonImage", typeof(ImageSource), typeof(MyButtonProperties), new PropertyMetadata(null));

        public static void SetButtonImage(DependencyObject element, ImageSource value)
            => element.SetValue(ButtonImageProperty, value);

        public static ImageSource GetButtonImage(DependencyObject element)
            => (ImageSource)element.GetValue(ButtonImageProperty);

        public static readonly DependencyProperty ButtonSVGImageProperty = DependencyProperty.RegisterAttached(
            "ButtonSVGImage", typeof(Uri), typeof(MyButtonProperties), new PropertyMetadata(null));

        public static void SetButtonSVGImage(DependencyObject element, Uri value)
            => element.SetValue(ButtonSVGImageProperty, value);

        public static Uri GetButtonSVGImage(DependencyObject element)
            => (Uri)element.GetValue(ButtonSVGImageProperty);

        public static readonly DependencyProperty ToggleButtonSVGImageProperty = DependencyProperty.RegisterAttached(
            "ToggleButtonSVGImage", typeof(Uri), typeof(MyButtonProperties), new PropertyMetadata(null));

        public static void SetToggleButtonSVGImage(DependencyObject element, Uri value)
            => element.SetValue(ToggleButtonSVGImageProperty, value);

        public static Uri GetToggleButtonSVGImage(DependencyObject element)
            => (Uri)element.GetValue(ToggleButtonSVGImageProperty);

        public static readonly DependencyProperty HoverButtonImageProperty = DependencyProperty.RegisterAttached(
            "HoverButtonImage", typeof(ImageSource), typeof(MyButtonProperties), new PropertyMetadata(null));

        public static void SetHoverButtonImage(DependencyObject element, ImageSource value)
            => element.SetValue(HoverButtonImageProperty, value);

        public static ImageSource GetHoverButtonImage(DependencyObject element)
            => (ImageSource)element.GetValue(HoverButtonImageProperty);

        public static readonly DependencyProperty HoverButtonSVGImageProperty = DependencyProperty.RegisterAttached(
            "HoverButtonSVGImage", typeof(Uri), typeof(MyButtonProperties), new PropertyMetadata(null));

        public static void SetHoverButtonSVGImage(DependencyObject element, Uri value)
            => element.SetValue(HoverButtonSVGImageProperty, value);

        public static Uri GetHoverButtonSVGImage(DependencyObject element)
            => (Uri)element.GetValue(HoverButtonSVGImageProperty);

        public static readonly DependencyProperty ToggleButtonIsSelectedSVGImageProperty = DependencyProperty.RegisterAttached(
            "ToggleButtonIsSelectedSVGImage", typeof(Uri), typeof(MyButtonProperties), new PropertyMetadata(null));

        public static void SetToggleButtonIsSelectedSVGImage(DependencyObject element, Uri value)
            => element.SetValue(ToggleButtonIsSelectedSVGImageProperty, value);

        public static Uri GetToggleButtonIsSelectedSVGImage(DependencyObject element)
            => (Uri)element.GetValue(ToggleButtonIsSelectedSVGImageProperty);

        public static readonly DependencyProperty CheckedButtonImageProperty = DependencyProperty.RegisterAttached(
            "CheckedButtonImage", typeof(ImageSource), typeof(MyButtonProperties), new PropertyMetadata(null));

        public static void SetCheckedButtonImage(DependencyObject element, ImageSource value)
            => element.SetValue(CheckedButtonImageProperty, value);

        public static ImageSource GetCheckedButtonImage(DependencyObject element)
            => (ImageSource)element.GetValue(CheckedButtonImageProperty);

        public static readonly DependencyProperty PressedButtonImageProperty = DependencyProperty.RegisterAttached(
            "PressedButtonImage", typeof(ImageSource), typeof(MyButtonProperties), new PropertyMetadata(null));

        public static void SetPressedButtonImage(DependencyObject element, ImageSource value)
            => element.SetValue(PressedButtonImageProperty, value);

        public static ImageSource GetPressedButtonImage(DependencyObject element)
            => (ImageSource)element.GetValue(PressedButtonImageProperty);

        public static readonly DependencyProperty ButtonTextProperty = DependencyProperty.RegisterAttached(
            "ButtonText", typeof(string), typeof(MyButtonProperties), new PropertyMetadata("Text..."));

        public static void SetButtonText(DependencyObject element, string value)
            => element.SetValue(ButtonTextProperty, value);

        public static string GetButtonText(DependencyObject element)
            => (string)element.GetValue(ButtonTextProperty);
    }
}
