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
      <div>
        <form @submit.prevent="checkForm" method="post">
          <div class="card-body">
            <div class="row">
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">Registration Num</label>
                  <input
                    type="text"
                    name="reg_no"
                    v-model="objectBody.regNumber"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">First Name</label>
                  <input
                    type="text"
                    name="fname"
                    v-model="objectBody.firstName"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">Surname</label>
                  <input
                    type="text"
                    name="surname"
                    v-model="objectBody.surname"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">Last Name</label>
                  <input
                    type="text"
                    name="lname"
                    v-model="objectBody.lastName"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-sm-6 col-md-6 col-xl-6">
                <div class="form-group">
                  <label class="form-label">Address</label>
                  <input
                    type="text"
                    name="address"
                    v-model="objectBody.address"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">State of Origin</label>
                  <select
                    v-model="myObject.StateId"
                    @change="getLga()"
                    name="state"
                    class="form-control form-control-inverse"
                    required
                  >
                    <option
                      v-for="State in States"
                      v-bind:value="State.stateId"
                      v-bind:key="State.stateId"
                      required
                    >
                      {{ State.name }}
                    </option>
                  </select>
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">Local Govt Area</label>
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
                  <label class="form-label">Religion</label>
                  <select
                    v-model="objectBody.religion"
                    name="religion"
                    class="form-control form-control-inverse"
                    required
                  >
                    <option
                      v-for="Reli in Religions"
                      v-bind:value="Reli.ReligionId"
                      v-bind:key="Reli.ReligionId"
                      required
                    >
                      {{ Reli.name }}
                    </option>
                  </select>
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <label class="form-label">Date of Birth</label>
                <vuejsDatepicker
                  input-class="form-control"
                  type="date_1"
                  name="date_1"
                  v-model="objectBody.dateOfBirth"
                >
                </vuejsDatepicker>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">Phone</label>
                  <input
                    type="number"
                    name="phonenumber_1"
                    v-model="objectBody.phoneNumber"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label"> Alt Phone</label>
                  <input
                    type="number"
                    name="phonenumber_2"
                    v-model="objectBody.alt_PhoneNumber"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-sm-3 col-md-3 col-xl-3 m-b-30">
                <label class="form-label">Admission Date</label>
                <vuejsDatepicker
                  input-class="form-control"
                  type="date_2"
                  name="date_2"
                  v-model="objectBody.dateOfAdmission"
                >
                </vuejsDatepicker>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">Program</label>
                  <select
                    type="text"
                    name="program"
                    v-model="objectBody.program"
                    class="form-control form-control-inverse"
                  >
                    <option
                      v-for="prog in Programs"
                      v-bind:value="prog.programId"
                      v-bind:key="prog.programId"
                      required
                    >
                      {{ prog.prog_name }}
                    </option>
                  </select>
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">Department</label>
                  <select
                    type="text"
                    name="dept"
                    v-model="objectBody.department"
                    class="form-control form-control-inverse"
                  >
                    <option
                      v-for="depart in Depts"
                      v-bind:value="depart.departmentId"
                      v-bind:key="depart.departmentId"
                      required
                    >
                      {{ depart.dept_name }}
                    </option>
                  </select>
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">Course</label>
                  <select
                    type="text"
                    name="course"
                    v-model="objectBody.course"
                    class="form-control form-control-inverse"
                  >
                    <option
                      v-for="cour in Courses"
                      v-bind:value="cour.courseId"
                      v-bind:key="cour.courseId"
                      required
                    >
                      {{ cour.course_name }}
                    </option>
                  </select>
                </div>
              </div>
              <!-- <div class="col-sm-3 col-md-3 col-xl-3 m-b-30">
                <label class="form-label">Admission Date</label>
                <vuejsDatepicker
                  input-class="form-control"
                  type="date_2"
                  name="date_2"
                  v-model="date_2"
                >
                </vuejsDatepicker>
              </div> -->
            </div>
            <div class="row">
                <!-- <div role="group" class="btn-group mr-3 sw-btn-group-extra">
                  <button
                    v-if="
                      this.objectBody.reg_no != '' &&
                      this.objectBody.fname != '' &&
                      this.objectBody.surname != '' &&
                      this.objectBody.lname != '' &&
                      this.objectBody.address != '' &&
                      this.objectBody.state != '' &&
                      this.objectBody.lga != '' &&
                      this.objectBody.religion != '' &&
                      this.objectBody.date_1 != '' &&
                      this.objectBody.phonenumber_1 != '' &&
                      this.objectBody.phonenumber_2 != '' &&
                      this.objectBody.program != '' &&
                      this.objectBody.dept != '' &&
                      this.objectBody.course != '' &&
                      this.objectBody.date_2 != ''
                    "
                    v-on:click="checkForm"
                    type="submit"
                    class="btn btn-submit btn-primary"
                  >
                    {{ CreateOrUpdate }}
                  </button>
                </div> -->
                
                <div role="group" class="btn-group mr-3 sw-btn-group-extra">
                  <button type="Submit" class="btn btn-submit btn-primary" @click.prevent="postPost()"> Submit </button>
                </div>
                <div role="group" class="btn-group mr-3 sw-btn-group-extra">
                  <button class="btn btn-danger" @click.prevent="onCancel()">Cancel</button>
                </div>
            </div>
          </div>
        </form>
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
      errors: [],
      showCreateButton: true,
      responseMessage: "",
      CreateOrUpdate: "Create",
      classList: null,
      Depts: null,
      States: null,
      Religions: null,
      lga: null,
      Courses: null,
      Programs: null,
      objectBody: {
        regNumber: "",
        firstName: "",
        surname: "",
        lastName: "",
        address: "",
        stateId: "",
        localGovt: "",
        religionId: "",
        dateOfBirth: "",
        phoneNumber: "",
        alt_PhoneNumber: "",
        programId: "",
        departmentId: "",
        courseId: "",
        dateOfAdmission: "",
      },
      // myObject: {
      //   Code: "",
      //   LocalGovt: "",
      //   MyState: "",
      //   StateId: "",
      // },
    };
  },

  mounted() {
    axios
      .get("/api/StudentReg/getAllState")
      .then((response) => (this.States = response.data));
    axios
      .get("/api/StudentReg/getReligion")
      .then((response) => (this.Religions = response.data));
    axios
      .get("/api/StudentReg/getAllDepartment")
      .then((response) => (this.Depts = response.data));
    axios
      .get("/api/StudentReg/getAllProgram")
      .then((response) => (this.Programs = response.data));
    axios
      .get("/api/StudentReg/getAllCourse")
      .then((response) => (this.Courses = response.data));
  },

  methods: {
    checkForm: function (e) {
      this.errors = [];

      if (this.objectBody.regNumber == "") this.errors.push("Code required.");

      if (this.objectBody.firstName == "")
        this.errors.push("Description required.");

      if (this.objectBody.surname == "")
        this.errors.push("Depreciation Rate required.");

      if (this.objectBody.lastName == "") this.errors.push("Method required.");

      if (this.objectBody.address == "")
        this.errors.push("Cost Code required.");

      if (this.objectBody.stateId == "") this.errors.push("Cost Code required.");

      if (this.objectBody.localGovt == "") this.errors.push("Cost Code required.");

      if (this.objectBody.religionId == "")
        this.errors.push("Cost Code required.");

      if (this.objectBody.dateOfBirth == "") this.errors.push("Cost Code required.");

      if (this.objectBody.phoneNumber == "")
        this.errors.push("Cost Code required.");

      if (this.objectBody.alt_PhoneNumber == "")
        this.errors.push("Cost Code required.");

      if (this.objectBody.programId == "")
        this.errors.push("Cost Code required.");

      if (this.objectBody.departmentId == "") this.errors.push("Cost Code required.");

      if (this.objectBody.courseId == "") this.errors.push("Cost Code required.");

      if (this.objectBody.dateOfAdmission == "") this.errors.push("Cost Code required.");

      if (
        this.objectBody.regNumber &&
        this.objectBody.firstName &&
        this.objectBody.surname &&
        this.objectBody.lastName &&
        this.objectBody.address &&
        this.objectBody.stateId &&
        this.objectBody.localGovt &&
        this.objectBody.religionId &&
        this.objectBody.dateOfBirth &&
        this.objectBody.phoneNumber &&
        this.objectBody.alt_PhoneNumber &&
        this.objectBody.programId &&
        this.objectBody.departmentId &&
        this.objectBody.courseId &&
        this.objectBody.dateOfAdmission
      ) {
        this.errors = [];

        this.postPost();
      }

      e.preventDefault();
    },

    postPost() {
        axios
        .post(`/api/StudentReg/addnewstudent/`, this.objectBody)
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

      this.$alert("Student Created Successfully!!!", "Ok", "success");
    },

    onCancel() {
      this.errors = [];

      this.objectBody.regNumber = "";
      this.objectBody.firstName = "";
      this.objectBody.surname = "";
      this.objectBody.lastName = "";
      this.objectBody.address = "";
      this.objectBody.stateId = "";
      this.objectBody.localGovt = "";
      this.objectBody.religionId = "";
      this.objectBody.dateOfBirth = "";
      this.objectBody.phoneNumber = "";
      this.objectBody.alt_PhoneNumber = "";
      this.objectBody.programId = "";
      this.objectBody.departmentId = "";
      this.objectBody.courseId = "";
      this.objectBody.dateOfAdmission = "";
    },

    getLga() {
      axios
        .get(`/api/StudentReg/eachgetLGA/${this.objectBody.stateId}`)
        .then((response) => {
          this.lga = response.data;
          console.log(response.data);
        });
    },
  },
};
</script>

