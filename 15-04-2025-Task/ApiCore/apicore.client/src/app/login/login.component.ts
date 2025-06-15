import { Component } from '@angular/core';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  errorMsg = '';
  successMsg = '';

  constructor(private _ser: UserService) { }

  Login(user: any) {
    this._ser.login().subscribe((users: any[]) => {
      const User = users.find((u: any) =>
        u.Email === user.Email && u.Password == user.Password
      );

      if (User) {
        this.successMsg = 'Login successful!';
        this.errorMsg = '';
      } else {
        this.errorMsg = 'Invalid email or password.';
        this.successMsg = '';
      }
    })
  }
}

