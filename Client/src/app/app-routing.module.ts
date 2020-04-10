import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TextAnalyzerComponent } from './Components/text-analyzer/text-analyzer.component';



const routes: Routes = [
  { path: '',  component: TextAnalyzerComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
