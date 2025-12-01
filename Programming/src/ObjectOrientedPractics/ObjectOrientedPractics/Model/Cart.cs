using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;


namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о корзине покупателя.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Хранит список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Создает экземпляр класса <see cref="Cart"/>.
        /// </summary>
        /// <param name="items"></param>
        public Cart(List<Item> items)
        {
            Items = items;
        }
        
        /// <summary>
        /// Создает экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
        }
         
        /// <summary>
        /// Задает и возвращает список товаров.
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
        /// Возвращает сумму и стоимость товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {
                double amount = 0;
                for (int i = 0; i < Items.Count; i++)
                {
                    amount += _items[i].Cost;
                }
                return amount;
            }
        }

        
    }
}
