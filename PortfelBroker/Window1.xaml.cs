/*
 *
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace PortfelBroker
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public static int num;
		public static double Maney=-1;
		public static int nomerStr;
		public static int nomerPort;
		public static ObservableCollection<Magazin> magazin=new ObservableCollection<Magazin>();
		public static ObservableCollection<History> histor=new ObservableCollection<History>();
		//public static ObservableCollection<Portfel> portf=new ObservableCollection<Portfel>();
		public static Collection<Polzovatel> Useri = new Collection<Polzovatel>();
        public static Collection<Portfel> portf;
        public Window1()
		{
			InitializeComponent();
			time();
			zagr();
			Registr reg = new Registr();
			reg.ShowDialog();
			if (Maney==-1)
            {
				Environment.Exit(0);
			}
            portf = Useri[num].port;
            historyData.ItemsSource=histor;
			magazinData.ItemsSource=magazin;
			portfelData.ItemsSource=portf;
			Scettext.Text=""+Maney;
			Logintext.Text=" "+Useri[num].Login;
		}


		
		void Refresh_Click(object sender, RoutedEventArgs e)
		{
            int i = 1;     
            Random rnd = new Random();
			magazin.Clear();
			magazin.Add(new Magazin(i,"ВТБ",rnd.Next(100,150),rnd.Next(10,100)));
            i++;
            magazin.Add(new Magazin(i, "Сбер", rnd.Next(100, 150), rnd.Next(10, 100)));
            i++;
            magazin.Add(new Magazin(i, "Тинькоф", rnd.Next(100, 150), rnd.Next(10, 100)));
            i++;
            magazin.Add(new Magazin(i, "ВТБ24", rnd.Next(100, 150), rnd.Next(10, 100)));
            i++;
            magazin.Add(new Magazin(i, "Рокетбанк", rnd.Next(100, 150), rnd.Next(10, 100)));
            i++;
            magazin.Add(new Magazin(i, "Газпром", rnd.Next(100, 150), rnd.Next(10, 100)));
            i++;
            magazin.Add(new Magazin(i, "Роснефть", rnd.Next(100, 150), rnd.Next(10, 100)));
            i++;
            magazin.Add(new Magazin(i, "СельхозБанк", rnd.Next(100, 150), rnd.Next(10, 100)));
            i++;
            magazin.Add(new Magazin(i, "Альфа-Банк", rnd.Next(100, 150), rnd.Next(10, 100)));
            i++;
            magazin.Add(new Magazin(i, "Почта Банк", rnd.Next(100, 150), rnd.Next(10, 100)));           
            magazinData.Items.Refresh();
		}
		
		void Scet_Click(object sender, RoutedEventArgs e)
		{
			Bankomat ban = new Bankomat();
			ban.ShowDialog();
			Scettext.Text=""+Maney;
		}
		
		void Pokypka_Click(object sender, RoutedEventArgs e)
		{
			if (magazinData.SelectedIndex!=-1) 
			{
				nomerStr = magazinData.SelectedIndex;
				Pocup po= new Pocup();
				po.ShowDialog();
                //if (portf.Count > 5)
                //{
                //    for (int i = 0; i < portf.Count; i++)
                //    {
                //        if (portf[i].name == portf[i + 1].name && portf[i].cena1 < portf[i + 1].cena1)
                //        {
                //            portf.RemoveAt(i);
                //        }
                //    }
                //}
                Scettext.Text=""+Maney;
				magazinData.Items.Refresh();
			}
			else
			{
				MessageBox.Show("Выберите какую акцию покупать.");
			}
		}
		
		void Prodazha_Click(object sender, RoutedEventArgs e)
		{
			if (portfelData.SelectedIndex!=-1) 
			{
				nomerPort = portfelData.SelectedIndex;
				foreach (var el in magazin) 
				{
					if (el.name==portf[nomerPort].name) 
					{
						nomerStr=el.nomer-1;
					}
				}
				Prod pr = new Prod();
                pr.ShowDialog();
                for (int i = 0; i < portf.Count; i++)
                {
                    if (portf[i].coll == 0)
                    {
                        portf.RemoveAt(i);
                    }
                }
                Scettext.Text=""+Maney;
				magazinData.Items.Refresh();
				portfelData.Items.Refresh();
			}
			else
			{
				MessageBox.Show("Выберите какую акцию породать. Не ошибайтесь.");
			}
			
		}
		public void time()
		{
			DispatcherTimer time= new DispatcherTimer();
			time.Interval=TimeSpan.FromSeconds(1);
			time.Tick+=SobitTime;
			time.Start();
		}
		private void SobitTime(Object source, EventArgs e)
		{
			texttime.Text=""+DateTime.Now;
		}
		public void zagr()
		{
			if (File.Exists("Polzovatel.bin")) 
			{
				BinaryFormatter binar = new BinaryFormatter();
				FileStream file = new FileStream("Polzovatel.bin",FileMode.Open);
				Useri = (ObservableCollection<Polzovatel>)binar.Deserialize(file);
				file.Close();
			}
			else
			{
				Useri= new ObservableCollection<Polzovatel>();
			}
		}
		
		void window1_Closed(object sender, EventArgs e)
		{
			Useri[num].Maney=Maney;
			BinaryFormatter binar = new BinaryFormatter();
			FileStream file = new FileStream("Polzovatel.bin",FileMode.Create);
			binar.Serialize(file,Useri);
			file.Close();
		}

        private void magazinData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}