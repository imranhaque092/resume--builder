import { ProductService } from './../../shared/product.service';
import { CategoryService } from './../../shared/category.service';

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormArray, Validators, FormGroup } from '@angular/forms';


@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})


export class ProductComponent implements OnInit {
  productForms: FormArray = this.fb.array([]);
  categoryList = [];
  notification = null;
  
  constructor(private fb: FormBuilder,
    private categoryService: CategoryService,
    private service: ProductService) { }

    ngOnInit() {
      this.categoryService.getCategoryList()
        .subscribe(res => this.categoryList = res as []);
    
      this.service.getProductList().subscribe(
        res => {
          if (res == [])
            this.addProductForm();
          else {
            //generate formarray as per the data received from BankAccont table
            (res as []).forEach((product: any) => {
              this.productForms.push(this.fb.group({
                productID: [product.productID],
                productPrice: [product.productPrice, Validators.required],
                productName: [product.productName, Validators.required],
                categoryID: [product.categoryID, Validators.min(1)],
                Coment: [product.coment, Validators.required]
              }));
            });
          }
        }
      );
    }
  
    addProductForm() {
      this.productForms.push(this.fb.group({
        productID: [0],
        productPrice: ['', Validators.required],
        productName: ['', Validators.required],
        categoryID: [0, Validators.min(1)],
        Coment: ['', Validators.required]
      }));
    }
  
    recordSubmit(fg: FormGroup) {
      if (fg.value.productID == 0)
        this.service.postProduct(fg.value).subscribe(
          (res: any) => {
            fg.patchValue({ productID: res.productID });
            this.showNotification('insert');
          });
      else
        this.service.putProduct(fg.value).subscribe(
          (res: any) => {
            this.showNotification('update');
          });
    }
  
    onDelete(productID, i) {
      if (productID == 0)
        this.productForms.removeAt(i);
      else if (confirm('Are you sure to delete this record ?'))
        this.service.deleteProduct(productID).subscribe(
          res => {
            this.productForms.removeAt(i);
            this.showNotification('delete');
          });
    }
  
    showNotification(category) {
      switch (category) {
        case 'insert':
          this.notification = { class: 'text-success', message: 'saved!' };
          break;
        case 'update':
          this.notification = { class: 'text-primary', message: 'updated!' };
          break;
        case 'delete':
          this.notification = { class: 'text-danger', message: 'deleted!' };
          break;
  
        default:
          break;
      }
      setTimeout(() => {
        this.notification = null;
      }, 3000);
    }
  

}


