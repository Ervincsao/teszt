import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BaseService {
  url="https://localhost:7199/api/";
  constructor(private http:HttpClient) {
    }
    getProducts(){
      return this.http.get(this.url+"Products")
   }
}
