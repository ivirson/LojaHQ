import { Usuario } from './usuario.model';
import { ProdutoPedido } from './produto-pedido.model';
export interface Pedido {
  id: number;
  produtos: ProdutoPedido[];
  dataPedido: Date;
  usuario: Usuario;
}
