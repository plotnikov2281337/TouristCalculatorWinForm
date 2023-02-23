using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouristCalculatorWinForm.Data;

namespace TouristCalculatorWinForm.Data
{
     
    internal class CalculateFunction
    {
        static List<City> cities = new List<City>();
        static public City departureCity = new City();
        static List<City> citiesToVisit = new List<City>();
        static public DB db = new DB(_cities: cities);
        static public double tripCost {get; set;}
        static public double totalCost = 0;

        static public double calculateFunction()
        {
            double sum = 0;
            foreach (var city in citiesToVisit)
            {
                db.initial();
                bool isFromEU = !(departureCity.Name == "Мадрид" || departureCity.Name == "Кишинёв" || departureCity.Name == "Лондон");

                if (departureCity.Name == "Мадрид")
                {
                    sum += db.city3.Transit;
                }
                if (departureCity.Name == "Кишинёв")
                {
                    sum += db.city11.Transit;
                }
                if (departureCity.Name == "Лондон")
                {
                    sum += db.city5.Transit;
                }
                if (departureCity.Name == "Рига")
                {
                    sum += db.city8.Transit;
                }
                if (city.Name == "Ватикан")
                {
                    sum += totalCost * 1.5;
                }
                if (city.Name == "Берлин")
                {
                    sum += city.Transit * 1.13;
                }
                if (city.Name == "Палермо")
                {
                    if (departureCity == db.city5)
                        sum += city.Transit * 1.07;
                    if (departureCity == db.city9)
                        sum += city.Transit * 1.11;
                }
                if (city.Name == "Рига" && departureCity == db.city3)
                {
                    sum += city.Transit * 1.09;
                }
                if (city.Name == "Палермо")
                {
                    sum += db.city1.Transit + db.city8.Transit;
                }
                if (!isFromEU)
                {
                    sum += city.Transit * 1.04;
                }
                else
                {
                    sum += city.Transit;
                }
                departureCity = city;
            }
            return sum;
        }

        static public City getCity(String text, Form form, Form nextForm)
        {
            City someCity = new City();
            foreach (var city in cities)
            {

                if (city.Name == text) { 
                    someCity = city;
                    form.Close();
                    nextForm.Show();
                }
            }
            if(someCity.Name == new City().Name)
            {
                form.Close();
                MessageBox.Show("Вы ввели неверный город. Запустите программу заново!", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Information);
                departureCity = new City();
                cities = new List<City>();
            }
            return someCity;
        }

        static public void addCity(String text, Form form, Form nextForm)
        {
            if(text == "")
            {
                GetTripCost form2 = new GetTripCost();
                form.Close();
                form2.Show();
            } else
            {
                City city = getCity(text, form, nextForm);
                citiesToVisit.Add(city);
            }
            
        }
    }
    
    
}

