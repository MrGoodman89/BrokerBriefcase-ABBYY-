/*
 * Сделано в SharpDevelop.
 * Пользователь: ROMA
 * Дата: 12/26/2017
 * Время: 19:25
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
    /// Interaction logic for Pocup.xaml
    /// </summary>
    public partial class Pocup : Window
    {
        public Pocup()
        {
            InitializeComponent();
            
            name.Text = "Название компании:   " + Window1.magazin[Window1.nomerStr].name;
            coll.Text = "Количестов акци:   " + Window1.magazin[Window1.nomerStr].coll;
            cena.Text = "Стоимость 1 акции:   " + Window1.magazin[Window1.nomerStr].cena1;

        }

        void poc_Click(object sender, RoutedEventArgs e)
        {
            
            int count;
            //if (Window1.portf.Count==-1) //&& Window1.magazin[Window1.nomerStr].name != Window1.portf[Window1.nomerStr].name
            //{
                if (textbox.Text != "")
                {
                    if (int.TryParse(textbox.Text, out count))
                    {
                        if (count > 0)
                        {
                            if (count <= Window1.magazin[Window1.nomerStr].coll && count * Window1.magazin[Window1.nomerStr].cena1 < Window1.Maney)
                            {
                              
                                Window1.Maney -= Window1.magazin[Window1.nomerStr].cena1 * count;
                                Window1.magazin[Window1.nomerStr].coll -= count;
                            bool isNew = true;
                            Portfel superP = null;
                            //Window1.portf.GetEnumerator()
                                foreach(Portfel p in Window1.portf)
                            { 
                                if(p.name== Window1.magazin[Window1.nomerStr].name)
                                {
                                    isNew = false;
                                    superP = p;
                                    //p.cena1 = (p.cena1 * p.coll + Window1.magazin[Window1.nomerStr].cena1 * count) / (p.coll + count);
                                    //p.coll += count;
                                }

                            }
                            if (isNew)
                            {
                                Window1.portf.Insert(0, new Portfel(Window1.portf.Count + 1, Window1.magazin[Window1.nomerStr].name, Window1.magazin[Window1.nomerStr].cena1,count
                                                           ,count));
                                Window1.histor.Insert(0, new History(Window1.histor.Count + 1, Window1.magazin[Window1.nomerStr].name, Window1.magazin[Window1.nomerStr].cena1,
                                                                       Window1.magazin[Window1.nomerStr].cena1 * count, count, "Купили"));

                            }
                            else
                            {
                                //Portfel fakeP = new Portfel(Window1.portf.Count + 1, "fake", 0.0, 1);
                                //Window1.portf.Add(fakeP);
                                Window1.portf.Remove(superP);
                                
                                superP.cena1 = (superP.cena1 * superP.coll + Window1.magazin[Window1.nomerStr].cena1 * count) / (superP.coll + count);
                                superP.cena1= Math.Round(superP.cena1, 2);
                                //superP.cena1 = string.Format("{0:0.##}", superP.cena1);
                                superP.coll += count;
                                Window1.portf.Add(superP);
                                Window1.histor.Insert(0, new History(Window1.histor.Count + 1, Window1.magazin[Window1.nomerStr].name, Window1.magazin[Window1.nomerStr].cena1,
                                                                      Window1.magazin[Window1.nomerStr].cena1 * count, count, "Купили"));

                            }
                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("Вы ошиблись, вы хотите купить акций больше чем есть в магазине\nили у вас не достаточно средств");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Вы ошиблись, введите целое не отрицательное число");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы ошиблись, введите целое не отрицательное число");
                    }
                }
           //}
           
        }


        void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int count;
            if (int.TryParse(textbox.Text, out count))
            {
                if (count > 0)
                {
                    cena9.Text = ""+ (Window1.magazin[Window1.nomerStr].cena1 * count);
                }
            }
        }
        //void group(object sender, TextChangedEventArgs e)
        //{
        //    int count;
        //    int.TryParse(textbox.Text, out count);
        //    int x = 1;
        //    if (Window1.magazin[Window1.nomerStr].name == Window1.portf[Window1.nomerStr].name)
        //    {
        //        Window1.portf.Remove(new Portfel(Window1.portf.Count + 1, Window1.magazin[Window1.nomerStr].name, Window1.magazin[Window1.nomerStr].cena1,
        //                                               count));
        //        x++;
        //        Window1.portf[Window1.nomerStr].coll += count;
        //        Window1.portf[Window1.nomerStr].cena1 = (Window1.magazin[Window1.nomerStr].cena1 + Window1.portf[Window1.nomerStr].cena1) / x;


        //        //string d= Window1.magazin[Window1.nomerStr].name = Window1.portf[Window1.nomerStr].name;
        //        //i++;
        //        //count += count;
        //        double k = (Window1.magazin[Window1.nomerStr].cena1 + Window1.portf[Window1.nomerStr].cena1) / i;
        //        Window1.portf.Insert(0, new Portfel(Window1.portf.Count, Window1.magazin[Window1.nomerStr].name, k,
        //                               count));
        //    }
        //    else
        //    {
        //        Window1.portf.Insert(0, new Portfel(Window1.portf.Count + 1, Window1.magazin[Window1.nomerStr].name, Window1.magazin[Window1.nomerStr].cena1,
        //                               count));
        //    }

        //}
    }
}