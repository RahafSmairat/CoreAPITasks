import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
//import { Category } from '../models/category.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  private categoriesApiUrl = 'https://localhost:7115/api/Category';
  private productsApiUrl = 'https://localhost:7115/api/Products/getAllProducts';

  constructor(private http: HttpClient) { }

  getAll() {
    return this.http.get<any[]>(this.categoriesApiUrl);
  }

  getById(id: number) {
    return this.http.get<any>(`${this.categoriesApiUrl}/${id}`);
  }

  getByName(name: string) {
    return this.http.get<any>(`${this.categoriesApiUrl}/name/${name}`);
  }

  delete(id: number) {
    return this.http.delete(`${this.categoriesApiUrl}/${id}`);
  }

  //////////////////

  getAllProducts() {
    return this.http.get<any[]>(this.productsApiUrl);
  }

  getProductById(id: number) {
    return this.http.get<any>(`${this.productsApiUrl}/${id}`);
  }

  getProductByName(name: string) {
    return this.http.get<any>(`${this.productsApiUrl}/name/${name}`);
  }

  deleteProduct(id: number) {
    return this.http.delete(`${this.productsApiUrl}/${id}`);
  }
}
