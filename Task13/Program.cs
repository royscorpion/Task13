using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    //Задача на моделирование объектов реального мира при помощи классов.

    // Проверка работоспособности
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("ул. Герцена, д. 72, кв.21", 72, 36, 36);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("ул. Республики, д. 59, оф.517", 108, 18, 25, 7);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }

    //Базовый класс Building, описывающий здание (родительский)
    class Building
    {
        //Свойства здания: адрес, длина, ширина, высота
        public string BuildingAddress { get; set; }
        public double BuildingLength { get; set; }
        public double BuildingWidth { get; set; }
        public double BuildingHeight { get; set; }

        //Конструктор с 4 параметрами
        public Building(string buildingAddress, double buildingLength, double buildingWidth, double buildingHeight)
        {
            BuildingAddress = buildingAddress;
            BuildingLength = buildingLength;
            BuildingWidth = buildingWidth;
            BuildingHeight = buildingHeight;
        }

        //Метод вывода информации о здании
        public string Print()
        {
            return ("\nАдрес: " + BuildingAddress + "\nРазмеры здания (ДхШхВ): " + Convert.ToString(BuildingLength) + "x" + BuildingWidth + "x" + BuildingHeight);
        }
    }

    //Производный класс MultiBuilding от родительского класса Building. Без прав унаследования
    sealed class MultiBuilding : Building
    {
        //Расширенные свойства здания: этажность
        public double BuildingLevels { get; set; }

        //Конструктор с 5 параметрами, включая 4 из базового класса
        public MultiBuilding(string buildingAddress, double buildingLength, double buildingWidth, double buildingHeight, double buildingLevels)
            : base(buildingAddress, buildingLength, buildingWidth, buildingHeight)
        {
            BuildingAddress = buildingAddress;
            BuildingLength = buildingLength;
            BuildingWidth = buildingWidth;
            BuildingHeight = buildingHeight;
            BuildingLevels = buildingLevels;
        }

        //Метод вывода расширенной информации о здании, включая информацию базового класса
        public new string Print()
        {
            return (base.Print() + "\nЭтажность: " + Convert.ToString(BuildingLevels));
        }
    }

    #region Проверка запрета унаследования класса MultiBuilding
    /*
    class NowBuilding : MultiBuilding
    {

    }
    */
    #endregion
}
