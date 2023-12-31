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

namespace WPFDemo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			/*
			// Button using code behind
			Grid grid = new Grid();

			this.Content = grid;

			Button btn = new Button();
			btn.Content = "Button code behind";
			btn.Width = 200;
			btn.Height = 200;
			btn.Background = Brushes.Blue;

			WrapPanel wrapPanel = new WrapPanel();
			TextBlock textBlock = new TextBlock();
			textBlock.Text = "I am a text block";
			textBlock.Background = Brushes.Red;

			wrapPanel.Children.Add(textBlock); // Add TextBlock to Wrap Panel
			btn.Content = wrapPanel;

			grid.Children.Add(btn); // Add button to grid
			*/


		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
            Console.WriteLine("Button pressed!");
        }

		/*private void Panel_Click(object sender, RoutedEventArgs e)
		{
            Console.WriteLine("Panel pressed");
        }*/

		private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			Console.WriteLine("Panel pressed");
		}
	}
}
