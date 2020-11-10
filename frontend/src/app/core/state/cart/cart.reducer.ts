import { Pedido } from './../../../models/pedido.model';
import { ActionTypes, CarrinhoActions } from './cart.actions';

export interface CarrinhoState {
    pedido: Pedido | null;
    error: any;
}

export const carrinhoState: CarrinhoState = {
    pedido: null,
    error: null
};

export function carrinhoReducer(state = carrinhoState, action: CarrinhoActions) {
      switch (action.type) {
        case ActionTypes.GET_CARRINHO_SUCESSO:
        {
          return {
            ...state,
            pedido: action.payload
          };
        }

        case ActionTypes.GET_CARRINHO_ERRO:
        {
          return {
            ...state,
            error: action.payload
          };
        }

        case ActionTypes.ADD_ITEM_CARRINHO_SUCESSO:
        {
          if (state.pedido) {
            return {
              ...state,
              pedido: {
                produtos: [
                  ...state.pedido.produtos,
                  action.payload
                ]
              }
            };
          }

          return {
            ...state,
            pedido: {
              produtos: [
                action.payload
              ]
            }
          };
        }

        case ActionTypes.ADD_ITEM_CARRINHO_ERRO:
        {
          return {
            ...state,
            error: action.payload
          };
        }

        case ActionTypes.REMOVE_ITEM_CARRINHO_SUCESSO:
        {
          return {
            ...state,
            pedido: action.payload
          };
        }

        case ActionTypes.REMOVE_ITEM_CARRINHO_ERRO:
        {
          return {
            ...state,
            error: action.payload
          };
        }

        case ActionTypes.LIMPAR_CARRINHO_SUCESSO:
        {
          return {
            ...state,
            pedido: null
          };
        }

        case ActionTypes.LIMPAR_CARRINHO_ERRO:
        {
          return {
            ...state,
            error: action.payload
          };
        }

        default:
          return state;
    }

}
