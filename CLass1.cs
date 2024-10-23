using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Nine
{
    private double _value1, _value2, _value3; // три вещественными полями

    public Nine(double value1, double value2, double value3)
    {
        if (double.IsNaN(value1) || double.IsNaN(value2) || double.IsNaN(value3))
            throw new ArgumentException("Values cannot be NaN.");

        _value1 = value1;
        _value2 = value2;
        _value3 = value3;
    }

    public Nine(Nine other) // Конструктор копирования
    {
        _value1 = other._value1;
        _value2 = other._value2;
        _value3 = other._value3;
    }

    public void ToInt() // Метод для приведения к целому типу
    {
        _value1 = (int)_value1;
        _value2 = (int)_value2;
        _value3 = (int)_value3;
    }

    public override string ToString() // Перегрузка ToString()
    {
        return $"\nValue1: {_value1}\nValue2: {_value2}\nValue3: {_value3}";
    }
}
