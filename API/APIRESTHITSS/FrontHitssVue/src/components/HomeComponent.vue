<template>
  <div class="table-responsive">
    <table class="table table-hover">
      <thead class="thead-dark">
        <tr>
          <th scope="col">#</th>
          <th scope="col">CI</th>
          <th scope="col">Nombre</th>
          <th scope="col">Apellido</th>
          <th scope="col">Fecha Nacimiento</th>
          <th scope="col">Direccion</th>
          <th scope="col">Email</th>
          <th scope="col">Telefono</th>
        </tr>
      </thead>
      <tbody>
        <template v-for="item in customers" :key="item.id">
          <tr>
            <th scope="row">{{ item.Id }}</th>
            <td>{{ item.ci }}</td>
            <td>{{ item.firstName }}</td>
            <td>{{ item.lastName }}</td>
            <td>{{ format_date(item.dateBirth)  }}</td>
            <td>{{ item.homeAdress }}</td>
            <td>{{ item.email }}</td>
            <td>{{ item.phoneNumer }}</td>
          </tr>
        </template>
      </tbody>
    </table>
  </div>

  </template>
  
  <script >
    import axios from "axios";
    import moment from 'moment';
    const axiosInstance = axios.create({
      headers: {
        "Access-Control-Allow-Origin": "*",
        "Content-Type": "	application/json"
      }
    });
    export default {
      name: "HomeComponent",
      components: {  
      },
      props: {
        refresh_data_filter: {
          type: String,
          required: false,
          default: null
        }
      },
      data: () => ({
        customers:[]
      }),
      created() {
      this.getListcustomers ();
    },
    watch: {
      refresh_data_filter: {
        handler: function(newVal) {
          if (newVal.length > 0) {
            this.getListcustomersFilter(newVal);
          }else{
            this.getListcustomers();
          }    
        }
      }
    },
      methods: {
        format_date(value){
          if (value) {
            return moment(String(value)).format('DD/MM/YYYY')
          }
        },
        getListcustomers() {
          axiosInstance.get(import.meta.env.VITE_API_URL+"Customer").then((response) => {
            this.customers=response.data.value;
            //console.log(this.customers);
            //console.log(response.data.value);
          }).catch((error) =>{
            console.log(error.response)

          });
        },
        getListcustomersFilter(CI) {
          axiosInstance.get(import.meta.env.VITE_API_URL+"Customer/getByCI",{ params: {CI:CI} }).then((response) => {
            this.customers=response.data.value;
            //console.log(response.data.value);
            this.$emit("setDatachild_filter")
          }).catch((error) =>{
            console.log(error.response)
          });
        }
      }
    }
  </script>
  
  
  