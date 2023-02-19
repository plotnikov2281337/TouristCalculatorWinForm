﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristCalculatorWinForm.Data
{
    internal class DB
    {
        private List<City> cities { get; set; }
        public DB(List<City> _cities)
        {
            cities = _cities;
        }
        public void initial()
        {
            city1.Name = "Берлин";
            city1.Price = 399;
            city1.Transit = 175;
            cities.Add(city1);

            city2.Name = "Прага";
            city2.Price = 300;
            city2.Transit = 270;
            cities.Add(city2);

            city3.Name = "Париж";
            city3.Price = 350;
            city3.Transit = 220;
            cities.Add(city3);

            city4.Name = "Рига";
            city4.Price = 250;
            city4.Transit = 170;
            cities.Add(city4);

            city5.Name = "Лондон";
            city5.Price = 390;
            city5.Transit = 270;
            cities.Add(city5);

            city6.Name = "Ватикан";
            city6.Price = 500;
            city6.Transit = 350;
            cities.Add(city6);

            city7.Name = "Палермо";
            city7.Price = 230;
            city7.Transit = 150;
            cities.Add(city7);

            city8.Name = "Варшава";
            city8.Price = 300;
            city8.Transit = 190;
            cities.Add(city8);

            city9.Name = "Кишинёв";
            city9.Price = 215;
            city9.Transit = 110;
            cities.Add(city9);

            city10.Name = "Мадрид";
            city10.Price = 260;
            city10.Transit = 190;
            cities.Add(city10);

            city11.Name = "Будапешт";
            city11.Price = 269;
            city11.Transit = 230;
            cities.Add(city11);
        }
        public City city1 = new City();
        public City city2 = new City();
        public City city3 = new City();
        public City city4 = new City();
        public City city5 = new City();
        public City city6 = new City();
        public City city7 = new City();
        public City city8 = new City();
        public City city9 = new City();
        public City city10 = new City();
        public City city11 = new City();
    }
}
