import { AppState } from './../index';
import { createSelector } from '@ngrx/store';

export const cartSelector = (state: AppState) => state.cart;

export const selectCarrinho = createSelector(
  cartSelector,
  state => state.pedido
);
