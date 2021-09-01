import React, { useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentMovieDetail } from "../actions";
import { useParams } from "react-router";
import Moment from "moment";

const MovieDetail = () => {
  const dispatch = useDispatch();

  const { content } = useSelector((state) => state.contentMovieDetail);
  const { id } = useParams();

  useEffect(() => {
    dispatch(fetchContentMovieDetail(id));
  }, [dispatch]);

  return (
    <div className="movieDetails">
      <div className="container-fluid p-0">
        <div className="row ">
          <iframe
            width="560"
            height="315"
            src={`${content.treyler}`}
            title="YouTube video player"
            frameborder="0"
            allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
            allowfullscreen
          ></iframe>

          <div className="row p-0">
            <div className="col-md-2 col-sm-4 p-0 ">
              <img
                src={`http://localhost:3000/images/${content.image}`}
                className="detailImg"
              />
            </div>
            <div className="col-md-4 col-sm-8 p-0">
              <div className="descMovie">{content.about}</div>
            </div>
            <div className="col-md-6 p-0">
              
                <div className="rightSide">
                  <div className="filmDetails">
                    <div className="context">
                      <br />
                      <ul className="detailsLine">
                        <li className="allLines">
                          <span className="descTitles">Formatlar</span>
                          <div className="secondPart">
                            <span className="abouts">
                              <a
                                data-toggle="tooltip"
                                data-placement="bottom"
                                title="Film 2D formatında nümayiş olunur"
                              >
                                <img
                                  src="http://localhost:3000/images/movies/ni_twod.png"
                                  alt="2D"
                                  className="miniImg"
                                />
                              </a>

                              <a
                                data-toggle="tooltip"
                                data-placement="bottom"
                                title="Film Rus dilində nümayiş olunur"
                              >
                                <img
                                  src="http://localhost:3000/images/movies/ni_rus.png"
                                  alt="Rus"
                                  className="miniImg"
                                />
                              </a>
                            </span>
                          </div>
                        </li>
                        <li className="allLines">
                          <span className="descTitles">Kinoteatrda</span>
                          <div className="secondPart">
                            {Moment(content.startTime).format("MMMM Do, YYYY")}{" "}
                            - {Moment(content.endTime).format("MMMM Do, YYYY")}
                          </div>
                        </li>
                        <li className="allLines">
                          <span className="descTitles">Ölkə</span>
                          <div className="secondPart">{content.country}</div>
                        </li>
                        <li className="allLines">
                          <span className="descTitles"> Rejissor</span>
                          <div className="secondPart">{content.director}</div>
                        </li>
                        <li className="allLines">
                          <span className="descTitles">Rollarda</span>
                          <div className="secondPart">{content.actors}</div>
                        </li>
                        <li className="allLines">
                          <div className="descTitles">Müddət</div>
                          <div className="secondPart">{content.duration}</div>
                        </li>
                        <li className="allLines">
                          <span className="descTitles">Janr</span>
                          <div className="secondPart">{content.genre}</div>
                        </li>
                        <li className="allLines">
                          <span className="descTitles">Yaş həddi</span>
                          <div className="secondPart">{content.age}+</div>
                        </li>
                      </ul>
                    </div>
                  </div>
                </div>
              
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default MovieDetail;
