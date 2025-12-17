using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{

    /// <summary>
    /// Интерфейс для системы скидок на товары.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        string Info { get;  }

        /// <summary>
        /// Вычисляет размер скидки для заданного типа товара.
        /// </summary>
        /// <param name="items">Список товаров для которых рассчитывается скидка.</param>
        /// <returns>Размер скидки в деньгах.</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку к списку товаров и возвращает размер примененной скидки.
        /// </summary>
        /// <param name="items">Список товаров к которым применяется скидка.</param>
        /// <returns>Размер скидки в деньгах.</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Обновляет состояние скидки на основе покупки.
        /// </summary>
        /// <param name="items">Список купленных товаров.</param>
        void Update(List<Item> items);

    }
}
