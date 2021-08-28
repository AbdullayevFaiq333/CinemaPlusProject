import React, { useEffect, useState } from "react";
import { useSelector, useDispatch } from "react-redux";
import {
  fetchContentMovie,
  fetchContentBranch,
  
} from "../actions";
import { useHistory } from "react-router-dom";
import axios from "axios";
import Moment from 'moment';

const BuyTicket = () => {
  const dispatch = useDispatch();
  const history = useHistory();

  const { movie } = useSelector((state) => state.contentMovie);
  const { movieWidthId } = useSelector((state) => state.movieWidthId);
  const { branch } = useSelector((state) => state.contentBranch);
  
  const [availableBranches, setAvailableBranches] = useState([]);
  const [startTime, setStartTime] = useState();
  const [endTime, setEndTime] = useState();
  
  const [session, setSession] = useState([])
  const [selectedBranch, setSelectedBranch] = useState();
  const [selectedMovie, setSelectedMovie] = useState();
  const [selectedSession, setSelectedSession] = useState();
  

  React.useEffect(() => {
    if (!!branch) {
      
        setAvailableBranches(branch);
     
    }
  }, [selectedMovie, branch]);

  useEffect(() => {
    dispatch(fetchContentMovie());
    dispatch(fetchContentBranch());
  }, [dispatch]);

  const handleChangeMovie = async ({ target: { value } }) => {
    console.log(value);
    setSelectedMovie(value);

    await axios
      .get(
        `https://localhost:44359/api/Content/getContentWebsiteMovieWidthId/${value}`
      )
      .then((response) => {
        setStartTime(response.data.startTime);
        setEndTime(response.data.endTime);
      });

      await axios
      .get(
        `https://localhost:44359/api/Session/${value}`
      )
      .then((respons) => {
        console.log(respons);
        setSession(respons.data);
        
      });

      
  };

  const handleBranchChange = ({ target: { value } }) => {
    setSelectedBranch(value);
  };

  const handleSessionChange = ({ target: { value } }) => {
    setSelectedSession(value);

    
  };

  const handlePlacesClick = (e) => {
    e.preventDefault();
    history.push("/hall", {
      session: selectedSession,
      branch: selectedBranch,
      movie: selectedMovie,
    });
  };

  return (
    <div class="filter">
      <div class="container-fluid p-0">
        <div class="row">
          <div class="filters">
            <form action>
              <ul class="filterList">
                <li class="filterSection filterFilm">
                  <select
                    name="filmFilter"
                    id="filmFilter"
                    value={selectedMovie}
                    class="selectFilter box"
                    onChange={handleChangeMovie}
                  >
                    <option value="0" selected disabled hidden>
                      Film
                    </option>
                    {
                      <>
                        {movie.map((movieItem) => {
                          return (
                            <option id="selectOpt" value={movieItem.id}>
                              {movieItem.name}
                            </option>
                          );
                        })}
                      </>
                    }
                  </select>
                </li>
                <li class="filterSection filterDate">
                  <select
                    name="dateFilter"
                    id="dateFilter"
                    class="selectFilter box"
                  >
                    <option value="0" selected disabled hidden>
                      Tarix
                    </option>
                    {
                      <>
                        <option value={movieWidthId.id}>{Moment(startTime).format('YYYY-MM-DD')}</option>
                        <option value={movieWidthId.id}>{Moment(endTime).format('YYYY-MM-DD')}</option>
                      </>
                    }
                  </select>
                </li>
                <li class="filterSection filterCinema">
                  <select
                    name="cinemaFilter"
                    id="cinemaFilter"
                    value={selectedBranch}
                    class="selectFilter box"
                    onChange={handleBranchChange}
                  >
                    <option value="0" selected disabled hidden>
                      Kinoteatrlar
                    </option>
                    {
                      <>
                        {availableBranches.map((branchItem) => {
                          return (
                            <option id="selectOpt" value={branchItem.id}>
                              {branchItem.name}
                            </option>
                          );
                        })}
                      </>
                    }
                  </select>
                </li>
                <li class="filterSection  filterSession">
                  <select
                    name="sessionFilter"
                    id="sessionFilter"
                    value={selectedSession}
                    class="selectFilter box"
                    onChange={handleSessionChange}
                  >
                    <option value="0" selected disabled hidden>
                      Seans
                    </option>
                    {
                      <>
                        {session.map((sessionItem) => {
                          return (
                            <option value={sessionItem.id}>{Moment(sessionItem.startTime).format('h:mm A')}-{Moment(sessionItem.endTime).format('h:mm A')}</option>
                            
                            
                          );
                        })}
                      </>
                    }
                   
                  </select>
                </li>
                <li class="filterSection">
                  <button
                    onClick={handlePlacesClick}
                    class="places btn"
                    data-cinema="0"
                  >
                    Yerlər
                  </button>
                </li>
                <li class="filterSection">
                  <button type="submit" class="disabled">
                    Almaq
                  </button>
                </li>
              </ul>
            </form>
          </div>
        </div>
      </div>
    </div>
  );
};

export default BuyTicket;
