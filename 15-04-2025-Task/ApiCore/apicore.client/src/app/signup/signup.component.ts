import { Component } from '@angular/core';
import { UserService } from '../services/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrl: './signup.component.css'
})
export class SignupComponent {
  msg: string = ''
  constructor(private _ser: UserService, private router: Router) { }

  Register(user: any) {
    const formData: FormData = new FormData();
    formData.append('FullName', user.FullName)
    formData.append('Email', user.Email)
    formData.append('Password', user.Password)

    this._ser.register(formData).subscribe((response) => {

      this.msg = "Regestered Succesfully!"
      //this.router.navigate(['/login'])
    })
  }
}
