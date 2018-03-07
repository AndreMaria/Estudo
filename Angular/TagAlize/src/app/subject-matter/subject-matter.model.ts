import { Label } from './label/label.model';
import { Tag } from './tag/Tag.model';
import { Model } from './model';

export class SubjectMatter extends Model {

    constructor(obj?: any) {
      super(obj);

      if (this.labels) {
        this.labels = this.labels.map(item => new Label(item));
      } else {
          this.labels = new Array<Label>();
      }

      if (this.tags) {
        this.tags = this.tags.map(item => new Tag(item));
      } else {
          this.tags = new Array<Tag>();
      }
    }

    public id: number;
    public content: string;
    public status: boolean;
    public labels: Array<Label>;
    public tags: Array<Tag>;
}
