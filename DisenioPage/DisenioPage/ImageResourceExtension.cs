﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using Xamarin.Forms.Internals;


namespace DisenioPage
{
    [Preserve(AllMembers = true)]
    [ContentProperty(nameof(Source))]
    class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;

            // Do your translation lookup here, using whatever method you require
            var imageSource = ImageSource.FromResource(Source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);

            return imageSource;
        }

    }
}
