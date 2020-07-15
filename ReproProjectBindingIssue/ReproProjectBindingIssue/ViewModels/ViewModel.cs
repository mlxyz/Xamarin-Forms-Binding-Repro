using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ReproProjectBindingIssue.Annotations;

namespace ReproProjectBindingIssue.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Vector3 _test;

        public event PropertyChangedEventHandler PropertyChanged;

        public Vector3 Test
        {
            get => _test;
            set
            {
                _test = value;
                OnPropertyChanged();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}