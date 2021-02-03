/*
 * Сделано в SharpDevelop.
 * Пользователь: ROMA
 * Дата: 12/25/2017
 * Время: 09:04
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;

namespace PortfelBroker
{
	/// <summary>
	/// Description of History.
	/// </summary>
	[Serializable]
	public class History
	{
		public History(int nomer,string name,double cena1,double cena9,int coll, string deist)
		{
			this.nomer=nomer;
			this.name=name;
			this.cena1=cena1;
			this.coll=coll;
			this.cena9=cena9;
			this.deist=deist;
			this.time=DateTime.Now;
		}
		public int nomer{get;set;}
		public string name{get;set;}
		public double cena1{get;set;}
		public int coll{get;set;}
		public double cena9{get;set;}
		public  string deist{get;set;}
		public DateTime time{get;set;}
	}
}
