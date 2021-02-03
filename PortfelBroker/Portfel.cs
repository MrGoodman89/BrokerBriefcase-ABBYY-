
using System;

namespace PortfelBroker
{
	/// <summary>
	/// Description of Portfel.
	/// </summary>
	[Serializable]
	public class Portfel
	{
		public Portfel(int nomer,string name,double cena1,double cena9 ,int coll)
		{
			this.nomer=nomer;
			this.name=name;
			this.cena1=cena1;
            this.cena9 = cena9;
			this.coll=coll;
			this.time=DateTime.Now;
		}
		public  int nomer{get;set;}
		public string name{get;set;}
		public double cena1{get;set;}
        public double cena9 { get; set; }
        public int coll{get;set;}
		public DateTime time{get;set;}
	}
}
