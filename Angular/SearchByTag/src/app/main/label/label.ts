export class Label {
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

    private category: string;
    get Category(){
        return this.category;
    }
    set Category(value: string){
        this.category = value;
    }

    private idMain: number;
    get IdMain(){
        return this.idMain;
    }
    set IdMain(value: number){
        this.idMain = value;
    }

}