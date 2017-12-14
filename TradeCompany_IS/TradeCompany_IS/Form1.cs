using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeCompany_IS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void документ__Продажа_товара_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.документ__Продажа_товара_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trade_company_DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trade_company_DataSet._Справочник__Товары_". При необходимости она может быть перемещена или удалена.
            this.справочник__Товары_TableAdapter.Fill(this.trade_company_DataSet._Справочник__Товары_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trade_company_DataSet._Справочник__Покупатели_". При необходимости она может быть перемещена или удалена.
            this.справочник__Покупатели_TableAdapter.Fill(this.trade_company_DataSet._Справочник__Покупатели_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trade_company_DataSet._Справочник__Продавцы_". При необходимости она может быть перемещена или удалена.
            this.справочник__Продавцы_TableAdapter.Fill(this.trade_company_DataSet._Справочник__Продавцы_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trade_company_DataSet._Справочник__Торговые_точки_". При необходимости она может быть перемещена или удалена.
            this.справочник__Торговые_точки_TableAdapter.Fill(this.trade_company_DataSet._Справочник__Торговые_точки_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trade_company_DataSet._Документ__Продажа_товара_". При необходимости она может быть перемещена или удалена.
            this.документ__Продажа_товара_TableAdapter.Fill(this.trade_company_DataSet._Документ__Продажа_товара_);

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportForm();
            reportForm.Show();
        }
    }
}
