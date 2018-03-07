import { Model } from '../model';

export class Tag extends Model {

    constructor(obj?: any) {
      super(obj);
    }
    public id: number;
    public simpleText: string;
    public normalized: string;
    public idSubjectMatter: number;
}
