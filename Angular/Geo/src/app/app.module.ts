import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule  } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { routing } from './app.routing';
import { LabelComponent } from './label/label.component';
import { PrincipalComponent } from './principal/principal.component';
import { TagComponent } from './tag/tag.component';
import { AutocompliteComponent } from './autocomplite/autocomplite.component';
import { HomeComponent } from './home/home.component';
import { PrincipalTagComponent } from './principal/principal.tag/principal.tag.component';
import { PrincipalLabelComponent } from './principal/principal.label/principal.label.component';

@NgModule({
  declarations: [
    AppComponent,
    LabelComponent,
    PrincipalComponent,
    TagComponent,
    AutocompliteComponent,
    HomeComponent,
    PrincipalTagComponent,
    PrincipalLabelComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpModule,
    routing
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
