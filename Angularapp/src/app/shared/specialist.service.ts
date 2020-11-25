import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class SpecialistService {

  constructor(private http: HttpClient) { }
  readonly BaseURI = 'http://localhost:50746/api';
  getSpecialistList() {
    return this.http.get(environment.apiBaseURI + '/Specialist');
  }
}
