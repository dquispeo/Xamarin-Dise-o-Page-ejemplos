﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DisenioPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditorCode : ContentPage
    {
        public EditorCode()
        {
            InitializeComponent();

            StackLayout stack = new StackLayout();
            var MyEditor = new Editor { Text = "I am an Editor" };
            stack.Children.Add(MyEditor);
            Content = stack;

        }
    }
}