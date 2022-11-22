import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { environment } from '../../../environments/environment';
import { ConfigService } from '../../services/config.service';
@Component({
  selector: 'app-about-tsa',
  templateUrl: './about-tsa.component.html',
  // styleUrls: ['./about-tsa.component.scss'],
  host: {class: 'd-flex flex-column flex-11a'}
})
export class AboutTsaComponent implements OnInit {
 

  ngOnInit(): void {};
  version = environment.visibleVersion;
  helpContactEmail = this.configSvc.helpContactEmail;
  helpContactPhone = this.configSvc.helpContactPhone;

  constructor(private dialog: MatDialogRef<AboutTsaComponent>,
    public configSvc: ConfigService,
    @Inject(MAT_DIALOG_DATA) public data: any) { }

  close() {
    return this.dialog.close();
  }

}
