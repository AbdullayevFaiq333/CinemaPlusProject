import React from "react";
import Branch from "./Branch";

const Contacts = () => {
  return (
    <>
    <Branch/>
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
                            <p>Azadlıq prospekti 45, 28 Mall TM</p>
                          </li>
                          <li>
                            <span>Telefon:</span>
                            <p>+99412 499 89 88</p>
                          </li>
                          <li>
                            <span>Elektron ünvan:</span>
                            <p>info@cinemaplus.az</p>
                          </li>
                          <li>
                            <span>Marketinq şöbəsi:</span>
                            <p>media@cinemaplus.az</p>
                          </li>
                          <li>
                            <span>İş saatı:</span>
                            <p>10:00-dan sonuncu seansa qədər</p>
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
                        src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3039.
                                                     343327916081!2d49.844576914761!3d40.
                                                     37908276585343!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!
                                                     1s0x40307da7a06b402f%3A0xd8897cf79ec36111!2s28%20Mall!5e0!3m2!
                                                     1sen!2s!4v1628704322459!5m2!1sen!2s"
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
