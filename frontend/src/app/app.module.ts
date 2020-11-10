import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { VitrineComponent } from './components/vitrine/vitrine.component';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import {
  MatButtonModule,
  MatCardModule,
  MatIconModule,
  MatToolbarModule
} from '@angular/material';
import { CardProdutoComponent } from './components/card-produto/card-produto.component';
import { StoreModule } from '@ngrx/store';
import { EffectsModule } from '@ngrx/effects';
import { carrinhoReducer } from './core/state/cart/cart.reducer';
import { CarrinhoEffects } from './core/state/cart/cart.effects';
import { StoreDevtoolsModule } from '@ngrx/store-devtools';
import { environment } from '../environments/environment';

@NgModule({
  declarations: [
    AppComponent,
    VitrineComponent,
    CardProdutoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CommonModule,
    HttpClientModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatCardModule,
    StoreModule.forRoot({
      cart: carrinhoReducer
    }),
    EffectsModule.forRoot([
      CarrinhoEffects
    ]),
    StoreDevtoolsModule.instrument({ maxAge: 25, logOnly: environment.production })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
