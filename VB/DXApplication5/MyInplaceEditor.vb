Imports DevExpress.XtraScheduler

Namespace DXApplication5
    #Region "#myinplaceeditor"
    Public Class MyInplaceEditor
        Inherits DevExpress.XtraScheduler.Native.SchedulerInplaceEditorEx

        Public Sub New(ByVal inplaceEditorArgs As DevExpress.XtraScheduler.SchedulerInplaceEditorEventArgs, ByVal apt As Appointment)
            MyBase.New(inplaceEditorArgs, apt)
        End Sub
        Protected Overrides Sub TextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.Control AndAlso e.KeyCode = System.Windows.Forms.Keys.S Then
                OnCommitChanges()
                e.Handled = True
            ElseIf e.Control AndAlso e.KeyCode = System.Windows.Forms.Keys.Z Then
                OnRollbackChanges()
                e.Handled = True
            Else
                'base.TextBox_KeyDown(sender, e);
                e.Handled = True
            End If
        End Sub
    End Class
    #End Region ' #myinplaceeditor
End Namespace
