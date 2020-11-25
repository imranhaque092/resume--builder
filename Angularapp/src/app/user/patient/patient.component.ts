import { PatientService } from './../../shared/patient.service';

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormArray, Validators, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-patient',
  templateUrl: './patient.component.html',
  styleUrls: ['./patient.component.css']
})
export class PatientComponent implements OnInit {
  patientForms: FormArray = this.fb.array([]);
  /* specialistList = []; */
  notification = null;
  

  constructor(private fb: FormBuilder,
    /* private specialistService: SpecialistService, */
    private service: PatientService) { }

    ngOnInit() {
      /* this.specialistService.getSpecialistList()
        .subscribe(res => this.specialistList = res as []); */
    
      this.service.getPatientList().subscribe(
        res => {
          if (res == [])
            this.addPatientForm();
          else {
           
            (res as []).forEach((patient: any) => {
              this.patientForms.push(this.fb.group({
                patientID: [patient.patientID],
                patientName: [patient.patientName, Validators.required],
                phone: [patient.phone, Validators.required],
               
                Payment: [patient.payment, Validators.required]
              }));
            });
          }
        }
      );
    }
  
    addPatientForm() {
      this.patientForms.push(this.fb.group({
        patientID: [0],
        patientName: ['', Validators.required],
        phone: ['', Validators.required],
        
        Payment: ['', Validators.required]
      }));
    }
  
    recordSubmit(fg: FormGroup) {
      if (fg.value.patientID == 0)
        this.service.postPatient(fg.value).subscribe(
          (res: any) => {
            fg.patchValue({ patientID: res.patientID });
            this.showNotification('insert');
          });
      else
        this.service.putPatient(fg.value).subscribe(
          (res: any) => {
            this.showNotification('update');
          });
    }
  
    onDelete(patientID, i) {
      if (patientID == 0)
        this.patientForms.removeAt(i);
      else if (confirm('Are you sure to delete this record ?'))
        this.service.deletePatient(patientID).subscribe(
          res => {
            this.patientForms.removeAt(i);
            this.showNotification('delete');
          });
    }
  
    showNotification(category) {
      switch (category) {
        case 'insert':
          this.notification = { class: 'text-success', message: 'Data Saved!' };
          break;
        case 'update':
          this.notification = { class: 'text-primary', message: 'Data updated!' };
          break;
        case 'delete':
          this.notification = { class: 'text-danger', message: 'Data deleted!' };
          break;
  
        default:
          break;
      }
      setTimeout(() => {
        this.notification = null;
      }, 3000);
    }

}
