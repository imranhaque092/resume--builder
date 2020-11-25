import { CandidateComponent } from './user/candidate/candidate.component';
import { PersonalInformationComponent } from './user/personal-information/personal-information.component';
//import { UserComponent } from './user/user/user.component';
import { AppointmentComponent } from './user/appointment/appointment.component';
import { PatientComponent } from './user/patient/patient.component';
import { DoctorComponent } from './user/doctor/doctor.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ProductComponent } from './user/product/product.component';
//import { PaymentDetailListComponent } from './user/payment-details/payment-detail-list/payment-detail-list.component';
//import { PaymentDetailsComponent } from './user/payment-details/payment-details.component';

import { AuthGuard } from './auth/auth.guard';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserComponent } from './user/user.component';
import { RegistrationComponent } from './user/registration/registration.component';
import { LoginComponent } from './user/login/login.component';
import { HomeComponent } from './home/home.component';
import { BankAccountComponent } from './user/bank-account/bank-account.component';
import { CareerInformationComponent } from './user/career-information/career-information.component';
import { EducationalInfomationComponent } from './user/educational-infomation/educational-infomation.component';
import { PreviewComponent } from './user/preview/preview.component';
import { MycvComponent } from './user/mycv/mycv.component';


const routes: Routes = [
  {path:'',redirectTo:'/user/login',pathMatch:'full'},
  {

    path: 'user', component: UserComponent,
    
    children: [
      { path: 'registration', component: RegistrationComponent },
      { path: 'login', component: LoginComponent }
    ]
    
  },
  {path: "", component:DashboardComponent, children:[
    //{path: "home", component:HomeComponent},
    {path:'home',component:HomeComponent,canActivate:[AuthGuard]},
    { path: 'Bank', component: BankAccountComponent },
    { path: 'Product', component: ProductComponent },
    { path: 'Doctor', component: DoctorComponent }, 
    { path: 'PersonalInformation', component: PersonalInformationComponent }, 
    { path: 'EducationalInfomation', component: EducationalInfomationComponent }, 
    { path: 'CareerInformation', component: CareerInformationComponent }, 
    { path: 'CandidateComponent', component: CandidateComponent },
    { path: 'PreviewComponent', component: PreviewComponent }, 
    { path: 'MycvComponent', component: MycvComponent },
    { path: 'Appointment', component: AppointmentComponent }
   /*  { path: 'Payment', component: PaymentDetailsComponent },
    { path: 'Paymentlist', component: PaymentDetailListComponent } */
    
  ]},

  
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents = [DashboardComponent, HomeComponent, LoginComponent];
