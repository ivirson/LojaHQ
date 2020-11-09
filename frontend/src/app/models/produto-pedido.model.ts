import { Produto } from './produto.model';

export interface ProdutoPedido {
  id: number;
  produto: Produto;
  produtoId: number;
  quantidade: number;
}
