import { DoctorService } from './../../shared/doctor.service';
import { SpecialistService } from './../../shared/specialist.service';


import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormArray, Validators, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-doctor',
  templateUrl: './doctor.component.html',
  styleUrls: ['./doctor.component.css']
})
export class DoctorComponent implements OnInit {
  doctorForms: FormArray = this.fb.array([]);
  specialistList = [];
  notification = null;
  

  constructor(private fb: FormBuilder,
    private specialistService: SpecialistService,
    private service: DoctorService) { }

    ngOnInit() {
      this.specialistService.getSpecialistList()
        .subscribe(res => this.specialistList = res as []);
    
      this.service.getDoctorList().subscribe(
        res => {
          if (res == [])
            this.addDoctorForm();
          else {
            //generate formarray as per the data received from BankAccont table
            (res as []).forEach((doctor: any) => {
              this.doctorForms.push(this.fb.group({
                doctorID: [doctor.doctorID],
                doctorName: [doctor.doctorName, Validators.required],
                phone: [doctor.phone, Validators.required],
                specialistID: [doctor.specialistID, Validators.min(1)],
                Reviews: [doctor.reviews, Validators.required]
              }));
            });
          }
        }
      );
    }
  
    addDoctorForm() {
      this.doctorForms.push(this.fb.group({
        doctorID: [0],
        doctorName: ['', Validators.required],
        phone: ['', Validators.required],
        specialistID: [0, Validators.min(1)],
        Reviews: ['', Validators.required]
      }));
    }
  
    recordSubmit(fg: FormGroup) {
      if (fg.value.doctorID == 0)
        this.service.postDoctor(fg.value).subscribe(
          (res: any) => {
            fg.patchValue({ doctorID: res.doctorID });
            this.showNotification('insert');
          });
      else
        this.service.putDoctor(fg.value).subscribe(
          (res: any) => {
            this.showNotification('update');
          });
    }
  
    onDelete(doctorID, i) {
      if (doctorID == 0)
        this.doctorForms.removeAt(i);
      else if (confirm('Are you sure to delete this record ?'))
        this.service.deleteDoctor(doctorID).subscribe(
          res => {
            this.doctorForms.removeAt(i);
            this.showNotification('delete');
          });
    }
  
    showNotification(category) {
      switch (category) {
        case 'insert':
          this.notification = { class: 'text-success', message: 'saved!' };
          break;
        case 'update':
          this.notification = { class: 'text-primary', message: 'updated!' };
          break;
        case 'delete':
          this.notification = { class: 'text-danger', message: 'deleted!' };
          break;
  
        default:
          break;
      }
      setTimeout(() => {
        this.notification = null;
      }, 3000);
    }

}
