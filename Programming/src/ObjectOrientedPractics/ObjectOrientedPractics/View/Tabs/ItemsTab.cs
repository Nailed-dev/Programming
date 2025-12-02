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
        /// Выбранный товар.
        /// </summary>
        private Item _currentItem;

        public ItemsTab()
        {
            InitializeComponent();

            var items = Enum.GetValues(typeof(Category));

            foreach (var item in items)
            {
                ItemCategoryComboBox.Items.Add(item);
            }


        }

        /// <summary>
        /// Добавление нового товара.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item("Empty item", "Empty description", 0, "Empty category");
            Items.Add(_currentItem);
            ItemsListBox.Items.Add(_currentItem.Name);
            ItemsListBox.SelectedIndex = Items.Count - 1;
            UpdateTextBoxes(_currentItem);
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
            int index = ItemsListBox.SelectedIndex;
            if (index == -1) return;
            _currentItem = Items[index];
            ItemCategoryComboBox.Text = _currentItem.Category;
            UpdateTextBoxes(_currentItem);

        }

        /// <summary>
        /// Обновляет данные в списке ItemsListBox.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void UpdateListBox(int index)
        {
            List<Item> items = Items;

            ItemsListBox.Items.Clear();

            foreach (var item in items)
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

        /// <summary>
        /// Удаление товара.
        /// </summary>
        private void RemoveButton_Click_1(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0) return;
            int index = ItemsListBox.SelectedIndex;
            Items.RemoveAt(index);
            ItemsListBox.Items.RemoveAt(index);

            if (ItemsListBox.Items.Count > index)
                ItemsListBox.SelectedIndex = index;
            else if (ItemsListBox.Items.Count != 0)
                ItemsListBox.SelectedIndex = 0;
            else
                ItemsListBox.SelectedIndex = -1;

            UpdateTextBoxes(_currentItem);

            if (ItemsListBox.Items.Count == 0)
                ClearTextBoxes();
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
                ItemsListBox.Items[Items.IndexOf(_currentItem)] = _currentItem.Name;
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
                _currentItem.Category = ItemCategoryComboBox.SelectedItem.ToString();
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