import React, { useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentDolbyAtmos } from "../actions";

const DolbyAtmos = () => {
  const dispatch = useDispatch();

  const { content } = useSelector((state) => state.contentDolbyAtmos);
  const {activeLanguage}=useSelector((state)=> state.languages)

  useEffect(() => {
    dispatch(fetchContentDolbyAtmos());
  }, [dispatch, activeLanguage]);

  return (
    <div className="dolbyAtmos">
      <div className="container">
        <div className="row">
          { (
            <>
              {content.map((dolbyAtmosItem) => {
                return (
                  <div key={content.id}>
                    <div className="col-md-12">
                      <img
                        src={`./images/${dolbyAtmosItem.logo}`}
                        alt="DolbyAtmos"
                        className="dolbyAtmos-Logo"
                      />
                    </div>
                    <div className="col-md-12" >
                      <p>
                        <h5>
                          <strong>{dolbyAtmosItem.firstTitle}</strong>
                        </h5>
                      </p>
                      <p>{dolbyAtmosItem.firstDescription}</p>
                      <div className="dolbyFirstDescription">
                        <iframe
                          width="560"
                          height="315"
                          src={dolbyAtmosItem.youtubeURL}
                          title="YouTube video player"
                          frameborder="0"
                          allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
                          allowfullscreen
                        ></iframe>
                      </div>
                      <p>
                        <h5>
                          <strong>{dolbyAtmosItem.secondTitle}</strong>
                        </h5>
                      </p>
                      <p>{dolbyAtmosItem.secondDescription}</p>
                    </div>
                  </div>
                );
              })}
            </>
          )}
        </div>
      </div>
    </div>
  );
};

export default DolbyAtmos;
