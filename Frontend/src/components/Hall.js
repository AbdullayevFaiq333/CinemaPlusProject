import React from "react";
import { useHistory } from "react-router-dom";

const Hall = () => {
  const history = useHistory();
  console.log(history.location.state);

  React.useEffect(() => {
    // api call to seats with history.location.state.sessionId
  }, [history]);

  return (
    <div class="plane">
      <div className="title">HALL</div>
      <ul className="rows">
        <div>
          <li className="rowName">SIRA 1</li>
          <ul class="seats" type="A">
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
        <div>
          <li className="rowName">SIRA 2</li>
          <ul class="seats" type="A">
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

        <div>
          <li className="rowName">SIRA 3</li>
          <ul class="seats" type="A">
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
