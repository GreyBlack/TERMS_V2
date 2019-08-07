import Vue from "vue";
import Router from "vue-router";
// import { notification } from "ant-design-vue";
import NProgress from "nprogress";
import "nprogress/nprogress.css";

Vue.use(Router);

const router = new Router({
  mode: "history",
  base: process.env.BASE_URL,
  routes: [
    {
      path: "/user",
      component: { render: h => h("router-view") },
      children: [
        {
          path: "/user",
          redirect: "/user/login"
        },
        {
          path: "/user/login",
          name: "login",
          component: () =>
            import(/* webpackChunkName: "user" */ "./views/User/Login")
        }
      ]
    },
    {
      path: "/",
      component: () =>
        import(/* webpackChunkName: "layout" */ "./layouts/BasicLayout"),
      children: [
        {
          path: "/",
          redirect: "/general/portal"
        },
        {
          path: "/general/portal",
          name: "portal",
          component: () =>
            import(/* webpackChunkName: "general" */ "./views/General/Portal")
        },
        {
          path: "/general/follow",
          name: "follow",
          component: () =>
            import(/* webpackChunkName: "general" */ "./views/General/Follow")
        },
        {
          path: "/apply",
          name: "apply",
          component: { render: h => h("router-view") },
          children: [
            {
              path: "/apply",
              redirect: "/apply/search"
            },
            {
              path: "/apply/search",
              name: "apply-search",
              component: () =>
                import(/* webpackChunkName: "apply" */ "./views/Apply/Search")
            },
            {
              path: "/apply/history",
              name: "history",
              component: () =>
                import(/* webpackChunkName: "apply" */ "./views/Apply/History")
            }
          ]
        },
        {
          path: "/approve/list",
          name: "approve",
          component: () =>
            import(/* webpackChunkName: "approve" */ "./views/Approve/List")
        },
        {
          path: "/search",
          name: "search",
          component: { render: h => h("router-view") },
          children: [
            {
              path: "/search",
              redirect: "/search/integrate"
            },
            {
              path: "/search/integrate",
              name: "integrate",
              component: () =>
                import(
                  /* webpackChunkName: "search" */ "./views/Search/Integrate"
                )
            },
            {
              path: "/search/advance",
              name: "advance",
              component: () =>
                import(
                  /* webpackChunkName: "search" */ "./views/Search/Advance"
                )
            }
          ]
        },
        {
          path: "/print/list",
          name: "print",
          component: () =>
            import(/* webpackChunkName: "print" */ "./views/Print/List")
        }
      ]
    }
  ]
});

router.beforeEach((to, from, next) => {
  if (to.path !== from.path) {
    NProgress.start();
  }
  // const record = findLast(to.matched, record => record.meta.authority);
  // if (record && !check(record.meta.authority)) {
  //   if (!isLogin() && to.path !== "/user/login") {
  //     next({
  //       path: "/user/login"
  //     });
  //   } else if (to.path !== "/403") {
  //     notification.error({
  //       message: "403",
  //       description: "你没有权限访问，请联系管理员咨询。"
  //     });
  //     next({
  //       path: "/403"
  //     });
  //   }
  //   NProgress.done();
  // }
  NProgress.done();

  next();
});

router.afterEach(() => {
  NProgress.done();
});

export default router;
