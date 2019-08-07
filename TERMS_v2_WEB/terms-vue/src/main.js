import Vue from "vue";
import App from "./App.vue";
import router from "./router";
import store from "./store";
import "./assets/css/index.css";
import {
  Layout,
  Menu,
  Breadcrumb,
  Icon,
  Button,
  Input,
  Select,
  Tabs,
  Tag,
  DatePicker,
  Table
} from "ant-design-vue";

Vue.config.productionTip = false;
Vue.use(Layout);
Vue.use(Menu);
Vue.use(Breadcrumb);
Vue.use(Icon);
Vue.use(Button);
Vue.use(Input);
Vue.use(Select);
Vue.use(Tabs);
Vue.use(Tag);
Vue.use(DatePicker);
Vue.use(Table);

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount("#app");
