using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {   
        /// <summary>
        /// Накопительная скидка.
        /// </summary>
        private int _points;

        /// <summary>
        /// Создает экземпляр класса <see cref="PointsDiscount"/>
        /// </summary>
        public PointsDiscount()
        {

        }

        public int Points
        {
            get => _points;
            set
            {
                ValueValidator.AssertOnPositiveValue(nameof(Points), value);
                _points = value;
            }
        }

        /// <summary>
        /// Возвращает инфомацию по накопительной скидке.
        /// </summary>
        public string Info
        {
            get => $"Накопительная - {Points} баллов";
        }

        /// <summary>
        /// Вычисляет скидку дя товара.
        /// </summary>
        /// <param name="items">Список товаров для которых применятеся скидка.</param>
        /// <returns>Возвращает общую стоимость товара с учетом скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double amount = 0;
            foreach (var item in items)
            {
                amount += item.Cost;
            }

            if (_points <= (int)(amount * 0.3))
            {
                return _points;
            }
            else
            {
                return Math.Ceiling(amount * 0.3);
            }

        }
        /// <summary>
        /// Применяет скидку к товару.
        /// </summary>
        /// <param name="items">Список товаров для которых применяется скидка.</param>
        /// <returns>Возвращает скидку.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            _points -= (int)discount;
            return discount;
        }

        /// <summary>
        /// Накапливает скидку.
        /// </summary>
        /// <param name="items">Список товаров к которым применяется скидка.</param>
        public void Update(List<Item> items)
        {
            double amount = 0;
            foreach (var item in items)
            {
                amount += item.Cost;
            }
            _points += (int)Math.Ceiling(amount * 0.1);
        }


        /// <summary>
        /// Сравнивает другой экземпляр с другим объектом <see cref="PointsDiscount"/> по колличеству баллов.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException">Выбрасывается в неожиданных случаях сравнения (должно быть обработано в коде).</exception>
        public int CompareTo(PointsDiscount other)
        {
            if (this.Points == other.Points)
            {
                return 0;
            }
            if (this.Points > other.Points)
            {
                return 1;
            }
            if (this.Points < other.Points)
            {
                return -1;
            }
            else
            {
                throw new NotImplementedException();
            }
        }



    }
}
