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
import { INVALID_INPUT_MSG, SAVE_SUCCESSFUL_MSG, EMAIL_TAKEN_MSG } from '../other/constants'
import { query } from '../other/utils'

const items = [
  { label: "First Name", validationFn: nameInputIsValid, itemRef: ref('')},
  { label: "Last Name", validationFn: nameInputIsValid, itemRef: ref('')},
  { label: "E-mail", validationFn: emailInputIsValid, itemRef: ref('')},
  { label: "Address", validationFn: addressInputIsvalid, itemRef: ref('')},
  { label: "Phone", validationFn: phoneInputIsValid, itemRef: ref('')},
]

const toast = useToast();
const showInvalidInputError = (label) => {
    toast.add({ severity: 'error', summary: 'Invalid input', detail: label + INVALID_INPUT_MSG, life: 3000 });
};
const showEmailTakenError = () => {
    toast.add({ severity: 'error', summary: 'Error', detail: EMAIL_TAKEN_MSG, life: 3000 });
};
const showSaveSuccess = () => {
    toast.add({ severity: 'success', summary: 'Success', detail: SAVE_SUCCESSFUL_MSG, life: 3000 });
};

const handleSubmitClick = async () => {
  for (let item of items) {
    if (!item.validationFn(item.itemRef.value)) {
      showInvalidInputError(item.label);
      return;
    }
  }

  let requestBody = {
    "firstName": items[0].itemRef.value,
    "lastName": items[1].itemRef.value,
    "email": items[2].itemRef.value,
    "address": items[3].itemRef.value !== '' ? items[3].itemRef.value : null,
    "phone": items[4].itemRef.value !== '' ? items[4].itemRef.value : null,
  }
  const status = await query('contacts', 'POST', JSON.stringify(requestBody));

  if(status === 200) {
    showSaveSuccess();
  }
  if(status === 409) {
    showEmailTakenError();
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
