import { Produto } from './../../models/produto.model';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-card-produto',
  templateUrl: './card-produto.component.html',
  styleUrls: ['./card-produto.component.scss']
})
export class CardProdutoComponent implements OnInit {

  @Input() public produto: Produto;

  constructor() { }

  ngOnInit() {
  }

}
