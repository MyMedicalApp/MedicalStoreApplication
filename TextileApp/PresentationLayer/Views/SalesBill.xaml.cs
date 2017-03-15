using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Windows.Controls.Primitives;

namespace MedicalApp.Views
{
    /// <summary>
    /// Interaction logic for SalesBill.xaml
    /// </summary>
    public partial class SalesBill : Page
    {
        public SalesBill()
        {
            InitializeComponent();
        }

        private void SalesBillGrid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //just accept enter key
            if (e.Key != Key.Enter) return;

            DependencyObject dep = (DependencyObject)e.OriginalSource;
            //here we just find the cell got focused ...
            //then we can use the cell key down or key up
            // iteratively traverse the visual tree
            while ((dep != null) && !(dep is DataGridCell) && !(dep is DataGridColumnHeader))
            {
                dep = VisualTreeHelper.GetParent(dep);
            }

            if (dep == null)
                return;

            if (dep is DataGridCell)
            {
                //cancel if datagrid in edit mode
                SalesBillGrid.CancelEdit();
                //get current cell
                DataGridCell cell = dep as DataGridCell;
                //deselect current cell
                cell.IsSelected = false;
                //find next right cell
                var nextCell = cell.PredictFocus(FocusNavigationDirection.Right);
                //if next right cell null go for find next ro first cell
                if (nextCell == null)
                {
                    DependencyObject nextRowCell;
                    nextRowCell = cell.PredictFocus(FocusNavigationDirection.Down);
                    //if next row is null so we have no more row Return;
                    if (nextRowCell == null) return;
                    //we do this because we cant use FocusNavigationDirection.Next for function PredictFocus
                    //so we have to find it this way
                    while ((nextRowCell as DataGridCell).PredictFocus(FocusNavigationDirection.Left) != null)
                        nextRowCell = (nextRowCell as DataGridCell).PredictFocus(FocusNavigationDirection.Left);
                    //set new cell as next cell
                    nextCell = nextRowCell;
                }
                //change current cell
                SalesBillGrid.CurrentCell = new DataGridCellInfo(nextCell as DataGridCell);
                //change selected cell
                (nextCell as DataGridCell).IsSelected = true;
                // start edit mode
                SalesBillGrid.BeginEdit();
            }
            //handl the default action of keydown
            e.Handled = true;
        }

        private void SalesBillGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit)
            {
                 SalesBillGrid.BeginEdit();
            }
        }
    }
}
