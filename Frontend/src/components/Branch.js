import React, { useEffect, useState } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentBranch } from "../actions";
import { SRLWrapper } from "simple-react-lightbox";
import axios from "axios";
import Tariffs from "./Tariffs";


const Branch = () => {
  const [tag, setTag] = useState("28 Mall");
  const [tariff, setTariff] = useState("");
  const [isClicked, setIsClicked] = useState(false);
  const dispatch = useDispatch();
  const { content } = useSelector((state) => state.contentBranch);

  useEffect(() => {
    dispatch(fetchContentBranch());
  }, [dispatch]);

  const handleClickBranch = async (id) => {
    await axios
      .get(`https://localhost:44359/api/Tariff/${id}`)
      .then((response) => setTariff(response.data));

    setIsClicked(true);
  };

  return (
    <>
      <div handleSetTag={setTag}></div>
      <div class="branchs">
        <div class="container-fluid">
          <div class="row">
            <ul class="branchNames">
              {
                <>
                  {content.map((branchItem) => {
                    return (
                      <li
                        key={branchItem.id}
                        class="CinemaDealer"
                        onClick={() => handleClickBranch(branchItem.id)}
                      >
                        <TagButton
                          name={`${branchItem.name}`}
                          handleSetTag={setTag}
                        />
                      </li>
                    );
                  })}
                </>
              }
            </ul>

            {isClicked ? (
              <SRLWrapper>
                <div>
                  <Tariffs tariff={tariff} />
                </div>
              </SRLWrapper>
              
            ) : (
              ""
            )}
          </div>
        </div>
      </div>
    </>
  );
};

const TagButton = ({ name, handleSetTag }) => {
  return (
    <button
      class="cinemaBranch CinemaDealer"
      onClick={() => handleSetTag(name)}
    >
      {name}
    </button>
  );
};

export default Branch;
