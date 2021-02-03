/*
 * Сделано в SharpDevelop.
 * Пользователь: ROMA
 * Дата: 12/26/2017
 * Время: 20:32
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
    /// Interaction logic for Prod.xaml
    /// </summary>
    public partial class Prod : Window
    {
        public Prod()
        {
            InitializeComponent();

            coll.Text = "Количество акций:   " + Window1.portf[Window1.nomerPort].coll;
            cenaP.Text = "Стоимость 1 акции в портфеле:   " + Window1.portf[Window1.nomerPort].cena1;
            cenaM.Text = "Стоимость 1 акции в магазине:   " + Window1.magazin[Window1.nomerStr].cena1;

        }
        void prod_Click(object sender, RoutedEventArgs e)
        {
            int count;
            double cenaProd;
            if (textbox.Text != "")
            {
                if (int.TryParse(textbox.Text, out count))
                {
                    if (count > 0)
                    {
                        if (count <= Window1.portf[Window1.nomerPort].coll)
                        {
                            cenaProd = Window1.magazin[Window1.nomerStr].cena1 * count;
                            if (Window1.portf[Window1.nomerPort].cena1 > Window1.magazin[Window1.nomerStr].cena1)
                            {
                                Window1.Maney += cenaProd;
                            }
                            else
                            {
                                Window1.Maney += cenaProd - (Window1.magazin[Window1.nomerStr].cena1 * count - Window1.portf[Window1.nomerPort].cena1 * count) * 0.13;
                            }
                            Window1.portf[Window1.nomerPort].coll -= count;
                            Window1.histor.Insert(0, new History(Window1.histor.Count + 1, Window1.portf[Window1.nomerPort].name, Window1.magazin[Window1.nomerStr].cena1,
                                                               cenaProd, count, "Продажа"));
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Вы ошиблись, вы хотите продать акций больше чем есть в портфеле.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы ошиблись, введите целое не отрицательное число.");

                    }
                }
                else
                {
                    MessageBox.Show("Вы ошиблись, введите целое не отрицательное число.");
                }
            }
        }
        void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int count;
            if (int.TryParse(textbox.Text, out count))
            {
                if (count > 0)
                {
                    cena9.Text = "" + (Window1.portf[Window1.nomerStr].cena1 * count);
                }
            }
        }
    }
}