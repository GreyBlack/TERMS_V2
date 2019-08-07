<template>
  <a-menu theme="dark" :defaultSelectedKeys="['1']" mode="inline">
    <a-menu-item
      key="1"
      @click="
        () => $router.push({ path: '/general/portal', query: $route.query })
      "
    >
      <a-icon type="pie-chart" />
      <span>病案首页</span>
    </a-menu-item>
    <a-menu-item
      key="2"
      @click="
        () => $router.push({ path: '/general/follow', query: $route.query })
      "
    >
      <a-icon type="star" />
      <span>我的关注</span>
    </a-menu-item>
    <a-sub-menu key="sub1">
      <span slot="title"><a-icon type="book" /><span>就诊借阅</span></span>
      <a-menu-item
        key="3"
        @click="
          () => $router.push({ path: '/apply/search', query: $route.query })
        "
        >借阅查询</a-menu-item
      >
      <a-menu-item
        key="4"
        @click="
          () => $router.push({ path: '/apply/history', query: $route.query })
        "
        >借阅历史</a-menu-item
      >
    </a-sub-menu>
    <a-sub-menu key="sub2">
      <span slot="title"
        ><a-icon type="file-search" /><span>综合查询</span></span
      >
      <a-menu-item
        key="6"
        @click="
          () => $router.push({ path: '/search/integrate', query: $route.query })
        "
        >综合查询</a-menu-item
      >
      <a-menu-item
        key="8"
        @click="
          () => $router.push({ path: '/search/advance', query: $route.query })
        "
        >高级查询</a-menu-item
      >
    </a-sub-menu>
    <a-menu-item
      key="9"
      @click="() => $router.push({ path: '/print/list', query: $route.query })"
    >
      <a-icon type="printer" />
      <span>病案打印</span>
    </a-menu-item>
  </a-menu>
</template>

<script>
export default {};
</script>

<style></style>
