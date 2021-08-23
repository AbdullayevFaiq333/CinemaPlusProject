import React, { useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentRow, fetchContentHall } from "../actions";
import { useHistory } from "react-router-dom";

const Hall = () => {
  const history = useHistory();
  console.log(history.location.state);

  const dispatch = useDispatch();

  const { row } = useSelector((state) => state.row);
  const { hall } = useSelector((state) => state.contentHall);

  useEffect(() => { 
    dispatch(fetchContentHall(history.location.state.session));
    if(hall[0] !== undefined){
      dispatch(fetchContentRow(hall[0].id));
    }
  }, [dispatch]);

  React.useEffect(() => {
    // api call to seats with history.location.state.sessionId
  }, [history]);

  return (
    <div class="plane">
      <div>
        <ul className="info d-flex">
          <li>Movie:{history.location.state.movie}</li>
          <li>Cinema:{history.location.state.branch}</li>
          <li>Session:{history.location.state.session}</li>
        </ul>
      </div>
      {
          <>
            {hall.map((hallItem) => {
              return (
                <div>
                  <div key={hallItem.id}  className="title">{hallItem.name}</div>
                  </div>
              );
            })}
          </>
        }
      
      <ul className="rows">
        {
          <>
            {row.map((rowItem) => {
              return (
                <div>
                  <li key={rowItem.id} className="rowName">
                    SIRA {rowItem.numberRow}
                  </li>
                  <ul class="seats" >
                    <li class="seat">
                      <input type="checkbox" id="A" />
                      <label for="A">1A</label>
                    </li>
                    <li class="seat">
                      <input type="checkbox" id="1B" />
                      <label for="1B">1B</label>
                    </li>
                    <li class="seat">
                      <input type="checkbox" id="1C" />
                      <label for="1C">1C</label>
                    </li>
                    <li class="seat">
                      <input type="checkbox" id="1D" />
                      <label for="1D">1D</label>
                    </li>
                    <li class="seat">
                      <input type="checkbox" id="1E" />
                      <label for="1E">1E</label>
                    </li>
                    <li class="seat">
                      <input type="checkbox" id="1F" />
                      <label for="1F">1F</label>
                    </li>
                  </ul>
                </div>
              );
            })}
          </>
        }
        </ul>
      <div className="prc">
        <div>TICKET PRICE:</div>
        <div>TOTAL PRICE:</div>
      </div>
      <div className="buy">
        <button type="button" className="btn btn-outline-primary">
          BUY TICKET
        </button>
      </div>
    </div>
  );
};

export default Hall;
