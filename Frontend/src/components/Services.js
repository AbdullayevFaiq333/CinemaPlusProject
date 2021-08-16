import React,{useEffect} from "react";
import { useSelector,useDispatch } from "react-redux";
import { fetchContentService } from '../actions';

const Platinum = () => {
    const dispatch = useDispatch();
    
    
    const { content } = useSelector((state) => state.contentService);

    useEffect(() => {
        dispatch(fetchContentService());
        
    }, [dispatch])
  
  return (
    <div className="service-section">
      <div class="overlay"></div>
      <div className="container">
        <div className="row">
          <div className="col-md-12">
            <div className="title">Service</div>
          </div>
          {
             (
                <>
                {content.map((serviceItem) => {
                  return (
                    <div key={serviceItem.id} className="col-md-6">
                      <div className="center-text">
                        <img src={`./images/${serviceItem.icon}`} alt="" />
                        <div className="title-img">{serviceItem.title}</div>
                        <p>{serviceItem.description}</p>
                      </div>
                    </div>
                  );
                })}
                </>
            )
          }
        </div>
      </div>
    </div>
  );
};

export default Platinum;
