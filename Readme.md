# How to place a button or editor in the form's title bar


<p>This functionality is supported by RibbonForm. However, this form always displays a ribbon at the top. If you do not want to display RibbonControl, you can create a custom RibbonControl and display only its toolbar at the top. This example demonstrates how to do this. </p><p>To add this functionality in your application, simply add the AdvancedXtraForm class to your project and inherit your forms from this class. Now you can add required items to the TitleToolBar property and they will be displayed in the form's title bar.</p><p>If you want to use this custom form as an MDI child, you need to modify the CalcMinHeight method to handle all possible scenarios. I.e. you need to make the parent ribbon height bigger to show command buttons when a form is maximized or reduce the ribbon height if its parent form is a regular form and the default command bar is already displayed.</p>

<br/>


