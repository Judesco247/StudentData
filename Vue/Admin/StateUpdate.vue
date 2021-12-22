<template>
     <div>
    <!-- Confirm pop-up -->

    <!-- New State Addition -->
    <div v-if="isFormVisible">
      <div class="page-wrapper">
        <div class="page-header">
          <div class="row align-items-end">
            <div class="col-lg-8">
              <div class="page-header-title">
                <div class="d-inline">
                  <h4>State Input Form</h4>
                  <span>ADD NEW NEW STATE</span>
                </div>
              </div>
            </div>
            <!-- <div class="col-lg-4">
              <div class="page-header-breadcrumb">
                <ul class="breadcrumb-title">
                  <li class="breadcrumb-item">
                    <a href="index.html"> <i class="feather icon-home"></i> </a>
                  </li>
                  <li class="breadcrumb-item">
                    <a href="#!">Data Table</a>
                  </li>
                  <li class="breadcrumb-item">
                    <a href="#!">Styling</a>
                  </li>
                </ul>
              </div>
            </div> -->
          </div>
        </div>
      </div>

      <div class="page body">
        <div class="card">
          <form @submit.prevent="checkForm" method="post"> 
            <div class="card-body">
              <div class="row">
                <div class="col-sm-2 col-md-2 col-xl-2">
                  <div class="form-group">
                    <label class="form-label"><strong>State Id</strong></label>
                    <input
                      name="StateId"
                      v-model="objectBody.stateId"
                      :readonly="CreateOrUpdate == 'Update'"
                      class="form-control"
                    />
                  </div>
                </div>
                <div class="col-3 col-xl-3">
                  <div class="form-group">
                    <label class="form-label"><strong>State Name</strong></label>
                    <input
                      name="statename"
                      v-model="objectBody.name"
                      class="form-control"
                    />
                  </div>
                </div>
                <div class="col-2 col-xl-2">
                  <div class="form-group">
                    <label class="form-label"><strong>State Code</strong></label>
                    <input
                      name="statecode"
                      v-model="objectBody.code"
                      class="form-control"
                    />
                  </div>
                </div>
                <div class="col-2 col-xl-2">
                  <div class="form-group">
                    <label class="form-label"><strong>Geozone Id</strong></label>
                    <input
                      name="geozone"
                      v-model="objectBody.geozoneid"
                      class="form-control"
                    />
                  </div>
                </div>
                <div class="col-2 col-xl-2">
                  <div class="form-group">
                    <label class="form-label"><strong> Country Id</strong></label>
                    <input
                      name="countryid"
                      v-model="objectBody.countryId"
                      class="form-control"
                    />
                  </div>
                </div>
              </div>
              <div role="group" class="btn-group mr-2 sw-btn-group-extra">
                    <button
                      v-if="
                        this.objectBody.stateId != '' &&
                        this.objectBody.name != '' &&
                        this.objectBody.code != '' &&
                        this.objectBody.geozoneid != '' &&
                        this.objectBody.countryId != ''
                      "
                      v-on:click="checkForm"
                      type="submit"
                      class="btn btn-primary mb-2"
                    >
                      {{ CreateOrUpdate }}
                    </button>
                  </div>
                  <div role="group" class="btn-group mr-2 sw-btn-group-extra">
                    <button @click.prevent="onCancel()" class="btn btn-danger">
                      Cancel
                    </button>
                  </div>
            </div>
          </form>
        </div>
      </div>
    </div>

    <!-- NAV DIV -->
    <nav v-if="!isFormVisible" aria-label="breadcrumb">
      <ol class="breadcrumb">
        <li class="breadcrumb-item" aria-current="page">
          <a @click="showForm()"
            ><span class="btn btn-primary h5">Add New State</span></a
          >
        </li>
      </ol>
    </nav>
    <!--END OF NAV DIV -->

    <!-- Set Asset Class Table -->
    <div v-if="!isFormVisible">
      <div class="page-wrapper">
        <div class="page-header">
          <div class="row align-items-end">
            <div class="col-lg-8">
              <div class="page-header-title">
                <div class="d-inline">
                  <span>THE LIST OF ALL STATES</span>
                </div>
              </div>
            </div>
            <!-- <div class="col-lg-4">
              <div class="page-header-breadcrumb">
                <ul class="breadcrumb-title">
                  <li class="breadcrumb-item">
                    <a href="index.html"> <i class="feather icon-home"></i> </a>
                  </li>
                  <li class="breadcrumb-item">
                    <a href="#!">Data Table</a>
                  </li>
                  <li class="breadcrumb-item">
                    <a href="#!">Styling</a>
                  </li>
                </ul>
              </div>
            </div> -->
          </div>
        </div>
      </div>

      <div class="page-body">
        <div class="card">
          <div class="card-body">
            <!-- <div>
              <button
                type="button"
                class="btn btn-submit btn-primary"
                v-on:click="generateReport"
              >
                Print Report
              </button>
            </div> -->
            <table
              id="datatables-buttons"
              class="table table-striped"
              style="width: 100%"
            >
              <thead>
                <tr>
                  <th>State Id</th>
                  <th>State Name</th>
                  <th>State Code</th>
                  <th>Geozone Id</th>
                  <th>Country Id</th>
                </tr>
              </thead>
              <tbody>
                <tr v-for="(StatesInfo, index) in stateList" :key="index">
                  <td>{{ StatesInfo.stateId }}</td>
                  <td>{{ StatesInfo.name }}</td>
                  <td>{{ StatesInfo.code }}</td>
                  <td>{{ StatesInfo.geozoneid }}</td>
                  <td>{{ StatesInfo.countryId }}</td>

                  <td>
                    <button
                      type="button"
                      class="btn btn-submit btn-primary btn-sm btn-block"
                      @click="editStates(StatesInfo.stateId)"
                    >
                      Edit
                    </button>
                    <!-- <button
                      type="button"
                      class="btn btn-submit btn-danger"
                      @click="
                        deleteAssetClass(
                          StatesInfo.StateId,
                          StatesInfo.Name
                        )
                      "
                    >
                      Delete
                    </button> -->
                  </td>
                </tr>
              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import VueSimpleAlert from "vue-simple-alert";
