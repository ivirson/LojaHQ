import { ActionReducerMap } from '@ngrx/store';
import * as cart from './cart';

export interface AppState {
  cart: cart.reducer.CarrinhoState;
}

export const reducers: ActionReducerMap<AppState> = {
  cart: cart.reducer.carrinhoReducer
};

export const effects: Array<any> = [
  cart.effects
];

export const initialState = {
  cart: cart.reducer.carrinhoState
};
