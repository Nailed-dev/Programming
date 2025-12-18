using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {

        /// <summary>
        /// Инструмент для работы с данными.
        /// </summary>
        private DataTool _dataTool;
        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Отображаемые товары.
        /// </summary>
        private List<Item> _displayedItems;
        
        /// <summary>
        /// Событие изменения списка товаров.
        /// </summary>
        public event EventHandler<EventArgs> ItemsChanged;
        


        

        public ItemsTab()
        {
            InitializeComponent();

            var items = Enum.GetValues(typeof(Category));
            foreach (var item in items)
            {
                ItemCategoryComboBox.Items.Add(item);
            }

            _dataTool = new DataTool();

            
            Items = new List<Item>();
            _displayedItems = new List<Item>();

            
            foreach (var sortOption in _dataTool.ComboSort)
            {
                OrderByComboBox.Items.Add(sortOption);
            }
        }

        /// <summary>
        /// Метод для вызова события ItemsChanged.
        /// </summary>
        private void OnItemsChanged()
        {
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }
        
        /// <summary>
        /// Подписка на события товара.
        /// </summary>
        /// <param name="item"></param>
        private void SubscribeToItemEvents(Item item)
        {
            if (item != null)
            {
                item.NameChanged += Item_NameChanged;
                item.CostChanged += Item_CostChanged;
                item.InfoChanged += Item_InfoChanged;
            }
        }

        /// <summary>
        /// Отписка от событий товара.
        /// </summary>
        /// <param name="item"></param>
        private void UnsubscribeFromItemEvents(Item item)
        {
            if (item != null)
            {
                item.NameChanged -= Item_NameChanged;
                item.CostChanged -= Item_CostChanged;
                item.InfoChanged -= Item_InfoChanged;
            }
        }

        /// <summary>
        /// Обработчик изменения имени товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Item_NameChanged(object sender, EventArgs e)
        {
            OnItemsChanged();
        }

        /// <summary>
        /// Обработчик изменения цены товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Item_CostChanged(object sender, EventArgs e)
        {
            OnItemsChanged();
        }
        
        /// <summary>
        /// Обработчик изменения описания товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Item_InfoChanged(object sender, EventArgs e)
        {
            OnItemsChanged();
        }

      








        /// <summary>
        /// Обновление текстбоксов.
        /// </summary>
        /// <param name="item">Товар</param>
        private void UpdateTextBoxes(Item item)
        {
            IdTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            DescriptionTextBox.Text = item.Info;

        }

        /// <summary>
        /// Обновление данных при выборе товара в ItemsListBox.
        /// </summary>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentItem != null)
            {
                UnsubscribeFromItemEvents(_currentItem);
            }
            int index = ItemsListBox.SelectedIndex;
            if (index == -1 || index >= _displayedItems.Count) return;

            _currentItem = _displayedItems[index];
            ItemCategoryComboBox.SelectedItem = _currentItem.Category;
            UpdateTextBoxes(_currentItem);
            SubscribeToItemEvents(_currentItem);
        }

        /// <summary>
        /// Обновляет данные в списке ItemsListBox.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void UpdateListBox(int index)
        {
            
            ItemsListBox.Items.Clear();

            
            foreach (var item in _displayedItems)
            {
                if (item.Name != "")
                {
                    ItemsListBox.Items.Add(item.Name);
                }
                else
                {
                    ItemsListBox.Items.Add($"Item {item.Id}");
                }
            }

            if (-1 <= index && index < ItemsListBox.Items.Count)
            {
                ItemsListBox.SelectedIndex = index;
            }
        
        }

        private void ApplySearchAndSort()
        {
            string searchText = FindTextBox.Text;
            string sortType = OrderByComboBox.Text;

           
            List<Item> filteredItems;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                filteredItems = _dataTool.SortName(Items, searchText);
            }
            else
            {
                filteredItems = new List<Item>(Items);
            }

            
            switch (sortType)
            {
                case "Name":
                    _displayedItems = _dataTool.SortByName(filteredItems);
                    break;
                case "Cost(Ascending)":
                    _displayedItems = _dataTool.CostByAscending(filteredItems);
                    break;
                case "Cost (Descending)":
                    _displayedItems = _dataTool.SortByCostDescending(filteredItems);
                    break;
                default:
                    _displayedItems = filteredItems;
                    break;
            }

            
            UpdateListBox(-1);

            
            if (_currentItem != null)
            {
                int newIndex = _displayedItems.IndexOf(_currentItem);
                if (newIndex != -1)
                {
                    ItemsListBox.SelectedIndex = newIndex;
                }
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplySearchAndSort();
        }

        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySearchAndSort();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item("Empty item", "Empty description", 0, Category.Others);
            Items.Add(_currentItem);
            SubscribeToItemEvents(_currentItem);


            ApplySearchAndSort();

            
            int index = _displayedItems.IndexOf(_currentItem);
            if (index != -1)
            {
                ItemsListBox.SelectedIndex = index;
            }

            UpdateTextBoxes(_currentItem);
            OnItemsChanged();

        }

        /// <summary>
        /// Удаление товара.
        /// </summary>
        private void RemoveButton_Click_1(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0 || ItemsListBox.SelectedIndex == -1) return;

            int selectedIndex = ItemsListBox.SelectedIndex;


            if (selectedIndex < _displayedItems.Count)
            {
                Item itemToRemove = _displayedItems[selectedIndex];
                UnsubscribeFromItemEvents(itemToRemove);
                Items.Remove(itemToRemove);


                if (_currentItem == itemToRemove)
                {
                    _currentItem = null;
                }
            }


            ApplySearchAndSort();


            if (_displayedItems.Count > 0)
            {
                ItemsListBox.SelectedIndex = Math.Min(selectedIndex, _displayedItems.Count - 1);
            }
            else
            {
                ClearTextBoxes();
                _currentItem = null;

            }
            OnItemsChanged();
        }  





        /// <summary>
        /// Очистка текстбоксов.
        /// </summary>
        private void ClearTextBoxes()
        {
            IdTextBox.Text = "";
            CostTextBox.Text = "";
            NameTextBox.Text = "";
            DescriptionTextBox.Text = "";
            IdTextBox.BackColor = Colors.NormalColor;
            CostTextBox.BackColor = Colors.NormalColor;
            NameTextBox.BackColor = Colors.NormalColor;
            DescriptionTextBox.BackColor = Colors.NormalColor;

        }

        /// <summary>
        /// Изменение цены товара, когда в CostTextBox меняется значение.
        /// </summary>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Items.Count == 0) return;
            if (_currentItem == null) return;

            if (CostTextBox.Text == "")
            {
                _currentItem.Cost = 0;
                return;
            }

            try
            {
                CostTextBox.BackColor = Colors.NormalColor;
                _currentItem.Cost = Convert.ToDouble(CostTextBox.Text);
            }
            catch
            {
                CostTextBox.BackColor = Colors.ErrorColor;
            }
        }

        /// <summary>
        /// Изменение названия товара, когда в NameTextBox меняется значение.
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Items.Count == 0) return;
            if (_currentItem == null) return;

            try
            {
                NameTextBox.BackColor = Colors.NormalColor;
                _currentItem.Name = NameTextBox.Text;

                
                int displayedIndex = _displayedItems.IndexOf(_currentItem);
                if (displayedIndex != -1)
                {
                    ItemsListBox.Items[displayedIndex] = _currentItem.Name;
                }

                
                
            }
            catch
            {
                NameTextBox.BackColor = Colors.ErrorColor;
            }
        }

        /// <summary>
        /// Изменение описания товара, когда в DescriptionTextBox меняется значение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Items.Count == 0) return;
            if (_currentItem == null) return;

            try
            {
                DescriptionTextBox.BackColor = Colors.NormalColor;
                _currentItem.Info = DescriptionTextBox.Text;
            }
            catch
            {
                DescriptionTextBox.BackColor = Colors.ErrorColor;
            }
        }


        /// <summary>
        /// Создает и сохраняет категорию товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;
            if (_currentItem == null) return;

            try
            {
                _currentItem.Category = (Category)ItemCategoryComboBox.SelectedItem;
                ItemCategoryComboBox.BackColor = Colors.NormalColor;
            }
            catch
            {
                ItemCategoryComboBox.BackColor = Colors.ErrorColor;
            }
        }

        /// <summary>
        /// Возвращает и задает коллекцию товаров.
        /// </summary>
        public List<Item> Items
        {
            get; set;
        }
         
    }
}