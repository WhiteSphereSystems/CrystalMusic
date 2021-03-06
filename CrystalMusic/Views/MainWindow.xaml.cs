﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


//Please change the namespace (default is CrystalMusic)
namespace CrystalMusic.Views
{
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window
	{
		ViewModels.MainViewModel ViewModel = new ViewModels.MainViewModel();
		public MainWindow()
		{
			InitializeComponent();
			this.ViewModel.Initialize(this);
			this.DataContext = this.ViewModel;
		}
	}
}
