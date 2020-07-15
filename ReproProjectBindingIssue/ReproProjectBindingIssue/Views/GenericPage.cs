using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Xamarin.Forms;

namespace ReproProjectBindingIssue.Views
{
    public class GenericPage : ContentPage
    {
        public static readonly BindableProperty TestProperty =
            BindableProperty.Create(nameof(Test), typeof(Vector3), typeof(GenericPage), new Vector3(1, 2, 3));

        public Vector3 Test
        {
            get => (Vector3)GetValue(TestProperty);
            set => SetValue(TestProperty, value);
        }
    }
}