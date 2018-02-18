import { StandardNormalized } from './StandardNormalized';

export class StandardTags {
    private standardItem:  StandardNormalized;
    get StandardItem() {		return this.standardItem;  }
    set StandardItem(value:  StandardNormalized) {    this.standardItem = value;  }
    private listSubItem: Array<StandardNormalized>;
    get ListSubItem() {		return this.listSubItem;  }
    set ListSubItem(value:  Array<StandardNormalized>) {    this.listSubItem = value;  }
}