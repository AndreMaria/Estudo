import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SubjectMatterComponent } from './subject-matter.component';

describe('SubjectMatterComponent', () => {
  let component: SubjectMatterComponent;
  let fixture: ComponentFixture<SubjectMatterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SubjectMatterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SubjectMatterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
