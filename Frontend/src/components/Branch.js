import React, { useEffect, useState } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentBranch } from "../actions";

import Tariffs from "./Tariffs";


const Branch = ({getBrach}) => {
  const [tag, setTag] = useState("28 Mall");
  const [tariff, setTariff] = useState("");
  const [isClicked, setIsClicked] = useState(false);
  // const [branchId,setBranchId] = useState(0);
  const dispatch = useDispatch();
  const { content } = useSelector((state) => state.contentBranch);

  useEffect(() => {
    dispatch(fetchContentBranch());
  }, [dispatch]);

  const handleClickBranch = async (id) => {
    // setBranchId(id);
    getBrach(id);
    // setIsClicked(true);
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

            {/* {isClicked ? (
              <SRLWrapper>
                <div>
                  <Tariffs branchId={branchId} />
                </div>
              </SRLWrapper>
              
            ) : (
              ""
            )} */}
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
