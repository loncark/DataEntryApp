<template>
  <div class="formContainer">
    <FloatLabel v-for="(item, index) in items" :key="index">
        <InputText :id="item.label" />
        <label :for="item.label"> {{ item.label }}</label>
    </FloatLabel>
    <Button icon="pi pi-check" label="Submit"></Button>
  </div>
</template>

<script setup>
import InputText from 'primevue/inputtext'
import FloatLabel from 'primevue/floatlabel'
import Button from 'primevue/button'

const items = [
  { label: "First Name", validationFn: () => true, },
  { label: "Last Name", validationFn: () => true, },
  { label: "E-mail", validationFn: () => true, },
  { label: "Address", validationFn: () => true, },
  { label: "Phone", validationFn: () => true, },
]

</script>

<style scoped>
.formContainer {
  display: flex;
  flex-direction: column;
  margin: 20vh auto auto auto;

  height: 400px;
  width: fit-content;
  justify-content: space-between;
  align-items: center;
}

.p-button {
  width: fit-content
}
</style>
