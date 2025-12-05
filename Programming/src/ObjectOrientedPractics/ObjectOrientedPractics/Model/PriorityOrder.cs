using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.View;


namespace ObjectOrientedPractics.Model
{

    /// <summary>
    /// Хранит данные о заказе приоритетного обслуживания.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Дата доставки.
        /// </summary>
        private DateTime _deliveryDate;

        /// <summary>
        /// Время доставки.
        /// </summary>
        private string _deliveryTime;

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>
        /// </summary>
        /// <param name="id">Id.</param>
        /// <param name="orderStatus">Статус заказа.</param>
        /// <param name="address">Адрес.</param>
        /// <param name="items">Товар.</param>
        /// <param name="deliveryDate">Дата доставки.</param>
        /// <param name="deliveryTime">Время доставки.</param>
        /// <param name="cart">Корзина.</param>
        public PriorityOrder(int id,  OrderStatus orderStatus, Address address, List<Item> items, 
            DateTime deliveryDate, string deliveryTime, Cart cart)
            : base (id, orderStatus, deliveryDate, address, cart)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }

        /// <summary>
        /// Возвращает и задает дату доставки.
        /// </summary>
        public DateTime DeliveryDate
        {
            get => _deliveryDate;
            set => _deliveryDate = value;
        }
        /// <summary>
        /// Возвращает и задает время доставки.
        /// </summary>
        public string DeliveryTime
        {
            get => _deliveryTime;
            set => _deliveryTime = value;
        }
            
    }

}
    
