using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;

namespace MarkupExtensions
{
    public partial class ArrayDemoPage : ContentPage
    {
        readonly ColorTypeConverter converter = new ColorTypeConverter();
        public ArrayDemoPage()
        {
            InitializeComponent();
            var tt = new Dictionary<String, Color>();
            
            foreach (var field in typeof(Color).GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                if (field != null && !String.IsNullOrEmpty(field.Name))
                    tt[field.Name] = (Color)(converter.ConvertFromInvariantString(field.Name));
            }
            rrr.ItemsSource = tt;
        }
    }
}