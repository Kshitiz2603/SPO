import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import axios from 'axios';

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

  constructor(private fb: FormBuilder) {
  }

  captureImage() {
    // Update the image URL to trigger a new fetch
    this.imageUrl = 'http://127.0.0.1:8000/capture?t=' + new Date().getTime();
  }

  // ngOnInit() {
  //   // this.onCapture();
  // }

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

  // captureImage(){
  //   this.onCapture();
  // }
}
