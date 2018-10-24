import { Component } from '@angular/core'
import { IRecord } from './record';
import { RecordService } from './record.service';
import { UtilityService } from '../utility.service';

@Component({
  selector: 'pm-detail',
  templateUrl: './record-list.component.html'
})

export class RecordListComponent {
  private showLoader: boolean = false;
  private _recordService;
  private _utilityService;

  errorMessage: string;
  showTable: boolean = false;
  records: IRecord[] = [];
  totalRecords: number = 0;

  constructor(recordService: RecordService, utilityService: UtilityService) {
    this._recordService = recordService;
    this._utilityService = utilityService;

    this._utilityService.checkLocalStorage();

  }

  startReadingXML(): void {
    this.showLoader = true;
    this._utilityService.checkLocalStorage();
    
    if (!this._utilityService.localStorageSet) {

      console.log("Local Storage NOT set - Reading from service");
      this._recordService.getRecordsXML().subscribe(
        records => {
          this.records = records;
          this.totalRecords = records.length;
          this._utilityService.saveLocalStorage(records);
        },
        error => this.errorMessage = <any>error
      );
    }
    else {
      
      console.log("Local Storage set");
      let recordsLS = this._utilityService.getLocalStorage();

      if (this.records.length == 0) {
        this.records = recordsLS;
      }
    }
    this.showLoader = false;
  };
}
