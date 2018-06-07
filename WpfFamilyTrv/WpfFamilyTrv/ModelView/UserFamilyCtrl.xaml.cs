using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfFamilyTrv.Model;
using WpfFamilyTrv.Data;
using WpfFamilyTrv.ModelView;

namespace WpfFamilyTrv.ModelView
{
    /// <summary>
    /// Interaction logic for UserFamilyCtrl.xaml
    /// </summary>
    public partial class UserFamilyCtrl : UserControl
    {
        Database db = new Database();
        readonly FamilyTreeViewModel _familyTree;
        private Point startPoint;
        public UserFamilyCtrl()
        {
            Person rootPerson = db.GetFamilyTree();

            // Create UI-friendly wrappers around the 
            // raw data objects (i.e. the view-model).
            _familyTree = new FamilyTreeViewModel(rootPerson);

            // Let the UI bind to the view-model.
            InitializeComponent();

            // Let the UI bind to the view-model.
            base.DataContext = _familyTree;

        }

        void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                _familyTree.SearchCommand.Execute(null);
        }

        private void Tree_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(null);
        }

        private void Tree_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                var mousePos = e.GetPosition(null);
                var diff = startPoint - mousePos;

                if (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance
                    || Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance)
                {
                    var treeView = sender as TreeView;
                    var treeViewItem =
                        FindAnchestor<TreeViewItem>((DependencyObject)e.OriginalSource);

                    if (treeView == null || treeViewItem == null)
                        return;

                    var folderViewModel = treeView.SelectedItem as PersonViewModel;
                    if (folderViewModel == null)
                        return;

                    var dragData = new DataObject(folderViewModel);
                    DragDrop.DoDragDrop(treeViewItem, dragData, DragDropEffects.Move);
                }
            }
        }

        private void DropTree_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(PersonViewModel)) ||
                sender != e.Source)
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void DropTree_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PersonViewModel)))
            {
                var personViewModel = e.Data.GetData(typeof(PersonViewModel)) as PersonViewModel;

                var treeViewItem =
                    FindAnchestor<TreeViewItem>((DependencyObject)e.OriginalSource);

                var dropTarget = treeViewItem.Header as PersonViewModel;

                if (dropTarget == null || personViewModel == null)
                    return;

                personViewModel.Parent = dropTarget;
            }
        }

        // Helper to search up the VisualTree
        private static T FindAnchestor<T>(DependencyObject current)
            where T : DependencyObject
        {
            do
            {
                if (current is T)
                {
                    return (T)current;
                }
                current = VisualTreeHelper.GetParent(current);
            }
            while (current != null);
            return null;
        }
    }
}
