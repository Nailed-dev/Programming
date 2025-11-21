using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Товар.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// _id товара.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;
        
        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает _id товара.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает и задаёт название товара.
        /// </summary>
        /// <exception cref="ArgumentException">Название товара должно иметь меньше 200 символов.</exception>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }
        
        /// <summary>
        /// Возвращает и задает описание товара.
        /// </summary>
        /// <exception cref="ArgumentException">Описание товара должно иметь меньше 500 символов.</exception>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт стоимость товара.
        /// </summary>
        /// <exception cref="ArgumentException">Цена товара должна быть от 0 до 100 000.</exception>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                ValueValidator.AssertOnRange(value, 0, 100000, nameof(Cost ));
                _cost = value;
            }
        }
        
        /// <summary>
        /// Созадет экземпляр <see cref="Item"/>
        /// </summary>
        public Item()
        {
            _id = IdGenerator.GetNextId();      
        }

        /// <summary>
        /// Конструктор класса Item.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="info"></param>
        /// <param name="cost"></param>
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = IdGenerator.GetNextId(); 
        }
    }
}
