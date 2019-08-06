import Vue from "vue";
import App from "./App.vue";
import router from "./router";
import store from "./store";
import { Layout, Menu, Breadcrumb, Icon, Button, Input } from "ant-design-vue";

Vue.config.productionTip = false;
Vue.use(Layout);
Vue.use(Menu);
Vue.use(Breadcrumb);
Vue.use(Icon);
Vue.use(Button);
Vue.use(Input);

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount("#app");
