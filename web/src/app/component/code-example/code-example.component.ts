import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-code-example',
  templateUrl: './code-example.component.html',
  styleUrls: ['./code-example.component.css'],
})
export class CodeExampleComponent implements OnInit {
  public name: string;
  public count: number;
  constructor() {}

  ngOnInit(): void {
    //     var newCount = this.count + 1;
    //           let isEdit = false;
    // var newStatus = isEdit ? false : true;
  }
}
