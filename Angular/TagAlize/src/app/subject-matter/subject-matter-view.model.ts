export class SubjectMatterView {

    private content: string;
    public get Content() { return this.content; }
    public set Content(value: string) { this.content = value; }

    private label: string;
    public get Label() { return this.label; }
    public set Label(value: string) { this.label = value; }

    public tags: Array<string>;
    public get Tags() { return this.tags; }
    public set Tags(value: Array<string>) { this.tags = value; }

}

