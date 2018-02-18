export class Tag {
    private id: number;
    get Id(){
        return this.id;
    }
    set Id(value: number){
        this.id = value;
    }
    
    private item: string;
    get Item(){
        return this.item;
    }
    set Item(value: string){
        this.item = value;
    }

    private normalized: string;
    get Normalized(){
        return this.normalized;
    }
    set Normalized(value: string){
        this.normalized = value;
    }

    private idMain: number;
    get IdMain(){
        return this.idMain;
    }
    set IdMain(value: number){
        this.idMain = value;
    }
}