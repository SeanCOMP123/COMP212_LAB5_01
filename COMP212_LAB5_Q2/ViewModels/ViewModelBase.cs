using COMP212_LAB5_Q2.Serivces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BookLibrary;
using BookLibrary.Models;

namespace COMP212_LAB5_Q2.ViewModels
{
    class ViewModelBase:INotifyPropertyChanged
    {
        protected virtual void SetProperty<T>(ref T member, T val, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(member, val)) return;
            member = val;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        protected IBookRepository _bookrepo;
        protected IAuthorRepository _authorrepo;

        public ViewModelBase() 
        {
            _bookrepo = new BookRespository();
            _authorrepo = new AuthorRepository();
        }
        private ObservableCollection<Titles> _titles;
        private ObservableCollection<Authors> _authors;

        public ObservableCollection<Titles> Titles 
        {
            get { return _titles; }
            set { SetProperty(ref _titles, value); }
        }
        public ObservableCollection<Authors> Authors
        {
            get { return _authors; }
            set { SetProperty(ref _authors, value); }
        }
    }
}
