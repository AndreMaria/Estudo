import { Label } from './label/label'
import { Tag } from './tag/tag'

export class Main {
    private id: number;
    get Id(){
        return this.id;
    }
    set Id(value: number){
        this.id = value;
    }
    
    private text: string;
    get Text(){
        return this.text;
    }
    set Text(value: string){
        this.text = value;
    }

    private labels: Array<Label>;
    get Labels() {
        return this.labels;
    }
    set Labels(value: Array<Label>){
        this.labels = value;
    }

    private tags: Array<Tag>;
    get Tags(){
        return this.tags;
    }
    set Tags(value: Array<Tag>){
        this.tags = value;
    }

}