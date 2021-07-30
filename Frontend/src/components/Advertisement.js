import React, { useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentAdvertisement } from "../actions";

const Advertisement = () => {

  const dispatch = useDispatch();

  const { content } = useSelector((state) => state.advertisement);

  useEffect(() => {
    dispatch(fetchContentAdvertisement());
  }, [dispatch]);

  return (
    <>
    {content.map((advertisementItem) => {
      return (
        <div key={content.id} className="advertisement" style={{
          backgroundImage:
          `url(http://localhost:3000/images/${advertisementItem.background})`,
        }}>
          <div className="container">
            <div className="row">
              <div className="col-md-12">
                <div className="adve">
                  <div className="coverAdvert for-style">
                    <img
                      src={`./images/${advertisementItem.image}`}
                      alt="coverAdvert"
                    />
                    
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      );
    })}
    </>
  );
};

export default Advertisement;
