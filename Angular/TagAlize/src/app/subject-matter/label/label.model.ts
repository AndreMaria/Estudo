export class Label{
    private id: number;
    public get Id() { return this.id; }
    public set Id(value: number) { this.id = value; }

    private title: string;
    public get Title() { return this.title; }
    public set Title(value: string) { this.title = value; }

    private idSubjectMatter: number;
    public get IdSubjectMatter() { return this.idSubjectMatter; }
    public set IdSubjectMatter(value: number) { this.idSubjectMatter = value; }
}