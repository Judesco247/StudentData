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
                    name="fname"
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
                    type="text"
                    name="state"
                    class="form-control form-control-inverse"
                    required
                  >
                  <option></option>
                  </select>
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">LGA</label>
                  <select
                    type="text"
                    name="lga"
                    class="form-control form-control-inverse"
                    required
                  >
                  <option></option>
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
                  type="date"
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
                    name="phonenumber"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label"> ALT PHONE NUMBER</label>
                  <input
                    type="number"
                    name="phonenumber"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">PROGRAM</label>
                  <input
                    type="text"
                    name="religion"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">DEPARTMENT</label>
                  <input
                    type="text"
                    name="religion"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <div class="form-group">
                  <label class="form-label">COURSE</label>
                  <input
                    type="text"
                    name="religion"
                    class="form-control form-control-inverse"
                  />
                </div>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                <label class="form-label">ADMISSION DATE</label>
                <vuejsDatepicker
                  input-class="form-control"
                  type="date"
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
  </div>
</template>

<script>
import vuejsDatepicker from "vuejs-datepicker";
export default {
  components: {
    vuejsDatepicker,
  },
};
</script>

