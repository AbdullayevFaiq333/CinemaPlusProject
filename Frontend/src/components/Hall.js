import React, { useEffect,useState } from "react";
import { useSelector, useDispatch } from "react-redux";
import {
  fetchContentRow,
  fetchContentHall,
  fetchContentSeat,
  fetchContentTicket,
  fetchContentMovieWidthId,
} from "../actions";
import { useHistory } from "react-router-dom";
import BuyTicket from "./BuyTicket";

const Hall = () => {
  const history = useHistory();
  console.log(history.location.state);

  const dispatch = useDispatch();

  const { row } = useSelector((state) => state.row);
  const { seat } = useSelector((state) => state.seat);
  const { hall } = useSelector((state) => state.contentHall);
  const { ticket } = useSelector((state) => state.ticket);
  const { movieWidthId } = useSelector((state) => state.movieWidthId);

  

  useEffect(() => {
    dispatch(fetchContentHall(history.location.state.session));
    dispatch(fetchContentMovieWidthId(history.location.state.movie));
    dispatch(fetchContentRow(history.location.state.session));
    dispatch(fetchContentSeat(3));
    dispatch(fetchContentTicket(history.location.state.session));
  }, [dispatch]);

  React.useEffect(() => {
    // api call to seats with history.location.state.sessionId
  }, [history]);

  return (
    <div class="plane">
      <ul className="title ">
        <li>Movie : {movieWidthId.name}</li>
        <li key={hall.id} >
          {hall.name}
        </li>
      </ul>

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
                              <label for={seatItem.seatNumber}>
                                {seatItem.seatNumber}
                              </label>
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
        <div>TICKET PRICE: {ticket.price}$</div>
        <div>TOTAL PRICE: {ticket.price * 2}$</div>
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
