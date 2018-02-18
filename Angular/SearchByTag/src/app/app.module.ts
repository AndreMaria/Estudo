import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';


import { AppComponent } from './app.component';
import { MainComponent } from './main/main.component';
import { LabelComponent } from './main/label/label.component';
import { TagComponent } from './main/tag/tag.component';
import { GridComponent } from './main/grid/grid.component';


@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    LabelComponent,
    TagComponent,
    GridComponent
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
