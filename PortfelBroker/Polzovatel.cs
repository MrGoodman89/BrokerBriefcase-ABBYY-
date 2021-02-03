/*
 * Сделано в SharpDevelop.
 * Пользователь: ROMA
 * Дата: 12/26/2017
 * Время: 22:33
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.ObjectModel;

namespace PortfelBroker
{
	/// <summary>
	/// Description of Polzovatel.
	/// </summary>
	[Serializable]
	public class Polzovatel
	{
		public Polzovatel(string log, string pas)
		{
			Login=log;
			Password=pas;
			Maney=0;
			port= new ObservableCollection<Portfel>();
			hist= new ObservableCollection<History>();
		}
		public string Login{get;set;}
		public string Password{get;set;}
		public double Maney{get;set;}
		public ObservableCollection<Portfel> port;
		public ObservableCollection<History> hist;
	}
}
