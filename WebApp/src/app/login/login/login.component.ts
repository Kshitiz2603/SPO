import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import axios from 'axios';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { FloatLabel } from 'primeng/floatlabel';
import { InputTextModule } from 'primeng/inputtext';
import { ButtonModule } from 'primeng/button';


@Component({
  selector: 'app-login',
  standalone: false,
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  imageUrl: string | null = null;
  result: any = 'Starting...';
  isLoggedIn: boolean = true;
  loginForm!: FormGroup;
  value1: string | undefined;

  value2: string | undefined;

  constructor(private fb: FormBuilder) {
  }

  captureImage() {
    // Update the image URL to trigger a new fetch
    this.imageUrl = 'http://127.0.0.1:8000/capture?t=' + new Date().getTime();
  }

  ngOnInit() {
    //this.createForm();
    // this.onCapture();
  }

  onLogin(){

  }

  createForm() {
    this.loginForm = this.fb.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  // onCapture(){
  //   axios.get('http://127.0.0.1:8000/capture', { responseType: 'blob' })
  //     .then(response => {
  //       const url = URL.createObjectURL(response.data);
  //       this.imageUrl = url;
  //       this.result = response.data;
  //     })
  //     .catch(error => 
  //       this.result = 'Error capturing image:'
  //   );
  // }

  register(){
    //this.onCapture();
  }
}
