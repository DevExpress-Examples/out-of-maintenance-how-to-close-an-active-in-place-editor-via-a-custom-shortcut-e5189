namespace DXApplication5
{
    #region #myinplaceeditor
    public class MyInplaceEditor : DevExpress.XtraScheduler.Native.SchedulerInplaceEditorEx
    {
        public MyInplaceEditor(DevExpress.XtraScheduler.SchedulerInplaceEditorEventArgs inplaceEditorArgs)
            : base(inplaceEditorArgs)
        {
        }
        protected override void TextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == System.Windows.Forms.Keys.S)
            {
                OnCommitChanges();
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == System.Windows.Forms.Keys.Z)
            {
                OnRollbackChanges();
                e.Handled = true;
            }
            else
                //base.TextBox_KeyDown(sender, e);
                e.Handled = true;
        }
    }
    #endregion #myinplaceeditor
}
