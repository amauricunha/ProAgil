import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'; // também para conseguir utilizar o módulo

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventosComponent } from './eventos/eventos.component';

@NgModule({
   declarations: [
      AppComponent,
      EventosComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      HttpClientModule // módulo para conseguir fazer um get ajax
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
