using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ReproProjectBindingIssue.Views
{
    public class GenericPage : ContentPage
    {
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(GenericPage));

        public static readonly BindableProperty TestProperty =
            BindableProperty.Create(nameof(Test), typeof(Vector3), typeof(GenericPage), new Vector3(1, 2, 3));

        public GenericPage()
        {
            var random = new Random();
            Command = new Command(() => Test = new Vector3(random.Next(1000), random.Next(1000), random.Next(1000)));
        }

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public Vector3 Test
        {
            get => (Vector3)GetValue(TestProperty);
            set => SetValue(TestProperty, value);
        }
    }
}