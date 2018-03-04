import { Label } from './label/label.model';
import { Tag } from './tag/Tag.model';

export class SubjectMatter {

    private id: number;
    public get Id() { return this.id; }
    public set Id(value: number) { this.id = value; }

    private content: string;
    public get Content() { return this.content; }
    public set Content(value: string) { this.content = value; }
    
    private status: boolean;
    public get Status() { return this.status; }
    public set Status(value: boolean) { this.status = value; }

    private labels: Array<Label>;
    public get Labels() { return this.labels; }
    public set Labels(value: Array<Label>) { this.labels = value; }

    public tags: Array<Tag>;
    public get Tags() { return this.tags; }
    public set Tags(value: Array<Tag>) { this.tags = value; }
}