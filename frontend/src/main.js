import { createApp } from 'vue'
import './style.css'
import App from './App.vue'
import PrimeVue from 'primevue/config';
import ToastService from 'primevue/toastservice';

import './style.css'
import 'primeicons/primeicons.css'
import 'primevue/resources/primevue.min.css'    
import 'primevue/resources/themes/aura-light-blue/theme.css' 

function startApp() {
  const app = createApp(App);

  app.use(PrimeVue);
  app.use(ToastService);

  app.mount('#app');
}

startApp();
