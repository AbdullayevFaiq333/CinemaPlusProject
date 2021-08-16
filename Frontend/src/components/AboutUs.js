import React from "react";
import {Link} from "react-router-dom";

const AboutUs = () => {
  return (
    <div class="aboutTab">
      <div class="overlay"></div>
      <div class="container">
        <div class="row">
          <div class="col-md-12">
            <div class="tabs">
              <h1 class="title">"CinemaPlus"</h1>
              <div class="description">
                <ul>
                  <li class="lines">
                    CinemaPlus şəbəkəsinə 8 kinoteatr, 38 ekran və 3802 oturacaq
                    daxildir.
                  </li>
                  <li class="lines">
                    Yüksək ölçülü 3D-kontentini nümayiş etdirmək imkanı olan
                    rəqəmsal proyeksiya sistemi və yüksək keyfiyyətli
                    kinoekranlar ilə təchiz olunub. Həmçinin, gücləndirilmiş
                    parlaqlıq və “Enhanced 4K Barco” dəqiq təsvirinə malikdir.
                    Bütün bunlar və başqa amillər kinofilmləri ən yaxşı
                    keyfiyyətdə nümayiş etdirmək imkanı yaradır.
                  </li>
                  <li class="lines">
                    “CinemaPlus” kinoteatrlar şəbəkəsinin tətbiq etdiyi
                    “Platinum Movie Suites” konsepsiyası tamaşaçılara yüksək
                    komfortlu, dəbdəbəli və dəridən hazırlanmış, söykənəcəyi tam
                    arxaya açılan italyan kreslolarda film izləmək və kinoseans
                    zamanı qida və içkilərin sifariş etmək imkanı yaradır.
                  </li>
                  <li class="lines">
                    Bundan əlavə “CinemaPlus” Azərbaycanda ilk dəfə Dolby Atmos
                    texnologiyası tətbiq edib.
                  </li>
                  <li class="lines">
                    Səs müşayiətini kinoteatrın istənilən yerinə yerləşdirmək və
                    yerini dəyişmək imkanı hesabına Dolby Digital Atmos film
                    yaradıcılarına kinoda səsi yeni bir mərhələyə çıxarmaq imkan
                    yaradır. Nəticədə tamaşaçı ekranda baş verənləri sadəcə
                    izləmir, hadisənin mərkəzinə daxil olur.
                  </li>
                </ul>
              </div>
              <div class="cinemas">
                <li class="dealers">
                  <Link to="/aboutUs/branch" class="dealer">
                    28 Mall
                  </Link>
                </li>
                <li class="dealers">
                  <a href="#" class="dealer">
                    Ganjlik Mall
                  </a>
                </li>
                <li class="dealers">
                  <a href="#" class="dealer">
                    Deniz Mall
                  </a>
                </li>
                <li class="dealers">
                  <a href="#" class="dealer">
                    Azerbaijan Cinema
                  </a>
                </li>
                <li class="dealers">
                  <a href="#" class="dealer">
                    Amburan Mall
                  </a>
                </li>
                <br />
                <li class="dealers">
                  <a href="#" class="dealer">
                    Sumqayıt
                  </a>
                </li>
                <li class="dealers">
                  <a href="#" class="dealer">
                    Khamsa Park (Ganja)
                  </a>
                </li>
                <li class="dealers">
                  <a href="#" class="dealer">
                    Ganja Mall (Ganja)
                  </a>
                </li>
                <li class="dealers">
                  <a href="#" class="dealer">
                    Naxçıvan
                  </a>
                </li>
                <li class="dealers">
                  <a href="#" class="dealer">
                    Şamaxı
                  </a>
                </li>
              </div>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-md-6 offers">
            <img
              src="images/about/about1.png.png"
              alt="about1"
              class="aboutImg"
            />
            <p>
              CinemaPlus şəbəkəsinə 7 kinoteatr, 33 ekran və 3638 oturacaq
              daxildir.
            </p>
          </div>
          <div class="col-md-6 offers">
            <img src="images/about/about2.png" alt="about2" class="aboutImg" />
            <p>
              Bizim kinoteatrın “Platinum Movie Suites” zalında film izləyəndən
              sonra Sizdə unudulmaz təəssüratlar qalacaq. Bu premium-zalın
              konsepsiyası tamaşaçılara yüksək komfortlu, arxaya açılan
              təmtəraqlı italyan dəri kreslolarında, kinoseans zamanı qida və
              içki sifariş etmək imkanı olan zalda film izləmək imkanı təklif
              edir.
            </p>
          </div>
          <div class="col-md-6 offers">
            <img src="images/about/about3.png" alt="about3" class="aboutImg" />
            <p>
              “CinemaPlus” öz qonaqları üçün bileti müxtəlif rahat üsullar ilə
              almaq imkanı yaradır: kinoteatrın www.cinemaplus.az rəsmi
              saytından, İOS və Android əməliyyat sistemləri tərəfindən idarə
              olunan smartfonlar üçün təzəlikcə işə düşmüş mobil tətbiq
              vasitəsilə və ya kinoteatrın bilet kassasından.
            </p>
          </div>
          <div class="col-md-6 offers">
            <img src="images/about/about4.png" alt="about4" class="aboutImg" />
          </div>
        </div>
      </div>
    </div>
  );
};

export default AboutUs;
