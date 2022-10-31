import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ApiResponse } from '../models/apiResponse';

@Injectable({
  providedIn: 'root'
})
export class PrimeNumbersService {
  constructor(private client: HttpClient) { }

  rootUrl = "primeNumbers"

  getPrimeNumbers(number: number) {
    let url = this.buildApiUrl(number);
    return this.client.get<ApiResponse>(url);
  }

  private buildApiUrl(number: number) {
    return environment.apiUrl + this.rootUrl + "/" + number;
  }
}
