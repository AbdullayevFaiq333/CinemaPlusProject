import React, { useEffect, useState } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentBranch } from "../actions";
import { SRLWrapper } from "simple-react-lightbox";
import axios from "axios";
import Tariffs from "./Tariffs";
import Contacts from "./Contacts";

const tariffs = [
  { id: "1", imageName: "28Mall.jpg", tag: "28 Mall" },
  { id: "2", imageName: "Ganja.jpg", tag: "Ganja Mall (Ganja)" },
  { id: "3", imageName: "Amburan.jpg", tag: "Amburan Mall" },
  { id: "4", imageName: "AzerbMall.jpg", tag: "Azerbaijan Cinema" },
  { id: "5", imageName: "GanjDenMall.jpg", tag: "Deniz Mall" },
  { id: "6", imageName: "Khamsa.jpg", tag: "Khamsa Park (Ganja)" },
  { id: "7", imageName: "Naxcivan.jpg", tag: "Nakhchivan" },
  { id: "8", imageName: "Samaxi.jpg", tag: "Shamakhy" },
  { id: "9", imageName: "Sum.jpg", tag: "Sumqayıt" },
  { id: "10", imageName: "GanjDenMall.jpg", tag: "Ganjlik Mall" },
];

const Branch = () => {
  const [tag, setTag] = useState("28 Mall");
  const [filteredImages, setFilteredImages] = useState([]);
  const [tariff, setTariff] = useState("");
  const [isClicked, setIsClicked] = useState(false);

  useEffect(() => {
    setFilteredImages(tariffs.filter((filter) => filter.tag === tag));
  }, [tag]);

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
