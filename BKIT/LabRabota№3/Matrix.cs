using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LabRabota_3
{
    class FigureMatrixCheckEmpty : IMatrixCheckEmpty<GeomFigure>
    {
        /// <summary>
        /// В качестве пустого элемента возвращается null
        /// </summary>
        public GeomFigure getEmptyElement()
        {
            return null;
        }
        /// <summary>
        /// Проверка что переданный параметр равен null
        /// </summary>
        public bool checkEmptyElement(GeomFigure element)
        {
            bool Result = false;
            if (element == null)
            {
                Result = true;
            }
            return Result;
        }
    }
}
public interface IMatrixCheckEmpty<T>
    {
        /// <summary>
        /// Возвращает пустой элемент
        /// </summary>
        T getEmptyElement();
        /// <summary>
        /// Проверка что элемент является пустым
        /// </summary>
        bool checkEmptyElement(T element);
    }
    public class Matrix<T>
    {
        /// <summary>
        /// Словарь для хранения значений
        /// </summary>
        Dictionary<string, T> _matrix = new Dictionary<string, T>();
        /// <summary>
        /// Количество элементов по горизонтали (максимальное количество столбцов)
 /// </summary>
 int maxX;
        /// <summary>
        /// Количество элементов по вертикали (максимальное количество строк)
 /// </summary>
 int maxY;
        /// <summary>
        /// Количество элементов по вертикали .....(максимальное количество строк)
        /// </summary>
        int maxZ;
        /// <summary>
        /// Реализация интерфейса для проверки пустого элемента
        /// </summary>
        IMatrixCheckEmpty<T> сheckEmpty;
        /// <summary>
        /// Конструктор
        /// </summary>
        public Matrix(int px, int py,int pz, IMatrixCheckEmpty<T> сheckEmptyParam)
        {
            this.maxX = px;
            this.maxY = py;
            this.maxZ = pz;
            this.сheckEmpty = сheckEmptyParam;
        }
        /// <summary>
        /// Индексатор для доступа к данных
        /// </summary>
        public T this[int x, int y,int z]
        {
            set
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                this._matrix.Add(key, value);
            }
            get
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                if (this._matrix.ContainsKey(key))
                {
                    return this._matrix[key];
                }
                else
                {
                    return this.сheckEmpty.getEmptyElement();
                }
            }
        }
        /// <summary>
        /// Проверка границ
        /// </summary>
        void CheckBounds(int x, int y, int z)
        {
        if (x < 0 || x >= this.maxX)
            {
                throw new ArgumentOutOfRangeException("x",
                "x=" + x + " выходит за границы");
            }
            if (y < 0 || y >= this.maxY)
            {
                throw new ArgumentOutOfRangeException("y",
                "y=" + y + " выходит за границы");
            }
            if (z < 0 || z >= this.maxZ)
            {
                throw new ArgumentOutOfRangeException("z",
                "z=" + z + " выходит за границы");
            }
        }
        /// <summary>
        /// Формирование ключа
        /// </summary>
        string DictKey(int x, int y,int z)
        {
            return x.ToString() + "_" + y.ToString() +"_" + z.ToString();
        }
        /// <summary>
        /// Приведение к строке
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder b = new StringBuilder();
            Console.WriteLine("XY");
            for (int j = 0; j < this.maxY; j++)
            {
            int k = 0;
                b.Append("[");
                for (int i = 0; i < this.maxX; i++)
                {
                        //Добавление разделителя-табуляции
                        if (i > 0)
                        {
                            b.Append("\t");
                        }
                        //Если текущий элемент не пустой
                        if (!this.сheckEmpty.checkEmptyElement(this[i, j,k]))
                        {
                            //Добавить приведенный к строке текущий элемент
                            b.Append(this[i, j,k].ToString());
                        }
                        else
                        {
                            //Иначе добавить признак пустого значения
                            b.Append(" - ");
                        }
                }
                b.Append("]\n");

            }
        Console.WriteLine("XZ");
        for (int j = 0; j < this.maxZ; j++)
        {
            int k = 0;
            b.Append("[");
            for (int i = 0; i < this.maxX; i++)
            {
                //Добавление разделителя-табуляции
                if (i > 0)
                {
                    b.Append("\t");
                }
                //Если текущий элемент не пустой
                if (!this.сheckEmpty.checkEmptyElement(this[i, k, j]))
                {
                    //Добавить приведенный к строке текущий элемент
                    b.Append(this[i, k, j].ToString());
                }
                else
                {
                    //Иначе добавить признак пустого значения
                    b.Append(" - ");
                }
            }
            b.Append("]\n");
        }
        Console.WriteLine("ZY");
        for (int j = 0; j < this.maxY; j++)
        {
            int k = 0;
            b.Append("[");
            for (int i = 0; i < this.maxZ; i++)
            {
                //Добавление разделителя-табуляции
                if (i > 0)
                {
                    b.Append("\t");
                }
                //Если текущий элемент не пустой
                if (!this.сheckEmpty.checkEmptyElement(this[k, j, i]))
                {
                    //Добавить приведенный к строке текущий элемент
                    b.Append(this[k, j, i].ToString());
                }
                else
                {
                    //Иначе добавить признак пустого значения
                    b.Append(" - ");
                }
            }
            b.Append("]\n");
        }

        return b.ToString();
        }
    }