import { Produto } from './produto.model';

export class ProdutoPedido {
  id?: number;
  produto: Produto;
  produtoId: number;
  quantidade?: number;
  previamenteAdicionado?: boolean;
}
