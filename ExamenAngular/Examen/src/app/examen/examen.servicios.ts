import { IUsuario } from './usuarios';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IUsuarioRegistro } from './registro';

@Injectable({
  providedIn: 'root'
})
export class ExamenService {
  registroUrl: string;
  mostrarUrl: string;
  private http: HttpClient;

  constructor(httpClient: HttpClient) {
    this.registroUrl = 'https://localhost:7120/api/personas/registro';
    this.mostrarUrl = 'https://localhost:7120/api/personas/mayores-de-21';
    this.http = httpClient;
  }

  postRegistro(registro: IUsuarioRegistro): Observable<any> {
    return this.http.post(this.registroUrl, registro);
  }

  getUsuarios(): Observable<IUsuario[]> {
    return this.http.get<IUsuario[]>(this.mostrarUrl);
  }
}