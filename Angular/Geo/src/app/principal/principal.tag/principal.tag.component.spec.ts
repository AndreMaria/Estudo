import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Principal.TagComponent } from './principal.tag.component';

describe('Principal.TagComponent', () => {
  let component: Principal.TagComponent;
  let fixture: ComponentFixture<Principal.TagComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Principal.TagComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Principal.TagComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
