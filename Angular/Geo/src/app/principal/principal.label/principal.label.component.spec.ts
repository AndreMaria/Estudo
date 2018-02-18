import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Principal.LabelComponent } from './principal.label.component';

describe('Principal.LabelComponent', () => {
  let component: Principal.LabelComponent;
  let fixture: ComponentFixture<Principal.LabelComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Principal.LabelComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Principal.LabelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
