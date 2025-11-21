using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Валидатор.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверка, что строка не длинее maxLength.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maxLength"></param>
        /// <param name="propertyName"></param>
        /// <exception cref="ArgumentException">Строка выходит за диапазон по длине.</exception>
       public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength){
                throw new ArgumentException($"{propertyName} must be less than {maxLength} chars");
            }
        }
        /// <summary>
        /// Проверка, что значение входит в диапазон от minLength до maxLength.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="minLength"></param>
        /// <param name="maxLength"></param>
        /// <param name="propertyName"></param>
        /// <exception cref="ArgumentException">Значение выходит за диапазон.</exception>
        public static void AssertOnRange(double value, int minLength, int maxLength, string propertyName)
        {
            if (value < minLength || value > maxLength)
            {
                throw new ArgumentException($"{propertyName} must be in range[{minLength}, {maxLength}]");
            }
        }
    }
}
