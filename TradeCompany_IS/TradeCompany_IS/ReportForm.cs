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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_7_Active_Users_DataSet._Документ__Продажа_товара_". При необходимости она может быть перемещена или удалена.
            this.документ__Продажа_товара_TableAdapter.Fill(this._7_Active_Users_DataSet._Документ__Продажа_товара_);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
