import React, { useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentTariff } from "../actions";
import { useParams } from "react-router";
import Branch from "./Branch";
import BranchInfo from "./BranchInfo";

const Tariffs = () => {
  const dispatch = useDispatch();

  const { content } = useSelector((state) => state.tariff);
  const {id} = useParams();

  useEffect(() => {
    dispatch(fetchContentTariff(id));
  }, [dispatch]);

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
                    src={`./images/${content.image}`}
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
