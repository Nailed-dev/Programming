using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.Model
{
    
    public class Address : ICloneable, IEquatable<Address>
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город(населенный пункт).
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        private string _apartment;

        public event EventHandler<EventArgs> AddressChanged;

    /// <summary>
    /// Возвращает и задает почтовый индекс покупателя(целое шестизначное число).
    /// </summary>
    public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                ValueValidator.AssertOnRange(value, 100000, 999999, nameof(Index));
                if (_index != value)
                {
                    var args = new EventArgs();
                    _index = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }


        /// <summary>
        /// Возвращает и задает страну покупателя(не более 50 символов).
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                if (_country != value)
                {
                    var args = new EventArgs();
                    _country = value;
                    AddressChanged?.Invoke(this, args);
                }

            }
        }

        /// <summary>
        /// Возвращает и задает город(населенный пункт) покупателя(не более 50 символов).
        /// </summary>
        public string City
        {
            get
            {
                return _city;

            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                if (_city != value)
                {
                    var args = new EventArgs();
                    _city = value;
                    AddressChanged?.Invoke(this, args );

                }
            }
        }

        /// <summary>
        /// Возвращает и задает улицу покупателя(не более 100 символов).
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                if (_street != value)
                {
                    var args = new EventArgs();
                    _street = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }


        /// <summary>
        /// Возвращает и задает номер дома покупателя(не более 10 символов).
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                if (_building != value)
                {
                    var args = new EventArgs();
                    _building = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }

        
        /// <summary>
        /// Возвращает и задает номер квартиры/помещения покупателя(не более 10 символов).
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                if (_apartment != value)
                {
                    var args = new EventArgs();
                    _apartment = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// Создаем экземпляр класса.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна.</param>
        /// <param name="city">Город(населенный пункт).</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер квартиры/помещения.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Создаем экземпляр класса.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = "";
            City = "";
            Street = "";
            Building = "";
            Apartment = "";
        }

        public object Clone()
        {
            return new Address(this.Index, this.Country, this.City, this.Street, this.Building, this.Apartment);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (object.ReferenceEquals(this, obj))
                return true;

            var address = (Address)obj;

            return (this.Index == address.Index);
        }

        public bool Equals(Address other)
        {
            throw new NotImplementedException();
        }

    }
}
