import React, { useEffect,useState } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentContact } from "../actions";
import axios from "axios";
import Branch from "./Branch";

const Contacts = () => {
  
  const [contact,setContact] = useState({});
  const [branchId,setBranchId] = useState(1);
  useEffect(() => {
    
    const getContact = async () => {
      await axios.get(`https://localhost:44359/api/Contact/${branchId}`)
        .then((response) => setContact(response.data));
    }

    getContact();
  }, [branchId]);
  return (
    <>
    <Branch getBrach={setBranchId}/>
    
    <div class="contact">
      <div class="container-fluid p-0">
        <div class="row">
          <div class="col-md-12">
            <div class="tabs">
            <div className="head">
                <a href="#" className="title">
                  ƏLAQƏ
                </a>
              </div>
              <div class="tabBody">
                <div class="contacts">
                  <div class="row">
                    <div class="col-md-6">
                      <div class="row">
                        <ul>
                          <li>
                            <span>Bizim ünvan:</span>
                            <p>{contact.ourAddress}</p>
                          </li>
                          <li>
                            <span>Telefon:</span>
                            <p>{contact.phone}</p>
                          </li>
                          <li>
                            <span>Elektron ünvan:</span>
                            <p>{contact.email}</p>
                          </li>
                          <li>
                            <span>Marketinq şöbəsi:</span>
                            <p>{contact.mediaSalesDepartment}</p>
                          </li>
                          <li>
                            <span>İş saatı:</span>
                            <p>{contact.workingHours}</p>
                          </li>
                          <li>
                            <a href="#" class="sendButton">
                              Bizə yazın
                            </a>
                          </li>
                        </ul>
                      </div>
                    </div>
                    <div class="col-md-6">
                      <iframe
                        src={contact.map}
                        class="map"
                        allowfullscreen=""
                        loading="lazy"
                      ></iframe>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    </>
  );
};

export default Contacts;
