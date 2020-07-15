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
            set => _test = value;
        }
    }
}