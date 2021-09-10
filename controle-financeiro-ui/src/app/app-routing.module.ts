import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListagemCategoriasComponent } from './components/Categoria/listagem-categorias/listagem-categorias.component';
import { NovaCategoriaComponent } from './components/Categoria/nova-categoria/nova-categoria.component';


const routes: Routes = [
  {
    path : 'categorias/listagemCategorias', component: ListagemCategoriasComponent
  },

  {
    path : 'categorias/novaCategorias', component: NovaCategoriaComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
