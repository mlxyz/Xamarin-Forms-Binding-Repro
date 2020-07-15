using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ReproProjectBindingIssue.ViewModels
{
    public class ControlViewModel
    {
        private Vector3 _test;

        public Vector3 Test
        {
            get => _test;
            set => _test = value; //only gets the default value from GenericControl (4,5,6), but *not* the default values from GenericPage
        }
    }
}