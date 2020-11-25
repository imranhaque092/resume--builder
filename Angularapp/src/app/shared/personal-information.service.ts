import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class PersonalInformationService {

  constructor(private http: HttpClient) { }

  postPersonalInformation(formData) {
    return this.http.post(environment.apiBaseURI + '/PersonalInformation', formData);
  }

  putPersonalInformation(formData) {
    return this.http.put(environment.apiBaseURI + '/PersonalInformation/' + formData.personalInformationID, formData);
  }

  deletePersonalInformation(id) {
    return this.http.delete(environment.apiBaseURI + '/PersonalInformation/' + id);
  }
  

  getPersonalInformationList() {
    return this.http.get(environment.apiBaseURI + '/PersonalInformation');
  }
  getPersontitleData():Observable<[]>{
    return this.http.get<[]>(environment.apiBaseURI+ '/PersonalInformation')
  }
}

