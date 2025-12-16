using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Делегат для методов, проверябщих условие для объекта.
    /// </summary>
    /// <param name="item">Товар для проверки условия.</param>
    /// <returns></returns>
    public delegate bool newDel_bool(Item item);

    /// <summary>
    /// Делегат для методов выполняющих сортировку списка товаров.
    /// </summary>
    /// <param name="item2"></param>
    /// <returns></returns>
    public delegate List<Item> newDel_list(List<Item> item2);
    /// <summary>
    /// Предоставляет набор инструментов для работы с данными товарами.
    /// </summary>
    public class DataTool
        
    {
        /// <summary>
        /// Список доступных способов сортировки.
        /// </summary>
        public List<string> ComboSort = new List<string>()
        {
            "Name",
            "Cost(Ascending)",
            "Cost (Descending)"
        };

        /// <summary>
        /// Определяет превышает ли стоимость товара 5000.
        /// </summary>
        /// <param name="item">Товар для проверки.</param>
        /// <returns></returns>
        public bool CostSorting(Item item)
        {
            return item.Cost > 5000;
        }

       
        public bool IsCategory(Item item, Category targetCategory)
        {
            return item.Category == targetCategory;
        }

        public List<Item> Sort(List<Item> items, newDel_bool del)
        {
            List<Item> sortlist = new List<Item>();
            foreach (Item item in items)
            {
                if (del(item))
                {
                    sortlist.Add(item); 
                }
            }
            return sortlist;
        }
         
        public List<Item> SortName(List<Item> items, string name)
        {
            List<Item> sortlist = new List<Item>();
            string searchNameLower;
            if (name == null)
            {
                searchNameLower = string.Empty;
            }
            else
            {
                searchNameLower = name.ToLower();
            }
            foreach (Item item in items)
            {
                if (item.Name.ToLower().Contains(searchNameLower))
                {
                    sortlist.Add(item);
                }
            }
            return sortlist;
        }

        public List<Item> SortByName(List<Item> items)
        {
            return items.OrderBy(item => item.Name).ToList();
        }

        public List<Item> CostByAscending(List<Item> items)
        {
            return items.OrderBy(item => item.Cost).ToList();
        }

        public List<Item> SortByCostDescending(List<Item> items)
        {
            return items.OrderByDescending(item => item.Cost).ToList();
        }

        public List<Item> ListSort(List<Item> items, newDel_list sorter)
        {
            return sorter(items);
        }
    }
}
