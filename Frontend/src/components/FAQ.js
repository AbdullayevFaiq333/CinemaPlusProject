import React from "react";

const FAQ = () => {
  return (
    <div className="faqInformation">
      <div className="container">
        <div className="row">
          <div className="col-md-12">
            <div className="faqHeader">
              <div className="active" id="faq">
                FAQ
              </div>
            </div>
            <div className="faqBody">
              <div className="faqRow">
                <div className="faqInfo">
                  <div className="bs-example">
                    <div className="accordion" id="accordionExample">
                      <div className="card">
                        <div className="card-header" id="heading1">
                          <h2 className="mb-0">
                            <button
                              type="button"
                              className="btn btn-link"
                              data-toggle="collapse"
                              data-target="#collapse1"
                            >
                              <i className="fa fa-plus"></i>"Dolby Atmos formatı
                              nədir?"
                            </button>
                          </h2>
                        </div>
                        <div
                          id="collapse1"
                          className="collapse"
                          aria-labelledby="heading1"
                          data-parent="#accordionExample"
                        >
                          <div className="card-body">
                            <p>
                              Dolby Atmos səs effektlərini yeni müstəviyə
                              çıxarır, hansı ki, tamaşaçılara təkcə səsin
                              istiqamətini deyil, həmçinin səsin mənbəyinin
                              vertikal mövqeyini hiss etmək imkanı yaradır. Belə
                              halda yağışın səsi həqiqətəndə tavandan gəlməyə
                              başlayır, qatarın yaxınlaşmasından isə yer
                              titrəməyə başlayır. “Formula Kino” və “Kronverk
                              Sinema” birləşmiş şəbəkəsinin zalları Dolby
                              Atmosun ilk Rusiya instalyasiyası olmuşdur.
                            </p>
                          </div>
                        </div>
                      </div>
                      <div className="card">
                        <div className="card-header" id="heading2">
                          <h2 className="mb-0">
                            <button
                              type="button"
                              className="btn btn-link collapsed"
                              data-toggle="collapse"
                              data-target="#collapse2"
                            >
                              <i className="fa fa-plus"></i>"Əgər mənim yaşım,
                              filmin yaş məhdudiyyətinə uyğun deyilsə, necə
                              olacaq?"
                            </button>
                          </h2>
                        </div>
                        <div
                          id="collapse2"
                          className="collapse "
                          aria-labelledby="heading2"
                          data-parent="#accordionExample"
                        >
                          <div className="card-body">
                            <p>
                              "Kassirlərin sizi buraxmamaq və ya bilet satmamaq
                              hüquqları var. Qanuna görə 12+ kateqoriyalı
                              filmlərə 6 yaşdan yuxarı uşaqların gəlmək
                              hüquqları var, lakin valideynlərin müşayiəti ilə!"
                            </p>
                          </div>
                        </div>
                      </div>
                      <div className="card">
                        <div className="card-header" id="heading4">
                          <h2 className="mb-0">
                            <button
                              type="button"
                              className="btn btn-link collapsed"
                              data-toggle="collapse"
                              data-target="#collapse3"
                            >
                              <i className="fa fa-plus"></i> "Filmin posteri çox
                              xoşuma gəlib, onu götürmək olar?"
                            </button>
                          </h2>
                        </div>
                        <div
                          id="collapse3"
                          className="collapse"
                          aria-labelledby="heading4"
                          data-parent="#accordionExample"
                        >
                          <div className="card-body">
                            <p>
                              "Mümkündür, əgər o mövcud olarsa. Posteri götürmək
                              üçün, kinoteatrın administratoruna müraciət etmək
                              lazımdır, onlar sizə mütləq kömək edəcəklər!"
                            </p>
                          </div>
                        </div>
                      </div>
                      <div className="card">
                        <div className="card-header" id="heading5">
                          <h2 className="mb-0">
                            <button
                              type="button"
                              className="btn btn-link collapsed"
                              data-toggle="collapse"
                              data-target="#collapse4"
                            >
                              <i className="fa fa-plus"></i> "Sizdə loyallıq
                              proqramı var?"
                            </button>
                          </h2>
                        </div>
                        <div
                          id="collapse4"
                          className="collapse"
                          aria-labelledby="heading5"
                          data-parent="#accordionExample"
                        >
                          <div className="card-body">
                            <p>
                              "Bizdə “CineClub” bonus kart proqramı fəaliyyət
                              göstərir. Bonus proqramının şərtlərini öyrənmək
                              üçün"
                              <a href="http://www.cinemaplus.az/az/cineclub/">
                                linkə
                              </a>
                              "keçin"
                            </p>
                          </div>
                        </div>
                      </div>
                      <div className="card">
                        <div className="card-header" id="heading6">
                          <h2 className="mb-0">
                            <button
                              type="button"
                              className="btn btn-link collapsed"
                              data-toggle="collapse"
                              data-target="#collapse5"
                            >
                              <i className="fa fa-plus"></i> "Bilet neçəyədir?"
                            </button>
                          </h2>
                        </div>
                        <div
                          id="collapse5"
                          className="collapse"
                          aria-labelledby="heading6"
                          data-parent="#accordionExample"
                        >
                          <div className="card-body">
                            <p>
                              "Biletin qiyməti, kinoteatrdan, formatdan,
                              vaxtından və həftənin günündən asılıdır. Bütün
                              qiymətlər bizim cədvəldə aktualdır. Biletin
                              qiymətini öyrənmək üçün, sizi maraqlandıran filmi,
                              formatı, həftənin günün və vaxtını "
                              <a href="http://www.cinemaplus.az/az/tariffs/">
                                linkdən
                              </a>
                              " seçmək lazımdır: "
                            </p>
                          </div>
                        </div>
                      </div>
                      <div className="card">
                        <div className="card-header" id="heading7">
                          <h2 className="mb-0">
                            <button
                              type="button"
                              className="btn btn-link collapsed"
                              data-toggle="collapse"
                              data-target="#collapse6"
                            >
                              <i className="fa fa-plus"></i> "Sabah/ ertəsi gün
                              / bir həftə sonra hansı filmlər nümayiş olunacaq?
                              Saytda cədvəl yoxdur!"
                            </button>
                          </h2>
                        </div>
                        <div
                          id="collapse6"
                          className="collapse"
                          aria-labelledby="heading7"
                          data-parent="#accordionExample"
                        >
                          <div className="card-body">
                            <p>
                              "Sabah/ ertəsi gün / bir həftə sonra hansı filmlər
                              nümayiş olunacaq? Saytda cədvəl yoxdur!"
                            </p>
                          </div>
                        </div>
                      </div>
                      <div className="card">
                        <div className="card-header" id="heading8">
                          <h2 className="mb-0">
                            <button
                              type="button"
                              className="btn btn-link collapsed"
                              data-toggle="collapse"
                              data-target="#collapse7"
                            >
                              <i className="fa fa-plus"></i> "Bu gün hansı
                              filmlər nümayiş olunur?"
                            </button>
                          </h2>
                        </div>
                        <div
                          id="collapse7"
                          className="collapse"
                          aria-labelledby="heading8"
                          data-parent="#accordionExample"
                        >
                          <div className="card-body">
                            <p>
                              "Məlumat bizim saytda qeyd olunub:"{" "}
                              <a href="http://www.cinemaplus.az">
                                http://www.cinemaplus.az
                              </a>
                            </p>
                          </div>
                        </div>
                      </div>
                      <div className="card">
                        <div className="card-header" id="heading9">
                          <h2 className="mb-0">
                            <button
                              type="button"
                              className="btn btn-link collapsed"
                              data-toggle="collapse"
                              data-target="#collapse8"
                            >
                              <i className="fa fa-plus"></i> "Uşaq və ya
                              yeniyetmə böyüklər üçün filmlərə gedə bilərmi?"
                            </button>
                          </h2>
                        </div>
                        <div
                          id="collapse8"
                          className="collapse"
                          aria-labelledby="heading9"
                          data-parent="#accordionExample"
                        >
                          <div className="card-body">
                            <p>
                              "Siz filmə ancaq valideynlərin müşayiəti ilə gedə
                              bilərsiz."
                            </p>
                          </div>
                        </div>
                      </div>
                      <div className="card">
                        <div className="card-header" id="heading10">
                          <h2 className="mb-0">
                            <button
                              type="button"
                              className="btn btn-link collapsed"
                              data-toggle="collapse"
                              data-target="#collapse9"
                            >
                              <i className="fa fa-plus"></i> "CinemaPlus
                              kinoteatrlar şəbəkəsində hazırda hansı aksiyalar
                              qüvvədədir? Hansı endirimlər var?"
                            </button>
                          </h2>
                        </div>
                        <div
                          id="collapse9"
                          className="collapse"
                          aria-labelledby="heading10"
                          data-parent="#accordionExample"
                        >
                          <div className="card-body">
                            <p>
                              "Bizim bütün aksiya və endirimlərimiz haqqında
                              məlumatla "{" "}
                              <a href="http://www.cinemaplus.az/az/campaigns/ ">
                                linkdən
                              </a>{" "}
                              " tanış ola bilərsiz:"
                            </p>
                          </div>
                        </div>
                      </div>
                      <div className="card">
                        <div className="card-header" id="heading11">
                          <h2 className="mb-0">
                            <button
                              type="button"
                              className="btn btn-link collapsed"
                              data-toggle="collapse"
                              data-target="#collapse10"
                            >
                              <i className="fa fa-plus"></i> "Saytda onlayn
                              bilet ala bilmədim, indi isə bütün yerlər tutulub,
                              nə etmək olar?"
                            </button>
                          </h2>
                        </div>
                        <div
                          id="collapse10"
                          className="collapse"
                          aria-labelledby="heading11"
                          data-parent="#accordionExample"
                        >
                          <div className="card-body">
                            <p>
                              "10 dəqiqədən sonra onlar yenidən satışa
                              qayıdacaqlar. Gözləyə də bilərsiniz və ya digər
                              yerləri ala bilərsiniz."
                            </p>
                          </div>
                        </div>
                      </div>
                      <div className="card">
                        <div className="card-header" id="heading12">
                          <h2 className="mb-0">
                            <button
                              type="button"
                              className="btn btn-link collapsed"
                              data-toggle="collapse"
                              data-target="#collapse11"
                            >
                              <i className="fa fa-plus"></i> "Əks əlaqə"
                            </button>
                          </h2>
                        </div>
                        <div
                          id="collapse11"
                          className="collapse show"
                          aria-labelledby="heading12"
                          data-parent="#accordionExample"
                        >
                          <div className="card-body">
                            <p>
                              "Sizin kinoteatrın və bütünlüklə şəbəkənin işinə
                              aid bütün arzu istəklərinizi, qeyd və
                              fikirlərinizi "{" "}
                              <a href="mailto:info@cinemaplus.az">
                                info@cinemaplus.az
                              </a>{" "}
                              " elektron poçtuna göndərə bilərsiniz. Hər bir
                              müraciət imkan daxilində ən qısa zamanda
                              işləniləcək və işdə nəzərə alınacaq."
                            </p>
                          </div>
                        </div>
                      </div>
                    </div>
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

export default FAQ;
