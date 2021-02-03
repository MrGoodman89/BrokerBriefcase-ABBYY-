/*
 * Сделано в SharpDevelop.
 * Пользователь: ROMA
 * Дата: 12/25/2017
 * Время: 08:59
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;

namespace PortfelBroker
{
	/// <summary>
	/// Description of Magazin.
	/// </summary>
	public class Magazin
	{
		public Magazin(int nomer,string name, double cena1, int coll)
		{
			this.nomer=nomer;
			this.name=name;
			this.cena1=cena1;
			this.coll=coll;
		}
		public int nomer{get;set;}
		public string name{get;set;}
		public  double cena1{get;set;}
		public int coll{get;set;}
	}
}
