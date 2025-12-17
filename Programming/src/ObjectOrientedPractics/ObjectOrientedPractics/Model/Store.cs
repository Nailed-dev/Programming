using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Store
    {
        /// <summary>
        /// Товар.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Покупатель.
        /// </summary>
        private List<Customer> _customers;


        /// <summary>
        /// Возвращает и задаёт товар.
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
        /// Возвращает и задает покупателя.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Store"/>
        /// </summary>
        /// <param name="items"></param>
        /// <param name="customers"></param>
        public Store(List<Item> items, List<Customer> customers)
        {
            items = items;
            Customers = customers;

        }


        /// <summary>
        /// Создает экземпляр класса <see cref="Store"/>
        /// </summary>
        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }
    }
}
