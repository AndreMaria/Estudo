export class TagAlize {
    
    private tag: string;
    get Tag(){
        return this.tag;
    }
    set Tag(value: string){
        this.tag = value;
    }

    private normalized: string;
    get Normalized(){
        return this.normalized;
    }
    set Normalized(value: string){
        this.normalized = value;
    }
}