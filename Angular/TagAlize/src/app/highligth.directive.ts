import { Directive, ElementRef, HostListener , Input } from '@angular/core';

@Directive({
  selector: '[appHighligth]'
})
export class HighligthDirective {

  @Input() highlightColor: string;

  constructor(private el: ElementRef) {
    console.log(`Elemento: ${this.el}`);
  }

  @HostListener('mouseenter') onMouseEnter() {
    this.highlight('yellow');
  }

  @HostListener('mouseleave') onMouseLeave() {
    this.highlight(null);
  }

  private highlight(color: string) {
    this.el.nativeElement.style.backgroundColor = color;
  }

}
