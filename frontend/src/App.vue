<script setup>
import Form from './components/Form.vue'
import { ref, watchEffect } from 'vue';

const theme = ref('light');

watchEffect(() => {
  document.documentElement.setAttribute('data-theme', theme.value);
});
</script>

<template>
  <div id="app" >
    <Form></Form>
  </div>
</template>

<style scoped>

</style>
