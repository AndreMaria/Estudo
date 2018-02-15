import { Route, Router, Routes, RouterModule } from '@angular/router';
import { ModuleWithProviders } from '@angular/core';

import { LabelComponent } from './label/label.component';
import { TagComponent } from './tag/tag.component';
import { PrincipalComponent } from './principal/principal.component';

const appRoutes: Routes = [
  { path: 'label', component: LabelComponent },
  { path: 'principal', component: PrincipalComponent },
  { path: 'tag', component: TagComponent }
];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);
