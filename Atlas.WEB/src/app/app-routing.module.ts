import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './core/Components/login/login.component';
import { AuthGuard } from './core/Guards/auth-guard.service';
import { HomeComponent } from './Pages/home/home.component';


const routes: Routes = [
{path: 'ouvidoria', loadChildren: () => import('./Pages/ouvidoria/ouvidoria.module').then(m => m.OuvidoriaModule)},
{path: 'seguroviagem', loadChildren: () => import('./Pages/seguro-viagem/seguro-viagem.module').then(s => s.SeguroViagemModule)},
{path: 'login', component: LoginComponent},
{path: '', component: HomeComponent, canActivate: [AuthGuard]},
{path: '**', redirectTo: '', canActivate: [AuthGuard]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
