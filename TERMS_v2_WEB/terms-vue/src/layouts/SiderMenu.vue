<template>
  <a-menu theme="dark" :defaultSelectedKeys="['1']" mode="inline">
    <a-menu-item key="1">
      <a-icon type="pie-chart" />
      <span>病案首页</span>
    </a-menu-item>
    <a-menu-item key="2">
      <a-icon type="star" />
      <span>我的关注</span>
    </a-menu-item>
    <a-sub-menu key="sub1">
      <span slot="title"><a-icon type="book" /><span>就诊借阅</span></span>
      <a-menu-item key="3">借阅查询</a-menu-item>
      <a-menu-item key="4">借阅历史</a-menu-item>
    </a-sub-menu>
    <a-sub-menu key="sub2">
      <span slot="title"
        ><a-icon type="file-search" /><span>综合查询</span></span
      >
      <a-menu-item key="6">综合查询</a-menu-item>
      <a-menu-item key="8">高级查询</a-menu-item>
    </a-sub-menu>
    <a-menu-item key="9">
      <a-icon type="printer" />
      <span>病案打印</span>
    </a-menu-item>
  </a-menu>
</template>

<script>
export default {};
</script>

<style></style>
