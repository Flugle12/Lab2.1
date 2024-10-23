using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ExtendNine : Nine // Дочерний класс
{
    private double _vector3Length; // Поля длина вектора и вектор трехмерного пространства
    private double[] _vector3;

    public ExtendNine(double x, double y, double z) : base(x, y, z) // Конструктор для заполнения вектора координатами и длины
    {
        _vector3 = new double[3] { x, y, z };
        _vector3Length = CalculateLength();
    }

    private double CalculateLength() // Метод вычисления длины вектора
    {
        return Math.Sqrt(_vector3[0] * _vector3[0] + _vector3[1] * _vector3[1] + _vector3[2] * _vector3[2]);
    }

    public void Normalize() // Метод нормализации вектора
    {
        if (_vector3Length > 0) // Проверяем, что длина больше нуля
        {
            for (int i = 0; i < _vector3.Length; i++)
            {
                _vector3[i] /= _vector3Length;
            }
        }
        else
        {
            throw new InvalidOperationException("Cannot normalize a zero-length vector.");
        }
    }

    public override string ToString() // Перегрузка метода ToString()
    {
        return $"\n{_vector3[0]}\n{_vector3[1]}\n{_vector3[2]}\nдлина вектора: {_vector3Length}";
    }
}