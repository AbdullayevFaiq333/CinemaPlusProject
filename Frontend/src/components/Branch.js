import React, { useEffect, useState } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentBranch } from "../actions";


const Branch = ({getBrach}) => {
  const [tag, setTag] = useState("28 Mall");
  
  const dispatch = useDispatch();
  const { branch } = useSelector((state) => state.contentBranch);
  const {activeLanguage}=useSelector((state)=> state.languages)

  useEffect(() => {
    dispatch(fetchContentBranch());
  }, [dispatch,activeLanguage]);

  const handleClickBranch = async (id) => {
    getBrach(id);
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
                  {branch.map((branchItem) => {
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