export default {
  components: {
    VueSimpleAlert,
  },

  data() {
    return {
      isFormVisible: false,
      errors:[],
      CreateOrUpdate: "Create",
      showCreateButton: true,
      canProcess: true,
      stateList: null,
      objectBody: {
        stateId: "",
        name: "",
        code: "",
        geozoneid: "",
        countryId: "",
      },
    };
  },

  methods: {
     checkForm: function (e) {
      this.errors = [];

      if (this.objectBody.stateId == "") this.errors.push("Code required.");

      if (this.objectBody.name == "")
        this.errors.push("Description required.");

      if (this.objectBody.code == "")
        this.errors.push("Depreciation Rate required.");

      if (this.objectBody.geozoneid == "")
        this.errors.push("Method required.");

      if (this.objectBody.countryId == "")
        this.errors.push("Cost Code required.");

      if (
        this.objectBody.stateId &&
        this.objectBody.name &&
        this.objectBody.code &&
        this.objectBody.geozoneid &&
        this.objectBody.countryId 
      ) {
        this.errors = [];

        this.postPost();
      }

      e.preventDefault();
    },

    postPost() {
      if (this.CreateOrUpdate == "Create") {
        axios
          .post(`/api/StudentReg/addnewState/`, this.objectBody)
          .then((response) => {
            this.responseMessage = response.data.responseDescription;
            this.canProcess = true;

            if (response.data.responseCode == "200") {
              //this Clears the Input field.
              this.onCancel();
            }
          })
          .catch((e) => {
            this.errors.push(e);
          });

        this.$alert("State Created Successfully!!!", "Ok", "success");

        this.isFormVisible = false;
      }

      if (this.CreateOrUpdate == "Update") {
        axios
          .put(`/api/StudentReg/updateStates/`, this.objectBody)
          .then((response) => {
            this.responseMessage = response.data.responseDescription;
            this.canProcess = true;

            if (response.data.responseCode == "200") {
              //this Clears the Input field.
              this.onCancel();
            }
          })
          .catch((e) => {
            this.errors.push(e);
          });

        this.$alert("State Updated Successfully!!!", "Ok", "success");

        this.isFormVisible = false;
      }
    },

    showForm() {
      this.isFormVisible = true;

      this.showCreateButton = false;
    },

     editStates(stateId) {
       
      axios
        .get(`/api/StudentReg/GetState/${stateId}`)
        .then((response) => {
          console.log(response.data);
          this.objectBody.stateId = response.data.stateId;
          this.objectBody.name = response.data.name;
          this.objectBody.code = response.data.code;
          this.objectBody.geozoneid = response.data.geozoneid;
          this.objectBody.countryId = response.data.countryId;

          this.isFormVisible = true;

          this.CreateOrUpdate = "Update";
        });
    },
    
    onCancel() {
      this.errors = [];

      this.objectBody.stateId = "";
      this.objectBody.name = "";
      this.objectBody.code = "";
      this.objectBody.geozoneid = "";
      this.objectBody.countryId = "";
    },
  },

  mounted() {
    axios
      .get("/api/StudentReg/getAllState")
      .then((response) => (this.stateList = response.data));
  },
}
</script>