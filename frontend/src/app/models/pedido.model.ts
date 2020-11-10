import { Usuario } from './usuario.model';
import { ProdutoPedido } from './produto-pedido.model';
export class Pedido {
  id?: number;
  produtos: ProdutoPedido[] = [];
  // dataPedido: Date;
  // usuario: Usuario;
}
