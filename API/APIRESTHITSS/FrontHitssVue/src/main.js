import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import axios from 'axios'



const app = createApp(App)
axios.defaults.headers.common["Authorization"];
app.use(router,axios)


app.mount('#app')
