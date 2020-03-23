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
using System.Windows.Shapes;
using System.Windows.Threading;
namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
		}

	
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			DispatcherTimer timer = new DispatcherTimer();
			timer.Start();
			timer.Interval = TimeSpan.FromSeconds(1);
			timer.Tick += Time_click;
			
		}

		private void Quit(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void Time_click(object sender, EventArgs e)
		{
			Timelbl.Content = DateTime.Now.ToLongTimeString();
			Datelbl.Content = DateTime.Now.ToLongDateString();
		}

	}
}
