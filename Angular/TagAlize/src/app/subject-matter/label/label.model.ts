import { Model } from '../model';
export class Label  extends Model {

    constructor(obj?: any) {
      super(obj);
    }

    public id: number;
    public title: string;
    public idSubjectMatter: number;
}
