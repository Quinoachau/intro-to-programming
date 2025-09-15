import { Component, signal } from '@angular/core';
import { Navigation } from './components/navigation';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  template: `<app-navigation />
    <main class="container mx-auto">
      <p>Our Stuff Goes Here</p>
      <router-outlet />
    </main> `,
  styles: [],
  imports: [Navigation, RouterOutlet],
})
export class App {
  title = signal('frontend');
}
