﻿using System;
using System.Windows.Input;

namespace GoToWindow.Commands
{
	public class ShowSettingsCommand : ICommand
	{
#pragma warning disable 67
		public event EventHandler CanExecuteChanged;
#pragma warning restore 67

		private readonly IGoToWindowContext _context;

		public ShowSettingsCommand(IGoToWindowContext context)
		{
			_context = context;
		}

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			_context.ShowSettings();
		}
	}
}
