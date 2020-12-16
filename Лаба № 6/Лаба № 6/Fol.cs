using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Reflection
    {
        /// <summary>
        /// Класс для исследования с помощью рефлексии
        /// </summary>
        public class ForInspection : IComparable
        {
            public ForInspection() { }
            public string help() { return "Помощи не будет";}
            public string property
            {
                get { return _property1; }
                set { _property1 = value; }
            }
            private string _property1;
            public int property2 { get; set; }
            public string Nadpis;
            /// <summary>
            /// Реализация интерфейса IComparable
            /// </summary>
            public int CompareTo(object obj)
            {
                return 0;
            }
        }
    }


