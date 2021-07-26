import React, { useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentDolbyAtmos } from "../actions";

const DolbyAtmos = () => {
  const dispatch = useDispatch();

  const { content, loading } = useSelector((state) => state.contentDolbyAtmos);

  useEffect(() => {
    dispatch(fetchContentDolbyAtmos());
  }, [dispatch]);

  return (
    <div class="dolbyAtmos">
      <div class="container">
        <div class="row">
          {loading ? (
            <h1>Loading</h1>
          ) : (
            <>
              {content.map((dolbyAtmosItem) => {
                return (
                  <div key={content.id}>
                    <div class="col-md-12">
                      <img
                        src={`./images/${dolbyAtmosItem.logo}`}
                        alt="DolbyAtmos"
                        class="dolbyAtmos-Logo"
                      />
                    </div>
                    <div class="col-md-12" >
                      <p>
                        <h5>
                          <strong>{dolbyAtmosItem.firstTitle}</strong>
                        </h5>
                      </p>
                      <p>{dolbyAtmosItem.firstDescription}</p>
                      <div class="dolbyFirstDescription">
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
