import { PersonalInformationService } from './../../shared/personal-information.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-preview',
  templateUrl: './preview.component.html',
  styleUrls: ['./preview.component.css']
})
export class PreviewComponent implements OnInit {

 
  personData:PersonalInformationService[];

  constructor(

    private personService:PersonalInformationService
  ) { }

  ngOnInit() {
 
    this.loadPersonData();
  }


    loadPersonData(){
      this.personService.getPersontitleData().subscribe((data)=>{
        console.log("data",data)
        this.personData=data;
        
      })
    }
}

