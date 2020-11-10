import { Effect, ofType, Actions } from '@ngrx/effects';
import { switchMap, catchError, tap } from 'rxjs/operators';
import { Injectable } from '@angular/core';
import { of } from 'rxjs';
import * as actions from './cart.actions';
import { CartService } from 'src/app/services/cart.service';


@Injectable()
export class CarrinhoEffects {
  constructor(
    private actions$: Actions,
    private cartService: CartService
  ) {}

  @Effect()
  addItemCarrinhoAction = this.actions$.pipe(
    ofType<actions.AddItemCarrinho>(actions.ActionTypes.ADD_ITEM_CARRINHO),
    switchMap((response: any) => {
      return of(new actions.AddItemCarrinhoSucesso(response.payload));
    }),
    catchError(err => of(new actions.AddItemCarrinhoErro(err)))
  );

  @Effect({ dispatch: false })
  onError = this.actions$.pipe(
    ofType<
      actions.GetCarrinhoErro |
      actions.AddItemCarrinhoErro |
      actions.RemoveItemCarrinhoErro |
      actions.LimparCarrinhoErro
    >(actions.ActionTypes.GET_CARRINHO_ERRO,
      actions.ActionTypes.ADD_ITEM_CARRINHO_ERRO,
      actions.ActionTypes.REMOVE_ITEM_CARRINHO_ERRO,
      actions.ActionTypes.LIMPAR_CARRINHO_ERRO),
    tap(error => {
      console.log(error);
    })
  );
}
