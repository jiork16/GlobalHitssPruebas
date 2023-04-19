<template>
<form>
  <div class="form-group">
    <label for="exampleInputEmail1">Cedula</label>
    <input type="text" class="form-control" id="CI" aria-describedby="CI"
    v-model="form.CI">
    <small id="CI" class="form-text text-muted">Ingrese la CI a buscar.</small>
  </div>
  <HomeComponent :refresh_data_filter="form.CI"></HomeComponent>
</form>
</template>

<script >
import HomeComponent from "@/components/HomeComponent.vue";
export default {
  components: {
    HomeComponent
  },
  data: () => ({
    form: {
      CI  :     null
    }
  })
}
</script>


