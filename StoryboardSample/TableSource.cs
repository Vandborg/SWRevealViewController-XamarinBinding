using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SWRevealExample {
  public class TableSource : UITableViewSource {
    public TableSource() {}

    public override int RowsInSection(UITableView tableview, int section) {
      return 3;
    }

    public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath) {
      string cellIdentifier = @"Cell";

      switch (indexPath.Row) {
        case 0:
          cellIdentifier = @"one";
          break;

        case 1:
          cellIdentifier = @"two";
          break;

        case 2:
          cellIdentifier = @"three";
          break;
      }

      UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
      return cell;
    }
  }
}
