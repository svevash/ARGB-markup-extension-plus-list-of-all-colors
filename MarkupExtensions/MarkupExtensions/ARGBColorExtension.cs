using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MarkupExtensions
{
    public class ARGBColorExtension : IMarkupExtension<Color>
    {
        public double R { set; get; }

        public double G { set; get; }

        public double B { set; get; }

        public double A { set; get; } = 1.0;

        public Color ProvideValue(IServiceProvider serviceProvider)
        {
            return Color.FromRgba(R, G, B, A);
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return (this as IMarkupExtension<Color>).ProvideValue(serviceProvider);
        }
    }
}
