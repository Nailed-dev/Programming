using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Товар.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
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
        /// Возвращает категорию товара.
        /// </summary>
        public Category Category { get; set; }

        public event EventHandler<EventArgs> NameChanged;
        public event EventHandler<EventArgs> CostChanged;
        public event EventHandler<EventArgs> InfoChanged;

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
                ValueValidator.AssertEmptyValue(value, nameof(Name));
                if (_name != value)
                {
                    var args = new EventArgs();
                    _name = value;
                    NameChanged?.Invoke(this, args);
                }
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
                ValueValidator.AssertEmptyValue(value, nameof(Info));
                if (_info != value)
                {
                    var args = new EventArgs();
                    _info = value;
                    InfoChanged?.Invoke(this, args);
                }
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
                if (_cost != value)
                {
                    var args = new EventArgs();
                    _cost = value;
                    CostChanged?.Invoke(this, args);
                }
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
        /// <param name="name">Имя.</param>
        /// <param name="info">Описание товара.</param>
        /// <param name="cost">Цена товара.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = IdGenerator.GetNextId();
            Category = category;
        }


        /// <summary>
        /// Создает глубокую копию текущего объекта <see cref="Address"/>.
        /// </summary>
        /// <returns>Новый объект <see cref="Address"/> с такими же значениями свойств.</returns>
        public object Clone()
        {
            return new Item(this.Name, this.Info, this.Cost, this.Category);
        }

        /// <summary>
        /// Определяет, равен ли текущий объект(Item) другому объекту(Item).
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Item other)
        {
            if (other == null)
                return false;

            if (object.ReferenceEquals(this, other))
                return true;

            return (this.Name == other.Name);
        }

        
        public int CompareTo(Item other)
        {

            if (this.Cost == other.Cost)
            {
                return 0;
            }
            if (this.Cost > other.Cost)
            {
                return 1;
            }
            if (this.Cost < other.Cost)
            {
                return -1;
            }
            else
            {
                throw new NotImplementedException();
            }
        }


        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Cost: {Cost}";
        }
    }


}
