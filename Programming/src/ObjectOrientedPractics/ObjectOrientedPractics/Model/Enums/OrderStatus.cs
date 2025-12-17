using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Enums
{
    public enum OrderStatus
    {
        /// <summary>
        /// Новый заказ.
        /// </summary>
        New,

        /// <summary>
        /// Обрабатывается.
        /// </summary>
        Processing,

        /// <summary>
        /// Собирается на складе.
        /// </summary>
        Assembly,

        /// <summary>
        /// Отправлен.
        /// </summary>
        Sent,

        /// <summary>
        /// Доставлен.
        /// </summary>
        Delivered,

        /// <summary>
        /// Возврат.
        /// </summary>
        Returned,

        /// <summary>
        /// Отменен.
        /// </summary>
        Abandoned
    }
}
