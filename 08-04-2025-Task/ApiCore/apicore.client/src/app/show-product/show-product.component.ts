import { Component } from '@angular/core';
import { CategoryService } from '../services/category.service';

@Component({
  selector: 'app-show-product',
  templateUrl: './show-product.component.html',
  styleUrl: './show-product.component.css'
})
export class ShowProductComponent {
  products: any;
  constructor(private categoryService: CategoryService) { }

  ngOnInit(): void {
    this.categoryService.getAllProducts().subscribe((data) => (this.products = data));
  }
}
