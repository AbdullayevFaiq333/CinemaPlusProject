import React, { useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentMovieDetail } from "../actions";
import { useParams } from "react-router";

const MovieDetail = () => {
  const dispatch = useDispatch();

  const { content } = useSelector((state) => state.contentMovieDetail);
  const { id } = useParams();

  useEffect(() => {
    dispatch(fetchContentMovieDetail(id));
  }, [dispatch]);

  return (
    <div class="movieDetails">
      
      <iframe
        width="560"
        height="315"
        src={`${content.treyler}`}
        title="YouTube video player"
        frameborder="0"
        allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
        allowfullscreen
      ></iframe>

      <div class="row">
        <div class="tabs">
          <div class="movieDesc">
            <div class="leftSide">
              <img src={`http://localhost:3000/images/${content.image}`} class="detailImg" />
              <div class="descMovie">
                {content.about}
              </div>
            </div>
            <div class="rightSide">
              <div class="filmDetails">
                <div class="context">
                  <br />
                  <ul class="detailsLine">
                    <li class="allLines">
                      <span class="descTitles">Formatlar</span>
                      <div class="secondPart">
                        <span class="abouts">
                          <a
                            data-toggle="tooltip"
                            data-placement="bottom"
                            title="Film 2D formatında nümayiş olunur"
                          >
                            <img
                              src="http://localhost:3000/images/movies/ni_twod.png"
                              alt="2D"
                              class="miniImg"
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
                              class="miniImg"
                            />
                          </a>
                        </span>
                      </div>
                    </li>
                    <li class="allLines">
                      <span class="descTitles">Kinoteatrda</span>
                      <div class="secondPart">{content.startTime} - {content.endTime}</div>
                    </li>
                    <li class="allLines">
                      <span class="descTitles">Ölkə</span>
                      <div class="secondPart">{content.country}</div>
                    </li>
                    <li class="allLines">
                      <span class="descTitles"> Rejissor</span>
                      <div class="secondPart">{content.director}</div>
                    </li>
                    <li class="allLines">
                      <span class="descTitles">Rollarda</span>
                      <div class="secondPart">
                        {content.actors}
                      </div>
                    </li>
                    <li class="allLines">
                      <div class="descTitles">Müddət</div>
                      <div class="secondPart">{content.duration}</div>
                    </li>
                    <li class="allLines">
                      <span class="descTitles">Janr</span>
                      <div class="secondPart">{content.genre}</div>
                    </li>
                    <li class="allLines">
                      <span class="descTitles">Yaş həddi</span>
                      <div class="secondPart">{content.age}+</div>
                    </li>
                  </ul>
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
