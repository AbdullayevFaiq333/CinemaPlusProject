import React from "react";

const Campaigns = () => {
  return (
    <div className="campaigns">
      <div className="container">
        <div className="row">
          <div className="col-md-12">
            <div className="campgHead">
              <a href="#" className="campgTitle">
                Aksiyalar
              </a>
            </div>
            <div className="campgBody">
              <div className="campgBlueLine"></div>
              <div className="row">
                <div className="col-md-4">
                  {" "}
                  <strong className="campgLabel">HOT</strong>
                  <div className="campgImg">
                    <p>"Qış Nağılı"na sərfəli aksiya!</p>
                    <a href="indexQisNagiliDetail.html">
                      {" "}
                      <img
                        src="images/campaigns/qn_aksiya.600x400.png"
                        alt="Qis Nagili"
                      />
                    </a>
                  </div>
                </div>
                <div className="col-md-4">
                  <div className="campgImg">
                    <p>Mastercard</p>
                    <a href="indexMasterCardDetail.html">
                      {" "}
                      <img
                        src="images/campaigns/master_5_aksiya.600x400.jpg"
                        alt="Qis Nagili"
                      />
                    </a>
                  </div>
                </div>
                <div className="col-md-4">
                  <div className="campgImg">
                    <p>McDonald’s-dan super təklif!</p>
                    <a href="indexMcDonaldsDetail.html">
                      {" "}
                      <img
                        src="images/campaigns/mcdonalds.600x400.png"
                        alt="Qis Nagili"
                      />
                    </a>
                  </div>
                </div>
                <div className="col-md-4">
                  {" "}
                  <strong className="campgLabel">HOT</strong>
                  <div className="campgImg">
                    <p>Super Gün (Bakı şəh.)</p>
                    <a href="indexSuperGun.html">
                      {" "}
                      <img
                        src="images/campaigns/campaign_baku.600x400.png"
                        alt="Qis Nagili"
                      />
                    </a>
                  </div>
                </div>
                <div className="col-md-4">
                  <div className="campgImg">
                    <p>Super Gün və Ailə Günü (Gəncə şəh., Sumqayıt şəh.)</p>
                    <a href="indexAileGunu.html">
                      {" "}
                      <img
                        src="images/campaigns/gence_campaign_1.600x400.png"
                        alt="Qis Nagili"
                      />
                    </a>
                  </div>
                </div>
                <div className="col-md-4">
                  {" "}
                  <strong className="campgLabel">HOT</strong>
                  <div className="campgImg">
                    <p>Carlsberg Combo</p>
                    <a href="indexCarslberg.html">
                      {" "}
                      <img
                        src="images/campaigns/football.600x400.png"
                        alt="Qis Nagili"
                      />
                    </a>
                  </div>
                </div>
                <div className="col-md-4">
                  {" "}
                  <strong className="campgLabel">HOT</strong>
                  <div className="campgImg">
                    <p>COMBO Menyu</p>
                    <a href="indexComboMenu.html">
                      {" "}
                      <img
                        src="images/campaigns/combo_menus_2_2.600x400.png"
                        alt="Qis Nagili"
                      />
                    </a>
                  </div>
                </div>
                <div className="col-md-4">
                  {" "}
                  <strong className="campgLabel">HOT</strong>
                  <div className="campgImg">
                    <p>Ulduzum</p>
                    <a href="indexUlduzum.html">
                      {" "}
                      <img
                        src="images/campaigns/ulduzum.600x400.png"
                        alt="Qis Nagili"
                      />
                    </a>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Campaigns;
