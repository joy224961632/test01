#region 組件 PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\PresentationCore.dll
#endregion

using System.ComponentModel;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using System.Windows.Media.Composition;

namespace System.Windows.Media
{
    //
    // 摘要:
    //     Represents a object type that has a width, height, and System.Windows.Media.ImageMetadata
    //     such as a System.Windows.Media.Imaging.BitmapSource and a System.Windows.Media.DrawingImage.
    //     This is an abstract class.
    [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
    [TypeConverter(typeof(ImageSourceConverter))]
    [ValueSerializer(typeof(ImageSourceValueSerializer))]
    public abstract class ImageSource : Animatable, IFormattable, IResource
    {
        //
        // 摘要:
        //     When overridden in a derived class, gets the width of the image in measure units
        //     (96ths of an inch).
        //
        // 傳回:
        //     The width of the image in measure units (96ths of an inch).
        public abstract double Width { get; }
        //
        // 摘要:
        //     When overridden in a derived class, gets the height of the image in measure units
        //     (96ths of an inch).
        //
        // 傳回:
        //     The height of the image.
        public abstract double Height { get; }
        //
        // 摘要:
        //     When overridden in a derived class, gets the System.Windows.Media.ImageMetadata
        //     associated with the image.
        //
        // 傳回:
        //     The metadata associated with the image.
        public abstract ImageMetadata Metadata { get; }

        //
        // 摘要:
        //     Converts pixels to DIPs in a way that is consistent with MIL.
        //
        // 參數:
        //   dpi:
        //     Width of the bitmap, in dots per inch.
        //
        //   pixels:
        //     Width of the bitmap, in pixels.
        //
        // 傳回:
        //     The natural size of the bitmap in MIL Device Independent Pixels (DIPs, or 1/96").
        protected static double PixelsToDIPs(double dpi, int pixels);
        //
        // 摘要:
        //     Creates a modifiable clone of this System.Windows.Media.ImageSource, making deep
        //     copies of this object's values. When copying dependency properties, this method
        //     copies resource references and data bindings (but they might no longer resolve)
        //     but not animations or their current values.
        //
        // 傳回:
        //     A modifiable clone of the current object. The cloned object's System.Windows.Freezable.IsFrozen
        //     property will be false even if the source's System.Windows.Freezable.IsFrozen
        //     property was true.
        public ImageSource Clone();
        //
        // 摘要:
        //     Creates a modifiable clone of this System.Windows.Media.ImageSource object, making
        //     deep copies of this object's current values. Resource references, data bindings,
        //     and animations are not copied, but their current values are.
        //
        // 傳回:
        //     A modifiable clone of the current object. The cloned object's System.Windows.Freezable.IsFrozen
        //     property will be false even if the source's System.Windows.Freezable.IsFrozen
        //     property was true.
        public ImageSource CloneCurrentValue();
        //
        // 摘要:
        //     Creates a string representation of this object based on the current culture.
        //
        // 傳回:
        //     A string representation of this object.
        public override string ToString();
        //
        // 摘要:
        //     Creates a string representation of this object based on the System.IFormatProvider
        //     passed in. If the provider is null, the System.Globalization.CultureInfo.CurrentCulture
        //     is used.
        //
        // 參數:
        //   provider:
        //     An System.IFormatProvider that supplies culture-specific formatting information.
        //
        // 傳回:
        //     A string representation of this object.
        public string ToString(IFormatProvider provider);
    }
}