import { Component } from '@angular/core';
import { ApiResponse } from './models/apiResponse';
import { Query } from './models/query';
import { PrimeNumbersService } from './services/prime-numbers.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  constructor(private primeNumbersService: PrimeNumbersService) { }

  model = new Query
  apiResponse = new ApiResponse();

  onSubmit() {
    this.primeNumbersService.getPrimeNumbers(this.model.number).subscribe((data: ApiResponse) => {
      this.apiResponse.primeNumbers = data.primeNumbers;
    });
  }

}

