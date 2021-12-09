<template>
  <div>
    <div>
      <div class="page-wrapper">
        <div class="page-header">
          <div class="row align-items-end">
            <div class="col-lg-8">
              <div class="page-header-title">
                <div class="d-inline">
                  <h4>NEW STUDENT REGISTRATION FORM</h4>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

    <div class="page-body">
      <div class="card">
        <form>
          <div class="card-body">
            <div class="row">
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">REGISTRATION NUM</label>
                  <input
                    type="text"
                    name="reg_no"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">FIRST NAME</label>
                  <input
                    type="text"
                    name="fname"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">SURNAME</label>
                  <input
                    type="text"
                    name="surname"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">LAST NAME</label>
                  <input
                    type="text"
                    name="lname"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-sm-6 col-md-6 col-xl-6">
                <div class="form-group">
                  <label class="form-label">ADDRESS</label>
                  <input
                    type="text"
                    name="address"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">STATE of ORIGIN</label>
                  <select
                    v-model="myObject.StateId"
                    @change="getLga()"
                    name="state"
                    class="form-control form-control-inverse"
                    required
                  >
                    <option
                      v-for="State in states"
                      v-bind:value="State.stateId"
                      v-bind:key="State.stateId"
                      required
                    >
                    {{ State.name }}
                    </option>
                  </select>

                  <!-- <select 
                                name=""
                                v-model="objectBody.assetCode"
                                @change="getAssetValue()"
                                class="form-control">
                                <option 
                                    v-for="blist in assetRegList"
                                    v-bind:value="blist.assetCode"
                                    v-bind:key="blist.assetCode"
                                    required
                                >
                                {{ blist.assetDesc }}
                                </option>
                                </select> -->
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">LGA</label>
                  <select
                    v-model="myObject.LocalGovt"
                    name="lga"
                    class="form-control form-control-inverse"
                    required
                  >
                    <option
                      v-for="lgalist in localGovt"
                      v-bind:value="lgalist.Code"
                      v-bind:key="lgalist.Code"
                      required
                    >
                      {{ lgalist.lgaName }}
                    </option>
                  </select>
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">RELIGION</label>
                  <input
                    type="text"
                    name="religion"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <label class="form-label">DATE of BIRTH</label>
                <vuejsDatepicker
                  input-class="form-control"
                  type="date_1"
                  name="admissiondate"
                  required
                  readonly
                >
                </vuejsDatepicker>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">PHONE NUMBER</label>
                  <input
                    type="number"
                    name="phonenumber_1"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label"> ALT PHONE NUMBER</label>
                  <input
                    type="number"
                    name="phonenumber_2"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">PROGRAM</label>
                  <select
                    type="text"
                    name="program"
                    class="form-control form-control-inverse"
                  >
                    <option></option>
                  </select>
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">DEPARTMENT</label>
                  <select
                    type="text"
                    name="dept"
                    class="form-control form-control-inverse"
                  >
                    <option></option>
                  </select>
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">COURSE</label>
                  <select
                    type="text"
                    name="course"
                    class="form-control form-control-inverse"
                  >
                    <option></option>
                  </select>
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <label class="form-label">ADMISSION DATE</label>
                <vuejsDatepicker
                  input-class="form-control"
                  type="date_2"
                  name="admissiondate"
                  required
                  readonly
                >
                </vuejsDatepicker>
              </div>
            </div>
            <div class="row">
              <div class="col-6">
                <div role="group" class="btn-group mr-3 sw-btn-group-extra">
                  <button type="submit" class="btn btn-submit btn-primary">
                    Create
                  </button>
                </div>
                <div role="group" class="btn-group mr-3 sw-btn-group-extra">
                  <button class="btn btn-danger">Cancel</button>
                </div>
              </div>
            </div>
          </div>
        </form>
      </div>
    </div>

    <!-- ASSET TABLE -->
    <div>
      <div class="page-wrapper">
        <div class="page-header">
          <div class="row align-items-end">
            <div class="col-lg-8">
              <div class="page-header-title">
                <div class="d-inline">
                  <h4>STUDENTS LIST TABLE</h4>
                  <span>THE LIST OF STUDENTS</span>
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
            <table
              id="datatables-buttons"
              class="table table-striped"
              style="width: 100%"
            >
              <thead>
                <tr>
                  <th>Registration No</th>
                  <th>Surname</th>
                  <th>First Name</th>
                  <th>Department</th>
                  <th>Admission Date</th>
                  <th>Contact No</th>
                </tr>
              </thead>
              <tbody>
                <!-- <tr v-for="(assetReg,index) in assetRegList" :key="index">
                        <td>{{ assetReg.assetCode }}</td>
                        <td>{{ assetReg.assetDesc }}</td>
                        <td style="display:none;">{{ assetReg.classCode }}</td>
                        <td style="display:none;">{{ assetReg.id }}</td>
                        <td>{{ assetReg.classDesc }}</td>
                        <td style="display:none;">{{ assetReg.unitCode }}</td>
                        <td>{{ assetReg.unitDesc }}</td>
                        <td style="display:none;">{{ assetReg.busline }}</td>
                        <td>{{ assetReg.buslineDesc }}</td>
                        <td>{{ assetReg.purchval }}</td>

                        <td>
                            <button type="button" class="btn btn-submit btn-primary" @click="editAssetReg(assetReg.assetCode)" >Edit</button>
                            <button type="button" class="btn btn-submit btn-danger" @click="deleteAssetReg(assetReg.id, assetReg.assetDesc)" >Delete</button>
                        </td>
                    </tr> -->
              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import vuejsDatepicker from "vuejs-datepicker";
export default {
  components: {
    vuejsDatepicker,
  },

  data() {
    return {
      isFormVisible: false,
      errors: [],
      showCreateButton: true,
      responseMessage: "",
      CreateOrUpdate: "Create",
      classList: null,
      departments: null,
      states: null,
      localGovt: null,
      course: null,
      program: null,
      objectBody: {
        reg_no: "",
        fname: "",
        surname: "",
        lname: "",
        address: "",
        state: "",
        lga: "",
        religion: "",
        date_1: "",
        phonenumber_1: "",
        phonenumber_2: "",
        program: "",
        dept: "",
        course: "",
        date_2: "",
      },
      myObject: {
        Code: "",
        LocalGovt: "",
        MyState: "",
        StateId: ""

      }
    };
  },

  mounted() {
    axios
      .get("/api/StudentReg/getAllState")
      .then((response) => (this.states = response.data));
    //  axios
    //     .get("/api/StudentReg/getLGA")
    //     .then((response) => (this.localGovt = response.data));
  },

  methods: {
    checkForm: function (e) {
            this.postPost();
        },
    getLga() {
      axios
            .get(
            `/api/StudentReg/eachgetLGA/${this.myObject.StateId}`
            )
            .then((response) => {
                this.localGovt = response.data;
                console.log(response.data);
            });
    },
    
  },
};
</script>

