import React, { useEffect, useState } from "react";
import { useSelector, useDispatch } from "react-redux";
import {
  fetchContentRow,
  fetchContentHall,
  
  fetchContentMovieWidthId,
  
} from "../actions";
import { useHistory } from "react-router-dom";
import StripeCheckout from "react-stripe-checkout";
import axios from "axios";
import { toast } from "react-toastify";



toast.configure();

const Hall = () => {
  const history = useHistory();
  
  const dispatch = useDispatch();

  const { row } = useSelector((state) => state.row);
  const { hall } = useSelector((state) => state.contentHall);
  
  const { movieWidthId } = useSelector((state) => state.movieWidthId);

  const [active, setActive] = useState(false);
  const [count, setCount] = useState(0);

  useEffect(() => {
    dispatch(fetchContentHall(history.location.state.session));
    dispatch(fetchContentMovieWidthId(history.location.state.movie));
    dispatch(fetchContentRow(history.location.state.session));
    
    
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

  return (
    <div class="plane">
      <div className="title ">
        <div >Movie: {movieWidthId.name}</div>
        <div key={hall.id}>{hall.name}</div>
      </div>

      <div className="rows ">
        {
          <>
            {row.map((rowItem) => {
              return (
                <div>
                  <div key={rowItem.id} className="rowName">
                    
                  <span>SIRA {rowItem.numberRow}</span> 
                  <span className="rowName2">SIRA {rowItem.numberRow}</span>
                  </div>
                  
                  <div>
                  <div class="seats">
                    {
                      <>
                        {rowItem.seats.map((seatItem )=> {
                           return (
                            <div
                              key={seatItem.id}
                              className={` ${active ? "active" : "seat"}`}
                              onClick={handleSeatClick}
                            >
                              <input type="checkbox" id={seatItem.id} />
                              <label for={seatItem.id}>
                                {seatItem.seatNumber}
                              </label>
                            </div>
                          );
                        })}
                      </>
                    }
                  </div>
                  
                  </div>
                  
                </div>
              );
            })}
          </>
        }
      </div>
      <div className="prc">
        <div>TICKET PRICE: 7₼</div>
        <div>TOTAL PRICE: {7 * count}₼</div>
      </div>

      <div className="buy">
        <StripeCheckout
          stripeKey="pk_test_51JSg7WEzYHUBwYrgcFnpvcxgAPfIAVmT8faLPz7qwaQ80VnLMPUwGcPgQfsjucfJHGCgInrtmh29UJMhUEXgIVHE00CdEE63Gx"
          token={handleToken}
          billingAddress
          shippingAddress
          amount={7 * count * 100}
          name={movieWidthId.name}
        />
      </div>
    </div>
  );
};

export default Hall;
