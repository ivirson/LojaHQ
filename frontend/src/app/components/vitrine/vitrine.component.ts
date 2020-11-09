import { Produto } from './../../models/produto.model';
import { Component, OnInit } from '@angular/core';
import { VitrineService } from 'src/app/services/vitrine.service';

@Component({
  selector: 'app-vitrine',
  templateUrl: './vitrine.component.html',
  styleUrls: ['./vitrine.component.scss']
})
export class VitrineComponent implements OnInit {
  public produtos: Produto[];

  constructor(
    private vitrineService: VitrineService
  ) { }

  ngOnInit() {
    this.getProdutos();
  }

  public getProdutos() {
    this.vitrineService.getProdutos().subscribe(
      res => this.produtos = res
    );
  }

}
