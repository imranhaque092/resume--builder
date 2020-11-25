import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CareerInformationService {

  constructor(private http: HttpClient) { }

  getCareerInformationList() {
    return this.http.get(environment.apiBaseURI + '/CareerInformation');
  }

  postCareerInformation(formData) {
    return this.http.post(environment.apiBaseURI + '/CareerInformation', formData);
  }

  putCareerInformation(formData) {
    return this.http.put(environment.apiBaseURI + '/CareerInformation/' + formData.careerInformationID, formData);
  }

  deleteCareerInformation(id) {
    return this.http.delete(environment.apiBaseURI + '/CareerInformation/' + id);
  }

 
}

