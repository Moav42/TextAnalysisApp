import { Component, OnInit } from '@angular/core';
import { MetricsModel } from 'src/app/Models/MetricsModel';
import { TextProcessorService } from 'src/app/Services/text-processor.service';
import { TextToProcessViewModel } from 'src/app/Models/ViewModels/TextToProcessViewModel';


@Component({
  selector: 'app-text-analyzer',
  templateUrl: './text-analyzer.component.html',
  styleUrls: ['./text-analyzer.component.css']
})
export class TextAnalyzerComponent implements OnInit {

  metricsModels: MetricsModel[] = [];
  inputText: string = "";

  isError: boolean = false;
  errorText: string = "";

  constructor(
    private service: TextProcessorService
  ) { }

  ngOnInit() {
  }

  public submitText(inputText: string){

    this.service.handleMetrics(new TextToProcessViewModel(inputText)).subscribe((data:MetricsModel[]) =>{
      this.metricsModels = data
    },
    (error)=>{
      this.isError=true;
      switch(error.status){
        case 500: {
          this.errorText = "Internal Server Error."; break;
        }
        case 400:{
          this.errorText = "Enter text";break;
        }
          case 0:{
            this.errorText= "No access to server"; break;
          }
          default:{
            this.errorText = "Unknown error";break;
          }
      }
    });
  }
  
}