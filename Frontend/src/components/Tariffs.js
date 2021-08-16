import React from "react";
import Branch from "./Branch";
import BranchInfo from "./BranchInfo";

const Tariffs = () => {
  return (
    <>
    <Branch/>
    <BranchInfo/>
    <div class="tariffs">
      <div class="container ">
        <div class="row">
          <div class="col-md-12">
            <div class="tabs">
              <div className="head">
                <a href="#" className="title">
                  TARIFLƏR
                </a>
                
              </div>
              <div class="tabBody">
                <div class="tabTariffs">
                  <img
                    src="images/tariffs/tarif_tablica_28_4.jpg"
                    alt="28 Mall"
                  />
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    </>
  );
};

export default Tariffs;
