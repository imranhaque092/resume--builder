import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CandidateService {

  constructor(private http: HttpClient) { }

  getCandidateList() {
    return this.http.get(environment.apiBaseURI + '/Candidate');
  }

  postCandidate(formData) {
    return this.http.post(environment.apiBaseURI + '/Candidate', formData);
  }

  putCandidate(formData) {
    return this.http.put(environment.apiBaseURI + '/Candidate/' + formData.candidateID, formData);
  }

  deleteCandidate(id) {
    return this.http.delete(environment.apiBaseURI + '/Candidate/' + id);
  }
  getPersontitleData():Observable<[]>{
    return this.http.get<[]>(environment.apiBaseURI+ '/Candidate')
  }
 
}