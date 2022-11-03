﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersClassLibrary.Controllers;
using UsersClassLibrary.Models;

namespace UsersWpf.ViewModels
{
    internal class UsersViewModel : BaseViewModel
    {
		private string _filtraNome;

		public string FiltraNome
		{
			get { return _filtraNome; }
			set { _filtraNome = value; NotifyPropertyChanged("FiltraNome"); }
		}

		private List<string> _listaSessi;

		public List<string> ListaSessi
		{
			get { return _listaSessi; }
			set { _listaSessi = value; NotifyPropertyChanged("ListaSessi"); }
		}

		private string _filtraSesso;

		public string FiltraSesso
		{
			get { return _filtraSesso; }
			set { _filtraSesso = value; NotifyPropertyChanged("FiltraSesso"); }
		}

		private List<User> _datiUtenti;

		public List<User> DatiUtenti
		{
			get { return _datiUtenti; }
			set { _datiUtenti = value; NotifyPropertyChanged("DatiUtenti"); }
		}

		public UsersViewModel()
		{
			ListaSessi = Users.GetGenders();
			DatiUtenti = Users.GetAll();
		}

	}
}
