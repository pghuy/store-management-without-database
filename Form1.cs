using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store_management_without_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Create new List Items under the Item type
        Item[] originListItems = new Item[0];
        //UTILITY FUNCTION

        // Add Item to Array Function
        public Item[] AddItemToArray(Item[] A, Item item)
        {
            Item[] B = new Item[A.Length + 1];
            for (int i = 0; i <= A.Length; i++)
            {
                if (i == A.Length)
                {
                    B[i] = item;
                }
                else
                {
                    B[i] = A[i];
                }
            }
            return B;
        }

        //Remove Item from Array
        // Check 2 Items in List Item by comparing struct areStructsMatched
        public bool areStructsMatched(Item a, Item b)
        {
            if (a.category == b.category && a.code == b.code && a.company == b.company && a.date == b.date && a.name == b.name && a.year == b.year)
            {
                return true;
            }
            return false;
        }
        public Item[] RemoveItemFromArray(Item[] A, int index)
        {
            Item[] B = new Item[A.Length - 1];
            int i = 0;
            int temp = 0;
            while (i < A.Length)
            {
                try
                {
                    if (i != index)
                    {
                        B[temp] = A[i];
                        temp += 1;
                        i++;
                    }
                    else
                    {
                        B[i] = A[i + 1];
                        temp = i + 1;
                        i += 2;
                    }
                }
                catch
                {
                    break;
                }
            }
            return B;
        }

        // Check radioBtn Checked Changed
        private void radioBtnCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnCategory.Checked == true)
            {
                cbBoxCategory.Text = "";
                tbCode.ReadOnly = true;
                tbCompany.ReadOnly = true;
                tbEDate.ReadOnly = true;
                tbName.ReadOnly = true;
                tbYear.ReadOnly = true;
                tbCode.Text = "";
                tbCompany.Text = "";
                tbEDate.Text = "";
                tbName.Text = "";
                tbYear.Text = "";
                noteSearch.Text = "*Nhập loại hàng cần tìm";
                labelCategoryNotice.Text = "*";
            }
            if (radioBtnItem.Checked == true)
            {
                tbCode.ReadOnly = false;
                tbCompany.ReadOnly = false;
                tbEDate.ReadOnly = false;
                tbName.ReadOnly = false;
                tbYear.ReadOnly = false;
                savedSelectedIndex = -1;
            }
            else
            {
                labelCategoryNotice.Text = "";
            }
        }
        private void radioBtnItem_CheckedChanged(object sender, EventArgs e)
        {
            noteSearch.Text = "*Nhập mã hàng, tên hàng, công ty sản xuất,năm sản xuất hoặc hạn dùng";
        }
        // IS INPUT VALID ?
        public bool isInputValidItem()
        {
            if (string.IsNullOrWhiteSpace(cbBoxCategory.Text))
            {
                MessageBox.Show("Vui lòng nhập loại hàng", "Lưu ý", MessageBoxButtons.OK);
                cbBoxCategory.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbCode.Text))
            {
                MessageBox.Show("Vui lòng nhập mã mặt hàng", "Lưu ý", MessageBoxButtons.OK);
                tbCode.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Vui lòng nhập nhập tên mặt hàng", "Lưu ý", MessageBoxButtons.OK);
                tbName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbEDate.Text))
            {
                MessageBox.Show("Vui lòng nhập ngày hết hạn", "Lưu ý", MessageBoxButtons.OK);
                tbEDate.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbCompany.Text))
            {
                MessageBox.Show("Vui lòng nhập tên công ty sản xuất", "Lưu ý", MessageBoxButtons.OK);
                tbCompany.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbYear.Text))
            {
                MessageBox.Show("Vui lòng nhập năm sản xuất", "Lưu ý", MessageBoxButtons.OK);
                tbYear.Focus();
                return false;
            }
            if (!string.IsNullOrWhiteSpace(tbYear.Text))
            {
                try
                {
                    if (Int32.Parse(tbYear.Text) > Int32.Parse(DateTime.Now.Year.ToString()) || Int32.Parse(tbYear.Text) < 1900)
                    {
                        MessageBox.Show("Vui lòng nhập đúng năm sản xuất từ 1900 - 2021", "Lưu ý", MessageBoxButtons.OK);
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập đúng năm sản xuất từ 1900 - 2021", "Lưu ý", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
        }
        public bool isInputValidCategory()
        {
            if (string.IsNullOrWhiteSpace(cbBoxCategory.Text))
            {
                MessageBox.Show("Vui lòng chọn/nhập loại hàng", "Cảnh báo", MessageBoxButtons.OK);
                cbBoxCategory.Focus();
                return false;
            }
            //if (!string.IsNullOrWhiteSpace(tbCode.Text) || !string.IsNullOrWhiteSpace(tbCompany.Text) || !string.IsNullOrWhiteSpace(tbEDate.Text) || !string.IsNullOrWhiteSpace(tbName.Text) || !string.IsNullOrWhiteSpace(tbSearch.Text) || !string.IsNullOrWhiteSpace(tbYear.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập chỉ nhập hoặc chọn loại hàng", "Cảnh báo", MessageBoxButtons.OK);
            //    cbBoxCategory.Focus();
            //    return false;
            //}

            return true;
        }
        //ADD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (radioBtnItem.Checked == true)
            {
                if (isInputValidItem())
                {
                    Item newCreatedItem = new Item();
                    newCreatedItem.category = cbBoxCategory.Text;
                    if (!cbBoxCategory.Items.Contains(cbBoxCategory.Text))
                    {
                        cbBoxCategory.Items.Add(cbBoxCategory.Text);
                    }
                    newCreatedItem.code = tbCode.Text;
                    newCreatedItem.name = tbName.Text;
                    try
                    {
                        newCreatedItem.date = DateTime.ParseExact(tbEDate.Text, "dd/MM/yyyy", null);
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đúng hạn dùng dd/MM/yyyy", "Lưu ý");
                        return;
                    }
                    newCreatedItem.company = tbCompany.Text;
                    newCreatedItem.year = Int32.Parse(tbYear.Text);
                    originListItems = AddItemToArray(originListItems, newCreatedItem);
                    dataGridViewItems.DataSource = originListItems;
                };
            }
            if (radioBtnCategory.Checked == true)
            {
                if (isInputValidCategory())
                {
                    if (!cbBoxCategory.Items.Contains(cbBoxCategory.Text))
                    {
                        cbBoxCategory.Items.Add(cbBoxCategory.Text);
                        MessageBox.Show($"Đã thêm loại hàng {cbBoxCategory.Text}");
                    }
                    else
                    {
                        MessageBox.Show($"Loại hàng {cbBoxCategory.Text} đã tồn tại , xin vui lòng nhập lại");
                    }
                }
            }
            if (!radioBtnItem.Checked && !radioBtnCategory.Checked)
            {
                MessageBox.Show("Vui lòng chọn vùng thao tác");
                return;
            }
        }
        //MODIFY
        // Transfer data from datagrid to textbox when clicking the cell
        int index;
        private void dataGridViewItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioBtnItem.Checked == true)
            {
                index = e.RowIndex;
                if (index >= 0)
                {
                    cbBoxCategory.Text = originListItems[index].category;
                    tbCode.Text = originListItems[index].code;
                    tbName.Text = originListItems[index].name;
                    tbEDate.Text = originListItems[index].date.ToString("dd/MM/yyyy");
                    tbCompany.Text = originListItems[index].company;
                    tbYear.Text = originListItems[index].year.ToString();
                }
            }

        }
        // Selecting Status on cbBoxCategory

        string savedSelectedText;
        int savedSelectedIndex;
        string text;
        private void cbBoxCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            savedSelectedText = cbBoxCategory.SelectedItem.ToString();
            savedSelectedIndex = cbBoxCategory.SelectedIndex;
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (radioBtnItem.Checked == true)
            {
                if (isInputValidItem())
                {
                    if (originListItems.Length > 0)
                    {
                        if (isDuplicateCategoryItem() == false)
                        {

                            DialogResult result = MessageBox.Show($"Loại hàng {cbBoxCategory.Text} hiện chưa có. Bạn có muốn thêm loại hàng {cbBoxCategory.Text}? ", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (result == DialogResult.OK)
                            {
                                cbBoxCategory.Items.Add(cbBoxCategory.Text);
                            }
                            else
                            {
                                return;
                            }
                        }
                        originListItems[index].category = cbBoxCategory.Text;
                        originListItems[index].code = tbCode.Text;
                        originListItems[index].name = tbName.Text;
                        try
                        {
                            originListItems[index].date = DateTime.ParseExact(tbEDate.Text, "dd/MM/yyyy", null);
                        }
                        catch
                        {
                            MessageBox.Show("Vui lòng nhập đúng hạn dùng dd/MM/yyyy", "Lưu ý");
                            return;
                        }
                        originListItems[index].company = tbCompany.Text;
                        originListItems[index].year = Int32.Parse(tbYear.Text);
                        dataGridViewItems.DataSource = null;
                        dataGridViewItems.DataSource = originListItems;
                        dataGridViewItems.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }
                    else
                    {
                        MessageBox.Show("Chưa có mặt hàng, vui lòng thêm mặt hàng");
                        return;
                    }
                }
            }
            if (radioBtnCategory.Checked == true)
            {
                if (isInputValidCategory())
                {
                    starLabel.Visible = false;
                    if (cbBoxCategory.Items.Count == 0 && cbBoxCategory.Text != "")
                    {
                        MessageBox.Show("Chưa có loại hàng nào , vui lòng thêm loại hàng trước khi sửa ");
                        return;
                    }
                    if (savedSelectedIndex > -1 && cbBoxCategory.Text != "")
                    {
                        text = cbBoxCategory.Text;
                        if (isDuplicateCategoryCategory() == false)
                        {
                            cbBoxCategory.Items[savedSelectedIndex] = text;
                            for (int i = 0; i < originListItems.Length; i++)
                            {
                                if (originListItems[i].category == savedSelectedText)
                                {
                                    originListItems[i].category = text;
                                }
                            }
                            dataGridViewItems.DataSource = null;
                            dataGridViewItems.DataSource = originListItems;
                            MessageBox.Show("Đã sửa loại hàng thành công");
                            savedSelectedIndex = -1;
                        }
                        else
                        {
                            text = cbBoxCategory.Text;
                            if (savedSelectedText == text)
                            {
                                MessageBox.Show($"Có vẻ bạn chưa nhập loại hàng mới");
                                return;
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show($"Loại hàng {text} đã tồn tại. \nBạn có muốn chuyển tất cả mặt hàng thuộc loại hàng {savedSelectedText} thành loại hàng {text}?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                if (result == DialogResult.OK)
                                {
                                    for (int i = 0; i < originListItems.Length; i++)
                                    {
                                        if (originListItems[i].category == savedSelectedText)
                                        {
                                            originListItems[i].category = text;
                                        }
                                    }
                                    dataGridViewItems.DataSource = null;
                                    dataGridViewItems.DataSource = originListItems;
                                    MessageBox.Show("Đã sửa loại hàng thành công");
                                    savedSelectedIndex = -1;
                                }
                                else
                                {
                                    return;
                                }
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Vui lòng chọn loại hàng cần thao tác (*) ");
                        starLabel.Visible = true;
                        savedSelectedIndex = -1;
                        return;
                    }
                }

            }
            if (!radioBtnItem.Checked && !radioBtnCategory.Checked)
            {
                MessageBox.Show("Vui lòng chọn vùng thao tác");
                return;
            }
        }
        public bool isDuplicateCategoryItem()
        {

            string cbText = cbBoxCategory.Text;
            for (int i = 0; i <= cbBoxCategory.Items.Count - 1; i++)
            {
                if (cbBoxCategory.Items[i].ToString() == cbText)
                {
                    return true;
                }
            }
            return false;
        }
        public bool isDuplicateCategoryCategory()
        {
            if (text == savedSelectedText)
            {
                return true;
            }
            for (int i = 0; i <= cbBoxCategory.Items.Count - 1; i++)
            {
                if (cbBoxCategory.Items[i].ToString() == text)
                {
                    return true;
                }
            }
            return false;
        }

        // DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (radioBtnItem.Checked == true)
            {
                if (index >= 0 && originListItems.Length > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng này không ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        originListItems = RemoveItemFromArray(originListItems, index);
                        dataGridViewItems.DataSource = null;
                        dataGridViewItems.DataSource = originListItems;
                        dataGridViewItems.Refresh();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có mặt hàng, vui lòng thêm mặt hàng");
                    return;
                }
            }
            if (radioBtnCategory.Checked == true)
            {
                starLabel.Visible = false;
                if (cbBoxCategory.Items.Count == 0 && cbBoxCategory.Text != "")
                {
                    MessageBox.Show("Chưa có loại hàng nào , mời bạn tạo loại hàng");
                    return;
                }
                if (savedSelectedIndex > -1 && cbBoxCategory.Text != "")
                {
                    DialogResult result = MessageBox.Show($"Xóa loại hàng {savedSelectedText} sẽ xóa tất cả các mặt hàng thuộc loại hàng {savedSelectedText}. Bạn có muốn tiếp tục không ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        cbBoxCategory.Items.RemoveAt(savedSelectedIndex);
                        cbBoxCategory.Text = "";
                        if (originListItems.Length > 0)
                        {
                            int j = 0;
                            while (j < originListItems.Length)
                            {
                                if (originListItems[j].category == savedSelectedText)
                                {
                                    originListItems = RemoveItemFromArray(originListItems, j);
                                    j = 0;
                                    continue;
                                }
                                j++;
                            }
                            dataGridViewItems.DataSource = null;
                            dataGridViewItems.DataSource = originListItems;
                            savedSelectedIndex = -1;
                        }
                    }
                    else
                    {
                        return;
                    }

                }
                else
                {
                    if (savedSelectedIndex == -1)
                    {
                        if (cbBoxCategory.Text == "" && cbBoxCategory.Items.Count == 0)
                        {
                            MessageBox.Show("Chưa có loại hàng nào , mời bạn tạo loại hàng");
                            savedSelectedIndex = -1;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn loại hàng cần thao tác (*) ");
                            starLabel.Visible = true;
                            savedSelectedIndex = -1;
                            return;
                        }
                    }
                    if (savedSelectedIndex == 0)
                    {
                        if (cbBoxCategory.Text == "" && cbBoxCategory.Items.Count == 0)
                        {
                            MessageBox.Show("Chưa có loại hàng nào , mời bạn tạo loại hàng");
                            savedSelectedIndex = -1;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn loại hàng cần thao tác (*) ");
                            starLabel.Visible = true;
                            savedSelectedIndex = -1;
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn loại hàng cần thao tác (*) ");
                        starLabel.Visible = true;
                        savedSelectedIndex = -1;
                        return;
                    }
                }
            }
            if (!radioBtnItem.Checked && !radioBtnCategory.Checked)
            {
                MessageBox.Show("Vui lòng chọn vùng thao tác");
                return;
            }
        }
        // SEARCH 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
            {
                if (radioBtnItem.Checked)
                {
                    string toLowerSearchText = tbSearch.Text.ToLower();
                    Item[] filteredArray = Array.FindAll(originListItems, i => i.code.ToLower().Contains(toLowerSearchText) || i.name.ToLower().Contains(toLowerSearchText) || i.company.ToLower().Contains(toLowerSearchText) || i.year.ToString().Contains(toLowerSearchText) || i.date.ToString().Contains(toLowerSearchText));
                    if (filteredArray.Length > 0)
                    {
                        dataGridViewItems.DataSource = null;
                        dataGridViewItems.DataSource = filteredArray;
                    }
                    else
                    {
                        MessageBox.Show($"Không tìm thấy thông tin phù hợp cho '{tbSearch.Text}'. \nNếu bạn đang muốn tìm theo trường loại hàng, xin vui lòng chọn vùng thao tác là loại hàng", "Lưu ý");
                        return;
                    }
                }
                if (radioBtnCategory.Checked)
                {
                    string toLowerSearchText = tbSearch.Text.ToLower();
                    int indexCbFindString = cbBoxCategory.FindString(toLowerSearchText);

                    if (indexCbFindString >= 0)
                    {
                        string filterCBValue = cbBoxCategory.Items[indexCbFindString].ToString();
                        Item newFilterCBValue = new Item();
                        newFilterCBValue.category = filterCBValue;
                        Item[] filteredArray = Array.FindAll(originListItems, i => i.category.ToLower().Contains(toLowerSearchText));
                        if (filteredArray.Length > 0)
                        {
                            //for (int i = 0; i < filteredArray.Length; i++)
                            //{
                            //    if (filterCBValue != filteredArray[i].category)
                            //    {
                            //        filteredArray = AddItemToArray(filteredArray, newFilterCBValue);
                            //    }
                            //}
                            dataGridViewItems.DataSource = null;
                            dataGridViewItems.DataSource = filteredArray;
                        }
                        else
                        {
                            Item[] filteredCategoryArray = new Item[0];
                            filteredCategoryArray = AddItemToArray(filteredCategoryArray, newFilterCBValue);
                            dataGridViewItems.DataSource = null;
                            dataGridViewItems.DataSource = filteredCategoryArray;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Không tìm thấy loại hàng '{tbSearch.Text}'");
                        return;
                    }

                }
                if (!radioBtnItem.Checked && !radioBtnCategory.Checked)
                {
                    MessageBox.Show("Vui lòng chọn vùng thao tác");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Xin mời nhập thông tin tìm kiếm");
                return;
            }
        }
        // Change datagridview to originDataGridView when tbSearch is empty

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                dataGridViewItems.DataSource = originListItems;
            }
        }

        // CREATE STRUCT ITEM TYPE
        public struct Item
        {
            public string category { set; get; }
            public string code { set; get; }
            public string name { set; get; }
            public DateTime date { set; get; }
            public string company { set; get; }
            public int year { set; get; }
        }
    }
}
