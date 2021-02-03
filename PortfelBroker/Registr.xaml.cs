/*
 * Сделано в SharpDevelop.
 * Пользователь: ROMA
 * Дата: 12/26/2017
 * Время: 22:42
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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
	/// Interaction logic for Registr.xaml
	/// </summary>
	public partial class Registr : Window
	{
		public Registr()
		{
			InitializeComponent();
		}
		

		
		void Vhod_Click(object sender, RoutedEventArgs e)
		{
			int i=0;
			bool bl=false;
			foreach (var el in Window1.Useri) 
			{
				if (txtlog.Text==el.Login && txtpas.Text==el.Password) 
				{
					bl=true;
					Window1.Maney=el.Maney;
					Window1.portf=el.port;
					Window1.histor=el.hist;
					Window1.num=i;
					this.Close();
				}
				i++;
			}
			if (!bl) 
			{
				MessageBox.Show("Вход не выполнен!");
			}
			
		}
		
		void Reg_Click(object sender, RoutedEventArgs e)
		{
			if (txtlog.Text!=""&&txtpas.Text!="") 
			{
			int i=0;
			bool bo=false;
				foreach (var el in Window1.Useri) 
				{
					if (txtlog.Text==el.Login) 
					{
						MessageBox.Show("пользователь существует!");
						bo=true;
					}
					i++;
				}
				if (!bo) 
				{
					Window1.Useri.Add(new Polzovatel(txtlog.Text,txtpas.Text));
					MessageBox.Show("Прошла регистрация!");
				}
			}
			else
			{
				MessageBox.Show("Введите логин и пароль!");
			}
		}
		
		void window1_Closed(object sender, EventArgs e)
		{
			BinaryFormatter binar = new BinaryFormatter();
			FileStream file = new FileStream("Polzovatel.bin",FileMode.Create);
			binar.Serialize(file,Window1.Useri);
			file.Close();
		}

        private void txtpas_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}