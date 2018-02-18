export class Standard {
    private standardItem:  string;
    get StandardItem() {		return this.standardItem;  }
    set StandardItem(value:  string) {    this.standardItem = value;  }
    private listSubItem: Array<string>;
    get ListSubItem() {		return this.listSubItem;  }
    set ListSubItem(value:  Array<string>) {    this.listSubItem = value;  }
  }
