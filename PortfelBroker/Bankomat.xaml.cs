/*
 * Сделано в SharpDevelop.
 * Пользователь: ROMA
 * Дата: 12/25/2017
 * Время: 09:35
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace PortfelBroker
{
	/// <summary>
	/// Interaction logic for Bankomat.xaml
	/// </summary>
	public partial class Bankomat : Window
	{
		public Bankomat()
		{
			InitializeComponent();
		}
		
		void Vvod_Click(object sender, RoutedEventArgs e)
		{
			double maney;
			if (double.TryParse(textbox.Text,out maney)) 
			{
				if (maney>=0) 
				{
					Window1.Maney+=maney;
					this.Close();
				}
				else
				{
					MessageBox.Show("Деньги не могут быть отрицательными!","Ошибка");
				}
			}
			else
			{
				MessageBox.Show("Ошибка ввода!","Ошибка");
			}
		}
		
		void Vivod_Click(object sender, RoutedEventArgs e)
		{
			double maney;
			if (double.TryParse(textbox.Text,out maney)) 
			{
				if (maney>=0 && maney<=Window1.Maney) 
				{
					Window1.Maney-=maney;
					this.Close();
				}
				else
				{
					MessageBox.Show("Недостаточно средств!","Ошибка");
				}
			}
			else
			{
				MessageBox.Show("Ошибка ввода!","Ошибка");
			}
		}
	}
}