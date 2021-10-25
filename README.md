# SquareCalcLib

### Коротко о проекте

Решение преставляет собой небольшую библиотеку для рассчета площадей различных фигур с Unit-тестами.

### Структура проекта

Решение представляет собой библиотеку классов .NET Core, а также Unit-тесты для проверки работы на примере двух базовых фигур.

Проект **SquareCalcLib** представляет собой саму библиотеку, в ней содержатся классы и интерфейс.

Интерфейс `IShape` представляет собой интерфейс любой фигуры, площадь которой может быть посчитана. 

Фигуры `Triangle` и `Square` представляет собой примеры реализации интерфейса `IShape`. Обе фигуры представляют собой класс, с реализованными методами рассчета площади.

### Как воспользоваться?

#### Создание фигуры

Для того, чтобы создать свою фигуру, например Circle (окружность), площадь которой может быть посчитана необходимо выполнить перечисленные ниже пункты. Также, при создании
фигуры следует учитывать особенности струтктуры проекта и "держать" все фигуры в директории `Shapes`. 

1. Создать новый .cs файл с классом
 ```cs
 public class Circle
 {

 }
 ```
2. Реализовать в классе интерфейс `IShape`
```cs
 public class Circle : IShape
 {
    public double CalculateSquare()
    {
        return 0;
    }
 }
 ```
 3. Добавить необходимые данные для нахождения площади (параметры фигуры)
 ```cs
 public class Circle : IShape
 {
    public double R;
    
    public double CalculateSquare()
    {
        return 0;
    }
 }
 ```
 Желательно сделать конструктор, для того, чтобы фигура не могла быть "пустой"
 ```cs
 public class Circle : IShape
 {
    public double R;
    
    public Circle(double r)
    {
        R = r;
    }
    
    public double CalculateSquare()
    {
        return 0;
    }
 }
 ```
 4. Прописать логику вычисления площади в функции `double CalculateSquare()`
 ```cs
 public class Circle : IShape
 {
    public double R;
 
    public Circle(double r)
    {
        R = r;
    }
    
    public double CalculateSquare()
    {
        return Math.Pow(R, 2) * Math.PI;
    }
 }
 ``` 
 
 Теперь фигура готова к работе. Чтобы протестировать ее необходимо вручную написать Unit-тесты.
 
 #### Unit-тесты
 
 Для написания Unit-тестов необходимо создать отдельный класс `{Название класса, который будет протестирован}Tester` в новом файле с соответствующим названием.
 
 Ниже представлен пример готового Unit-теста для класса `Circle`:
 
 ```
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareCalcLibCore.Shapes;
using System;
using System.Diagnostics;

namespace SquareCalcLibUnitTest
{
	[TestClass]
	public class CircleTester
	{
		[TestMethod]
		public void TriangleTest1()
		{
			Circle t = new Circle(5);

			double square = Math.PI * 25;

			Assert.AreEqual(square, t.CalculateSquare());
		}

		[TestMethod]
		public void TriangleTest2()
		{
			Circle t = new Circle(3);

			double square = Math.PI * 9;

			Assert.AreEqual(square, t.CalculateSquare());
		}
	}
}
 ```
