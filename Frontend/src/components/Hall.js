import React, { useEffect, useState } from "react";
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
import StripeCheckout from "react-stripe-checkout";
import axios from "axios";
import { toast } from "react-toastify";

toast.configure();

const Hall = () => {
  const history = useHistory();
  console.log(history.location.state);

  const dispatch = useDispatch();

  const { row } = useSelector((state) => state.row);
  const { seat } = useSelector((state) => state.seat);
  const { hall } = useSelector((state) => state.contentHall);
  const { ticket } = useSelector((state) => state.ticket);
  const { movieWidthId } = useSelector((state) => state.movieWidthId);

  console.log(seat)
  const [active, setActive] = useState(false);
  const [count, setCount] = useState(0);

  useEffect(() => {
    dispatch(fetchContentHall(history.location.state.session));
    dispatch(fetchContentMovieWidthId(history.location.state.movie));
    dispatch(fetchContentRow(history.location.state.session));
    //dispatch(fetchContentSeat());

    dispatch(fetchContentTicket(history.location.state.session));
  }, [dispatch]);

  const handleSeatClick = () => {
    setActive(!active);
    if (!active) {
      setCount(count + 1);
    }
  };

  async function handleToken(token) {
    const response = await axios.post("https://localhost:44359/api/Pay", {
      CartNumber: token.CartNumber,
      Month: token.Month,
      Year: token.Year,
      Cvc: token.Cvc,
      Value: token.Value,
    });
    const { status } = response.data;
    if (status === "success") {
      toast("Success! Check emails for details", { type: "success" });
    } else {
      toast("Something went wrong", { type: "error" });
    }
  }

  React.useEffect(() => {
    // api call to seats with history.location.state.sessionId
  }, [history]);

  return (
    <div class="plane">
      <ul className="title ">
        <li>Movie: {movieWidthId.name}</li>
        <li key={hall.id}>{hall.name}</li>
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
                        {rowItem.seats.map((seatItem )=> {
                           return (
                            <li
                              key={seatItem.id}
                              className={` ${active ? "active" : "seat"}`}
                              onClick={handleSeatClick}
                            >
                              <input type="checkbox" id={seatItem.id} />
                              <label for={seatItem.id}>
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
        <div>TICKET PRICE: {ticket.price}₼</div>
        <div>TOTAL PRICE: {ticket.price * count}₼</div>
      </div>

      <div className="buy">
        <StripeCheckout
          stripeKey="pk_test_51JSg7WEzYHUBwYrgcFnpvcxgAPfIAVmT8faLPz7qwaQ80VnLMPUwGcPgQfsjucfJHGCgInrtmh29UJMhUEXgIVHE00CdEE63Gx"
          token={handleToken}
          billingAddress
          shippingAddress
          amount={ticket.price * count * 100}
          name={movieWidthId.name}
        />
      </div>
    </div>
  );
};

export default Hall;
