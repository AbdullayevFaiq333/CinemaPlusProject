import React, { useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentPlatinum } from "../actions";

const Platinum = () => {
  const dispatch = useDispatch();

  const { content } = useSelector((state) => state.contentPlatinum);

  useEffect(() => {
    dispatch(fetchContentPlatinum());
  }, [dispatch]);

  return (
    <div className="platinum-section">
      <div className="container">
        <div className="row">
          <div className="col-md-12">
            <div className="title">Platinum</div>
          </div>
          {
            <>
              {content.map((platinumItem) => {
                return (
                  <div key={platinumItem.id} className="col-md-6">
                    <div className="center-text">
                      <img src={`./images/${platinumItem.icon}`} alt="" />
                      <div className="title-img">{platinumItem.title}</div>
                      <p>{platinumItem.description}</p>
                    </div>
                  </div>
                );
              })}
            </>
          }
        </div>
      </div>
    </div>
  );
};

export default Platinum;
