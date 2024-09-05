<template>
  <div class="formContainer">
    <FloatLabel v-for="(item, index) in items" :key="index">
        <InputText :id="item.label" v-model="item.itemRef.value"/>
        <label :for="item.label"> {{ item.label }}</label>
    </FloatLabel>
    <Toast/>
    <Button icon="pi pi-check" label="Submit" @click="handleSubmitClick"></Button>

  </div>
</template>

<script setup>
import InputText from 'primevue/inputtext'
import FloatLabel from 'primevue/floatlabel'
import Button from 'primevue/button'
import { nameInputIsValid, addressInputIsvalid, emailInputIsValid, phoneInputIsValid } from '../other/validation'
import { ref } from 'vue'
import Toast from 'primevue/toast'
import { useToast } from "primevue/usetoast";

const items = [
  { label: "First Name", validationFn: nameInputIsValid, itemRef: ref('')},
  { label: "Last Name", validationFn: nameInputIsValid, itemRef: ref('')},
  { label: "E-mail", validationFn: emailInputIsValid, itemRef: ref('')},
  { label: "Address", validationFn: addressInputIsvalid, itemRef: ref('')},
  { label: "Phone", validationFn: phoneInputIsValid, itemRef: ref('')},
]

const toast = useToast();
const showError = (label) => {
    toast.add({ severity: 'error', summary: 'Invalid input', detail: label + " is improperly formatted, empty or contains forbidden characters.", life: 3000 });
};

const handleSubmitClick = () => {
  for (let item of items) {
    if (!item.validationFn(item.itemRef.value)) {
      showError(item.label);
    }
  }
}

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
