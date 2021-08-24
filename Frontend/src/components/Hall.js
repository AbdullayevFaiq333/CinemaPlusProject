import React, { useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";
import {
  fetchContentRow,
  fetchContentHall,
  fetchContentSeat,
} from "../actions";
import { useHistory } from "react-router-dom";

const Hall = () => {
  const history = useHistory();
  console.log(history.location.state);

  const dispatch = useDispatch();

  const { row } = useSelector((state) => state.row);
  const { seat } = useSelector((state) => state.seat);
  const { hall } = useSelector((state) => state.contentHall);

  useEffect(() => {
    dispatch(fetchContentHall(history.location.state.session));
    if (hall[0] !== undefined) {
      dispatch(fetchContentRow(hall[0].id));
    }
  }, [dispatch]);

  useEffect(() => {
    dispatch(fetchContentRow());
    
    dispatch(fetchContentSeat());

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
                <div key={hallItem.id} className="title">
                  {hallItem.name}
                </div>
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
                  <ul class="seats">
                    {
                      <>
                        {seat.map((seatItem) => {
                          return (
                            <li key={seatItem.id} class="seat">
                              <input type="checkbox" id={seatItem.seatNumber} />
                              <label for={seatItem.seatNumber}>{seatItem.seatNumber}</label>
                            </li>
                          );
                        })}
                      </>
                    }

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
