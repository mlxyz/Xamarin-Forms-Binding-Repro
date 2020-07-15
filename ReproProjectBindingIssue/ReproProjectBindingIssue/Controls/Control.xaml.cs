using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ReproProjectBindingIssue.ViewModels;
using ReproProjectBindingIssue.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReproProjectBindingIssue.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Control : GenericControl
    {
        public Control()
        {
            InitializeComponent();
        }
    }
}