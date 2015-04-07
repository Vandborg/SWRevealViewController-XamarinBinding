using Foundation;
using UIKit;
using System;

namespace SWRevealExample {
  public class TableSource : UITableViewSource {
    public TableSource() {}

    public override nint RowsInSection(UITableView tableview, nint section) {
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
