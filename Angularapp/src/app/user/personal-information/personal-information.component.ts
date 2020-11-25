import { PersonalInformationService } from './../../shared/personal-information.service';
import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, Validators, FormGroup, NgForm } from '@angular/forms';

@Component({
  selector: 'app-personal-information',
  templateUrl: './personal-information.component.html',
  styleUrls: ['./personal-information.component.css']
})
export class PersonalInformationComponent implements OnInit {

  personalInformationForms: FormArray = this.fb.array([]);
 
  notification = null;

  constructor(private fb: FormBuilder,
    
    private service: PersonalInformationService) { }

  ngOnInit() {
    
     this.service.getPersonalInformationList().subscribe(
      res => {
        if (res == [])
          this.addPersonalInformationForm();
        else {
         
          (res as []).forEach((personalInformation: any) => {
            this.personalInformationForms.push(this.fb.group({
              personalInformationID: [personalInformation.personalInformationID],
              firstName: [personalInformation.firstName, Validators.required],
              lastName: [personalInformation.lastName, Validators.required],
              fatherName: [personalInformation.fatherName, Validators.required],
              motherName: [personalInformation.motherName, Validators.required],
              dateOfBirth: [personalInformation.dateOfBirth, Validators.required],
              gender: [personalInformation.gender, Validators.required],
              maritalStatus: [personalInformation.maritalStatus, Validators.required],
              permanentAddress: [personalInformation.permanentAddress, Validators.required],
              presentAddress: [personalInformation.presentAddress, Validators.required]
            }));
          });
        }
      }
    ); 
  }

  addPersonalInformationForm() {
    this.personalInformationForms.push(this.fb.group({
      personalInformationID: [0],
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      fatherName: ['', Validators.required],
      motherName: ['', Validators.required],
      dateOfBirth: ['', Validators.required],
      gender: ['', Validators.required],
      maritalStatus: ['', Validators.required],
      permanentAddress: ['', Validators.required],
      presentAddress: ['', Validators.required]
    }));
    
  }

  recordSubmit(fg: FormGroup) {
    if (fg.value.personalInformationID == 0)
      this.service.postPersonalInformation(fg.value).subscribe(
        (res: any) => {
          fg.patchValue({ personalInformationID: res.personalInformationID });
          this.showNotification('insert');
          this.personalInformationForms=null;
          
        });
    else
      this.service.putPersonalInformation(fg.value).subscribe(
        (res: any) => {
          this.showNotification('update');
        });
  }

  onDelete(personalInformationID, i) {
    if (personalInformationID == 0)
      this.personalInformationForms.removeAt(i);
    else if (confirm('Are you sure to delete this record ?'))
      this.service.deletePersonalInformation(personalInformationID).subscribe(
        res => {
          this.personalInformationForms.removeAt(i);
          this.showNotification('delete');
        });
  }
  
  
  showNotification(category) {
    switch (category) {
      case 'insert':
        this.notification = { class: 'text-success', message: 'Data Inserted successfully!' };
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
