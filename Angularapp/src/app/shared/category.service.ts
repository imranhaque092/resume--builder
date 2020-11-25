import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  constructor(private http: HttpClient) { }
  readonly BaseURI = 'http://localhost:50746/api';
  getCategoryList() {
    return this.http.get(environment.apiBaseURI + '/Category');
  }
}


