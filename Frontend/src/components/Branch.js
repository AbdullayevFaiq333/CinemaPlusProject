import React, { useEffect, useState } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentBranch } from "../actions";

const tariffs = [
  { id: "1", imageName: "28Mall.jpg", tag: "28 Mall" },
  { id: "2", imageName: "deniz.jpg", tag: "Deniz Mall" },
];

const Branch = () => {
  const [tag, setTag] = useState("all");
  const [filteredImages, setFiltereedImages] = useState([]);

  useEffect(() => {
    tag === "all"
      ? setFiltereedImages(tariffs)
      : setFiltereedImages(tariffs.filter((filter) => filter.tag === tag));
  }, [tag]);

  const dispatch = useDispatch();

  const { content } = useSelector((state) => state.contentBranch);

  useEffect(() => {
    dispatch(fetchContentBranch());
  }, [dispatch]);
  return (
    <>
      <div handleSetTag={setTag}>
        <TagButton name="all" handleSetTag={setTag} class="CinemaDealer"/>
        
        <div>
          {filteredImages.map((tariff) => (
            <div key={tariff.id} >
              <img src={`./images/tariffs/`} />
              {tariff.imageName}
              </div>
          ))}
        </div>
      </div>
      <div class="branchs">
        <div class="container-fluid">
          <div class="row">
            <ul class="branchNames">
              {
                <>
                  {content.map((branchItem) => {
                    return (
                      <li key={branchItem.id} class="CinemaDealer">
                        <a href="#" class="cinemaBranch">
                          {branchItem.name}
                        </a>
                        <TagButton name={`${branchItem.name}`} handleSetTag={setTag} class="CinemaDealer"/>
        
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

const TagButton = ({ name,handleSetTag }) => {
  return <button  onClick={()=>handleSetTag(name)}>{name.toUpperCase()}</button>;
};

export default Branch;
