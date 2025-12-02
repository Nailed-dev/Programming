using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// _id пользователя.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// ФИО пользователя.
        /// </summary>
        private string _fullname;
        /// <summary>
        /// Адресс доставки.
        /// </summary>
        private Address _address;
        
        

        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Список заказов покупателя.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Возвращает и задает ФИО пользователя.
        /// </summary>
        /// <exception cref="ArgumentException">ФИО должно иметь меньше 200 символов.</exception>

        /// <summary>
        /// Возвращает _id.
        /// </summary>
        public int Id { get { return _id; } }

        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                ValueValidator.AssertEmptyValue(value, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адресс доставки.
        /// </summary>
        /// <exception cref="ArgumentException">Адресс должен иметь меньше 500 символов.</exception>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                
                _address = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Конструктор класса Customer.
        /// </summary>
        /// <param name="fullname"></param>
        /// <param name="address"></param>
        public Customer(string fullname, Address address, Cart cart)
        {
            Fullname = fullname;
            Address = address;
            _id = IdGenerator.GetNextId();
            Cart = cart;
        }

        /// <summary>
        /// Возвращает и задает корзину покупателя.
        /// </summary>
        public Cart Cart
        {
            get
            {
                return _cart;
            }
            set
            {
                _cart = value;
            }
        }

        /// <summary>
        /// Возвращает и задает список заказов покупателя.
        /// </summary>
        public List<Order> Orders
        {
            get
            {
                return _orders;
            }
            set
            {
                _orders = value;
            }

        }
        
        

        
    }
    
}
