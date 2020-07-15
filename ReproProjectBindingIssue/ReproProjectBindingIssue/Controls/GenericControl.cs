using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using ReproProjectBindingIssue.Views;
using Xamarin.Forms;

namespace ReproProjectBindingIssue.Controls
{
    public class GenericControl : ContentView
    {
        public static readonly BindableProperty TestProperty =
            BindableProperty.Create(nameof(Test), typeof(Vector3), typeof(GenericControl), new Vector3(4, 5, 6), propertyChanged: PropertyChanged);

        public Vector3 Test
        {
            get => (Vector3)GetValue(TestProperty);
            set => SetValue(TestProperty, value);
        }

        private static void PropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            System.Diagnostics.Debug.WriteLine("property changed"); //gets the default values from GenericPage (1,2,3) as expected
            var control = bindable as Control;
            Vector3 value = (Vector3)newvalue;
            control.label.Text = "Modified directly (no binding) -> X:" + value.X + " Y:" + value.Y + " Z:" + value.Z;
        }
    }
}