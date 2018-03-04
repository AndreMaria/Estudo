export class Tag {
    private id: number;
    public get Id() { return this.id; }
    public set Id(value: number) { this.id = value; }

    private simpleText: string;
    public get SimpleText() { return this.simpleText; }
    public set SimpleText(value: string) { this.simpleText = value; }

    private normalized: string;
    public get Normalized() { return this.normalized; }
    public set Normalized(value: string) { this.normalized = value; }

    private idSubjectMatter: number;
    public get IdSubjectMatter() { return this.idSubjectMatter; }
    public set IdSubjectMatter(value: number) { this.idSubjectMatter = value; }
}