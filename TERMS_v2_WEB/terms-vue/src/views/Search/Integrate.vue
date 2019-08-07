<template>
  <div>
    <div class="content-header">
      <a-input-group class="flex" compact>
        <a-select defaultValue="MRNumber" size="large">
          <a-select-option value="MRNumber">病案号</a-select-option>
          <a-select-option value="PatientName">患者姓名</a-select-option>
          <a-select-option value="IDNumber">证件号</a-select-option>
          <a-select-option value="PersonName">人员姓名</a-select-option>
          <a-select-option value="DiagnosisICD">诊断ICD</a-select-option>
          <a-select-option value="OperationICD">手术ICD</a-select-option>
        </a-select>
        <a-input-search
          placeholder="请输入检索内容"
          @search="onSearch"
          enterButton
          size="large"
        />
      </a-input-group>
      <div class="search-tab-container">
        <template>
          <a-tabs class="search-menu-tabs">
            <a-tab-pane tab="门/急诊科室" key="1"> </a-tab-pane>
            <a-tab-pane tab="住院科室" key="2"></a-tab-pane>
            <a-button slot="tabBarExtraContent"
              ><a-icon type="reload" />清空条件</a-button
            >
          </a-tabs>
        </template>
      </div>
    </div>
    <div class="content-body">
      <div class="form-card">
        <template>
          <div class="search-form-row">
            <strong class="search-form-label">出院科室:</strong>
            <template v-for="dep in deps">
              <a-checkable-tag
                :key="dep"
                :checked="selectedTags.indexOf(dep) > -1"
                @change="checked => depTagChange(dep, checked)"
              >
                {{ dep }}
              </a-checkable-tag>
            </template>
          </div>
          <div class="search-form-row">
            <strong class="search-form-label">标签:</strong>
            <template v-for="tag in tags">
              <a-checkable-tag
                :key="tag"
                :checked="selectedTags.indexOf(tag) > -1"
                @change="checked => customTagChange(tag, checked)"
              >
                {{ tag }}
              </a-checkable-tag>
            </template>
          </div>
          <div class="search-form-row">
            <strong class="search-form-label">就诊状态:</strong>
            <template v-for="s in status">
              <a-checkable-tag
                :key="s"
                :checked="selectedTags.indexOf(s) > -1"
                @change="checked => statusTagChange(s, checked)"
              >
                {{ s }}
              </a-checkable-tag>
            </template>
          </div>
          <div class="search-form-row">
            <strong class="search-form-label">出院时间:</strong>
            <a-range-picker size="large" @change="dateChange" />
          </div>
        </template>
      </div>
      <div class="form-card">
        <template>
          <div>
            <div style="margin-bottom: 16px">
              <span style="margin-left: 8px">
                <template v-if="hasSelected">
                  {{ `Selected ${selectedRowKeys.length} items` }}
                </template>
              </span>
            </div>
            <a-table
              :rowSelection="{
                selectedRowKeys: selectedRowKeys,
                onChange: onSelectChange
              }"
              :columns="columns"
              :dataSource="data"
            />
          </div>
        </template>
      </div>
    </div>
  </div>
</template>

<script>
import moment from "moment";
import "moment/locale/zh-cn";

moment.locale("zh-cn");

const columns = [
  {
    title: "Name",
    dataIndex: "name"
  },
  {
    title: "Age",
    dataIndex: "age"
  },
  {
    title: "Address",
    dataIndex: "address"
  }
];

const data = [];
for (let i = 0; i < 46; i++) {
  data.push({
    key: i,
    name: `Edward King ${i}`,
    age: 32,
    address: `London, Park Lane no. ${i}`
  });
}
export default {
  data() {
    return {
      deps: ["神经科", "骨科", "整容科", "内分泌科"],
      tags: ["死亡", "甲级", "手术", "过敏"],
      status: ["待回收", "已回收", "已编目", "已归档"],
      selectedTags: [],
      data,
      columns,
      selectedRowKeys: [], // Check here to configure the default column
      loading: false
    };
  },
  computed: {
    hasSelected() {
      return this.selectedRowKeys.length > 0;
    }
  },
  methods: {
    onSearch(value) {
      alert("触发搜索：关键字" + value);
    },
    dateChange(date, dateString) {
      console.log(date, dateString);
    },
    depTagChange(tag, checked) {
      this.handleChange(tag, checked);
    },
    customTagChange(tag, checked) {
      this.handleChange(tag, checked);
    },
    statusTagChange(tag, checked) {
      this.handleChange(tag, checked);
    },
    handleChange(tag, checked) {
      const { selectedTags } = this;
      const nextSelectedTags = checked
        ? [...selectedTags, tag]
        : selectedTags.filter(t => t !== tag);
      console.log("You are interested in: ", nextSelectedTags);
      this.selectedTags = nextSelectedTags;
    },
    onSelectChange(selectedRowKeys) {
      console.log("selectedRowKeys changed: ", selectedRowKeys);
      this.selectedRowKeys = selectedRowKeys;
    }
  }
};
</script>

<style>
.content-header {
  background-color: #fff;
  padding: 24px 24px 0 24px;
}
.form-card {
  background-color: #fff;
  margin-top: 12px;
  padding: 8px 24px 0 24px;
}
.search-tab-container {
  margin-top: 20px;
}

.search-menu-tabs .ant-tabs-bar {
  margin: 0;
}
.search-form-row {
  margin-bottom: 10px;
  padding-bottom: 10px;
  border-bottom: 1px dashed #ccc;
}
.search-form-row:last-child {
  border-bottom: 0;
}
.search-form-label {
  margin-right: 20px;
}
.search-form-row .ant-tag {
  font-size: 16px;
  padding: 5px 8px;
  height: auto;
}
</style>
