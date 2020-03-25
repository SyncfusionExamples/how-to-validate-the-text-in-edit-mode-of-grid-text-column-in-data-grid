# How to validate the text in edit mode of GridTextColumn in DataGrid(SfDataGrid)?	

## About the sample
This example illustrates how to validate the text in edit mode of GridTextColumn in DataGrid(SfDataGrid)?

By default, SfDataGrid does not provide the direct support for validating the text in edit mode in GridTextBoxColumn. You can achieve this by customizing the GridCellTextBoxRenderer class. In this class you can get the old value and new value from KeyDown and KeyUp events.

```C#
public class GridCellTextBoxRendererExt : GridCellTextBoxRenderer
{
       string oldvalue = null;
       string newvalue = null;
        
       public override void OnInitializeEditElement(DataColumnBase dataColumn, TextBox uiElement, object dataContext)
       {
           base.OnInitializeEditElement(dataColumn, uiElement, dataContext);
           uiElement.KeyDown += UiElement_KeyDown;
           uiElement.KeyUp += UiElement_KeyUp;
       }

       private void UiElement_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
       {
           TextBox textBox = (e.OriginalSource as TextBox);
           newvalue = textBox.Text;
           Console.WriteLine("NewValue: " + newvalue + "\n\noldvalue: " + oldvalue);
           if (newvalue == "Sample")
           {
               textBox.Text = oldvalue;
               textBox.SelectionStart = textBox.Text.Length;
           }
       }

       private void UiElement_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
       {
           oldvalue = (e.OriginalSource as TextBox).Text;
       }
} 
```

## Requirements to run the demo
Visual Studio 2015 and above versions
