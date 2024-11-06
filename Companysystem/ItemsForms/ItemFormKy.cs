using Companysystem.Clientforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companysystem.ItemsForms
{
    public partial class ItemFormKy : BaseForm
    {
        public ItemFormKy()
        {
            InitializeComponent();
            // تأكد من تعيين WrapMode إلى DataGridViewTriState.True
            dv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // يمكنك أيضًا ضبط ارتفاع الصف تلقائيًا ليتناسب مع النص
            dv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // تأكد من تعيين WrapMode إلى DataGridViewTriState.True لرؤوس الأعمدة
            dv.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // يمكنك أيضًا ضبط ارتفاع رؤوس الأعمدة تلقائيًا ليتناسب مع النص
            dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void ItemFormKy_Load(object sender, EventArgs e)
        {

        }

        private void dv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
