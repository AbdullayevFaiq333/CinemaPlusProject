import React, { useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentCampaignDetail } from "../actions";
import { useParams } from "react-router";
import Moment from 'moment';

const CampaignDetail = () => {
  const dispatch = useDispatch();

  const { content } = useSelector((state) => state.contentCampaignDetail);
  const {id} = useParams();
  const {activeLanguage}=useSelector((state)=> state.languages)
  
  
  
  useEffect(() => {
    dispatch(fetchContentCampaignDetail(id));
  }, [dispatch,activeLanguage]);

  return (
    <div className="campaignDetail">
      <div className="container">
        <div className="row">
          
          <div className="col-md-12">
            <div className="campgDetailHead">
              <h4 className="campgHead">{content.title}</h4>
              <div className="campgDate"> {Moment(content.date).format('MMMM Do, YYYY')} </div>
              
              <div className="campgImg">
                <img src={`http://localhost:3000/images/${content.image}`} alt="" />
              </div>
              
            </div>
          </div>
        </div>
        <div className="col-md-7">
              <div className="campgDesc">
                <ul>
                  
                  <strong>
                    {content.description}
                  </strong>
                </ul>
              </div>
            </div>
          
        
      </div>
    </div>
  );
};

export default CampaignDetail;
