import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class EducationalInfomationService {

  constructor(private http: HttpClient) { }



  postEducationalInfomation(formData) {
    return this.http.post(environment.apiBaseURI + '/EducationalInfomation', formData);
  }

  putEducationalInfomation(formData) {
    return this.http.put(environment.apiBaseURI + '/EducationalInfomation/' + formData.educationalInfomationID, formData);
  }

  deleteEducationalInfomation(id) {
    return this.http.delete(environment.apiBaseURI + '/EducationalInfomation/' + id);
  }

  getEducationalInfomationList() {
    return this.http.get(environment.apiBaseURI + '/EducationalInfomation');
  }
}

