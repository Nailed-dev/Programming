using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        /// <summary>
        /// Id.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Дата доставки.
        /// </summary>
        private DateTime _date;

        /// <summary>
        /// Адресс доставки.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Общая стоимость.
        /// </summary>
        private double _amount;

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="orderStatus"></param>
        /// <param name="date"></param>
        /// <param name="address"></param>
        /// <param name="cart"></param>
        public Order(int id, OrderStatus orderStatus, DateTime date, Address address, Cart cart)
        {
            _id = id;
            orderStatus = orderStatus;
            Date = date;
            Address = address;
            Items = cart.Items;
            Amount = cart.Amount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            Cart cart = new Cart();
            _id = IdGenerator.GetNextId();
            OrderStatus = OrderStatus.New;
            Date = DateTime.Now;
            Address = new Address();
            Items = cart.Items;
            Amount = cart.Amount;
        }
        /// <summary>
        /// Возвращает и задает дату доставки.
        /// </summary>
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адресс доставки.
        /// </summary>
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
        /// Вовзращает и задает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает и задает общую стоимость товаров в заказе.
        /// </summary>
        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
        /// <summary>
        /// Возвращает и задает состояние заказа.
        /// </summary>
        public OrderStatus OrderStatus { get; set;  }

        /// <summary>
        /// Возвращает ID покупателя.
        /// </summary>
        public int Id { get { return _id; } }
    }
}
