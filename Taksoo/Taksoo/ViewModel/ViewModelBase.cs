using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Taksoo.ViewModel
{
    public interface IEntityViewModelBase
    {
        Guid Id { get; set; }
        bool IsBusy { get; set; }
        List<string> ErrorMsgs { get; set; }
    }
    public abstract class EntityViewModelBase : INotifyPropertyChanged, IEntityViewModelBase
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public Guid Id { get; set; }

        public bool IsBusy { get; set; }

        public List<string> ErrorMsgs { get; set; }
        
        public EntityViewModelBase()
        {
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
