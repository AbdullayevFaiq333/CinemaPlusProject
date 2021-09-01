import React, { useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentMovie } from "../actions";
import { Link } from "react-router-dom";

const Movies = () => {
  const dispatch = useDispatch();

  const { movie } = useSelector((state) => state.contentMovie);

  useEffect(() => {
    dispatch(fetchContentMovie());
  }, [dispatch]);

  return (
    <div className="movies">
      <div className="container">
        <div className="moviesBody ">
          <div className="row">
            <div className="col-md-10 offset-md-1">
              <div className="row">
                {
                  <>
                    {movie?.map((movieItem) => {
                      return (
                        <div
                          key={movieItem.id}
                          className="col-md-3 col-sm-6 col-xs-6"
                        >
                          <div className="movieBody">
                            <div className="titImg">
                              <h2>
                                <a href="#">{movieItem.name}</a>
                              </h2>
                              <div className="movieImage">
                                <Link to={`movie/${movieItem.id}`} href="#">
                                  <div className="posterAnim">
                                    <img
                                      src={`http://localhost:3000/images/${movieItem.image}`}
                                      alt="movie"
                                    />
                                  </div>
                                </Link>
                              </div>
                            </div>
                            <div className="icons">
                              <div className="posterIcons">
                                <span className="about">
                                  <a
                                    data-toggle="tooltip"
                                    data-placement="bottom"
                                    title="Film 2D formatında nümayiş olunur"
                                  >
                                    <img
                                      src="images/movies/ni_twod.png"
                                      alt="2D"
                                    />
                                  </a>

                                  <a
                                    data-toggle="tooltip"
                                    data-placement="bottom"
                                    title="Film Rus dilində nümayiş olunur"
                                  >
                                    <img
                                      src="images/movies/ni_rus.png"
                                      alt="Rus"
                                    />
                                  </a>
                                </span>
                              </div>
                            </div>
                            <div className="sessions">
                              <div className="goFilm">
                                <a href="#">SEANSLAR</a>
                                <span class="barrage">+{movieItem.age}</span>
                              </div>
                            </div>
                          </div>
                        </div>
                      );
                    })}
                  </>
                }
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Movies;
