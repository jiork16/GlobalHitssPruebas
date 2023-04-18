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
  }),
  created() {
    //this.getListCategory();
  },
  methods: {
    setDatainput(data) {
      console.log(data)
      this.form.id=data.id
      this.form.code=data.code
      this.form.name=data.name
      this.form.category_id=data.category_id
      this.selected= data.category_id
      console.log(this.selected)
    },
    cleanData(){
      this.form.code=null
      this.form.name=null
      this.form.category_id=0
      this.getListCategory();
      this.selected=0
    },
    saveProduct(){
      if (this.form.code === null || (this.form.code).length==0 ) {
        alert("Ingrese Codigo")
        return
      }
      if (this.form.name === null || (this.form.name).length==0 ) {
        alert("Ingrese Nombre")
        return
      }
      if (this.selected==0 ) {
        alert("Seleccione Categoria")
        return
      }
      if (this.form.id===null || this.form.id===0) {
        this.postSaveProduct();
      }else{
        this.updateModifyProduct();
        this.form.id=null
      }
    }
  }
}
</script>


