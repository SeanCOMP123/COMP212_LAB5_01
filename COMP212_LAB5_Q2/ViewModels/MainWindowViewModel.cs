using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP212_LAB5_Q2.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _CurrentViewModel;

        ListBookViewModel _listBookView = new ListBookViewModel();
        AddBookViewModel _addBookView = new AddBookViewModel();

        public ViewModelBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }
        }

        public DelegateCommand View1Command { get; set; }
        public DelegateCommand View2Command { get; set; }
        public DelegateCommand ExitCommand { get; set; }

        public MainWindowViewModel()
        {
            View1Command = new DelegateCommand(ShowListView);
            View2Command = new DelegateCommand(ShowAddView);
            ExitCommand = new DelegateCommand(ExitApp);
        }
        private void ShowListView() 
        {
            CurrentViewModel = _listBookView;
            CurrentViewModel.LoadBook();
        }
        private void ShowAddView() 
        {
            CurrentViewModel = _addBookView;
            CurrentViewModel.Add
        }
        private void ExitApp() 
        { 
            
        }


    }
}
