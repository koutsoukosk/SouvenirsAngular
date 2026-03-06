import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, inject, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Observable } from 'rxjs';
import { Souvenir } from '../models/souvenir.model';
import { AsyncPipe } from '@angular/common';
import { JsonPipe } from '@angular/common';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,HttpClientModule,AsyncPipe],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  http = inject(HttpClient);

  souvenirs$ = this.getSouvenirs();

  private getSouvenirs():Observable<Souvenir[]> {
    return this.http.get<Souvenir[]>('https://localhost:7079/api/Souvenirs');
  }
}
