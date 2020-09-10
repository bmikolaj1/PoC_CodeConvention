import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'code-convention-poc';

  ngOnInit() {
    let pet = 2;
    pet += 3;
    if (pet === 8) {
      console.error('ok');
    }
  }
}
