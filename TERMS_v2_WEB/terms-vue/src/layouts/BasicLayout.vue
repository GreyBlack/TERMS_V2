<template>
  <a-layout id="components-layout-demo-side" style="min-height: 100vh">
    <a-layout-sider collapsible v-model="collapsed" :trigger="null">
      <div class="logo">可信电子病案管理系统</div>
      <SiderMenu />
    </a-layout-sider>
    <a-layout>
      <a-layout-header style="background: #fff; padding: 0">
        <a-icon
          class="trigger"
          :type="collapsed ? 'menu-unfold' : 'menu-fold'"
          @click="collapsed = !collapsed"
        ></a-icon>
        <Header />
      </a-layout-header>
      <a-layout-content style="margin: 0 16px">
        <a-breadcrumb style="margin: 16px 0">
          <a-breadcrumb-item>User</a-breadcrumb-item>
          <a-breadcrumb-item>Bill</a-breadcrumb-item>
        </a-breadcrumb>
        <div class="layout-content">
          <router-view></router-view>
        </div>
      </a-layout-content>
    </a-layout>
  </a-layout>
</template>
<script>
import Header from "./Header";
import SiderMenu from "./SiderMenu";
export default {
  data() {
    return {
      collapsed: false
    };
  },
  components: {
    Header,
    SiderMenu
  }
};
</script>

<style scoped>
.layout-content {
}
.trigger {
  padding: 0 20px;
  line-height: 64px;
  font-size: 20px;
  cursor: pointer;
}
.trigger:hover {
  background: #eeeeee;
}
.logo {
  height: 64px;
  line-height: 64px;
  text-align: center;
  overflow: hidden;
  color: #fff;
  font-size: 18px;
}
.nav-theme-dark >>> .logo {
  color: #ffffff;
}
</style>
