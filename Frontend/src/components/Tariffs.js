import React, { useEffect,useState } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentTariff } from "../actions";
import { SRLWrapper } from "simple-react-lightbox";
import axios from "axios";

import Branch from "./Branch";

const Tariffs = () => {
  //const dispatch = useDispatch();
  const [tariff,setTariff] = useState({});
  // const { content } = useSelector((state) => state.tariff);
  const [branchId,setBranchId] = useState(1);

  useEffect(() => {
    // dispatch(fetchContentTariff());
    const getTariff = async () => {
      await axios.get(`https://localhost:44359/api/Tariff/${branchId}`)
        .then((response) => setTariff(response.data));
    }

    getTariff();
  }, [branchId]);

  return (
    <>
      <Branch getBrach={setBranchId} />

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
                <SRLWrapper>
                <div class="tabTariffs">
                    <img src={`http://localhost:3000/images/${tariff.image}`} alt="28 Mall" />
                  </div>
                </SRLWrapper>
                  
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
