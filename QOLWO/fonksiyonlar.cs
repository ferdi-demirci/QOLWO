using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QOLWO
{
    class fonksiyonlar
    {
        public void texleridoldur(Control kontroladi, DevExpress.XtraGrid.Views.Grid.GridView Gridismi, string fieldname)
        {
            kontroladi.Text = Gridismi.GetFocusedRowCellValue(fieldname).ToString();

        }
   
        
    }
}
