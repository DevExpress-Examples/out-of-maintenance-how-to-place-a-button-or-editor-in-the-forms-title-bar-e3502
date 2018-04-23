using System;
using System.Collections.Generic;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System.Drawing;

namespace WindowsApplication1
{
    [System.ComponentModel.DesignerCategory("")]
    public class AdvancedRibbonControl : RibbonControl
    {

        public AdvancedRibbonControl()
        {
            Toolbar.ShowCustomizeItem = false;
            RibbonStyle = RibbonControlStyle.MacOffice;
        }

        protected override RibbonViewInfo CreateViewInfo()
        {
            return new AdvancedRibbonViewInfo(this);
        }
    }

    public class AdvancedRibbonViewInfo : RibbonViewInfo
    {
        public AdvancedRibbonViewInfo(RibbonControl ribbon)
            : base(ribbon)
        {
            
        }


        protected override int CalcMinHeight()
        {
            return Caption.CalcCaptionHeight();
        }

    }
}
