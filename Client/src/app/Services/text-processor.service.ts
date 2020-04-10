import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { TextToProcessViewModel } from '../Models/ViewModels/TextToProcessViewModel';

@Injectable({
  providedIn: 'root'
})

export class TextProcessorService {

  API_URL = environment.textProcessorApiRoute;

  constructor(
    private http: HttpClient
  ) { }

  public handleMetrics(textToProcess: TextToProcessViewModel): Observable<null>{
    return this.http.post<null>(this.API_URL, textToProcess);
  }
}
