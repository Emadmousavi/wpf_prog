using System;
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
using Microsoft.Win32;


namespace WpfApp1
{
	public class emad
	{
		public static int a=0; 
	}
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		
		public MainWindow()
		{
			InitializeComponent();
		}

		private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var combo = (ComboBox)sender;
			var info = (ComboBoxItem)combo.SelectedValue;
			MessageBox.Show((string)info.Content);

		}

		private void WrapPanel_Click(object sender, RoutedEventArgs e)
		{
			FrameworkElement emad = e.Source as FrameworkElement;
			switch (emad.Name)
			{
				case "Aplly": MessageBox.Show("apply");break;
				case "Restart": MessageBox.Show("reset"); break;
				case "Refresh": MessageBox.Show("refresh"); break;
			}
		}

		private void show_picture(object sender, RoutedEventArgs e)
		{
			OpenFileDialog op = new OpenFileDialog();  
		   op.Title = "Select a picture";  
		   op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +  
		   "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +  
		   "Portable Network Graphic (*.png)|*.png";  
		  if (op.ShowDialog() == true)  
		  {  
			  imgPhoto.Source = new BitmapImage(new Uri(op.FileName));  
		  } 
		}

		private void imgPhoto_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			new Uri("MainWindow.xaml");
		}

		private void Hide(object sender, RoutedEventArgs e)
		{
			imgPhoto.Visibility = Visibility.Hidden;
		}

		private void Refresh(object sender, RoutedEventArgs e)
		{
			checkbox1.IsChecked = checkbox2.IsChecked = checkbox3.IsChecked = checkbox4.IsChecked = checkbox5.IsChecked = checkbox6.IsChecked = checkbox7.IsChecked = checkbox8.IsChecked =
			checkbox9.IsChecked = checkbox10.IsChecked = false;

			Note.Text = null;
		}

		private void Next_page(object sender, RoutedEventArgs e)
		{
			if (tab.SelectedIndex == 1)
				tab.SelectedIndex = 2;
			else
				tab.SelectedIndex = 1;
		}

		private void clock(object sender, RoutedEventArgs e)
		{
			Window1 window1 = new Window1();
			if (emad.a == 0)
			{ 
				window1.Show();
				emad.a = 1;
			}
			

		}

		private void Guide(object sender, RoutedEventArgs e)
		{
			Window2 window2 = new Window2();
			window2.Show();
		}
	}
}
