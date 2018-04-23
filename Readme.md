# How to close an active in-place editor via a custom shortcut


<p>An in-place editor is activated when an end-user adds a new appointment by pressing the Enter key in selected cells or edits the appointment by pressing the F2 key. By default, a user can close the  editor via the Enter key (save modifications) or the Escape key (cancel modifications). If you wish to change these shortcuts, it is necessary to create a custom in-place editor and override its  TextBox_KeyDown method. This example illustrates how to provide the capability to close the editor via the Ctrl+S shortcut and cancel changes via the Ctrl+Z shortcut.</p>

<br/>


