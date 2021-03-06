﻿// Copyright (c) 2013 Ronald Valkenburg
// This software is licensed under the MIT License (see LICENSE file for details)
using System;
using System.Windows.Input;

namespace NDragDrop
{
    public class DelegateCommand<T> : ICommand
    {
        private readonly Action<T> _execute;

        public event EventHandler CanExecuteChanged
        {
            add { }
            remove { }
        }

        public DelegateCommand(Action<T> execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute((T)parameter);
        }
    }
}
