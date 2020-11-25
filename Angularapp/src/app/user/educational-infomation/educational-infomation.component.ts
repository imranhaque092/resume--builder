import { EducationalInfomationService } from './../../shared/educational-infomation.service';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-educational-infomation',
  templateUrl: './educational-infomation.component.html',
  styleUrls: ['./educational-infomation.component.css']
})
export class EducationalInfomationComponent implements OnInit {

  educationalInfomationForms: FormArray = this.fb.array([]);
  
  notification = null;

  constructor(private fb: FormBuilder,
   
    private service: EducationalInfomationService) { }

  ngOnInit() {
    

    /* this.service.getEducationalInfomationList().subscribe(
      res => {
        if (res == [])
          this.addEducationalInfomationForm();
        else {
         
          (res as []).forEach((educationalInfomation: any) => {
            this.educationalInfomationForms.push(this.fb.group({
              educationalInfomationID: [educationalInfomation.educationalInfomationID],
              lavelOfEducation: [educationalInfomation.lavelOfEducation, Validators.required],
              examName: [educationalInfomation.examName, Validators.required],
              majorSubject: [educationalInfomation.majorSubject, Validators.required],
              instituteName: [educationalInfomation.instituteName, Validators.required],
              result: [educationalInfomation.result, Validators.required],
              yearOfPassing: [educationalInfomation.yearOfPassing, Validators.required],
              duration: [educationalInfomation.duration, Validators.required]
            }));
          });
        }
      }
    ); */
  }

  addEducationalInfomationForm() {
    this.educationalInfomationForms.push(this.fb.group({
      educationalInfomationID: [0],
      lavelOfEducation: ['', Validators.required],
      examName: ['', Validators.required],
      majorSubject: ['', Validators.required],
      instituteName: ['', Validators.required],
      result: ['', Validators.required],
      yearOfPassing: ['', Validators.required],
      duration: ['', Validators.required]
    }));
  }

  recordSubmit(fg: FormGroup) {
    if (fg.value.educationalInfomationID == 0)
      this.service.postEducationalInfomation(fg.value).subscribe(
        (res: any) => {
          fg.patchValue({ educationalInfomationID: res.educationalInfomationID });
          this.showNotification('insert');
          this.educationalInfomationForms=null;
        });
    else
      this.service.putEducationalInfomation(fg.value).subscribe(
        (res: any) => {
          this.showNotification('update');
        });
  }

  onDelete(educationalInfomationID, i) {
    if (educationalInfomationID == 0)
      this.educationalInfomationForms.removeAt(i);
    else if (confirm('Are you sure to delete this record ?'))
      this.service.deleteEducationalInfomation(educationalInfomationID).subscribe(
        res => {
          this.educationalInfomationForms.removeAt(i);
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

