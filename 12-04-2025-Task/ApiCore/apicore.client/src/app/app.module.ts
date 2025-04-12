import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ShowCategoriesComponent } from './show-categories/show-categories.component';
import { ShowProductComponent } from './show-product/show-product.component';

@NgModule({
  declarations: [
    AppComponent,
    ShowCategoriesComponent,
    ShowProductComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
