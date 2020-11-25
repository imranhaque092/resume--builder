import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class DoctorService {

  constructor(private http: HttpClient) { }

  postDoctor(formData) {
    return this.http.post(environment.apiBaseURI + '/Doctor', formData);
  }

  putDoctor(formData) {
    return this.http.put(environment.apiBaseURI + '/Doctor/' + formData.doctorID, formData);
  }

  deleteDoctor(id) {
    return this.http.delete(environment.apiBaseURI + '/Doctor/' + id);
  }

  getDoctorList() {
    return this.http.get(environment.apiBaseURI + '/Doctor');
  }
}
