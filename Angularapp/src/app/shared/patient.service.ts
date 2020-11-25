import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class PatientService {
  postDoctor(value: any) {
    throw new Error('Method not implemented.');
  }
  putDoctor(value: any) {
    throw new Error('Method not implemented.');
  }
  deleteDoctor(doctorID: any) {
    throw new Error('Method not implemented.');
  }


  

  constructor(private http: HttpClient) { }

  

  postPatient(formData) {
    return this.http.post(environment.apiBaseURI + '/Patient', formData);
  }

  putPatient(formData) {
    return this.http.put(environment.apiBaseURI + '/Patient/' + formData.patientID, formData);
  }

  deletePatient(id) {
    return this.http.delete(environment.apiBaseURI + '/Patient/' + id);
  }

  getPatientList() {
    return this.http.get(environment.apiBaseURI + '/Patient');
  }
}
