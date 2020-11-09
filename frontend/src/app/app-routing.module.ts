import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { VitrineComponent } from './components/vitrine/vitrine.component';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    redirectTo: 'vitrine',
  },
  {
    path: 'vitrine',
    component: VitrineComponent,
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
