using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;

namespace WindowsApplication1
{
    public partial class MainForm : AdvancedXtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            DevExpress.XtraBars.Ribbon.RibbonBarManager manager = TitleBarToolBar.Ribbon.Manager;
            TitleBarToolBar.ItemLinks.Add(new BarButtonItem(manager, "Test"));
            RepositoryItemTextEdit riTextEdit = new RepositoryItemTextEdit();
            TitleBarToolBar.ItemLinks.Add(new BarEditItem(manager, riTextEdit));
            riTextEdit.EditValueChanged += new EventHandler(riTextEdit_EditValueChanged);
            RepositoryItemButtonEdit riButtonEdit = new RepositoryItemButtonEdit();
            riButtonEdit.ButtonClick += riButtonEdit_ButtonClick;
            riButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            riButtonEdit.Buttons[0].Caption = "Button";
            riButtonEdit.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            TitleBarToolBar.ItemLinks.Add(new BarEditItem(manager, riButtonEdit));
        }

        void riButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MessageBox.Show("Test");
        }

        void riTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            Text = (sender as TextEdit).Text;
        }
    }
}
