import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { SubjectMatterComponent } from './subject-matter/subject-matter.component';
import { LabelComponent } from './subject-matter/label/label.component';
import { TagComponent } from './subject-matter/tag/tag.component';
import { HighligthDirective } from './highligth.directive';


@NgModule({
  declarations: [
    AppComponent,
    SubjectMatterComponent,
    LabelComponent,
    TagComponent,
    HighligthDirective
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
