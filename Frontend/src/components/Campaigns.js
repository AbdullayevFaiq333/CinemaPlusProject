import React, { useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentCampaigns } from "../actions";
import {Link} from "react-router-dom";

const Campaigns = () => {
  const dispatch = useDispatch();

  const { content } = useSelector((state) => state.contentCampaigns);
  const {activeLanguage}=useSelector((state)=> state.languages)

  useEffect(() => {
    dispatch(fetchContentCampaigns());
  }, [dispatch,activeLanguage]);
  return (
    <div className="campaigns">
      <div className="container">
        <div className="row">
          <div className="col-md-12">
            <div className="campgHead">
              <a href="#" className="campgTitle">
                Aksiyalar
              </a>
            </div>
            <div className="campgBody">
              <div className="campgBlueLine"></div>
              <div className="row">
                {content.map((campaignItem) => {
                  return (
                    <div key={campaignItem.id} className="col-md-4">
                      
                      <div className="campgImg">
                        <p>{campaignItem.title}</p>
                        <Link to={`campaign/${campaignItem.id}`} >
                          
                          <img
                            src={`./images/${campaignItem.image}`}
                            alt="Qis Nagili"
                          />
                        </Link>
                      </div>
                    </div>
                  );
                })}
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Campaigns;
