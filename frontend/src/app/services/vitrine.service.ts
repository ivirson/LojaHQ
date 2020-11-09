import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Produto } from '../models/produto.model';

@Injectable({
  providedIn: 'root'
})
export class VitrineService {

  constructor(
    private http: HttpClient
  ) { }

  public getProdutos(): Observable<Produto[]> {
    const endpoint = `${environment.apiRootUrl}vitrine`;
    return this.http.get<Produto[]>(endpoint);
  }
}
