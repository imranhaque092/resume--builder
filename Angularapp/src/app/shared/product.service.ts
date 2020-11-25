import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http: HttpClient) { }

  postProduct(formData) {
    return this.http.post(environment.apiBaseURI + '/Product', formData);
  }

  putProduct(formData) {
    return this.http.put(environment.apiBaseURI + '/Product/' + formData.productID, formData);
  }

  deleteProduct(id) {
    return this.http.delete(environment.apiBaseURI + '/Product/' + id);
  }

  getProductList() {
    return this.http.get(environment.apiBaseURI + '/Product');
  }
}


