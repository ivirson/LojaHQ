import { ProdutoPedido } from './../../models/produto-pedido.model';
import { Pedido } from './../../models/pedido.model';
import { AppState } from './../../core/state/index';
import { Produto } from './../../models/produto.model';
import { Component, Input, OnInit } from '@angular/core';
import { Store } from '@ngrx/store';
import { Router } from '@angular/router';
import * as fromCart from '../../core/state/cart';
import { selectCarrinho } from 'src/app/core/state/cart/cart.selectors';

@Component({
  selector: 'app-card-produto',
  templateUrl: './card-produto.component.html',
  styleUrls: ['./card-produto.component.scss']
})
export class CardProdutoComponent implements OnInit {

  @Input() public produto: Produto;
  public pedido = new Pedido();

  constructor(
    private store$: Store<AppState>,
    private router: Router
  ) { }

  ngOnInit() {
  }

  public viewProductDetails(produtoId: number) {

  }

  public handleAddToCart(produtoId: number) {
    this.pedido.produtos.push(
      {
        produtoId: produtoId,
        produto: this.produto,
        // quantidade: 1
      }
    );
    this.store$.dispatch(new fromCart.actions.AddItemCarrinho(this.pedido));
  }

  public handleBuyItem(produtoId: number) {
    alert(produtoId);
  }

}
