import { Action } from '@ngrx/store';

export enum ActionTypes {
    GET_CARRINHO = '[CARRINHO] Get Carrinho',
    GET_CARRINHO_SUCESSO = '[CARRINHO] Get Carrinho Sucesso',
    GET_CARRINHO_ERRO = '[CARRINHO] Get Carrinho Erro',
    ADD_ITEM_CARRINHO = '[CARRINHO] Adiciona Item ao Carrinho',
    ADD_ITEM_CARRINHO_SUCESSO = '[CARRINHO] Adiciona Item ao Carrinho Sucesso',
    ADD_ITEM_CARRINHO_ERRO = '[CARRINHO] Adiciona Item ao Carrinho Erro',
    REMOVE_ITEM_CARRINHO = '[CARRINHO] Remove Item do Carrinho',
    REMOVE_ITEM_CARRINHO_SUCESSO = '[CARRINHO] Remove Item do Carrinho Sucesso',
    REMOVE_ITEM_CARRINHO_ERRO = '[CARRINHO] Remove Item do Carrinho Erro',
    LIMPAR_CARRINHO = '[CARRINHO] Limpar Carrinho',
    LIMPAR_CARRINHO_SUCESSO = '[CARRINHO] Limpar Carrinho Sucesso',
    LIMPAR_CARRINHO_ERRO = '[CARRINHO] Limpar Carrinho Erro'
}

export class GetCarrinho implements Action {
    readonly type = ActionTypes.GET_CARRINHO;
    constructor(public payload?: any) {}
}

export class GetCarrinhoSucesso implements Action {
    readonly type = ActionTypes.GET_CARRINHO_SUCESSO;
    constructor(public payload?: any) {}
}

export class GetCarrinhoErro implements Action {
    readonly type = ActionTypes.GET_CARRINHO_ERRO;
    constructor(public payload?: any) {}
}

export class AddItemCarrinho implements Action {
    readonly type = ActionTypes.ADD_ITEM_CARRINHO;
    constructor(public payload?: any) {}
}

export class AddItemCarrinhoSucesso implements Action {
    readonly type = ActionTypes.ADD_ITEM_CARRINHO_SUCESSO;
    constructor(public payload?: any) {}
}

export class AddItemCarrinhoErro implements Action {
    readonly type = ActionTypes.ADD_ITEM_CARRINHO_ERRO;
    constructor(public payload?: any) {}
}

export class RemoveItemCarrinho implements Action {
    readonly type = ActionTypes.REMOVE_ITEM_CARRINHO;
    constructor(public payload?: any) {}
}

export class RemoveItemCarrinhoSucesso implements Action {
    readonly type = ActionTypes.REMOVE_ITEM_CARRINHO_SUCESSO;
    constructor(public payload?: any) {}
}

export class RemoveItemCarrinhoErro implements Action {
    readonly type = ActionTypes.REMOVE_ITEM_CARRINHO_ERRO;
    constructor(public payload?: any) {}
}

export class LimparCarrinho implements Action {
    readonly type = ActionTypes.LIMPAR_CARRINHO;
    constructor(public payload?: any) {}
}

export class LimparCarrinhoSucesso implements Action {
    readonly type = ActionTypes.LIMPAR_CARRINHO_SUCESSO;
    constructor(public payload?: any) {}
}

export class LimparCarrinhoErro implements Action {
    readonly type = ActionTypes.LIMPAR_CARRINHO_ERRO;
    constructor(public payload?: any) {}
}

export type CarrinhoActions =
    | GetCarrinho
    | GetCarrinhoSucesso
    | GetCarrinhoErro
    | AddItemCarrinho
    | AddItemCarrinhoSucesso
    | AddItemCarrinhoErro
    | RemoveItemCarrinho
    | RemoveItemCarrinhoSucesso
    | RemoveItemCarrinhoErro
    | LimparCarrinho
    | LimparCarrinhoSucesso
    | LimparCarrinhoErro;
