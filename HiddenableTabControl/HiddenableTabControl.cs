using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhalanXware
{
    public partial class HiddenableTabControl : TabControl{

        [Browsable(true)]
        [Category("Appearance")]
        public bool HiddenTab { set; get; }

        protected override void WndProc(ref Message m){
            // Hide tabs by trapping the TCM_ADJUSTRECT message
            if (m.Msg == 0x1328 && !DesignMode && this.HiddenTab == true)
                m.Result = (IntPtr)1;
            else
                base.WndProc(ref m);
        }
    }     
}
