import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AppointmentService {

  constructor(private http: HttpClient) { }

  postAppointment(formData) {
    return this.http.post(environment.apiBaseURI + '/Appointment', formData);
  }

  putAppointment(formData) {
    return this.http.put(environment.apiBaseURI + '/Appointment/' + formData.appointmentID, formData);
  }

  deleteAppointment(id) {
    return this.http.delete(environment.apiBaseURI + '/Appointment/' + id);
  }

  getAppointmentList() {
    return this.http.get(environment.apiBaseURI + '/Appointment');
  }
}

