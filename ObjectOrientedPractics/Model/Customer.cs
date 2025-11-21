using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

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
        private string _address;
        
        /// <summary>
        /// Возвращает _id.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает и задает ФИО пользователя.
        /// </summary>
        /// <exception cref="ArgumentException">ФИО должно иметь меньше 200 символов.</exception>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
            }
        }

        /// <summary>
        /// Возвращает и задает адресс доставки.
        /// </summary>
        /// <exception cref="ArgumentException">Адресс должен иметь меньше 500 символов.</exception>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Customer"/>
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
        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
            _id = IdGenerator.GetNextId();
        }
    }
    
}
