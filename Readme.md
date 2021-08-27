<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128634049/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5189)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to close an active in-place editor via a custom shortcut


<p>An in-place editor is activated when an end-user adds a new appointment by pressing the Enter key in selected cells or edits the appointment by pressing the F2 key. By default, a user can close the  editor via the Enter key (save modifications) or the Escape key (cancel modifications). If you wish to change these shortcuts, it is necessary to create a custom in-place editor and override its  TextBox_KeyDown method. This example illustrates how to provide the capability to close the editor via the Ctrl+S shortcut and cancel changes via the Ctrl+Z shortcut.</p>

<br/>


