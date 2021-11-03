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
                            <label class="form-label">ASSET CODE</label>
                            <input 
                              type="text" 
                              name="assetcode" 
                              class="form-control form-control-inverse"
                            />
                        </div>
                </div>
                <div class="col-sm-9 col-md-9 col-xl-9">
                        <div class="form-group">
                            <label class="form-label">ASSET DESCRIPTION</label>
                            <input 
                              type="text" 
                              name="assetdesc" 
                              class="form-control form-control-inverse"
                            />
                        </div>
                </div>
            </div>
            <div class="row">
              <div class="col-sm-9 col-md-9 col-xl-9 m-b-30">
                <label class="form-label">ASSET CLASSIFICATION</label>
                <select
                  name="assetclass"
                  class="form-control form-control-inverse"
                >
                  <option
                  >
                  
                  </option>
                </select>
              </div>
              <div class="col-sm-3 col-md-3 col-xl-3">
                        <div class="form-group">
                            <label class="form-label">DEPRECIATION RATE</label>
                            <input 
                              type="number" 
                              name="deprate" 
                              class="form-control form-control-inverse"
                            />
                        </div>
                </div>
            </div>

            <div class="row">
              <div class="col-sm-6 col-md-6 col-xl-6 m-b-30">
                <label class="form-label">DEPARTMENT</label>
                <select
                  name="assetclass"
                  class="form-control form-control-inverse"
                >
                  <option
                  >
                  
                  </option>
                </select>
              </div>
              <div class="col-sm-6 col-md-6 col-xl-6 m-b-30">
                <label class="form-label">BUSINESS LINE</label>
                <select
                  name="assetclass"
                  class="form-control form-control-inverse"
                >
                  <option
                  >
                  
                  </option>
                </select>
              </div>
              
            </div>

            <div class="row">
                <div class="col-sm-4 col-md-4 col-xl-4 m-b-30">
                  <label class="form-label">RECLASSIFICATION DATE</label>
                  <vuejsDatepicker
                    input-class="form-control"
                    name="reclassdate"
                    type="date"
                  >
                  </vuejsDatepicker>
                </div>
                <div class="col-sm-4 col-md-4 col-xl-4 m-b-30">
                  <label class="form-label">PURCHASE</label>
                  <div class="row">
                      <div class="col-sm-6 col-md-6 col-xl-6">
                          <label class="form-label">DATE</label>
                          <vuejsDatepicker
                            input-class="form-control"
                            name="purchdate"
                            type="date"
                          >
                          </vuejsDatepicker>
                      </div>
                      <div class="col-sm-6 col-md-6 col-xl-6">
                          <div class="form-group">
                            <label class="form-label">VALUE</label>
                            <input 
                              type="number" 
                              name="purchval"
                              class="form-control form-control-inverse"
                            />
                        </div>
                      </div>
                  </div>
                </div>

                <div class="col-sm-4 col-md-4 col-xl-4 m-b-30">
                  <label class="form-label">INSURANCE</label>
                  <div class="row">
                      <div class="col-sm-6 col-md-6 col-xl-6">
                          <label class="form-label">DATE</label>
                          <vuejsDatepicker
                            input-class="form-control"
                            name="insurdate"
                            type="date"
                          >
                          </vuejsDatepicker>
                      </div>
                      <div class="col-sm-6 col-md-6 col-xl-6">
                          <div class="form-group">
                            <label class="form-label">VALUE</label>
                            <input 
                              type="number" 
                              name="insurdval"
                              class="form-control form-control-inverse" 
                            />
                        </div>
                      </div>
                  </div>
                </div>
            </div>

             <div class="row">
                <div class="col-sm-4 col-md-4 col-xl-4 m-b-30">
                  <label class="form-label">LAST MOVEMENT DATE</label>
                  <vuejsDatepicker
                    input-class="form-control"
                    name="lastmovdate"
                    type="date"
                  >
                  </vuejsDatepicker>
                </div>
                <div class="col-sm-4 col-md-4 col-xl-4 m-b-30">
                  <label class="form-label">DISPOSAL</label>
                  <div class="row">
                      <div class="col-sm-6 col-md-6 col-xl-6">
                          <label class="form-label">DATE</label>
                          <vuejsDatepicker
                            input-class="form-control"
                            name="dispdate"
                            type="date"
                          >
                          </vuejsDatepicker>
                      </div>
                      <div class="col-sm-6 col-md-6 col-xl-6">
                          <div class="form-group">
                            <label class="form-label">VALUE</label>
                            <input 
                              type="number" 
                              name="dispval"
                              class="form-control form-control-inverse" 
                            />
                        </div>
                      </div>
                  </div>
                </div>

                <div class="col-sm-4 col-md-4 col-xl-4 m-b-30">
                  <label class="form-label">REVALUATION</label>
                  <div class="row">
                      <div class="col-sm-6 col-md-6 col-xl-6">
                          <label class="form-label">DATE</label>
                          <vuejsDatepicker
                            input-class="form-control"
                            name="revaldate"
                            type="date"
                          >
                          </vuejsDatepicker>
                      </div>
                      <div class="col-sm-6 col-md-6 col-xl-6">
                          <div class="form-group">
                            <label class="form-label">VALUE</label>
                            <input 
                              type="number" 
                              name="revalval"
                              class="form-control form-control-inverse" 
                            />
                        </div>
                      </div>
                  </div>
                </div>
            </div>

            <div class="row">
                <div class="col-sm-4 col-md-4 col-xl-4 m-b-30">
                    <div class="form-group">
                            <label class="form-label">ACCUMULATED DEPRECIATION VALUE</label>
                            <input 
                              type="number" 
                              name="accum_depval"
                              class="form-control form-control-inverse"
                            />
                    </div>
                </div>
            </div>
            
            <div class="row">
              <div class="col-6">
                <div role="group" class="btn-group mr-2 sw-btn-group-extra">
                  <button
                    type="submit"
                    class="btn btn-submit btn-primary"
                  >
                    
                  </button>
                </div>
                <div role="group" class="btn-group mr-2 sw-btn-group-extra">
                  <button  class="btn btn-danger">Cancel</button>
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
export default {
    
}
</script>

