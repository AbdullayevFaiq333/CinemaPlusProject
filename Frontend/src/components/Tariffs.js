import React, { useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentTariff } from "../actions";



const Tariffs = ({ tariff }) => {
  const dispatch = useDispatch();

  // const { content } = useSelector((state) => state.tariff);

  useEffect(() => {
    // dispatch(fetchContentTariff());
    console.log(tariff);
  }, []);

  return (
    <>
      

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
                    <img src={`http://localhost:3000/images/${tariff.image}`} alt="28 Mall" />
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
