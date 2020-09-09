import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'code-convention-poc';
}


export function random(id:number) {
  var kId = id + 1;
  console.log(kId);
}
