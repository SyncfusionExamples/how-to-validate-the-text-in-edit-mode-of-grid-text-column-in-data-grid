using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SfDataGridDemo
{
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
}
