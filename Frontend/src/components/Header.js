import React, { useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";
import {
  fetchContentNavbar,
  fetchContentPlatinum,
  fetchContentDolbyAtmos,
  fetchLanguages,
  fetchContentService,
  fetchContentFooter,
  fetchContentSecondFooter,
  fetchContentNews,
  fetchContentFAQ,
  fetchContentCampaigns,
  fetchContentCampaignDetail,
  fetchContentMovie,
  fetchContentMovieDetail,
} from "../actions";
import { Link } from "react-router-dom";

const Header = () => {
  const dispatch = useDispatch();

  const { languages } = useSelector((state) => state.languages);
  const { content, loading } = useSelector((state) => state.contentNavbar);
  const {activeLanguage}=useSelector((state)=> state.languages)
  if (localStorage.getItem("language") === null) {
    localStorage.setItem("language", "AZ");
  }

  useEffect(() => {
    dispatch(fetchContentNavbar());
    dispatch(fetchLanguages());
  }, [dispatch, activeLanguage]);

  const handleClickLanguage = (code) => {
    localStorage.setItem("language", code);
    dispatch(fetchLanguages(code));
    
  };

  return (
    <div>
      {loading ? (
        <h1>loading</h1>
      ) : (
        <nav class="navbar navbar-expand-lg navbar-dark fixed-top p-0">
          <div class="container-fluid p-0">
            <div>
              <img
                className="logo-img"
                src="http://localhost:3000/images/navbar/logo.svg"
              />
            </div>
            <button
              class="navbar-toggler"
              type="button"
              data-bs-toggle="collapse"
              data-bs-target="#navbarNavAltMarkup"
              aria-controls="navbarNavAltMarkup"
              aria-expanded="false"
              aria-label="Toggle navigation"
            >
              <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse right navbar-collapse" id="navbarNavAltMarkup">
              <div class="navbar-nav ">
                <div className=" navbar-up">
                  {content.navbarDto.map((navbarItem) => {
                    return (
                      <div key={navbarItem.id}>
                        <Link class="nav-link title" to={`${navbarItem.url}`}>
                          {navbarItem.title}
                        </Link>
                      </div>
                    );
                  })}
                  {languages.map((language) => {
                    return (
                      <Link
                        class="nav-link "
                        key={language.id}
                        onClick={() => handleClickLanguage(language.code)}
                      >
                        {language.code}
                      </Link>
                    );
                  })}
                  <img src="http://localhost:3000/images/navbar/ios.svg" />
                  <img src="http://localhost:3000/images/navbar/android.svg" />
                </div>
                <div className=" navbar-down">
                  {content.secondNavbarDto.map((secondNavbarItem) => {
                    return (
                      <div key={secondNavbarItem.id}>
                        <Link
                          class="nav-link title"
                          to={`${secondNavbarItem.url}`}
                        >
                          {secondNavbarItem.title}
                        </Link>
                      </div>
                    );
                  })}
                  <div className="phone">
                    <i class="fas fa-phone-alt"></i>+99412 499 89 88
                  </div>
                </div>
              </div>
            </div>
          </div>
        </nav>

        // <div className="container-fluid">
        //   <div className="row">
        //     <div className="col-md-5 p-0">
        //       <div className="nav-logo">
        //         <img
        //           src="http://localhost:3000/images/navbar/logo.svg"
        //           className="mr-auto"
        //           alt=""
        //         />
        //       </div>
        //     </div>
        //     <div className="col-md-7">
        //       <div className="row">
        //         <div className="nav-right-up">

        //           <ul className="static_menu d-flex">
        //             {content.navbarDto.map((navbarItem) => {
        //               return (
        //                 <li key={navbarItem.id}>
        //                   <Link to={`${navbarItem.url}`}>
        //                     {" "}
        //                     {navbarItem.title}
        //                   </Link>
        //                 </li>
        //               );
        //             })}
        //           </ul>
        //           <ul className="languages">
        //             {languages.map((language) => {
        //               return (
        //                 <li
        //                   key={language.id}
        //                   onClick={() => handleClickLanguage(language.code)}
        //                 >
        //                   {language.code}
        //                 </li>
        //               );
        //             })}
        //             <img src="http://localhost:3000/images/navbar/ios.svg" />
        //             <img src="http://localhost:3000/images/navbar/android.svg" />
        //           </ul>
        //         </div>
        //         <div className="nav-right-down">
        //           <ul className="d-flex">
        //             {content.secondNavbarDto.map((secondNavbarItem) => {
        //               return (
        //                 <li key={secondNavbarItem.id}>
        //                   <Link to={`${secondNavbarItem.url}`}>
        //                     {" "}
        //                     {secondNavbarItem.title}
        //                   </Link>
        //                 </li>
        //               );
        //             })}
        //             <div className="phone">
        //               <i class="fas fa-phone-alt"></i>+99412 499 89 88
        //             </div>
        //           </ul>
        //         </div>
        //       </div>
        //     </div>
        //   </div>
        // </div>
      )}
    </div>
  );
};

export default Header;
