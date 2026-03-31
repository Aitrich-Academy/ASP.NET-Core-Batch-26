import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { JobprovidersComponent } from './jobproviders/jobproviders.component';
import { NewRegistrationsComponent } from './new-registrations/new-registrations.component';

const routes: Routes = [
  { path: 'jobproviders', component: JobprovidersComponent },
  {path:'new-registrations',component:NewRegistrationsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
