import { Component } from '@angular/core';
import { BaseService } from '../base.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrl: './products.component.css'
})
export class ProductsComponent {

  products?:any;
  constructor(private service:BaseService){ {
    this.service.getProducts().subscribe(
      (res)=>this.products=res
  )
  }
}

}
