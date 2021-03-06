import { MyScheduleComponent } from './pages/my-schedule/my-schedule.component';
import { FriendsComponent } from './pages/friends/friends.component';
import { NotificationComponent } from './pages/notification/notification.component';
import { DashBoardComponent } from './pages/dashboard/dashboard.component';
import { VerificationCodeComponent } from './pages/verification-code/verification-code.component';
import { RegisterComponent } from './pages/register/register.component';
import { NgModule } from "@angular/core";
import { NativeScriptModule } from "nativescript-angular/nativescript.module";
import { NativeScriptFormsModule } from "nativescript-angular/forms";
import { NativeScriptHttpModule } from "nativescript-angular/http";
import { NativeScriptRouterModule } from "nativescript-angular/router";
import { AccordionModule } from "nativescript-accordion/angular";
import { DropDownModule  } from "nativescript-drop-down/angular";
import { AppComponent } from "./app.component";
import { routes, navigatableComponents } from "./app.routing";
import { LoginComponent } from "./pages/login/login.component";
import { SearchPageComponent } from "./pages/search-page/search-page.component";
import { ScheduleComponent } from "./pages/schedule/schedule.component";
import {EditScheduleComponent} from "./pages/edit-schedule/edit-schedule.component"
import { GridViewModule } from "nativescript-grid-view/angular";
import { FriendDetailsComponent } from "./pages/friend-details/friend-details.component";

@NgModule({
  imports: [
    NativeScriptModule,
    NativeScriptFormsModule,
    NativeScriptHttpModule,
    NativeScriptRouterModule,
    AccordionModule,
    DropDownModule,
    GridViewModule,
    NativeScriptRouterModule.forRoot(routes)
  ],

  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    VerificationCodeComponent,
    SearchPageComponent,
    DashBoardComponent,
    NotificationComponent,
    FriendsComponent,
    ScheduleComponent,
    MyScheduleComponent,
    FriendDetailsComponent,
    EditScheduleComponent
  ],

  bootstrap: [
    AppComponent
  ]
})
export class AppModule { }
